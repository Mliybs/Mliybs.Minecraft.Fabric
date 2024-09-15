using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace Mliybs.Minecraft.Fabric.Generator
{
    [Generator]
    public class JavaClassGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            context.RegisterPostInitializationOutput(x =>
            {
                x.AddSource("JavaConstructor.g.cs", """
                    #if FABRIC_LIBRARY
                    using System;
                    
                    namespace Mliybs.Minecraft.Fabric
                    {
                        [AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false, Inherited = false)]
                        public class JavaConstructorAttribute : Attribute
                        {}
                    }
                    #endif
                    """);
            });

            var classProvider = context.SyntaxProvider.CreateSyntaxProvider(static (x, _) => x is ClassDeclarationSyntax,
                static (x, _) => (INamedTypeSymbol)x.SemanticModel.GetDeclaredSymbol(x.Node))
                .Where(x => x.HasBaseWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.Internals.JavaClass"))
                .Collect();

            var methodProvider = context.SyntaxProvider.CreateSyntaxProvider(static (x, _) => x is ConstructorDeclarationSyntax
            {
                AttributeLists.Count: > 0
            }, static (x, _) => (IMethodSymbol)x.SemanticModel.GetDeclaredSymbol(x.Node))
                .Where(x => x.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.JavaConstructorAttribute"));

            context.RegisterSourceOutput(classProvider, static (x, y) =>
            {
                foreach (var @class in y.Distinct<INamedTypeSymbol>(SymbolEqualityComparer.Default))
                {
                    if (@class.IsSealed)
                        x.AddSource($"JavaClass.{@class.MetadataName.Replace('`', '_')}.g.cs", @class.NestedClassCompletion($$"""
                            private {{@class.Name}}() : base(nint.Zero)
                            {
                                throw new NotSupportedException();
                            }
                            """, true));

                    else
                        x.AddSource($"JavaClass.{@class.MetadataName.Replace('`', '_')}.g.cs", @class.NestedClassCompletion($$"""
                            public {{@class.Name}}(nint handle) : base(handle) {}
                            """, true));
                }
            });

            context.RegisterSourceOutput(methodProvider, static (x, y) =>
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

                x.AddSource($"JavaConstructor.{y.ContainingType.MetadataName.Replace('`', '_')}.{methodName}", y.ContainingType.NestedClassCompletion($$"""
                internal static readonly nint {{methodName}} = GetConstructorID(ClassRef, {{map}});

                private unsafe void {{methodName}}Invoke({{string.Join(", ", y.Parameters.Select(x => $"{x.Type.GetFullyQualifiedName()} {x.Name}"))}})
                {
                    ObjectRef = (({{type}})Env->Functions->NewObject){{(y.Parameters.Length == 0
                        ? $"(Env, ClassRef, {methodName})"
                        : $"(Env, ClassRef, {methodName}, {string.Join(", ", y.Parameters.Select(x =>
                        {
                            var name = x.Type.GetFullyQualifiedName();
                            if (name.StartsWith("global::")) return $"{x.Name}.ObjectRef";
                            if (name == "string") return $"NewString({x.Name})";
                            return x.Name;
                        }))})")}};
                }
                """, true));
            });
        }
    }
}
