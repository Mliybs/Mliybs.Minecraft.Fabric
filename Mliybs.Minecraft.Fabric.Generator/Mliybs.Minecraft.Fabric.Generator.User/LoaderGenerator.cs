using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq;

namespace Mliybs.Minecraft.Fabric.Generator
{
    [Generator]
    public class LoaderGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            var provider = context.SyntaxProvider.CreateSyntaxProvider(static (x, _) => x is MethodDeclarationSyntax
            {
                AttributeLists.Count: > 0
            }, static (x, _) => (IMethodSymbol)x.SemanticModel.GetDeclaredSymbol(x.Node))
                .Where(x => x.HasAttributeWithFullyQualifiedName("global::Mliybs.Minecraft.Fabric.FabricModAttribute"))
                .Collect();
            
            context.RegisterSourceOutput(provider, static (x, y) =>
            {
                foreach (var item in y)
                {
                    x.AddSource("FabricLoader.g.cs", $$"""
                    #if !FABRIC_LIBRARY
                    using System;
                    using System.Runtime.InteropServices;
                    using System.Runtime.CompilerServices;
                    
                    namespace Mliybs.Minecraft.Fabric
                    {
                        public static class FabricLoader
                        {
                            [UnmanagedCallersOnly(EntryPoint = nameof(Load))]
                            private static void Load(nint env, nint resolver, nint logger)
                            {
                                [UnsafeAccessor(UnsafeAccessorKind.StaticMethod, Name = nameof(Load))]
                                static extern void Loader_Load(UnsafeAccessorLoader @this, nint env, nint resolver, nint logger);
                    
                                Loader_Load(null!, env, resolver, logger);

                                {{item.ContainingType.GetFullyQualifiedName()}}.{{item.GetFullyQualifiedName()}}();
                            }
                        }
                    }
                    #endif
                    """);

                    return;
                }
            });
        }
    }
}
