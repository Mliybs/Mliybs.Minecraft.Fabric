using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace Mliybs.Minecraft.Fabric.Generator
{
    internal static class GeneratorHelper
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
    }
}
