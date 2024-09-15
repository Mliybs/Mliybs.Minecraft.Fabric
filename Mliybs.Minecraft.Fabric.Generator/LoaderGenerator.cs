using Microsoft.CodeAnalysis;
using System.Linq;

namespace Mliybs.Minecraft.Fabric.Generator
{
    [Generator]
    public class LoaderGenerator : IIncrementalGenerator
    {
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            context.RegisterPostInitializationOutput(x => x.AddSource("FabricLoader.g.cs", """
                #if !FABRIC_LIBRARY
                using System;
                using System.Runtime.InteropServices;
                using System.Runtime.CompilerServices;

                namespace Mliybs.Minecraft.Fabric
                {
                    public static class FabricLoader
                    {
                        [UnmanagedCallersOnly(EntryPoint = nameof(Load))]
                        private static void Load(nint env, nint resolver)
                        {
                            [UnsafeAccessor(UnsafeAccessorKind.StaticMethod, Name = nameof(Load))]
                            static extern void Loader_Load(UnsafeAccessorLoader @this, nint env, nint resolver);

                            Loader_Load(null!, env, resolver);
                        }
                    }
                }
                #endif
                """));
        }
    }
}
