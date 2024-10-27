using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Mliybs.Minecraft.Fabric.Generator
{
    [Generator]
    public class SignatureGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            var provider = context.SyntaxProvider.CreateSyntaxProvider((x, _) => x is MethodDeclarationSyntax
            {
                AttributeLists.Count: > 0
            } or PropertyDeclarationSyntax
            {
                AttributeLists.Count: > 0
            }, (x, _) => x.SemanticModel.GetDeclaredSymbol(x.Node))
                .Where(x => x.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.SignatureAttribute"))
                .Collect();

            context.RegisterSourceOutput(provider, static (x, y) =>
            {
                var classes = y.GroupBy<ISymbol, INamedTypeSymbol>(x => x.ContainingType, SymbolEqualityComparer.Default)
                    .Select(group => (group.Key, group.Select(symbol =>
                    {
                        if (symbol is IMethodSymbol method) return MethodSignatureGenerate(x, method);
                        if (symbol is IPropertySymbol property)
                        {
                            var (arg, useMapping) = property.GetAttributes()
                                .Where(x => x.AttributeClass.HasFullyQualifiedName("global::Mliybs.Minecraft.Fabric.SignatureAttribute"))
                                .Select(x => ((string)x.ConstructorArguments[0].Value, (bool)x.ConstructorArguments[1].Value))
                                .Single();
                            var type = property.Type.GetFullyQualifiedName();
                            if (useMapping) return $$"""    {{property.GetFullyQualifiedName()}} = new(GetStaticObjectField(ClassRef, MapFieldName(Names.OriginName, "{{arg}}", $"L{({{type}}.Names.OriginSignature)};"), $"L{({{type}}.Names.MapSignature)};"));""";
                            else return $$"""    {{property.GetFullyQualifiedName()}} = new(GetStaticObjectField(ClassRef, "{{arg}}", $"L{({{type}}.Names.MapSignature)};"));""";
                        }

                        throw new ArgumentException(nameof(symbol));
                    })));

                foreach (var @class in classes)
                {
                    x.AddSource($"SignatureInitialize.{@class.Key.GetFullyQualifiedNameForFile()}.g.cs", @class.Key.NestedClassCompletion($$"""
                        private static void SignatureInitialize()
                        {
                        {{string.Join("\n", @class.Item2)}}
                        }
                        """, true));
                }
            });
        }

        public static string MethodSignatureGenerate(SourceProductionContext x, IMethodSymbol y)
        {
            var (value, useMapping) = y.GetAttributes()
                .Where(x => x.AttributeClass.HasFullyQualifiedName("global::Mliybs.Minecraft.Fabric.SignatureAttribute"))
                .Select(x => ((string)x.ConstructorArguments[0].Value, (bool)x.ConstructorArguments[1].Value))
                .Single();

#nullable enable
            string? returnType = y.ReturnsVoid ? null : y.ReturnType.GetFullyQualifiedName();

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
                    if (param.Type.OriginalDefinition.GetFullyQualifiedName() == "global::Mliybs.Minecraft.Fabric.Internals.JavaArray<T>")
                    {
                        var genericType = name.Substring(52, name.Length - 53);
                        origin.Append($"[L{{({regex.Replace(genericType, string.Empty)}.Names.OriginSignature)}};");
                        map.Append($"[L{{({regex.Replace(genericType, string.Empty)}.Names.MapSignature)}};");
                        method.Append(regex.Replace(genericType.Substring(genericType.LastIndexOf('.') + 1), string.Empty) + "Array");
                        type.Append("nint, ");
                    }

                    else
                    {
                        origin.Append($"L{{({regex.Replace(name, string.Empty)}.Names.OriginSignature)}};");
                        map.Append($"L{{({regex.Replace(name, string.Empty)}.Names.MapSignature)}};");
                        if (name == "global::Java.Lang.Class")
                            method.Append("Class");

                        else
                            method.Append(regex.Replace(name.Substring(name.LastIndexOf('.') + 1), string.Empty));
                        type.Append("nint, ");
                    }
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
                if (returnType!.StartsWith("global::"))
                {
                    if (y.ReturnType.OriginalDefinition.GetFullyQualifiedName() == "global::Mliybs.Minecraft.Fabric.Internals.JavaArray<T>")
                    {
                        var genericType = returnType.Substring(52, returnType.Length - 53);
                        origin.Append($"[L{{({regex.Replace(genericType, string.Empty)}.Names.OriginSignature)}};");
                        map.Append($"[L{{({regex.Replace(genericType, string.Empty)}.Names.MapSignature)}};");
                        type.Append("nint>");
                    }

                    else
                    {
                        origin.Append($"L{{({regex.Replace(returnType, string.Empty)}.Names.OriginSignature)}};");
                        map.Append($"L{{({regex.Replace(returnType, string.Empty)}.Names.MapSignature)}};");
                        type.Append("nint>");
                    }

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
                            if (y.IsStatic) function = "Env->Functions->CallStaticBooleanMethod";
                            else function = "Env->Functions->CallBooleanMethod";
                            break;

                        case "byte":
                            origin.Append('B');
                            map.Append('B');
                            type.Append("byte>");
                            if (y.IsStatic) function = "Env->Functions->CallStaticByteMethod";
                            else function = "Env->Functions->CallByteMethod";
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

            var generic = new StringBuilder();

            foreach (var param in y.TypeParameters)
            {
                var list = new List<string>();
                foreach (var @class in param.ConstraintTypes.Where(x => x.TypeKind == TypeKind.Class))
                    list.Add(@class.GetFullyQualifiedName());

                foreach (var @interface in param.ConstraintTypes.Where(x => x.TypeKind == TypeKind.Interface))
                    list.Add(@interface.GetFullyQualifiedName());

                foreach (var genericType in param.ConstraintTypes.Where(x => x.TypeKind == TypeKind.TypeParameter))
                    list.Add(genericType.Name);

                if (param.HasUnmanagedTypeConstraint) list.Add("unmanaged");

                if (list.Count == 0) continue;

                generic.Append(" where ").Append(param.Name).Append(" : ").Append(string.Join(", ", list));
            }

            x.AddSource($"Signature.{y.ContainingType.GetFullyQualifiedNameForFile()}.{methodName}.g.cs", y.ContainingType.NestedClassCompletion($$"""
                internal static nint {{methodName}} { get; private set; }
                """));

            // 两个分部声明必须都有unsafe修饰符，所以将unsafe移到方法体内部
            if (y.IsPartialDefinition) x.AddSource($"MethodBody.{y.ContainingType.GetFullyQualifiedNameForFile()}.{methodName}.g.cs", y.ContainingType.NestedClassCompletion($$"""
                {{y.DeclaredAccessibility.GetAccessModifier()}}{{(y.IsStatic ? "static " : "")}}{{(y.IsVirtual ? "virtual " : "")}}partial {{(y.ReturnsVoid ? "void" : returnType!)}} {{y.GetFullyQualifiedName()}}({{string.Join(", ", y.Parameters.Select(x => $"{x.Type.GetFullyQualifiedName()} {x.Name}"))}}){{generic}}
                {
                    unsafe
                    {
                        {{(y.ReturnsVoid ? "" : "var result = ")}}(({{type}}){{function}}){{(y.IsStatic
                                ? (y.Parameters.Length == 0 ? $"(Env, ClassRef, {methodName})" : $"(Env, ClassRef, {methodName}, {string.Join(", ", y.Parameters.Select(x =>
                                {
                                    var name = x.Type.GetFullyQualifiedName();
                                    if (name.StartsWith("global::") || x.Type.TypeKind == TypeKind.TypeParameter) return $"{x.Name}.ObjectRef";
                                    if (name == "string") return $"NewString({x.Name})";
                                    return x.Name;
                                }))})")
                                : (y.Parameters.Length == 0 ? $"(Env, ObjectRef, {methodName})" : $"(Env, ObjectRef, {methodName}, {string.Join(", ", y.Parameters.Select(x =>
                                {
                                    var name = x.Type.GetFullyQualifiedName();
                                    if (name.StartsWith("global::") || x.Type.TypeKind == TypeKind.TypeParameter) return $"{x.Name}.ObjectRef";
                                    if (name == "string") return $"NewString({x.Name})";
                                    return x.Name;
                                }))})")
                            )}};

                        return{{(y.ReturnsVoid ? "" : (returnType!.StartsWith("global::")
                            ? " new(result)"
                            : (returnType == "string"
                                ? " GetString(result)"
                                : (y.ReturnType.TypeKind == TypeKind.TypeParameter
                                    ? $" {y.ReturnType.Name}.From(result)"
                                    : " result"))))}};
                    }
                }
                """));

            if (useMapping) return $$"""    {{methodName}} = {{(y.IsStatic ? "GetStaticMethodID" : "GetMethodID")}}(ClassRef, MapMethodName(Names.OriginName, "{{value}}", {{origin}}), {{map}});""";
            else return $$"""    {{methodName}} = {{(y.IsStatic ? "GetStaticMethodID" : "GetMethodID")}}(ClassRef, "{{value}}", {{map}});""";
        }
    }
}
