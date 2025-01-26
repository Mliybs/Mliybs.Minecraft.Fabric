namespace Java.Util;

[JavaInterface(typeof(IMap<,>))]
public partial class Map<K, V> : JavaObject, IMap<K, V>, IClassRef<Map<K, V>>, IFromHandle<Map<K, V>>
    where K : JavaObject, IClassRef<K>, IFromHandle<K>
    where V : JavaObject, IClassRef<V>, IFromHandle<V>
{
    internal static Names Names => Map.Names;

    public static Class<Map<JavaObject, JavaObject>> ClassRef => Map.ClassRef;

    static Class<Map<K, V>> IClassRef<Map<K, V>>.ClassRef => Class.Proxy<Map<K, V>>(ClassRef.ObjectRef);
}

[MapName("java.util.Map", false), StaticGeneric(typeof(Map<,>))]
public static partial class Map
{

}

[JavaInterface(typeof(Map<,>))]
public partial interface IMap<K, V>
    where K : JavaObject, IClassRef<K>, IFromHandle<K>
    where V : JavaObject, IClassRef<V>, IFromHandle<V>
{}