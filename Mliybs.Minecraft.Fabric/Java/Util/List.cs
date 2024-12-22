namespace Java.Util;

[JavaInterface(typeof(IList<>))]
public partial class List<T> : Collection<T>, IClassRef<List<T>>, IFromHandle<List<T>>, IList<T> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => List.Names;

    public static Class<List<JavaObject>> ClassRef => List.ClassRef;

    static Class<List<T>> IClassRef<List<T>>.ClassRef => Class.Proxy<List<T>>(ClassRef.ObjectRef);
}

[MapName("java.util.List", false), StaticGeneric(typeof(List<>))]
public static partial class List
{
}

[JavaInterface(typeof(List<>))]
public partial interface IList<T> : ICollection<T> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
}
