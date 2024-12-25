using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mliybs.Minecraft.Fabric.Generator.Wrappers
{
    [Generator]
    public class ItemWrapperGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            var @class = context.SyntaxProvider.CreateSyntaxProvider(static (x, _) => x is ClassDeclarationSyntax,
                static (x, _) => (INamedTypeSymbol)x.SemanticModel.GetDeclaredSymbol(x.Node))
                .Where(x => x.BaseType?.Interfaces.Any(x => x.OriginalDefinition.HasFullyQualifiedName("global::Mliybs.Minecraft.Fabric.Internals.IWrapper<T>")) == true)
                .Collect();

            context.RegisterSourceOutput(@class, static (x, y) =>
            {
                foreach (var @class in y.Distinct<INamedTypeSymbol>(SymbolEqualityComparer.Default))
                {
                    GenerateWrapper(x, @class);
                }
            });
        }

        static void GenerateWrapper(SourceProductionContext x, INamedTypeSymbol y)
        {
            var overriddens = y.GetMembers()
                .OfType<IMethodSymbol>()
                .Where(x => x.IsOverride)
                .Select(x =>
                {
                    var span = x.GetFullyQualifiedName().AsSpan();
                    if (x.OverriddenMethod.GetAttributes().FirstOrDefault(x => x.AttributeClass.HasFullyQualifiedName("global::Mliybs.Minecraft.Fabric.HandlerAttribute")) is not null and AttributeData data)
                        return ((string)data.ConstructorArguments[0].Value).AsSpan().Slice(0, span.Length - 8).ToString();
                    if (span.EndsWith("Handler".AsSpan())) return span.Slice(0, span.Length - 7).ToString();
                    return span.ToString();
                })
                .Distinct(StringComparer.Ordinal)
                .Select(x => $"{x}Delegate _{x} = {x}Handler;\n    wrapper.{x} = System.Runtime.InteropServices.Marshal.GetFunctionPointerForDelegate<{x}Delegate>(_{x});\n    keepAlive.Add(_{x});");

            var name = y.GetFullyQualifiedName();
            
            x.AddSource($"Wrapper.{y.GetFullyQualifiedNameForFile()}.g.cs", y.NestedClassCompletion($$"""
                static (string OriginName, string OriginSignature, string MapName, string MapSignature) Names => WrapperNames;
                
                static global::Java.Lang.Class<{{name}}> global::Mliybs.Minecraft.Fabric.Internals.IClassRef<{{name}}>.ClassRef => global::Java.Lang.Class.Proxy<{{name}}>(global::Mliybs.Minecraft.Fabric.Loader.GetObjectRef(WrapperClassRef));
                
                protected override bool TryGetWrapper(out Wrapper wrapper)
                {
                    var keepAlive = new System.Collections.Concurrent.ConcurrentBag<Delegate>();
                    wrapper = new Wrapper();
                    {{string.Join("\n    ", overriddens)}}
                    wrapper.Id = Add(keepAlive);
                    return true;
                }
                """, false, $"global::Mliybs.Minecraft.Fabric.Internals.IClassRef<{name}>, global::Mliybs.Minecraft.Fabric.Internals.IFromHandle<{name}>"));
        }
    }
}
