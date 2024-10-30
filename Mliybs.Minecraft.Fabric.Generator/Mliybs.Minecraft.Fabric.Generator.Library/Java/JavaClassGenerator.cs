using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Mliybs.Minecraft.Fabric.Generator.Java
{
    [Generator]
    public class JavaClassGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            var classProvider = context.SyntaxProvider.CreateSyntaxProvider(static (x, _) => x is ClassDeclarationSyntax,
                static (x, _) => (INamedTypeSymbol)x.SemanticModel.GetDeclaredSymbol(x.Node))
                .Where(x => x.HasBaseWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.Internals.JavaClass")
                    && !x.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.SuppressJavaClassAttribute"))
                .Collect();

            var methodProvider = context.SyntaxProvider.CreateSyntaxProvider(static (x, _) => x is ConstructorDeclarationSyntax
            {
                AttributeLists.Count: > 0
            }, static (x, _) => (IMethodSymbol)x.SemanticModel.GetDeclaredSymbol(x.Node))
                .Where(x => x.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.JavaConstructorAttribute"))
                .Collect();

            context.RegisterSourceOutput(classProvider, static (x, y) =>
            {
                var classes = y.AsParallel().Distinct<INamedTypeSymbol>(SymbolEqualityComparer.Default);

                var dictionary = new Dictionary<string, List<string>>();

                foreach (var @class in classes)
                {
                    if (@class.BaseType!.GetFullyQualifiedName() == "global::Mliybs.Minecraft.Fabric.Internals.JavaClass") continue;

                    if (dictionary.TryGetValue(@class.BaseType!.GetFullyQualifiedName(), out var list))
                        list.Add($"if (IsInstanceOf(handle, {@class.GetFullyQualifiedName()}.ClassRef.ObjectRef)) return {@class.GetFullyQualifiedName()}.From(handle);\n    ");

                    else
                        dictionary.Add(@class.BaseType!.GetFullyQualifiedName(), new()
                        {
                            $"if (IsInstanceOf(handle, {@class.GetFullyQualifiedName()}.ClassRef.ObjectRef)) return {@class.GetFullyQualifiedName()}.From(handle);\n    "
                        });
                }

                foreach (var @class in classes)
                {
                    var text = "";
                    if (dictionary.TryGetValue(@class.GetFullyQualifiedName(), out var list))
                        text = string.Join("", list);

                    if (@class.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.JavaInterfaceAttribute"))
                        x.AddSource($"JavaInterface.{@class.GetFullyQualifiedNameForFile()}.g.cs", @class.NestedClassCompletion($$"""
                            internal {{@class.Name}}(nint handle) : base(handle) {}
                            
                            public static {{@class.GetQualifiedName()}} From(nint handle)
                            {
                                {{text}}return new(handle);
                            }
                            """, true));

                    else
                        x.AddSource($"JavaClass.{@class.GetFullyQualifiedNameForFile()}.g.cs", @class.NestedClassCompletion($$"""
                            {{(@class.AllInterfaces.Any(x => x.OriginalDefinition.GetFullyQualifiedName() == "global::Mliybs.Minecraft.Fabric.Internals.IWrapper<T>") ? "public" : "internal")}} {{@class.Name}}(nint handle) : base(handle) {}

                            #pragma warning disable CS0108
                            public static {{@class.GetQualifiedName()}} From(nint handle)
                            {
                                {{text}}return new(handle);
                            }
                            #pragma warning restore CS0108
                            """));
                }
            });

            context.RegisterSourceOutput(methodProvider, static (x, y) =>
            {
                var classes = y.AsParallel().GroupBy<IMethodSymbol, INamedTypeSymbol>(x => x.ContainingType, SymbolEqualityComparer.Default)
                    .Select(group => (group.Key, group.Select(methods => JavaConstructorGenerate(x, methods))));

                foreach (var @class in classes)
                {
                    x.AddSource($"JavaConstructorInitialize.{@class.Key.GetFullyQualifiedNameForFile()}.g.cs", @class.Key.NestedClassCompletion($$"""
                    private static void JavaConstructorInitialize()
                    {
                    {{string.Join("\n", @class.Item2)}}
                    }
                    """, true));
                }
            });
        }
        static string JavaConstructorGenerate(SourceProductionContext x, IMethodSymbol y)
        {
            var method = new StringBuilder()
                .Append(y.ContainingType.Name)
                .Append('_');

            var map = new StringBuilder().Append("$\"(");

            var regex = new Regex("<.+?>");

            foreach (var param in y.Parameters)
            {
                var name = param.Type.GetFullyQualifiedName();

                if (name.StartsWith("global::"))
                {
                    map.Append($"L{{({regex.Replace(name, string.Empty).Replace("?", "")}.Names.MapSignature)}};");
                    method.Append(regex.Replace(param.Type.TypeKind == TypeKind.Interface ? param.Type.GetQualifiedName().Substring(1) : param.Type.GetQualifiedName(), string.Empty).Replace("?", ""));
                }

                else
                    switch (name)
                    {
                        case "int":
                            map.Append('I');
                            method.Append("Int");
                            break;

                        case "long":
                            map.Append('J');
                            method.Append("Long");
                            break;

                        case "bool":
                            map.Append('Z');
                            method.Append("Bool");
                            break;

                        case "sbyte":
                            map.Append('B');
                            method.Append("Byte");
                            break;

                        case "byte":
                            map.Append('B');
                            method.Append("Byte");
                            break;

                        case "char":
                            map.Append('C');
                            method.Append("Char");
                            break;

                        case "short":
                            map.Append('S');
                            method.Append("Short");
                            break;

                        case "float":
                            map.Append('F');
                            method.Append("Float");
                            break;

                        case "double":
                            map.Append('D');
                            method.Append("Double");
                            break;

                        case "string":
                            map.Append("Ljava/lang/String;");
                            method.Append("String");
                            break;

                        default: // 包括nint
                            map.Append("Ljava/lang/Object;");
                            method.Append("Object");
                            break;
                    }
            }

            map.Append(")V\"");

            var methodName = method.ToString();

            x.AddSource($"JavaConstructor.{y.ContainingType.GetFullyQualifiedNameForFile()}.{methodName}", y.ContainingType.NestedClassCompletion($$"""
                internal static nint {{methodName}} { get; private set; }

                #nullable enable
                private static unsafe nint {{methodName}}Invoke({{string.Join(", ", y.Parameters.Select(x => $"{x.Type.GetFullyQualifiedName()} {x.GetFullyQualifiedName()}"))}})
                {
                    {{SignatureGenerator.SetJValues(y.Parameters)}}return Env->Functions->NewObjectA{{$"(Env, ClassRef.ObjectRef, {methodName}, @params)"}};
                }
                """, true));

            return $$"""    {{methodName}} = GetConstructorID(ClassRef.ObjectRef, {{map}});""";
        }
    }
}
