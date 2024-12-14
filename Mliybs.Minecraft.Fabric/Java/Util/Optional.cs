namespace Java.Util;

public partial class Optional<T> : Java.Lang.Object, IClassRef<Optional<T>>, IFromHandle<Optional<T>> where T : Lang.Object, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => Optional.Names;

    public static Class<Optional<Java.Lang.Object>> ClassRef => Optional.ClassRef;

    static Class<Optional<T>> IClassRef<Optional<T>>.ClassRef => new(ClassRef.ObjectRef);

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
