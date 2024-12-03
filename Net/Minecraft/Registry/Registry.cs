namespace Net.Minecraft.Registry;

[JavaInterface(typeof(IRegistry<>))]
public partial class Registry<T> : Java.Lang.Object, IClassRef<Registry<T>>, IFromHandle<Registry<T>>, IRegistry<T>
    where T : Java.Lang.Object, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => Registry.Names;

    public static Class<Registry<Java.Lang.Object>> ClassRef => Registry.ClassRef;

    static Class<Registry<T>> IClassRef<Registry<T>>.ClassRef => new(ClassRef.ObjectRef);
}

[MapName("net/minecraft/class_2378"), StaticGeneric(typeof(Registry<>))]
public static partial class Registry
{
    [Signature("method_10226")]
    public static partial TEntry Register<TRegistry, TEntry>(IRegistry<TRegistry> registry, string id, TEntry entry) where TRegistry : Java.Lang.Object, IClassRef<TRegistry>, IFromHandle<TRegistry> where TEntry : Java.Lang.Object, TRegistry, IClassRef<TEntry>, IFromHandle<TEntry>;
}

[JavaInterface(typeof(Registry<>))]
public partial interface IRegistry<T> : IJavaClass where T : Java.Lang.Object, IClassRef<T>, IFromHandle<T>
{
}
