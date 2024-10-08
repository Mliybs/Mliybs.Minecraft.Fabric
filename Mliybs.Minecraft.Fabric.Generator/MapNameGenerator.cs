using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mliybs.Minecraft.Fabric.Generator
{
    [Generator]
    public class MapNameGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            var provider = context.SyntaxProvider.CreateSyntaxProvider(static (x, _) => x is ClassDeclarationSyntax
            {
                AttributeLists.Count: > 0
            }, static (x, _) => (INamedTypeSymbol)x.SemanticModel.GetDeclaredSymbol(x.Node))
                .Where(x => x.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.MapNameAttribute") && x.HasBaseWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.Internals.JavaClass"))
                .Collect();

            context.RegisterSourceOutput(provider, static (x, y) =>
            {
                foreach (var @class in y.Distinct<INamedTypeSymbol>(SymbolEqualityComparer.Default))
                {
                    var list = new List<string>();

                    var type = @class;

                    while (type is not null)
                    {
                        list.Add(type.GetAttributes()
                        .Where(x => x.AttributeClass.HasFullyQualifiedName("global::Mliybs.Minecraft.Fabric.MapNameAttribute")
                            && x.ConstructorArguments.Length > 0)
                        .Select(x => (string)x.ConstructorArguments[0].Value)
                        .Single());

                        type = type.ContainingType;
                    }

                    var name = string.Join("$", list.Reverse<string>()).Replace('/', '.');

                    x.AddSource($"MapName.{@class.GetFullyQualifiedNameForFile()}.g.cs", @class.NestedClassCompletion($$"""
                        internal static Names Names { get; } = MapClassName("{{name}}");

                        public static nint ClassRef { get; } = FindClass(Names.MapSignature);
                        """, true));
                }
            });
        }
    }
}
