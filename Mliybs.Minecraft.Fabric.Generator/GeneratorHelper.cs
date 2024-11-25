using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Mliybs.Minecraft.Fabric.Generator
{
    public static class GeneratorHelper
    {
        private static readonly SymbolDisplayFormat format =
        SymbolDisplayFormat.FullyQualifiedFormat.WithMiscellaneousOptions(
            SymbolDisplayFormat.FullyQualifiedFormat.MiscellaneousOptions |
            SymbolDisplayMiscellaneousOptions.IncludeNullableReferenceTypeModifier);

        /// <summary>
        /// 返回带global::前缀的全名
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        public static string GetFullyQualifiedName(this ISymbol symbol) => symbol.ToDisplayString(format);

        public static bool HasFullyQualifiedName(this ISymbol symbol, string name) => symbol.ToDisplayString(format) == name;

        /// <summary>
        /// 输入带global::前缀的特性全名判断是否拥有该特性
        /// </summary>
        /// <param name="symbol"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool HasAttributeWithFullyQualifiedName(this ISymbol symbol, string name)
        {
            foreach (var item in symbol.GetAttributes())
                if (item.AttributeClass?.HasFullyQualifiedName(name) == true)
                    return true;

            return false;
        }

        public static bool HasBaseWithFullyQualifiedName(this ITypeSymbol type, string name)
        {
            type = type.BaseType;

            while (type is not null)
            {
                if (type.HasFullyQualifiedName(name)) return true;
                type = type.BaseType;
            }

            return false;
        }

        public static string GetQualifiedName(this ISymbol symbol)
        {
            var name = symbol.GetFullyQualifiedName();
            var span = name.AsSpan();
            var index = span.IndexOf('<');
            if (index == -1) return span.Slice(name.LastIndexOf('.') + 1).ToString();
            return span.Slice(span.Slice(0, index).LastIndexOf('.') + 1).ToString();
        }

        public static string GetFullyQualifiedNameForFile(this ISymbol symbol)
        {
            var name = Regex.Replace(symbol.GetFullyQualifiedName(), "<.+?>", "_T");
            return name.Substring(8);
        }

#nullable enable
        public static string NestedClassCompletion(this ITypeSymbol type, string content, bool? onlyUseInLibrary = null, string? implements = null)
        {
            var builder = new StringBuilder().AppendLine("// <auto-generated />");

            if (onlyUseInLibrary.HasValue)
                if (onlyUseInLibrary.Value) builder.AppendLine("#if FABRIC_LIBRARY");
                else builder.AppendLine("#if !FABRIC_LIBRARY");

            builder.AppendLine($$"""
                using System;

                namespace {{type.ContainingNamespace}}
                {
                """);

            var list = new List<ITypeSymbol>();

            while (type is not null)
            {
                list.Add(type);
                type = type.ContainingType;
            }

            // 反向遍历
            for (int i = list.Count - 1; i >= 0; i--)
            {
                builder.Append(' ', 4 * (list.Count - i));
                builder.Append($"partial {(list[i].TypeKind == TypeKind.Interface ? "interface" : "class")} ");
                if (implements is null) builder.AppendLine(list[i].GetQualifiedName());
                else
                {
                    builder.Append(list[i].GetQualifiedName());
                    builder.Append(" : ");
                    builder.AppendLine(implements);
                }
                builder.Append(' ', 4 * (list.Count - i));
                builder.AppendLine("{");
            }

            var tabs = '\n' + new string(' ', 4 * (list.Count + 1));

            builder.Append(' ', 4 * (list.Count + 1));
            builder.AppendLine(content.Replace("\n", tabs));

            for (int i = 0; i < list.Count; i++)
            {
                builder.Append(' ', 4 * (list.Count - i));
                builder.AppendLine("}");
            }

            builder.Append('}');

            if (onlyUseInLibrary.HasValue) builder.AppendLine("\n#endif");

            return builder.ToString();
        }

        public static string GetAccessModifier(this Accessibility accessibility) => accessibility switch
        {
            // Friend即为Internal
            Accessibility.NotApplicable => "",
            Accessibility.Private => "private ",
            Accessibility.Protected => "protected ",
            Accessibility.ProtectedAndInternal => "private internal ",
            Accessibility.Internal => "internal ",
            Accessibility.ProtectedOrInternal => "protected internal ",
            Accessibility.Public => "public ",
            _ => ""
        };
    }
}
