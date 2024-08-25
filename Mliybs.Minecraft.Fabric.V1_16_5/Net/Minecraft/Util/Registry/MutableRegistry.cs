namespace Net.Minecraft.Util.Registry;

public abstract class MutableRegistry<T> : Registry<T> where T : JavaClass, IClassRef
{
    internal new static readonly Names Names = MapClassName("net.minecraft.class_2385");

    public new static IntPtr ClassRef { get; } = FindClass(Names.MapSignature);

    public MutableRegistry() {}

    public MutableRegistry(IntPtr handle) : base(handle) {}
}