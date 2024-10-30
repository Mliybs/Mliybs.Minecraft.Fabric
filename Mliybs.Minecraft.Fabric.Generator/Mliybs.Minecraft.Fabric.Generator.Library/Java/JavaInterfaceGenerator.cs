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
                .Where(x => x.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.JavaInterfaceAttribute"))
                .Collect();

            var classes = context.SyntaxProvider.CreateSyntaxProvider(static (x, _) => x is ClassDeclarationSyntax
            {
                AttributeLists.Count: > 0
            }, static (x, _) => (INamedTypeSymbol)x.SemanticModel.GetDeclaredSymbol(x.Node))
                .Where(x => !x.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.JavaInterfaceAttribute") && x.Interfaces.Any(x => x.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.JavaInterfaceAttribute")))
                .Collect();

            context.RegisterSourceOutput(provider, static (x, y) =>
            {
                foreach (var item in y.AsParallel().Distinct<INamedTypeSymbol>(SymbolEqualityComparer.Default))
                {
                    var attribute = (INamedTypeSymbol)item.GetAttributes().Single(static x => x.AttributeClass?.GetFullyQualifiedName() == "global::Mliybs.Minecraft.Fabric.JavaInterfaceAttribute").ConstructorArguments[0].Value;
                    var name = attribute?.OriginalDefinition.GetFullyQualifiedName();

                    if (item.TypeKind == TypeKind.Interface)
                    {
                        x.AddSource($"JavaInterface.{item.GetFullyQualifiedNameForFile()}.g.cs", item.NestedClassCompletion($$"""
                            internal static Names Names => {{name}}.Names;

                            public static Class ClassRef => {{name}}.ClassRef;
                            """));
                    }
                }
            });

            context.RegisterSourceOutput(classes, static (x, y) =>
            {
                foreach (var item in y.AsParallel().Distinct<INamedTypeSymbol>(SymbolEqualityComparer.Default))
                {
                    var attribute = (INamedTypeSymbol)item.Interfaces.Single(x => x.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.JavaInterfaceAttribute")).GetAttributes().Single(static x => x.AttributeClass?.GetFullyQualifiedName() == "global::Mliybs.Minecraft.Fabric.JavaInterfaceAttribute").ConstructorArguments[0].Value;
                    var name = attribute?.OriginalDefinition.GetFullyQualifiedName();

                    x.AddSource($"JavaInterfaceCast.{item.GetFullyQualifiedNameForFile()}.g.cs", item.NestedClassCompletion($$"""
                        public static implicit operator {{name}}({{item.GetFullyQualifiedName()}} item) => new(item.ObjectRef);

                        public static explicit operator {{item.GetFullyQualifiedName()}}({{name}} item) => item.To<{{item}}>();
                        """, true));
                }
            });
        }
    }
}
