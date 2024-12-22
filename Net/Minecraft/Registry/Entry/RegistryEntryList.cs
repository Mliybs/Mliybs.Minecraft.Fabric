namespace Net.Minecraft.Registry.Entry;

[JavaInterface(typeof(IRegistryEntryList<>))]
public partial class RegistryEntryList<T> : JavaObject, IClassRef<RegistryEntryList<T>>, IFromHandle<RegistryEntryList<T>> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => RegistryEntryList.Names;

    public static Class<RegistryEntryList<JavaObject>> ClassRef => RegistryEntryList.ClassRef;

    static Class<RegistryEntryList<T>> IClassRef<RegistryEntryList<T>>.ClassRef => Class.Proxy<RegistryEntryList<T>>(ClassRef.ObjectRef);
}

[MapName("net/minecraft/class_6885"), StaticGeneric(typeof(RegistryEntryList<>))]
public static partial class RegistryEntryList
{}

[JavaInterface(typeof(RegistryEntryList<>))]
public partial interface IRegistryEntryList<T> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{}