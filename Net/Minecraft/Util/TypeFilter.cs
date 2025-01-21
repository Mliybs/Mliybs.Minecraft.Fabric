namespace Net.Minecraft.Util;

[JavaInterface(typeof(ITypeFilter<,>))]
public partial class TypeFilter<T, K> : JavaObject, ITypeFilter<T, K>, IClassRef<TypeFilter<T, K>>, IFromHandle<TypeFilter<T, K>>
    where T : JavaObject, IClassRef<T>, IFromHandle<T>
    where K : JavaObject, T, IClassRef<K>, IFromHandle<K>
{
    internal static Names Names => TypeFilter.Names;

    public static Class<TypeFilter<JavaObject, JavaObject>> ClassRef => TypeFilter.ClassRef;

    static Class<TypeFilter<T, K>> IClassRef<TypeFilter<T, K>>.ClassRef => Class.Proxy<TypeFilter<T, K>>(ClassRef.ObjectRef);
}

[MapName("net/minecraft/class_5575"), StaticGeneric(typeof(TypeFilter<,>))]
public static partial class TypeFilter
{
    public static Class<TypeFilter<JavaObject, JavaObject>> ClassRef => _classRef;
}

[JavaInterface(typeof(TypeFilter<,>))]
public partial interface ITypeFilter<T, K>
    where T : JavaObject, IClassRef<T>, IFromHandle<T>
    where K : JavaObject, T, IClassRef<K>, IFromHandle<K>
{
}