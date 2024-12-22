namespace Net.Minecraft.Registry;

[JavaInterface(typeof(IDefaultedRegistry<>))]
public partial class DefaultedRegistry<T> : Registry<T>, IClassRef<DefaultedRegistry<T>>, IFromHandle<DefaultedRegistry<T>>, IDefaultedRegistry<T>
    where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => DefaultedRegistry.Names;

    public static Class<DefaultedRegistry<JavaObject>> ClassRef => DefaultedRegistry.ClassRef;

    static Class<DefaultedRegistry<T>> IClassRef<DefaultedRegistry<T>>.ClassRef => Class.Proxy<DefaultedRegistry<T>>(ClassRef.ObjectRef);
}

[MapName("net/minecraft/class_7922"), StaticGeneric(typeof(DefaultedRegistry<>))]
public static partial class DefaultedRegistry
{
}

[JavaInterface(typeof(DefaultedRegistry<>))]
public partial interface IDefaultedRegistry<T> : IRegistry<T> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{}
