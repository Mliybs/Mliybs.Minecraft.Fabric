namespace Mliybs.Minecraft.Fabric.Internals;

public sealed partial class InternalClass : JavaObject, IClassRef<InternalClass>, IFromHandle<InternalClass>
{
    public static Class<InternalClass> ClassRef
    {
        get => throw new NotSupportedException();
    }
}
