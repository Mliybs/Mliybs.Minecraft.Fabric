namespace Java.Util;

public partial class Optional<T> : JavaObject, IClassRef<Optional<T>>, IFromHandle<Optional<T>> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => Optional.Names;

    public static Class<Optional<JavaObject>> ClassRef => Optional.ClassRef;

    static Class<Optional<T>> IClassRef<Optional<T>>.ClassRef => Class.Proxy<Optional<T>>(ClassRef.ObjectRef);

    [Signature("get", false)]
    public partial T Get();

    [Signature("isEmpty", false)]
    public partial bool IsEmpty();

    [Signature("isPresent", false)]
    public partial bool IsPresent();
}

[MapName("java.util.Optional", false), StaticGeneric(typeof(Optional<>))]
public static partial class Optional
{
}
