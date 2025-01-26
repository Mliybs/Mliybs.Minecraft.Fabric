using Java.Util;

namespace Java.Lang;

[JavaInterface(typeof(IIterable<>)), FromMode(FromModes.SimpleFrom)]
public partial class Iterable<T> : JavaObject, IClassRef<Iterable<T>>, IFromHandle<Iterable<T>>, IIterable<T> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => Iterable.Names;

    public static Class<Iterable<JavaObject>> ClassRef => Iterable.ClassRef;

    static Class<Iterable<T>> IClassRef<Iterable<T>>.ClassRef => Class.Proxy<Iterable<T>>(ClassRef.ObjectRef);

    [Signature("iterator", false)]
    public partial Iterator<T> Iterator();

    public IEnumerator<T> GetEnumerator()
    {
        var iterator = Iterator();
        while (iterator.HasNext()) yield return iterator.Next();
    }
}

[MapName("java.lang.Iterable", false), StaticGeneric(typeof(Iterable<>))]
public static partial class Iterable
{
}

[JavaInterface(typeof(Iterable<>))]
public partial interface IIterable<T> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    Iterator<T> Iterator();

    public IEnumerator<T> GetEnumerator()
    {
        var iterator = Iterator();
        while (iterator.HasNext()) yield return iterator.Next();
    }
}
