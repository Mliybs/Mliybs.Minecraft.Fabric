using Java.Lang;
using Java.Util.Stream;
using Java.Util.Function;

namespace Java.Util;

public partial class Optional<T> : JavaObject, IClassRef<Optional<T>>, IFromHandle<Optional<T>> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => Optional.Names;

    public static Class<Optional<JavaObject>> ClassRef => Optional.ClassRef;

    static Class<Optional<T>> IClassRef<Optional<T>>.ClassRef => Class.Proxy<Optional<T>>(ClassRef.ObjectRef);

    [Signature("get", false)]
    public partial T Get();

    [Signature("isPresent", false)]
    public partial bool IsPresent();

    [Signature("isEmpty", false)]
    public partial bool IsEmpty();

    [Signature("ifPresent", false)]
    public partial void IfPresent(Consumer.ConsumerDelegate<T> action);

    [Signature("ifPresentOrElse", false)]
    public partial void IfPresentOrElse(Consumer.ConsumerDelegate<T> action, Runnable.RunnableDelegate emptyAction);

    [Signature("filter", false)]
    public partial Optional<T> Filter(Java.Util.Function.Predicate.PredicateDelegate<T> predicate);

    [Signature("map", false)]
    public partial Optional<U> Map<U>(Java.Util.Function.Function.FunctionDelegate<T, U> mapper) where U : JavaObject, IClassRef<U>, IFromHandle<U>;

    [Signature("flatMap", false)]
    public partial Optional<U> FlatMap<U>(Java.Util.Function.Function.FunctionDelegate<T, Optional<U>> mapper) where U : JavaObject, IClassRef<U>, IFromHandle<U>;

    [Signature("or", false)]
    public partial Optional<T> Or(Supplier.SupplierDelegate<Optional<T>> supplier);

    [Signature("stream", false)]
    public partial Stream<T> Stream();

    [Signature("orElse", false)]
    public partial T OrElse(T other);

    [Signature("orElseGet", false)]
    public partial T OrElseGet(Supplier.SupplierDelegate<T> supplier);

    [Signature("orElseThrow", false)]
    public partial T OrElseThrow();

    [Signature("orElseThrow", false)]
    public partial T OrElseThrow(Supplier.SupplierDelegate<Throwable> exceptionSupplier);
}

[MapName("java.util.Optional", false), StaticGeneric(typeof(Optional<>))]
public static partial class Optional
{
    [Signature("empty", false)]
    public static partial Optional<T> Empty<T>() where T : JavaObject, IClassRef<T>, IFromHandle<T>;

    [Signature("of", false)]
    public static partial Optional<T> Of<T>(T value) where T : JavaObject, IClassRef<T>, IFromHandle<T>;

    [Signature("ofNullable", false)]
    public static partial Optional<T> OfNullable<T>(T value) where T : JavaObject, IClassRef<T>, IFromHandle<T>;
}
