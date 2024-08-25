namespace Net.Minecraft.Util.Registry;

public class SimpleRegistry<T> : MutableRegistry<T> where T : JavaClass, IClassRef
{
    internal new static readonly Names Names = MapClassName("net.minecraft.class_2370");

    public new static IntPtr ClassRef { get; } = FindClass(Names.MapSignature);

    public SimpleRegistry() {}

    public SimpleRegistry(IntPtr handle) : base(handle) {}
}