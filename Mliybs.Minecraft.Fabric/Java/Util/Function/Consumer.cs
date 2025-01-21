using System;

namespace Java.Util.Function;

public partial class Consumer<T> : JavaObject, IClassRef<Consumer<T>>, IFromHandle<Consumer<T>> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => Consumer.Names;

    public static Class<Consumer<JavaObject>> ClassRef => Consumer.ClassRef;

    static Class<Consumer<T>> IClassRef<Consumer<T>>.ClassRef => Class.Proxy<Consumer<T>>(ClassRef.ObjectRef);

    [Signature("accept", false)]
    public partial void Accept(T t);
}

[MapName("java.util.function.Consumer", false), StaticGeneric(typeof(Consumer<>))]
public static partial class Consumer
{
    public delegate void ConsumerDelegate<in T>(T t) where T : JavaObject, IClassRef<T>, IFromHandle<T>;

    public delegate void ConsumerDelegateHandler(nint t);

    internal static ConsumerDelegateHandler? Handle<T>(ConsumerDelegate<T>? @delegate) where T : JavaObject, IClassRef<T>, IFromHandle<T> => @delegate is null ? null : x => @delegate(T.From(x));
}
