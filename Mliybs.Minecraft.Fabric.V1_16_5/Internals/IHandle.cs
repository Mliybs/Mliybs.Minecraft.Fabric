namespace Mliybs.Minecraft.Fabric.V1_16_5.Internals;

public interface IHandle
{
    IntPtr Handle { get; }
}

public interface IHandle<T> : IHandle
{

}

internal class DefaultHandle(IntPtr handle) : IHandle
{
    public IntPtr Handle => handle;
}

internal class DefaultHandle<T>(IntPtr handle) : DefaultHandle(handle), IHandle<T>
{
}