using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Concurrent;
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
                .Where(x => x.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.MapNameAttribute") && (x.IsStatic || x.HasBaseWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.Internals.JavaClass")))
                .Collect();

            context.RegisterSourceOutput(provider, static (x, y) =>
            {
                var bag = new ConcurrentBag<(string, string)>();
                y.AsParallel().Distinct<INamedTypeSymbol>(SymbolEqualityComparer.Default).ForAll(@class =>
                {
                    var list = new List<string>();

                    var useMapping = true;

                    var type = @class;

                    while (type is not null)
                    {
                        list.Add(type.GetAttributes()
                        .Where(x => x.AttributeClass.HasFullyQualifiedName("global::Mliybs.Minecraft.Fabric.MapNameAttribute")
                            && x.ConstructorArguments.Length > 0)
                        .Select(x =>
                        {
                            useMapping = (bool)x.ConstructorArguments[1].Value;
                            return (string)x.ConstructorArguments[0].Value;
                        })
                        .Single());

                        type = type.ContainingType;
                    }

                    var name = string.Join("$", list.Reverse<string>()).Replace('/', '.');

                    bag.Add(($"MapName.{@class.GetFullyQualifiedNameForFile()}.g.cs", @class.NestedClassCompletion($$"""
                        internal static Names Names { get; } = {{(useMapping ? $"MapClassName(\"{name}\")" : $"(\"{name}\", \"{name.Replace('.', '/')}\", \"{name}\", \"{name.Replace('.', '/')}\")")}};

                        public static Class ClassRef { get; } = FindClass(Names.MapSignature);
                        """, true)));
                });

                for (var hasNext = bag.TryTake(out var tuple); hasNext; hasNext = bag.TryTake(out tuple))
                    x.AddSource(tuple.Item1, tuple.Item2);
            });
        }
    }
}
