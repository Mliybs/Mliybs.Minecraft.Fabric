namespace Net.Minecraft.World;

public abstract class World(IntPtr handle) : JavaClass(handle), IClassRef
{
    internal static readonly Names Names = MapClassName("net.minecraft.class_1937");

    public static IntPtr ClassRef { get; } = FindClass(Names.MapSignature);
}