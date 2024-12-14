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
                .Where(x => x.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.MapNameAttribute") && (x.IsStatic || x.HasBaseWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.Internals.JavaClass")));

            context.RegisterSourceOutput(provider, static (x, y) =>
            {
                    var list = new List<string>();

                    var useMapping = true;

                    var type = y;

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

                    var attribute = y.GetAttributes().FirstOrDefault(static x => x.AttributeClass?.GetFullyQualifiedName() == "global::Mliybs.Minecraft.Fabric.StaticGenericAttribute")?.ConstructorArguments[0].Value as INamedTypeSymbol;

                    var typeName = System.Text.RegularExpressions.Regex.Replace(attribute?.OriginalDefinition.GetFullyQualifiedName() ?? y.GetFullyQualifiedName(), "(?<=(<|, )).*?(?=(>|, ))", "Java.Lang.Object");

                    x.AddSource($"MapName.{y.GetFullyQualifiedNameForFile()}.g.cs", y.NestedClassCompletion($$"""
                        internal static Names Names { get; } = {{(useMapping ? $"MapClassName(\"{name}\")" : $"(\"{name}\", \"{name.Replace('.', '/')}\", \"{name}\", \"{name.Replace('.', '/')}\")")}};

                        public static Class<{{typeName}}> ClassRef { get; } = FindClass<{{typeName}}>(Names.MapSignature);
                        """, true));
            });
        }
    }
}
