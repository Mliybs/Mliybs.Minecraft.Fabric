namespace Com.Google.Common.Collect;

[JavaInterface(typeof(IMultimap<,>))]
public partial class Multimap<T, U> : Java.Lang.Object, IClassRef<Multimap<T, U>>, IFromHandle<Multimap<T, U>>, IMultimap<T, U>
    where T : Java.Lang.Object, IClassRef<T>, IFromHandle<T>
    where U : Java.Lang.Object, IClassRef<U>, IFromHandle<U>
{
    internal static Names Names => Multimap.Names;

    public static Class<Multimap<Java.Lang.Object, Java.Lang.Object>> ClassRef => Multimap.ClassRef;

    static Class<Multimap<T, U>> IClassRef<Multimap<T, U>>.ClassRef => new(ClassRef.ObjectRef);
}

[MapName("com.google.common.collect.Multimap", false), StaticGeneric(typeof(Multimap<,>))]
public static partial class Multimap
{}

[JavaInterface(typeof(Multimap<,>))]
public partial interface IMultimap<T, U>
    where T : Java.Lang.Object, IClassRef<T>, IFromHandle<T>
    where U : Java.Lang.Object, IClassRef<U>, IFromHandle<U>
{}