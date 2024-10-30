using System;

namespace Java.Util.Function;

public partial class Consumer<T> : Lang.Object, IClassRef, IFromHandle<Consumer<T>> where T : Lang.Object, IClassRef, IFromHandle<T>
{
    internal static Names Names => Consumer.Names;

    public static Class ClassRef => Consumer.ClassRef;

    [Signature("accept", false)]
    public partial void Accept(T t);

    public delegate void ConsumerDelegate(T t);

    internal static Consumer.ConsumerDelegateHandler Handle(ConsumerDelegate @delegate) => x => @delegate(T.From(x));
}

[MapName("java.util.function.Consumer", false)]
public static partial class Consumer
{
    public delegate void ConsumerDelegateHandler(nint t);
}