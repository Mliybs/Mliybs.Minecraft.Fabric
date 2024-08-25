namespace Mliybs.Minecraft.Fabric.V1_16_5.Internals;

public sealed class InternalClass : JavaClass, IClassRef
{
    public static IntPtr ClassRef
    {
        get => throw new NotSupportedException();
    }

    private InternalClass() => throw new NotSupportedException();
}