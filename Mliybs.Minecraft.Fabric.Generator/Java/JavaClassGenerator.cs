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
                foreach (var @class in y.Distinct<INamedTypeSymbol>(SymbolEqualityComparer.Default))
                {
                    if (@class.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.JavaInterfaceAttribute"))
                        x.AddSource($"JavaInterface.{@class.GetFullyQualifiedNameForFile()}.g.cs", @class.NestedClassCompletion($$"""
                            internal {{@class.Name}}(nint handle) : base(handle) {}
                            
                            public static {{@class.GetQualifiedName()}} From(nint handle)
                            {
                                return new(handle);
                            }
                            """, true));

                    else if (@class.IsSealed && !@class.Interfaces.Any(x => x.OriginalDefinition.HasFullyQualifiedName("global::Mliybs.Minecraft.Fabric.Internals.IJavaEnum<T>")))
                        x.AddSource($"JavaClass.{@class.GetFullyQualifiedNameForFile()}.g.cs", @class.NestedClassCompletion($$"""
                            private {{@class.Name}}() : base(nint.Zero)
                            {
                                throw new NotSupportedException();
                            }
                            
                            public static {{@class.GetQualifiedName()}} From(nint handle)
                            {
                                throw new NotSupportedException();
                            }
                            """, true));

                    else if (@class.IsAbstract)
                        x.AddSource($"JavaClass.{@class.GetFullyQualifiedNameForFile()}.g.cs", @class.NestedClassCompletion($$"""
                            internal {{@class.Name}}(nint handle) : base(handle) {}
                            """, true));

                    else
                        x.AddSource($"JavaClass.{@class.GetFullyQualifiedNameForFile()}.g.cs", @class.NestedClassCompletion($$"""
                            {{(@class.AllInterfaces.Any(x => x.OriginalDefinition.GetFullyQualifiedName() == "global::Mliybs.Minecraft.Fabric.Internals.IWrapper<T>") ? "public" : "internal")}} {{@class.Name}}(nint handle) : base(handle) {}

                            #pragma warning disable CS0108
                            public static {{@class.GetQualifiedName()}} From(nint handle)
                            {
                                return new(handle);
                            }
                            #pragma warning restore CS0108
                            """));
                }
            });

            context.RegisterSourceOutput(methodProvider, static (x, y) =>
            {
                var classes = y.GroupBy<IMethodSymbol, INamedTypeSymbol>(x => x.ContainingType, SymbolEqualityComparer.Default)
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

            var type = new StringBuilder().Append("delegate* unmanaged[Cdecl]<Mliybs.JNI.JNIEnv*, nint, nint, ");

            var regex = new Regex("<.+?>");

            foreach (var param in y.Parameters)
            {
                var name = param.Type.GetFullyQualifiedName();

                if (name.StartsWith("global::"))
                {
                    map.Append($"L{{({regex.Replace(name, string.Empty)}.Names.MapSignature)}};");
                    method.Append(regex.Replace(name.Substring(name.LastIndexOf('.') + 1), string.Empty));
                    type.Append("nint, ");
                }

                else
                    switch (name)
                    {
                        case "int":
                            map.Append('I');
                            method.Append("Int");
                            type.Append("int, ");
                            break;

                        case "long":
                            map.Append('L');
                            method.Append("Long");
                            type.Append("long, ");
                            break;

                        case "bool":
                            map.Append('Z');
                            method.Append("Bool");
                            type.Append("bool, ");
                            break;

                        case "byte":
                            map.Append('B');
                            method.Append("Byte");
                            type.Append("byte, ");
                            break;

                        case "char":
                            map.Append('C');
                            method.Append("Char");
                            type.Append("char, ");
                            break;

                        case "short":
                            map.Append('S');
                            method.Append("Short");
                            type.Append("short, ");
                            break;

                        case "float":
                            map.Append('F');
                            method.Append("Float");
                            type.Append("float, ");
                            break;

                        case "double":
                            map.Append('D');
                            method.Append("Double");
                            type.Append("double, ");
                            break;

                        case "string":
                            map.Append("Ljava/lang/String;");
                            method.Append("String");
                            type.Append("nint, ");
                            break;

                        default: // 包括nint
                            map.Append("Ljava/lang/Object;");
                            method.Append("Object");
                            type.Append("nint, ");
                            break;
                    }
            }

            map.Append(")V\"");

            type.Append("nint>");

            var methodName = method.ToString();

            x.AddSource($"JavaConstructor.{y.ContainingType.GetFullyQualifiedNameForFile()}.{methodName}", y.ContainingType.NestedClassCompletion($$"""
                internal static nint {{methodName}} { get; private set; }

                private unsafe void {{methodName}}Invoke({{string.Join(", ", y.Parameters.Select(x => $"{x.Type.GetFullyQualifiedName()} {x.Name}"))}})
                {
                    ObjectRef = (({{type}})Env->Functions->NewObject){{(y.Parameters.Length == 0
                    ? $"(Env, ClassRef, {methodName})"
                    : $"(Env, ClassRef, {methodName}, {string.Join(", ", y.Parameters.Select(x =>
                    {
                        var name = x.Type.GetFullyQualifiedName();
                        if (name.StartsWith("global::") || x.Type.TypeKind == TypeKind.TypeParameter) return $"{x.Name}.ObjectRef";
                        if (name == "string") return $"NewString({x.Name})";
                        return x.Name;
                    }))})")}};
                }
                """, true));

            return $$"""    {{methodName}} = GetConstructorID(ClassRef, {{map}});""";
        }
    }
}
