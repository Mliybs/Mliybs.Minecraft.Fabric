using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Mliybs.Minecraft.Fabric.Generator.Java
{
    [Generator]
    public class JavaClassGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            var classProvider = context.SyntaxProvider.CreateSyntaxProvider(static (x, _) => x is ClassDeclarationSyntax,
                static (x, _) => (INamedTypeSymbol)x.SemanticModel.GetDeclaredSymbol(x.Node))
                .Where(x => x.HasBaseWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.Internals.JavaClass")
                    && !x.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.SuppressJavaClassAttribute"))
                .Collect();

            context.RegisterSourceOutput(classProvider, static (x, y) =>
            {
                foreach (var @class in y.Distinct<INamedTypeSymbol>(SymbolEqualityComparer.Default))
                {
                    x.AddSource($"JavaClass.{@class.GetFullyQualifiedNameForFile()}.g.cs", @class.NestedClassCompletion($$"""
                        protected {{@class.Name}}(nint handle) : base(handle) {}

                        #pragma warning disable CS0108
                        public static {{@class.GetQualifiedName()}} From(nint handle)
                        {
                            return new(handle);
                        }
                        #pragma warning restore CS0108
                        """));
                }
            });  
        }
    }
}
