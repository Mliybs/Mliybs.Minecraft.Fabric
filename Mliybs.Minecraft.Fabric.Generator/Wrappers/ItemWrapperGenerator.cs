using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mliybs.Minecraft.Fabric.Generator.Wrappers
{
    [Generator]
    public class ItemWrapperGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            var @class = context.SyntaxProvider.CreateSyntaxProvider(static (x, _) => x is ClassDeclarationSyntax,
                static (x, _) => (INamedTypeSymbol)x.SemanticModel.GetDeclaredSymbol(x.Node))
                .Where(x => x.HasBaseWithFullyQualifiedName("global::Net.Minecraft.Item.Item"))
                .Collect();

            context.RegisterSourceOutput(@class, static (x, y) =>
            {
                foreach (var @class in y.Distinct<INamedTypeSymbol>(SymbolEqualityComparer.Default))
                {
                    GenerateItemWrapper(x, @class);
                }
            });
        }

        static void GenerateItemWrapper(SourceProductionContext x, INamedTypeSymbol y)
        {
            var overriddens = y.GetMembers()
                .OfType<IMethodSymbol>()
                .Distinct<IMethodSymbol>(SymbolEqualityComparer.Default)
                .Where(x => x.IsOverride)
                .Select(x =>
                {
                    var name = x.GetFullyQualifiedName();
                    if (name.EndsWith("Handler")) return name;
                    if (x.OverriddenMethod!.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.SignatureAttribute")) return name + "Handler";
                    return null;
                })
                .Where(x => x is not null)
                .Distinct(StringComparer.Ordinal)
                .Select(x => $"{x} = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate<{x}Delegate>({x})");

            x.AddSource($"ItemWrapper.{y.GetFullyQualifiedNameForFile()}.g.cs", y.NestedClassCompletion($$"""
                protected override bool TryGetWrapper(out ItemWrapper wrapper)
                {
                    wrapper = new ItemWrapper()
                    {
                        {{string.Join(",\n        ", overriddens)}}
                    };
                    return true;
                }
                """, false, $"Mliybs.Minecraft.Fabric.Internals.IFromHandle<{y.GetQualifiedName()}>"));
        }
    }
}
