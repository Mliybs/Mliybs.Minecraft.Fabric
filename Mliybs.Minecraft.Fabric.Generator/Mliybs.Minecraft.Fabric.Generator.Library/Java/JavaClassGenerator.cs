#define SIMPLE_FROM

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
            #if SIMPLE_FROM
            var classProvider = context.SyntaxProvider.CreateSyntaxProvider(static (x, _) => x is ClassDeclarationSyntax,
                static (x, _) => (INamedTypeSymbol)x.SemanticModel.GetDeclaredSymbol(x.Node))
                .Where(x => x.HasBaseWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.Internals.JavaClass")
                    && !x.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.SuppressJavaClassAttribute"));
            #else
            var classProvider = context.SyntaxProvider.CreateSyntaxProvider(static (x, _) => x is ClassDeclarationSyntax,
                static (x, _) => (INamedTypeSymbol)x.SemanticModel.GetDeclaredSymbol(x.Node))
                .Where(x => x.HasBaseWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.Internals.JavaClass")
                    && !x.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.SuppressJavaClassAttribute"))
                .Collect();
            #endif

            var methodProvider = context.SyntaxProvider.CreateSyntaxProvider(static (x, _) => x is ClassDeclarationSyntax,
                static (x, _) => (INamedTypeSymbol)x.SemanticModel.GetDeclaredSymbol(x.Node))
                .Where(x => x.HasBaseWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.Internals.JavaClass"));

            #if SIMPLE_FROM
            context.RegisterSourceOutput(classProvider, static (x, y) =>
            {
                x.AddSource($"JavaClass.{y.GetFullyQualifiedNameForFile()}.g.cs", y.NestedClassCompletion($$"""
                    {{(y.Interfaces.Any(x => x.OriginalDefinition.HasFullyQualifiedName("global::Mliybs.Minecraft.Fabric.Internals.IWrapper<T>")) ? "protected internal" : "internal")}} {{y.Name}}(nint handle) : base(handle) {}

                    #pragma warning disable CS0108
                    public static {{y.GetQualifiedName()}} From(nint handle)
                    {
                        return new(handle);
                    }
                    #pragma warning restore CS0108
                    """));
            });
            #else
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

                    x.AddSource($"JavaClass.{@class.GetFullyQualifiedNameForFile()}.g.cs", @class.NestedClassCompletion($$"""
                        internal {{@class.Name}}(nint handle) : base(handle) {}

                        #pragma warning disable CS0108
                        public static {{@class.GetQualifiedName()}} From(nint handle)
                        {
                            {{text}}return new(handle);
                        }
                        #pragma warning restore CS0108
                        """));
                }
            });
            #endif

            context.RegisterSourceOutput(methodProvider, static (x, y) =>
            {
                var result = string.Join("\n", y.GetMembers().Where(x => x.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.JavaConstructorAttribute"))
                    .Select(method => JavaConstructorGenerate(x, (IMethodSymbol)method)));

                if (result == string.Empty) return;

                x.AddSource($"JavaConstructorInitialize.{y.GetFullyQualifiedNameForFile()}.g.cs", y.NestedClassCompletion($$"""
                private static void JavaConstructorInitialize()
                {
                {{result}}
                }
                """, true));
            });
        }
        static string JavaConstructorGenerate(SourceProductionContext x, IMethodSymbol y)
        {
            var method = new StringBuilder();

            var map = new StringBuilder().Append("$\"(");

            var regex = new Regex("<.*?>+");

            method.Append(regex.Replace(y.ContainingType.Name, ""))
                .Append('_');

            foreach (var param in y.Parameters)
            {
                var name = param.Type.GetFullyQualifiedName();

                if (name.StartsWith("global::"))
                {
                    if (param.Type.OriginalDefinition.GetFullyQualifiedName() == "global::Mliybs.Minecraft.Fabric.Internals.JavaArray<T>")
                    {
                        var genericType = name.AsSpan().Slice(52, name.Length - 53);
                        // JavaArray的类型参数一定以global::开头，不以它开头的一定是泛型类型参数
                        if (!genericType.StartsWith("global::".AsSpan())) genericType = "global::Java.Lang.Object".AsSpan();
                        var @string = regex.Replace(genericType.ToString(), string.Empty);
                        map.Append($"[L{{({@string}.Names.MapSignature)}};");
                        method.Append(regex.Replace(genericType.Slice(genericType.LastIndexOf('.') + 1).ToString(), string.Empty) + "Array");
                    }

                    else
                    {
                        map.Append($"L{{({regex.Replace(name, string.Empty).Replace("?", "")}.Names.MapSignature)}};");
                        method.Append(regex.Replace(param.Type.TypeKind == TypeKind.Interface ? param.Type.GetQualifiedName().Substring(1) : param.Type.GetQualifiedName(), string.Empty).Replace("?", ""));
                    }
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
                    {{SetJValues(y.Parameters)}}return Env->Functions->NewObjectA{{$"(Env, ClassRef.ObjectRef, {methodName}, @params)"}};
                }
                """, true));

            return $$"""    {{methodName}} = GetConstructorID(ClassRef.ObjectRef, {{map}});""";
        }

        public static string SetJValues(System.Collections.Immutable.ImmutableArray<IParameterSymbol> symbols)
        {
            var builder = new StringBuilder().AppendLine($"JValue* @params = stackalloc JValue[{symbols.Length}];");
            for (var i = 0; i < symbols.Length; i++)
            {
                switch (symbols[i].Type.GetFullyQualifiedName())
                {
                    case "int":
                        builder.AppendLine($"    @params[{i}].i = {SetParam(symbols[i])};");
                        break;

                    case "long":
                        builder.AppendLine($"    @params[{i}].j = {SetParam(symbols[i])};");
                        break;

                    case "bool":
                        builder.AppendLine($"    @params[{i}].z = {SetParam(symbols[i])};");
                        break;

                    case "sbyte":
                        builder.AppendLine($"    @params[{i}].b = {SetParam(symbols[i])};");
                        break;

                    case "byte":
                        builder.AppendLine($"    @params[{i}].b = {SetParam(symbols[i])};");
                        break;

                    case "char":
                        builder.AppendLine($"    @params[{i}].c = {SetParam(symbols[i])};");
                        break;

                    case "short":
                        builder.AppendLine($"    @params[{i}].s = {SetParam(symbols[i])};");
                        break;

                    case "float":
                        builder.AppendLine($"    @params[{i}].f = {SetParam(symbols[i])};");
                        break;

                    case "double":
                        builder.AppendLine($"    @params[{i}].d = {SetParam(symbols[i])};");
                        break;

                    default:
                        builder.AppendLine($"    @params[{i}].l = {SetParam(symbols[i])};");
                        break;
                }
            }
            builder.Append("    ");
            return builder.ToString();
        }

        public static string SetParam(IParameterSymbol x)
        {
            var name = x.Type.GetFullyQualifiedName();
            if (x.Type.TypeKind == TypeKind.Delegate)
            {
                var nestedClass = x.Type.ContainingType.GetFullyQualifiedName();
                return $"Mliybs.Minecraft.Fabric.Wrappers.InvocationHandlerWrapper.GetProxyOf({nestedClass}.ClassRef, {nestedClass}.Handle({x.GetFullyQualifiedName()}))";
            }
            if (name.StartsWith("global::") || x.Type.TypeKind == TypeKind.TypeParameter) return $"{x.GetFullyQualifiedName()}?.ObjectRef ?? nint.Zero";
            if (name == "string") return $"NewString({x.GetFullyQualifiedName()})";
            return x.GetFullyQualifiedName();
        }
    }
}
