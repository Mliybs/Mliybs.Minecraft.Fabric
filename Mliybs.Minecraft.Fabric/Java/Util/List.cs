namespace Java.Util;

[JavaInterface(typeof(IList<>))]
public partial class List<T> : Collection<T>, IClassRef<List<T>>, IFromHandle<List<T>>, IList<T> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => List.Names;

    public static Class<List<JavaObject>> ClassRef => List.ClassRef;

    static Class<List<T>> IClassRef<List<T>>.ClassRef => Class.Proxy<List<T>>(ClassRef.ObjectRef);

    [Signature("addAll", false)]
    public partial bool AddAll<E>(int index, ICollection<E> c) where E : JavaObject, T, IClassRef<E>, IFromHandle<E>;

    [Signature("get", false)]
    public partial T Get(int index);

    [Signature("set", false)]
    public partial T Set(int index, T element);

    [Signature("add", false)]
    public partial void Add(int index, T element);

    [Signature("remove", false)]
    public partial T Remove(int index);

    [Signature("indexOf", false)]
    public partial int IndexOf(JavaObject o);

    [Signature("lastIndexOf", false)]
    public partial int LastIndexOf(JavaObject o);

    [Signature("subList", false)]
    public partial List<T> SubList(int fromIndex, int toIndex);
}

[MapName("java.util.List", false), StaticGeneric(typeof(List<>))]
public static partial class List
{
}

[JavaInterface(typeof(List<>))]
public partial interface IList<T> : ICollection<T> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    bool AddAll<E>(int index, ICollection<E> c) where E : JavaObject, T, IClassRef<E>, IFromHandle<E>;
    
    T Get(int index);
    
    T Set(int index, T element);
    
    void Add(int index, T element);
    
    T Remove(int index);
    
    int IndexOf(JavaObject o);
    
    int LastIndexOf(JavaObject o);
    
    List<T> SubList(int fromIndex, int toIndex);
}
