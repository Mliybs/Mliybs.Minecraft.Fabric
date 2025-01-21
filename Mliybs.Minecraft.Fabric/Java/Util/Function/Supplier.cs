namespace Java.Util.Function;

public partial class Supplier<T> : JavaObject, IClassRef<Supplier<T>>, IFromHandle<Supplier<T>> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => Supplier.Names;

    public static Class<Supplier<JavaObject>> ClassRef => Supplier.ClassRef;

    static Class<Supplier<T>> IClassRef<Supplier<T>>.ClassRef => Class.Proxy<Supplier<T>>(ClassRef.ObjectRef);

    [Signature("get", false)]
    public partial T Get();
}

[MapName("java.util.function.Supplier", false), StaticGeneric(typeof(Supplier<>))]
public static partial class Supplier
{
    public delegate T SupplierDelegate<out T>() where T : JavaObject, IClassRef<T>, IFromHandle<T>;

    public delegate nint SupplierDelegateHandler();

    internal static SupplierDelegateHandler? Handle<T>(SupplierDelegate<T>? @delegate) where T : JavaObject, IClassRef<T>, IFromHandle<T> => @delegate is null ? null : () => @delegate().ObjectRef;
}
