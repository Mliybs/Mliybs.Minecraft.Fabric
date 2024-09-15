using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Mliybs.Minecraft.Fabric.Generator
{
    [Generator]
    public class SignatureGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            context.RegisterPostInitializationOutput(x => x.AddSource("SignatureAttribute.g.cs", """
                #if FABRIC_LIBRARY
                using System;

                namespace Mliybs.Minecraft.Fabric
                {
                    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
                    public sealed class SignatureAttribute : Attribute
                    {
                        public string Value { get; }

                        public SignatureAttribute(string value)
                        {
                            Value = value;
                        }
                    }
                }
                #endif
                """));

            var provider = context.SyntaxProvider.CreateSyntaxProvider((x, _) => x is MethodDeclarationSyntax
            {
                AttributeLists.Count: > 0
            }, (x, _) => (IMethodSymbol)x.SemanticModel.GetDeclaredSymbol(x.Node))
                .Where(x => x.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.SignatureAttribute"));

            context.RegisterSourceOutput(provider, MethodSignatureGenerate);
        }

        static void MethodSignatureGenerate(SourceProductionContext x, IMethodSymbol y)
        {
            var value = string.Empty;

            foreach (var attribute in y.GetAttributes())
                if (attribute.AttributeClass.HasFullyQualifiedName("global::Mliybs.Minecraft.Fabric.SignatureAttribute") && attribute.ConstructorArguments.Length > 0)
                    value = (string)attribute.ConstructorArguments[0].Value;

            var returnType = y.ReturnType.GetFullyQualifiedName();

            var method = new StringBuilder()
                .Append(y.Name)
                .Append('_');

            var origin = new StringBuilder().Append("$\"(");

            var map = new StringBuilder().Append("$\"(");

            var type = new StringBuilder().Append("delegate* unmanaged[Cdecl]<Mliybs.JNI.JNIEnv*, nint, nint, ");

            var function = string.Empty;

            var regex = new Regex("<.+?>");

            foreach (var param in y.Parameters)
            {
                var name = param.Type.GetFullyQualifiedName();

                if (name.StartsWith("global::"))
                {
                    origin.Append($"L{{({regex.Replace(name, string.Empty)}.Names.OriginSignature)}};");
                    map.Append($"L{{({regex.Replace(name, string.Empty)}.Names.MapSignature)}};");
                    method.Append(regex.Replace(name.Substring(name.LastIndexOf('.') + 1), string.Empty));
                    type.Append("nint, ");
                }

                else
                    switch (name)
                    {
                        case "int":
                            origin.Append('I');
                            map.Append('I');
                            method.Append("Int");
                            type.Append("int, ");
                            break;

                        case "long":
                            origin.Append('L');
                            map.Append('L');
                            method.Append("Long");
                            type.Append("long, ");
                            break;

                        case "bool":
                            origin.Append('Z');
                            map.Append('Z');
                            method.Append("Bool");
                            type.Append("bool, ");
                            break;

                        case "byte":
                            origin.Append('B');
                            map.Append('B');
                            method.Append("Byte");
                            type.Append("byte, ");
                            break;

                        case "char":
                            origin.Append('C');
                            map.Append('C');
                            method.Append("Char");
                            type.Append("char, ");
                            break;

                        case "short":
                            origin.Append('S');
                            map.Append('S');
                            method.Append("Short");
                            type.Append("short, ");
                            break;

                        case "float":
                            origin.Append('F');
                            map.Append('F');
                            method.Append("Float");
                            type.Append("float, ");
                            break;

                        case "double":
                            origin.Append('D');
                            map.Append('D');
                            method.Append("Double");
                            type.Append("double, ");
                            break;

                        case "string":
                            origin.Append("Ljava/lang/String;");
                            map.Append("Ljava/lang/String;");
                            method.Append("String");
                            type.Append("nint, ");
                            break;

                        default: // 包括nint
                            origin.Append("Ljava/lang/Object;");
                            map.Append("Ljava/lang/Object;");
                            method.Append("Object");
                            type.Append("nint, ");
                            break;
                    }
            }

            origin.Append(')');
            map.Append(')');

            if (y.ReturnsVoid)
            {
                origin.Append('V');
                map.Append('V');
                type.Append("void>");
                if (y.IsStatic) function = "Env->Functions->CallStaticVoidMethod";
                else function = "Env->Functions->CallVoidMethod";
            }

            else
            {
                if (returnType.StartsWith("global::"))
                {
                    origin.Append($"L{{({returnType}.Names.OriginSignature)}};");
                    map.Append($"L{{({returnType}.Names.MapSignature)}};");
                    type.Append("nint>");
                    if (y.IsStatic) function = "Env->Functions->CallStaticObjectMethod";
                    else function = "Env->Functions->CallObjectMethod";
                }

                else
                    switch (returnType)
                    {
                        case "int":
                            origin.Append('I');
                            map.Append('I');
                            type.Append("int>");
                            if (y.IsStatic) function = "Env->Functions->CallStaticIntMethod";
                            else function = "Env->Functions->CallIntMethod";
                            break;

                        case "long":
                            origin.Append('L');
                            map.Append('L');
                            type.Append("long>");
                            if (y.IsStatic) function = "Env->Functions->CallStaticLongMethod";
                            else function = "Env->Functions->CallLongMethod";
                            break;

                        case "bool":
                            origin.Append('Z');
                            map.Append('Z');
                            type.Append("bool>");
                            if (y.IsStatic) function = "Env->Functions->CallStaticLongMethod";
                            else function = "Env->Functions->CallLongMethod";
                            break;

                        case "byte":
                            origin.Append('B');
                            map.Append('B');
                            type.Append("byte>");
                            if (y.IsStatic) function = "Env->Functions->CallStaticLongMethod";
                            else function = "Env->Functions->CallLongMethod";
                            break;

                        case "char":
                            origin.Append('C');
                            map.Append('C');
                            type.Append("char>");
                            if (y.IsStatic) function = "Env->Functions->CallStaticCharMethod";
                            else function = "Env->Functions->CallCharMethod";
                            break;

                        case "short":
                            origin.Append('S');
                            map.Append('S');
                            type.Append("short>");
                            if (y.IsStatic) function = "Env->Functions->CallStaticShortMethod";
                            else function = "Env->Functions->CallShortMethod";
                            break;

                        case "float":
                            origin.Append('F');
                            map.Append('F');
                            type.Append("float>");
                            if (y.IsStatic) function = "Env->Functions->CallStaticFloatMethod";
                            else function = "Env->Functions->CallFloatMethod";
                            break;

                        case "double":
                            origin.Append('D');
                            map.Append('D');
                            type.Append("double>");
                            if (y.IsStatic) function = "Env->Functions->CallStaticDoubleMethod";
                            else function = "Env->Functions->CallDoubleMethod";
                            break;

                        case "string":
                            origin.Append("Ljava/lang/String;");
                            map.Append("Ljava/lang/String;");
                            type.Append("nint>");
                            if (y.IsStatic) function = "Env->Functions->CallStaticObjectMethod";
                            else function = "Env->Functions->CallObjectMethod";
                            break;

                        default:
                            origin.Append("Ljava/lang/Object;");
                            map.Append("Ljava/lang/Object;");
                            type.Append("nint>");
                            if (y.IsStatic) function = "Env->Functions->CallStaticObjectMethod";
                            else function = "Env->Functions->CallObjectMethod";
                            break;
                    }
            }

            origin.Append('"');
            map.Append('"');

            var methodName = method.ToString();

            x.AddSource($"Signature.{y.ContainingType.MetadataName.Replace('`', '_')}.{y.MetadataName.Replace('`', '_')}", y.ContainingType.NestedClassCompletion($$"""
                internal static readonly nint {{methodName}} = {{(y.IsStatic ? "GetStaticMethodID" : "GetMethodID")}}(ClassRef, MapMethodName(Names.OriginName, "{{value}}", {{origin}}), {{map}});
                """));

            // 两个分部声明必须都有unsafe修饰符，所以将unsafe移到方法体内部
            if (y.IsPartialDefinition) x.AddSource($"MethodBody.{y.ContainingType.MetadataName.Replace('`', '_')}.{y.MetadataName.Replace('`', '_')}", y.ContainingType.NestedClassCompletion($$"""
                {{y.DeclaredAccessibility.GetAccessModifier()}}partial {{(y.ReturnsVoid ? "void" : returnType)}} {{y.GetFullyQualifiedName()}}({{string.Join(", ", y.Parameters.Select(x => $"{x.Type.GetFullyQualifiedName()} {x.Name}"))}})
                {
                    unsafe
                    {
                        var result = (({{type}}){{function}}){{(y.IsStatic
                                ? (y.Parameters.Length == 0 ? $"(Env, ClassRef, {methodName})" : $"(Env, ClassRef, {methodName}, {string.Join(", ", y.Parameters.Select(x =>
                                {
                                    var name = x.Type.GetFullyQualifiedName();
                                    if (name.StartsWith("global::")) return $"{x.Name}.ObjectRef";
                                    if (name == "string") return $"NewString({x.Name})";
                                    return x.Name;
                                }))})")
                                : (y.Parameters.Length == 0 ? $"(Env, ObjectRef, {methodName})" : $"(Env, ObjectRef, {methodName}, {string.Join(", ", y.Parameters.Select(x =>
                                {
                                    var name = x.Type.GetFullyQualifiedName();
                                    if (name.StartsWith("global::")) return $"{x.Name}.ObjectRef";
                                    if (name == "string") return $"NewString({x.Name})";
                                    return x.Name;
                                }))})")
                            )}};

                        return {{(returnType.StartsWith("global::")
                            ? "new(result)"
                            : (returnType == "string" ? "GetString(result)" : "result"))}};
                    }
                }
                """));
        }
    }
}
