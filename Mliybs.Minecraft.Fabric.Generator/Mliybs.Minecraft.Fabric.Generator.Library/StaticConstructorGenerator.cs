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
                , static (x, _) => (INamedTypeSymbol)x.SemanticModel.GetDeclaredSymbol(x.Node));

            context.RegisterSourceOutput(provider, static (x, y) =>
            {
                var init = Initializer.None;
                var builder = new StringBuilder();
                var generic = (y.GetAttributes().SingleOrDefault(x => x.AttributeClass!.HasFullyQualifiedName("global::Mliybs.Minecraft.Fabric.StaticGenericAttribute"))?.ConstructorArguments[0].Value as INamedTypeSymbol)?.OriginalDefinition;

                foreach (var member in y.GetMembers())
                {
                    if (!init.HasFlag(Initializer.Signature) && member.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.SignatureAttribute"))
                    {
                        if (y.IsStatic) builder.Append("\n    StaticSignatureInitialize();");
                        else builder.Append("\n    SignatureInitialize();");
                        init |= Initializer.Signature;
                    }

                    if (member is IMethodSymbol && member.IsStatic && member.Name.EndsWith("Initialize"))
                    {
                        builder.Append($"\n    {member.Name}();");
                    }
                }
                
                if (generic is not null)
                    foreach (var member in generic.GetMembers())
                    {
                        if (!init.HasFlag(Initializer.Signature) && member.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.SignatureAttribute"))
                        {
                            builder.Append("\n    SignatureInitialize();");
                            init |= Initializer.Signature;
                        }

                        if (!init.HasFlag(Initializer.JavaConstructor) && member.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.JavaConstructorAttribute"))
                        {
                            builder.Append("\n    JavaConstructorInitialize();");
                            init |= Initializer.JavaConstructor;
                        }

                        if (member is IMethodSymbol && member.IsStatic && member.Name.EndsWith("Initialize"))
                        {
                            builder.Append($"\n    {member.Name}();");
                        }
                    }

                if (init != Initializer.None && ((!y.IsStatic && y.TypeParameters.IsEmpty) || generic is not null))
                    x.AddSource($"StaticConstructor.{y.GetFullyQualifiedNameForFile()}.g.cs", y.NestedClassCompletion($$"""
                        static {{y.Name}}()
                        {{{builder}}
                        }
                        """, true, removeClassGeneric: true));
            });
        }

        enum Initializer
        {
            None = 0,
            Signature = 0b1,
            JavaConstructor = 0b10
        }
    }
}