namespace Mliybs.Minecraft.Fabric.Internals;

public interface IFunctionalInterface<T, K> where T : JavaObject, IFunctionalInterface<T, K>, IClassRef<T>, IFromHandle<T> where K : Delegate
{
    internal static abstract T ToObject(K @delegate);
}

[SuppressJavaClass]
public partial class FunctionalInterface : JavaObject, IFunctionalInterface<FunctionalInterface, Action>, IClassRef<FunctionalInterface>, IFromHandle<FunctionalInterface>
{
    private FunctionalInterface() : base(nint.Zero)
    {
        throw new NotSupportedException();
    }

    internal static Names Names => JavaObject.Names;

    static Class<FunctionalInterface> IClassRef<FunctionalInterface>.ClassRef => Class.Proxy<FunctionalInterface>(JavaObject.ClassRef.ObjectRef);

    static FunctionalInterface IFunctionalInterface<FunctionalInterface, Action>.ToObject(Action @delegate) => throw new NotSupportedException();

    static FunctionalInterface IFromHandle<FunctionalInterface>.From(nint handle) => throw new NotSupportedException();
}