namespace Java.Util.Function;

public partial class Predicate<T> : JavaObject, IClassRef<Predicate<T>>, IFromHandle<Predicate<T>>
    where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => Predicate.Names;

    public static Class<Predicate<JavaObject>> ClassRef => Predicate.ClassRef;

    static Class<Predicate<T>> IClassRef<Predicate<T>>.ClassRef => Class.Proxy<Predicate<T>>(ClassRef.ObjectRef);

    [Signature("test", false)]
    public partial bool Test(T t);
}

[MapName("java.util.function.Predicate"), StaticGeneric(typeof(Predicate<>))]
public static partial class Predicate
{
    public delegate bool PredicateDelegate<in T>(T t) where T : JavaObject, IClassRef<T>, IFromHandle<T>;

    internal delegate bool PredicateDelegateHandler(nint t);

    internal static PredicateDelegateHandler? Handle<T>(PredicateDelegate<T>? @delegate) where T : JavaObject, IClassRef<T>, IFromHandle<T> => @delegate is null ? null : x => @delegate.Invoke(T.From(x));
}