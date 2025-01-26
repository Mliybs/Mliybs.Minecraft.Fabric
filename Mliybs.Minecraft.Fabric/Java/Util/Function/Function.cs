namespace Java.Util.Function;

public partial class Function<T, R> : JavaObject, IClassRef<Function<T, R>>, IFromHandle<Function<T, R>>
    where T : JavaObject, IClassRef<T>, IFromHandle<T>
    where R : JavaObject, IClassRef<R>, IFromHandle<R>
{
    internal static Names Names => Function.Names;

    public static Class<Function<JavaObject, JavaObject>> ClassRef => Function.ClassRef;

    static Class<Function<T, R>> IClassRef<Function<T, R>>.ClassRef => Class.Proxy<Function<T, R>>(ClassRef.ObjectRef);

    [Signature("apply", false)]
    public partial R Apply(T t);
}

[MapName("java.util.function.Function", false), StaticGeneric(typeof(Function<,>))]
public static partial class Function
{
    public delegate R FunctionDelegate<in T, out R>(T t) where T : JavaObject, IClassRef<T>, IFromHandle<T>;

    internal delegate nint FunctionDelegateHandler(nint t);

    internal static FunctionDelegateHandler? Handle<T, R>(FunctionDelegate<T, R>? @delegate)
        where T : JavaObject, IClassRef<T>, IFromHandle<T>
        where R : JavaObject, IClassRef<R>, IFromHandle<R>
        => @delegate is null ? null : x => @delegate.Invoke(T.From(x)).ObjectRef;
}