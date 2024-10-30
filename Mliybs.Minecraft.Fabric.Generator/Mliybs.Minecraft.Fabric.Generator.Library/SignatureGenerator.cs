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
                var classes = y.AsParallel().GroupBy<ISymbol, INamedTypeSymbol>(x => x.ContainingType, SymbolEqualityComparer.Default)
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
                            if (useMapping) return $$"""    {{property.GetFullyQualifiedName()}} = new(GetStaticObjectField(ClassRef.ObjectRef, MapFieldName(Names.OriginName, "{{arg}}", $"L{({{type}}.Names.OriginSignature)};"), $"L{({{type}}.Names.MapSignature)};"));""";
                            else return $$"""    {{property.GetFullyQualifiedName()}} = new(GetStaticObjectField(ClassRef.ObjectRef, "{{arg}}", $"L{({{type}}.Names.MapSignature)};"));""";
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
            var check = y.GetAttributes()
                .Where(x => x.AttributeClass.HasFullyQualifiedName("global::Mliybs.Minecraft.Fabric.ReturnCheckAttribute"))
                .Select(x => (string)x.ConstructorArguments[0].Value!)
                .SingleOrDefault();

            string? returnType = y.ReturnsVoid ? null : y.ReturnType.GetFullyQualifiedName();

            var method = new StringBuilder()
                .Append(y.Name)
                .Append('_');

            var origin = new StringBuilder().Append("$\"(");

            var map = new StringBuilder().Append("$\"(");

            var function = string.Empty;

            var regex = new Regex("<.+?>");

            // var regexReplace = y.ContainingType.TypeParameters.Any() ? "<Mliybs.Minecraft.Fabric.Internals.InternalClass>" : string.Empty;
            const string regexReplace = "";

            foreach (var param in y.Parameters)
            {
                var name = param.Type.GetFullyQualifiedName();

                if (param.Type.TypeKind == TypeKind.Delegate)
                {
                    var @delegate = param.Type.ContainingType.GetFullyQualifiedName();
                    origin.Append($"L{{({regex.Replace(@delegate, regexReplace)}.Names.OriginSignature)}};");
                    map.Append($"L{{({regex.Replace(@delegate, regexReplace)}.Names.MapSignature)}};");
                    method.Append("Object");
                }
                
                else if (name.StartsWith("global::"))
                {
                    if (param.Type.OriginalDefinition.GetFullyQualifiedName() == "global::Mliybs.Minecraft.Fabric.Internals.JavaArray<T>")
                    {
                        var genericType = name.Substring(52, name.Length - 53);
                        origin.Append($"[L{{({regex.Replace(genericType, regexReplace)}.Names.OriginSignature)}};");
                        map.Append($"[L{{({regex.Replace(genericType, regexReplace)}.Names.MapSignature)}};");
                        method.Append(regex.Replace(genericType.Substring(genericType.LastIndexOf('.') + 1), string.Empty) + "Array");
                    }

                    else
                    {
                        origin.Append($"L{{({regex.Replace(name, regexReplace).Replace("?", "")}.Names.OriginSignature)}};");
                        map.Append($"L{{({regex.Replace(name, regexReplace).Replace("?", "")}.Names.MapSignature)}};");
                        if (name == "global::Java.Lang.Class")
                            method.Append("Class");

                        else
                            method.Append(regex.Replace(param.Type.TypeKind == TypeKind.Interface ? param.Type.GetQualifiedName().Substring(1) : param.Type.GetQualifiedName(), regexReplace).Replace("?", ""));
                    }
                }

                else
                    switch (name)
                    {
                        case "int":
                            origin.Append('I');
                            map.Append('I');
                            method.Append("Int");
                            break;

                        case "long":
                            origin.Append('J');
                            map.Append('J');
                            method.Append("Long");
                            break;

                        case "bool":
                            origin.Append('Z');
                            map.Append('Z');
                            method.Append("Bool");
                            break;

                        case "sbyte":
                            origin.Append('B');
                            map.Append('B');
                            method.Append("Byte");
                            break;

                        case "byte":
                            origin.Append('B');
                            map.Append('B');
                            method.Append("Byte");
                            break;

                        case "char":
                            origin.Append('C');
                            map.Append('C');
                            method.Append("Char");
                            break;

                        case "short":
                            origin.Append('S');
                            map.Append('S');
                            method.Append("Short");
                            break;

                        case "float":
                            origin.Append('F');
                            map.Append('F');
                            method.Append("Float");
                            break;

                        case "double":
                            origin.Append('D');
                            map.Append('D');
                            method.Append("Double");
                            break;

                        case "string":
                            origin.Append("Ljava/lang/String;");
                            map.Append("Ljava/lang/String;");
                            method.Append("String");
                            break;

                        default: // 包括nint
                            origin.Append("Ljava/lang/Object;");
                            map.Append("Ljava/lang/Object;");
                            method.Append("Object");
                            break;
                    }
            }

            origin.Append(')');
            map.Append(')');

            if (y.ReturnsVoid)
            {
                origin.Append('V');
                map.Append('V');
                if (y.IsStatic) function = "Env->Functions->CallStaticVoidMethodA";
                else if (y.IsVirtual) function = "Env->Functions->CallNonvirtualVoidMethodA";
                else function = "Env->Functions->CallVoidMethodA";
            }

            else
            {
                if (y.ReturnType.TypeKind == TypeKind.Delegate)
                {
                    var @delegate = y.ReturnType.ContainingType.GetFullyQualifiedName();
                    origin.Append($"L{{({regex.Replace(@delegate, regexReplace)}.Names.OriginSignature)}};");
                    map.Append($"L{{({regex.Replace(@delegate, regexReplace)}.Names.MapSignature)}};");
                }
                
                else if (returnType!.StartsWith("global::"))
                {
                    if (y.ReturnType.OriginalDefinition.GetFullyQualifiedName() == "global::Mliybs.Minecraft.Fabric.Internals.JavaArray<T>")
                    {
                        var genericType = returnType.Substring(52, returnType.Length - 53);
                        origin.Append($"[L{{({regex.Replace(genericType, regexReplace)}.Names.OriginSignature)}};");
                        map.Append($"[L{{({regex.Replace(genericType, regexReplace)}.Names.MapSignature)}};");
                    }

                    else
                    {
                        origin.Append($"L{{({regex.Replace(returnType, regexReplace)}.Names.OriginSignature)}};");
                        map.Append($"L{{({regex.Replace(returnType, regexReplace)}.Names.MapSignature)}};");
                    }

                    if (y.IsStatic) function = "Env->Functions->CallStaticObjectMethodA";
                    else if (y.IsVirtual) function = "Env->Functions->CallNonvirtualObjectMethodA";
                    else function = "Env->Functions->CallObjectMethodA";
                }

                else
                    switch (returnType)
                    {
                        case "int":
                            origin.Append('I');
                            map.Append('I');
                            if (y.IsStatic) function = "Env->Functions->CallStaticIntMethodA";
                            else if (y.IsVirtual) function = "Env->Functions->CallNonvirtualIntMethodA";
                            else function = "Env->Functions->CallIntMethodA";
                            break;

                        case "long":
                            origin.Append('J');
                            map.Append('J');
                            if (y.IsStatic) function = "Env->Functions->CallStaticLongMethodA";
                            else if (y.IsVirtual) function = "Env->Functions->CallNonvirtualLongMethodA";
                            else function = "Env->Functions->CallLongMethodA";
                            break;

                        case "bool":
                            origin.Append('Z');
                            map.Append('Z');
                            if (y.IsStatic) function = "Env->Functions->CallStaticBooleanMethodA";
                            else if (y.IsVirtual) function = "Env->Functions->CallNonvirtualBooleanMethodA";
                            else function = "Env->Functions->CallBooleanMethodA";
                            break;

                        case "sbyte":
                            origin.Append('B');
                            map.Append('B');
                            if (y.IsStatic) function = "Env->Functions->CallStaticByteMethodA";
                            else if (y.IsVirtual) function = "Env->Functions->CallNonvirtualByteMethodA";
                            else function = "Env->Functions->CallByteMethodA";
                            break;

                        case "byte":
                            origin.Append('B');
                            map.Append('B');
                            if (y.IsStatic) function = "Env->Functions->CallStaticByteMethodA";
                            else if (y.IsVirtual) function = "Env->Functions->CallNonvirtualByteMethodA";
                            else function = "Env->Functions->CallByteMethodA";
                            break;

                        case "char":
                            origin.Append('C');
                            map.Append('C');
                            if (y.IsStatic) function = "Env->Functions->CallStaticCharMethodA";
                            else if (y.IsVirtual) function = "Env->Functions->CallNonvirtualCharMethodA";
                            else function = "Env->Functions->CallCharMethodA";
                            break;

                        case "short":
                            origin.Append('S');
                            map.Append('S');
                            if (y.IsStatic) function = "Env->Functions->CallStaticShortMethodA";
                            else if (y.IsVirtual) function = "Env->Functions->CallNonvirtualShortMethodA";
                            else function = "Env->Functions->CallShortMethodA";
                            break;

                        case "float":
                            origin.Append('F');
                            map.Append('F');
                            if (y.IsStatic) function = "Env->Functions->CallStaticFloatMethodA";
                            else if (y.IsVirtual) function = "Env->Functions->CallNonvirtualFloatMethodA";
                            else function = "Env->Functions->CallFloatMethodA";
                            break;

                        case "double":
                            origin.Append('D');
                            map.Append('D');
                            if (y.IsStatic) function = "Env->Functions->CallStaticDoubleMethodA";
                            else if (y.IsVirtual) function = "Env->Functions->CallNonvirtualDoubleMethodA";
                            else function = "Env->Functions->CallDoubleMethodA";
                            break;

                        case "string":
                            origin.Append("Ljava/lang/String;");
                            map.Append("Ljava/lang/String;");
                            if (y.IsStatic) function = "Env->Functions->CallStaticObjectMethodA";
                            else if (y.IsVirtual) function = "Env->Functions->CallNonvirtualObjectMethodA";
                            else function = "Env->Functions->CallObjectMethodA";
                            break;

                        default:
                            origin.Append("Ljava/lang/Object;");
                            map.Append("Ljava/lang/Object;");
                            if (y.IsStatic) function = "Env->Functions->CallStaticObjectMethodA";
                            else if (y.IsVirtual) function = "Env->Functions->CallNonvirtualObjectMethodA";
                            else function = "Env->Functions->CallObjectMethodA";
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

                foreach (var genericType in param.ConstraintTypes.Where(x => x.TypeKind == TypeKind.TypeParameter))
                    list.Add(genericType.Name);

                foreach (var @interface in param.ConstraintTypes.Where(x => x.TypeKind == TypeKind.Interface))
                    list.Add(@interface.GetFullyQualifiedName());

                if (param.HasUnmanagedTypeConstraint) list.Add("unmanaged");

                if (list.Count == 0) continue;

                generic.Append(" where ").Append(param.GetFullyQualifiedName()).Append(" : ").Append(string.Join(", ", list));
            }

            x.AddSource($"Signature.{y.ContainingType.GetFullyQualifiedNameForFile()}.{methodName}.g.cs", y.ContainingType.NestedClassCompletion($$"""
                internal static nint {{methodName}} { get; private set; }
                """, true));

            // 两个分部声明必须都有unsafe修饰符，所以将unsafe移到方法体内部
            if (y.IsPartialDefinition) x.AddSource($"MethodBody.{y.ContainingType.GetFullyQualifiedNameForFile()}.{methodName}.g.cs", y.ContainingType.NestedClassCompletion($$"""
                {{y.DeclaredAccessibility.GetAccessModifier()}}{{(y.IsStatic ? "static " : "")}}{{(y.IsVirtual ? "virtual " : "")}}partial {{(y.ReturnsVoid ? "void" : returnType!)}} {{y.GetFullyQualifiedName()}}({{string.Join(", ", y.Parameters.Select(x => $"{x.Type.GetFullyQualifiedName()} {x.GetFullyQualifiedName()}"))}}){{generic}}
                {
                #nullable enable
                    unsafe
                    {
                        {{SetJValues(y.Parameters)}}{{(y.ReturnsVoid ? "" : "var result = ")}}{{function}}{{(y.IsStatic
                                ? $"(Env, ClassRef.ObjectRef, {methodName}, @params)"
                                : $"(Env, ObjectRef, {(y.IsVirtual ? "ClassRef.ObjectRef, " : "")}{methodName}, @params)"
                            )}};

                        return{{(y.ReturnsVoid ? "" : (returnType!.StartsWith("global::")
                            ? $" {(check is null ? (returnType + ".From") : check + $".ReturnCheck")}(result)"
                            : (returnType == "string"
                                ? " GetString(result)"
                                : (y.ReturnType.TypeKind == TypeKind.TypeParameter
                                    ? $" {(check is null ? $"{y.ReturnType.Name}.From" : (check + $".ReturnCheck"))}(result)"
                                    : " result"))))}};
                    }
                }
                """, true));

            if (!y.IsStatic) x.AddSource($"ProxyMethodBody.{y.ContainingType.GetFullyQualifiedNameForFile()}.{methodName}.g.cs", y.ContainingType.NestedClassCompletion($$"""
                internal static {{(y.ReturnsVoid ? "void" : returnType!)}} {{y.GetFullyQualifiedName()}}Proxy(nint obj{{string.Join("", y.Parameters.Select(x => $", {x.Type.GetFullyQualifiedName()} {x.GetFullyQualifiedName()}"))}}){{generic}}
                {
                #nullable enable
                    unsafe
                    {
                        {{SetJValues(y.Parameters)}}{{(y.ReturnsVoid ? "" : "var result = ")}}{{function}}{{$"(Env, obj, {(y.IsVirtual ? "ClassRef.ObjectRef, " : "")}{methodName}, @params)"}};

                        return{{(y.ReturnsVoid ? "" : (returnType!.StartsWith("global::")
                            ? $" {(check is null ? (returnType + ".From") : check + $".ReturnCheck")}(result)"
                            : (returnType == "string"
                                ? " GetString(result)"
                                : (y.ReturnType.TypeKind == TypeKind.TypeParameter
                                    ? $" {(check is null ? $"{y.ReturnType.Name}.From" : (check + $".ReturnCheck"))}(result)"
                                    : " result"))))}};
                    }
                }
                """, true));

            if (returnType == "string" && y.ContainingType.Interfaces.Any(x => x.OriginalDefinition.GetFullyQualifiedName() == "global::Mliybs.Minecraft.Fabric.Internals.IWrapper<T>"))
                x.AddSource($"RawMethodBody.{y.ContainingType.GetFullyQualifiedNameForFile()}.{methodName}.g.cs", y.ContainingType.NestedClassCompletion($$"""
                    protected {{(y.IsStatic ? "static " : "")}}nint {{y.GetFullyQualifiedName()}}Raw({{string.Join(", ", y.Parameters.Select(x => $"{x.Type.GetFullyQualifiedName()} {x.GetFullyQualifiedName()}"))}}){{generic}}
                    {
                    #nullable enable
                        unsafe
                        {
                            {{SetJValues(y.Parameters)}}return {{function}}{{(y.IsStatic
                                    ? $"(Env, ClassRef.ObjectRef, {methodName}, @params)"
                                    : $"(Env, ObjectRef, {(y.IsVirtual ? "ClassRef.ObjectRef, " : "")}{methodName}, @params)")}};
                        }
                    }
                    """, true));

            if (useMapping) return $$"""    {{methodName}} = {{(y.IsStatic ? "GetStaticMethodID" : "GetMethodID")}}(ClassRef.ObjectRef, MapMethodName(Names.OriginName, "{{value}}", {{origin}}), {{map}});""";
            else return $$"""    {{methodName}} = {{(y.IsStatic ? "GetStaticMethodID" : "GetMethodID")}}(ClassRef.ObjectRef, "{{value}}", {{map}});""";
        }

        public static string SetJValues(System.Collections.Immutable.ImmutableArray<IParameterSymbol> symbols)
        {
            var builder = new StringBuilder().AppendLine($"JValue* @params = stackalloc JValue[{symbols.Length}];");
            for (var i = 0; i < symbols.Length; i++)
            {
                switch (symbols[i].Type.GetFullyQualifiedName())
                {
                    case "int":
                        builder.AppendLine($"        @params[{i}].i = {SetParam(symbols[i])};");
                        break;

                    case "long":
                        builder.AppendLine($"        @params[{i}].j = {SetParam(symbols[i])};");
                        break;

                    case "bool":
                        builder.AppendLine($"        @params[{i}].z = {SetParam(symbols[i])};");
                        break;

                    case "sbyte":
                        builder.AppendLine($"        @params[{i}].b = {SetParam(symbols[i])};");
                        break;

                    case "byte":
                        builder.AppendLine($"        @params[{i}].b = {SetParam(symbols[i])};");
                        break;

                    case "char":
                        builder.AppendLine($"        @params[{i}].c = {SetParam(symbols[i])};");
                        break;

                    case "short":
                        builder.AppendLine($"        @params[{i}].s = {SetParam(symbols[i])};");
                        break;

                    case "float":
                        builder.AppendLine($"        @params[{i}].f = {SetParam(symbols[i])};");
                        break;

                    case "double":
                        builder.AppendLine($"        @params[{i}].d = {SetParam(symbols[i])};");
                        break;

                    default:
                        builder.AppendLine($"        @params[{i}].l = {SetParam(symbols[i])};");
                        break;
                }
            }
            if (symbols.Length != 0) builder.Append("        ");
            return builder.ToString();
        }

        public static string SetParam(IParameterSymbol x)
        {
            var name = x.Type.GetFullyQualifiedName();
            if (x.Type.TypeKind == TypeKind.Delegate)
            {
                var nestedClass = x.Type.ContainingType.GetFullyQualifiedName();
                return $"Mliybs.Minecraft.Fabric.Wrappers.InvocationHandlerWrapper.GetProxyOf({nestedClass}.ClassRef, {x.GetFullyQualifiedName()})";
            }
            if (name.StartsWith("global::") || x.Type.TypeKind == TypeKind.TypeParameter) return $"{x.GetFullyQualifiedName()}{(x.NullableAnnotation == NullableAnnotation.Annotated ? "?.ObjectRef ?? nint.Zero" : ".ObjectRef")}";
            if (name == "string") return $"NewString({x.GetFullyQualifiedName()})";
            return x.GetFullyQualifiedName();
    }
    }
}
