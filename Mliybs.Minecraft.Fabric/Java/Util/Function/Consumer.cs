using System;

namespace Java.Util.Function;

public partial class Consumer<T> : Lang.Object, IClassRef<Consumer<T>>, IFromHandle<Consumer<T>> where T : Lang.Object, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => Consumer.Names;

    public static Class<Consumer<Java.Lang.Object>> ClassRef => Consumer.ClassRef;

    static Class<Consumer<T>> IClassRef<Consumer<T>>.ClassRef => new(ClassRef.ObjectRef);

    [Signature("accept", false)]
    public partial void Accept(T t);

    public delegate void ConsumerDelegate(T t);

    internal static Consumer.ConsumerDelegateHandler Handle(ConsumerDelegate @delegate) => x => @delegate(T.From(x));
}

[MapName("java.util.function.Consumer", false), StaticGeneric(typeof(Consumer<>))]
public static partial class Consumer
{
    public delegate void ConsumerDelegateHandler(nint t);

    internal static ConsumerDelegateHandler Handle(ConsumerDelegateHandler @delegate) => @delegate;
}
