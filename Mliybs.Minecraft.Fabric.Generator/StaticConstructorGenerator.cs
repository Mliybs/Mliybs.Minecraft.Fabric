using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mliybs.Minecraft.Fabric.Generator
{
    [Generator]
    public class StaticConstructorGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            var provider = context.SyntaxProvider.CreateSyntaxProvider(static (x, _) => x is ClassDeclarationSyntax
                , static (x, _) => (INamedTypeSymbol)x.SemanticModel.GetDeclaredSymbol(x.Node))
                .Collect();

            context.RegisterSourceOutput(provider, static (x, y) =>
            {
                foreach (var @class in y.Distinct<INamedTypeSymbol>(SymbolEqualityComparer.Default))
                {
                    var hasAttribute = false;
                    var builder = new StringBuilder();

                    if (@class.GetMembers().Any(x => x.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.SignatureAttribute")))
                    {
                        builder.Append("\n    SignatureInitialize();");
                        hasAttribute = true;
                    }

                    if (@class.GetMembers().Any(x => x.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.JavaEnumAttribute")))
                    {
                        builder.Append("\n    JavaEnumInitialize();");
                        hasAttribute = true;
                    }

                    if (@class.GetMembers().Any(x => x.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.JavaConstructorAttribute")))
                    {
                        builder.Append("\n    JavaConstructorInitialize();");
                        hasAttribute = true;
                    }

                    foreach (var method in @class.GetMembers().OfType<IMethodSymbol>().Where(x => x.Name.EndsWith("Initialize")))
                        builder.Append($"\n    {method.Name}();");

                    if (hasAttribute)
                        x.AddSource($"StaticConstructor.{@class.GetFullyQualifiedNameForFile()}.g.cs", @class.NestedClassCompletion($$"""
                            static {{@class.Name}}()
                            {{{builder}}
                            }
                            """, true));
                }
            });
        }
    }
}
