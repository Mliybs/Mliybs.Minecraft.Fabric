using Java.Util;

namespace Java.Lang;

[JavaInterface(typeof(IIterable<>))]
public partial class Iterable<T> : Lang.Object, IClassRef<Iterable<T>>, IFromHandle<Iterable<T>>, IIterable<T> where T : Lang.Object, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => Iterable.Names;

    public static Class<Iterable<Java.Lang.Object>> ClassRef => Iterable.ClassRef;

    static Class<Iterable<T>> IClassRef<Iterable<T>>.ClassRef => new(ClassRef.ObjectRef);

    [Signature("iterator", false)]
    public partial Iterator<T> Iterator();
}

[MapName("java.lang.Iterable", false), StaticGeneric(typeof(Iterable<>))]
public static partial class Iterable
{
}

[JavaInterface(typeof(Iterable<>))]
public partial interface IIterable<T> : IJavaClass where T : Lang.Object, IClassRef<T>, IFromHandle<T>
{
    Iterator<T> Iterator();
}
