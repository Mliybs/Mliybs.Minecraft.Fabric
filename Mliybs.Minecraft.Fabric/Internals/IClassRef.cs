namespace Mliybs.Minecraft.Fabric.Internals;

public interface IClassRef<T> where T : Java.Lang.Object, IClassRef<T>
{
    static abstract Class<T> ClassRef { get; }
}