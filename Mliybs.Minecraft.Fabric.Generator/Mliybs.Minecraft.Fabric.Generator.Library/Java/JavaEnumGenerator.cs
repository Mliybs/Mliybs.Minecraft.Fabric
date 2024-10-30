using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mliybs.Minecraft.Fabric.Generator.Java
{
    [Generator]
    public class JavaEnumGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            var provider = context.SyntaxProvider.CreateSyntaxProvider(static (x, _) => x is ClassDeclarationSyntax,
                static (x, _) => (INamedTypeSymbol)x.SemanticModel.GetDeclaredSymbol(x.Node))
                .Collect();

            context.RegisterSourceOutput(provider, static (x, y) =>
            {
                foreach (var @class in y.AsParallel().Distinct<INamedTypeSymbol>(SymbolEqualityComparer.Default))
                {
#nullable enable
                    var text = string.Join("\n", @class.GetMembers().OfType<IPropertySymbol>()
                        .Where(x => x.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.JavaEnumAttribute"))
                        .Select(x => $$"""    {{x.Name}} = ValueOf("{{x.GetAttributes()
                            .Where(x => x.AttributeClass.HasFullyQualifiedName("global::Mliybs.Minecraft.Fabric.JavaEnumAttribute"))
                            .Select(x => (string?)x.ConstructorArguments[0].Value)
                            .Single() ?? x.Name.ToUpper()}}");"""));

                    if (!string.IsNullOrWhiteSpace(text))
                        x.AddSource($"JavaEnum.{@class.GetFullyQualifiedNameForFile()}.g.cs", @class.NestedClassCompletion($$"""
                            private static void JavaEnumInitialize()
                            {
                            {{text}}
                            }
                            """, true));
                }
            });
        }
    }
}
