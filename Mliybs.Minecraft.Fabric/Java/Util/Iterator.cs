namespace Java.Util;


[JavaInterface(typeof(IIterator<>)), SuppressJavaClass]
public partial class Iterator<T> : Lang.Object, IClassRef<Iterator<T>>, IFromHandle<Iterator<T>>, IIterator<T> where T : Lang.Object, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => Iterator.Names;

    public static Class<Iterator<Java.Lang.Object>> ClassRef => Iterator.ClassRef;

    static Class<Iterator<T>> IClassRef<Iterator<T>>.ClassRef => new(ClassRef.ObjectRef);

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
public partial interface IIterator<T> : IJavaClass where T : Lang.Object, IClassRef<T>, IFromHandle<T>
{
    bool HasNext();

    T Next();
}
