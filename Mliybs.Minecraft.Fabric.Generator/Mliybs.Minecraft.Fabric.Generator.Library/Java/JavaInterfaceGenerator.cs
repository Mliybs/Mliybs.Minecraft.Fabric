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
            var classProvider = context.SyntaxProvider.CreateSyntaxProvider(static (x, _) => x is ClassDeclarationSyntax,
                static (x, _) => (INamedTypeSymbol)x.SemanticModel.GetDeclaredSymbol(x.Node))
                .Where(x => !x.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.JavaInterfaceAttribute"));

            var interfaceProvider = context.SyntaxProvider.CreateSyntaxProvider(static (x, _) => x is InterfaceDeclarationSyntax
            {
                AttributeLists.Count: > 0
            }, static (x, _) => (INamedTypeSymbol)x.SemanticModel.GetDeclaredSymbol(x.Node))
                .Where(x => x.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.JavaInterfaceAttribute"));

            context.RegisterSourceOutput(classProvider, static (x, y) =>
            {
                var name = y.GetFullyQualifiedName();
                
                var strings = string.Join("\n", y.Interfaces.Select(x => x.InterfaceToClass())
                    .Where(x => x is not null)
                    .Select(x => $"public static implicit operator {x.OriginalDefinition.GetFullyQualifiedName()}({name} obj) => new(obj.ObjectRef);\npublic static explicit operator {name}({x.OriginalDefinition.GetFullyQualifiedName()} obj) => IsInstanceOf(obj.ObjectRef, ClassRef.ObjectRef) ? new(obj.ObjectRef) : throw new InvalidCastException();"));
                
                if (strings.Length == 0) return;
                
                x.AddSource($"JavaInterfaceConvert.{y.GetFullyQualifiedNameForFile()}.g.cs", y.NestedClassCompletion($$"""
                    {{strings}}
                    """));
            });

            context.RegisterSourceOutput(interfaceProvider, static (x, y) =>
            {
                var attribute = (INamedTypeSymbol)y.GetAttributes().Single(static x => x.AttributeClass?.GetFullyQualifiedName() == "global::Mliybs.Minecraft.Fabric.JavaInterfaceAttribute").ConstructorArguments[0].Value;
                var name = attribute?.OriginalDefinition.GetFullyQualifiedName();

                if (y.GetMembers().OfType<IPropertySymbol>().FirstOrDefault(x => x.Name == "ClassRef") is not null)
                {
                    x.AddSource($"MapName.{y.GetFullyQualifiedNameForFile()}.g.cs", y.NestedClassCompletion($$"""
                        internal static Names Names { get; } = {{name}}.Names;
                        """, true, "IJavaClass"));
                }

                else
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
