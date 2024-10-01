namespace Mliybs.Minecraft.Fabric.Internals;

public sealed partial class InternalClass : JavaClass, IClassRef, IFromHandle<InternalClass>
{
    public static nint ClassRef
    {
        get => throw new NotSupportedException();
    }
}