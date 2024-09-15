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
            context.RegisterPostInitializationOutput(x =>
            {
                x.AddSource("MapNameAttribute.g.cs", """
                    #if FABRIC_LIBRARY
                    using System;
                
                    namespace Mliybs.Minecraft.Fabric
                    {
                        [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
                        public sealed class MapNameAttribute : Attribute
                        {
                            public string Value { get; }
                
                            public MapNameAttribute(string value)
                            {
                                Value = value;
                            }
                        }
                    }
                    #endif
                    """);
            });

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

                    x.AddSource($"MapName.{@class.MetadataName.Replace('`', '_')}.g.cs", @class.NestedClassCompletion($$"""
                        internal static readonly Names Names = MapClassName("{{name}}");

                        public static nint ClassRef { get; } = FindClass(Names.MapSignature);
                        """, true));
                }
            });
        }
    }
}
