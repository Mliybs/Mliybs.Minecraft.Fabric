namespace Java.Util.Stream;

[JavaInterface(typeof(IStream<>))]
public partial class Stream<T> : JavaObject, IClassRef<Stream<T>>, IFromHandle<Stream<T>>
    where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => Stream.Names;

    public static Class<Stream<JavaObject>> ClassRef => Stream.ClassRef;

    static Class<Stream<T>> IClassRef<Stream<T>>.ClassRef => Class.Proxy<Stream<T>>(ClassRef.ObjectRef);
}

[MapName("java.util.stream.Stream", false), StaticGeneric(typeof(Stream<>))]
public static partial class Stream
{}

[JavaInterface(typeof(Stream<>))]
public partial interface IStream<T> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{}