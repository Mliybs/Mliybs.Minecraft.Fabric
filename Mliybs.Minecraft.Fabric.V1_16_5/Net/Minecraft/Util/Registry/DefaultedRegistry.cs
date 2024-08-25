namespace Net.Minecraft.Util.Registry;

public class DefaultedRegistry<T> : SimpleRegistry<T> where T : JavaClass, IClassRef
{
    internal new static readonly Names Names = MapClassName("net.minecraft.class_2348");
    
    public new static IntPtr ClassRef { get; } = FindClass(Names.MapSignature);

    public DefaultedRegistry() {}

    public DefaultedRegistry(IntPtr handle) : base(handle) {}
}

public sealed class DefaultedRegistry : DefaultedRegistry<InternalClass>
{
    private DefaultedRegistry() => throw new NotSupportedException();
}