using System;
using System.Collections;

namespace Mliybs.Minecraft.Fabric.Wrappers;

[SuppressJavaClass]
public sealed partial class ReadOnlyCollectionWrapper<T> : Java.Util.Collection<T>, IClassRef<ReadOnlyCollectionWrapper<Java.Lang.Object>>, IFromHandle<ReadOnlyCollectionWrapper<T>>, IReadOnlyCollection<T>, Java.Util.ICollection<T> where T : Java.Lang.Object, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => ReadOnlyCollectionWrapper.Names;

    public static Class<ReadOnlyCollectionWrapper<Java.Lang.Object>> ClassRef => ReadOnlyCollectionWrapper.ClassRef;

    private readonly IReadOnlyCollection<T> collection = default!;

    [JavaConstructor]
    private ReadOnlyCollectionWrapper(long size, long iterator) : base(nint.Zero)
    {
        throw new NotSupportedException();
    }

    public ReadOnlyCollectionWrapper(IReadOnlyCollection<T> collection) : base(nint.Zero)
    {
        this.collection = collection;
        ObjectRef = ReadOnlyCollectionWrapper_LongLongInvoke(Marshal.GetFunctionPointerForDelegate<WrapperStatics.IntDelegate>(Size), Marshal.GetFunctionPointerForDelegate<WrapperStatics.ObjectDelegate>(Iterator));
    }

    private int Size() => collection.Count;

    private nint Iterator() => new IteratorWrapper<T>(collection.GetEnumerator()).ObjectRef;

    public int Count => collection.Count;

    public IEnumerator<T> GetEnumerator() => collection.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => collection.GetEnumerator();

    public static ReadOnlyCollectionWrapper<T> From(nint handle)
    {
        throw new InvalidCastException();
    }
}

[MapName("com.mlinetles.nativeloader.wrappers.ReadOnlyCollectionWrapper", false), StaticGeneric(typeof(ReadOnlyCollectionWrapper<>))]
public static partial class ReadOnlyCollectionWrapper
{
}
