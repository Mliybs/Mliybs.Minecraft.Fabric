using Net.Minecraft.Registry.Entry;

namespace Net.Minecraft.World.Biome.Source;

[MapName("net/minecraft/class_4543")]
public partial class BiomeAccess : JavaObject, IClassRef<BiomeAccess>, IFromHandle<BiomeAccess>
{
    [MapName("class_4544"), JavaInterface(typeof(IStorage))]
    public partial class Storage : JavaObject, IClassRef<Storage>, IFromHandle<Storage>
    {
        [Signature("method_16359")]
        public partial RegistryEntry<Biome> GetBiomeForNoiseGen(int biomeX, int biomeY, int biomeZ);
    }

    [JavaInterface(typeof(Storage))]
    public partial interface IStorage
    {
        RegistryEntry<Biome> GetBiomeForNoiseGen(int biomeX, int biomeY, int biomeZ);
    }
}
