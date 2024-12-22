namespace Com.Google.Common.Collect;

[JavaInterface(typeof(IMultimap<,>))]
public partial class Multimap<T, U> : JavaObject, IClassRef<Multimap<T, U>>, IFromHandle<Multimap<T, U>>, IMultimap<T, U>
    where T : JavaObject, IClassRef<T>, IFromHandle<T>
    where U : JavaObject, IClassRef<U>, IFromHandle<U>
{
    internal static Names Names => Multimap.Names;

    public static Class<Multimap<JavaObject, JavaObject>> ClassRef => Multimap.ClassRef;

    static Class<Multimap<T, U>> IClassRef<Multimap<T, U>>.ClassRef { get; } = Class.Proxy<Multimap<T, U>>(ClassRef.ObjectRef);
}

[MapName("com.google.common.collect.Multimap", false), StaticGeneric(typeof(Multimap<,>))]
public static partial class Multimap
{}

[JavaInterface(typeof(Multimap<,>))]
public partial interface IMultimap<T, U>
    where T : JavaObject, IClassRef<T>, IFromHandle<T>
    where U : JavaObject, IClassRef<U>, IFromHandle<U>
{}