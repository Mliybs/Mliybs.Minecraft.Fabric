namespace Mliybs.Minecraft.Fabric.Internals;

public interface IClassRef<T> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    static abstract Class<T> ClassRef { get; }
}