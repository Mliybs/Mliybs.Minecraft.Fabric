namespace Net.Minecraft.Registry.Entry;

[JavaInterface(typeof(IRegistryEntry<>))]
public partial class RegistryEntry<T> : JavaObject, IClassRef<RegistryEntry<T>>, IFromHandle<RegistryEntry<T>> where T  : JavaObject, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => RegistryEntry.Names;

    public static Class<RegistryEntry<JavaObject>> ClassRef => RegistryEntry.ClassRef;

    static Class<RegistryEntry<T>> IClassRef<RegistryEntry<T>>.ClassRef => Class.Proxy<RegistryEntry<T>>(ClassRef.ObjectRef);
}

[MapName("net/minecraft/class_6880"), StaticGeneric(typeof(RegistryEntry<>))]
public static partial class RegistryEntry
{}

[JavaInterface(typeof(RegistryEntry<>))]
public partial interface IRegistryEntry<T> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{}
