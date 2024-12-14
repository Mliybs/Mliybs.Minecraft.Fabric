using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mliybs.Minecraft.Fabric.Generator.Java
{
    [Generator]
    public class JavaInterfaceGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            var provider = context.SyntaxProvider.CreateSyntaxProvider(static (x, _) => x is ClassDeclarationSyntax
            {
                AttributeLists.Count: > 0
            } or InterfaceDeclarationSyntax
            {
                AttributeLists.Count: > 0
            }, static (x, _) => (INamedTypeSymbol)x.SemanticModel.GetDeclaredSymbol(x.Node))
                .Where(x => x.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.JavaInterfaceAttribute"));

            context.RegisterSourceOutput(provider, static (x, y) =>
            {
                var attribute = (INamedTypeSymbol)y.GetAttributes().Single(static x => x.AttributeClass?.GetFullyQualifiedName() == "global::Mliybs.Minecraft.Fabric.JavaInterfaceAttribute").ConstructorArguments[0].Value;
                var name = attribute?.OriginalDefinition.GetFullyQualifiedName();

                if (y.TypeKind == TypeKind.Interface)
                {
                    x.AddSource($"JavaInterface.{y.GetFullyQualifiedNameForFile()}.g.cs", y.NestedClassCompletion($$"""
                        internal static Names Names => {{name}}.Names;

                        public static Class<{{(y.TypeParameters.Length == 0 ? name : System.Text.RegularExpressions.Regex.Replace(name, "(?<=(<|, )).*?(?=(>|, ))", "Java.Lang.Object"))}}> ClassRef => {{name}}.ClassRef;
                        """, true, "IJavaClass"));
                }
            });
        }
    }
}
