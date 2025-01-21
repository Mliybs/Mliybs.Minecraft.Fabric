namespace Net.Minecraft.World;

[MapName("net/minecraft/class_2902")]
public partial class Heightmap : JavaObject, IClassRef<Heightmap>, IFromHandle<Heightmap>
{
    [MapName("class_2903")]
    public partial class Type : Enum<Type>, IClassRef<Type>, IFromHandle<Type>
    {
        [Signature("field_13194")]
        public static Heightmap.Type WORLD_SURFACE_WG { get; private set; }

        [Signature("field_13202")]
        public static Heightmap.Type WORLD_SURFACE { get; private set; }

        [Signature("field_13195")]
        public static Heightmap.Type OCEAN_FLOOR_WG { get; private set; }

        [Signature("field_13200")]
        public static Heightmap.Type OCEAN_FLOOR { get; private set; }

        [Signature("field_13197")]
        public static Heightmap.Type MOTION_BLOCKING { get; private set; }

        [Signature("field_13203")]
        public static Heightmap.Type MOTION_BLOCKING_NO_LEAVES { get; private set; }
    }
}
