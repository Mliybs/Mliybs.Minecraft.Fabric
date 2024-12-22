namespace Java.Util;


[JavaInterface(typeof(IIterator<>)), SuppressJavaClass]
public partial class Iterator<T> : JavaObject, IClassRef<Iterator<T>>, IFromHandle<Iterator<T>>, IIterator<T> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => Iterator.Names;

    public static Class<Iterator<JavaObject>> ClassRef => Iterator.ClassRef;

    static Class<Iterator<T>> IClassRef<Iterator<T>>.ClassRef => Class.Proxy<Iterator<T>>(ClassRef.ObjectRef);

    internal Iterator(nint handle) : base(handle)
    {}

    [Signature("hasNext", false)]
    public partial bool HasNext();

    [Signature("next", false)]
    public partial T Next();

    public static Iterator<T> From(nint handle)
    {
        return new(handle);
    }
}

[MapName("java.util.Iterator", false), StaticGeneric(typeof(Iterator<>))]
public static partial class Iterator
{
}

[JavaInterface(typeof(Iterator<>))]
public partial interface IIterator<T> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    bool HasNext();

    T Next();
}
