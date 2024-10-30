namespace Mliybs.Minecraft.Fabric.Internals;

public interface IHandle
{
    nint Handle { get; }
}

public interface IHandle<T> : IHandle
{

}

internal class DefaultHandle(nint handle) : IHandle
{
    public nint Handle => handle;
}

internal class DefaultHandle<T>(nint handle) : DefaultHandle(handle), IHandle<T>
{
}