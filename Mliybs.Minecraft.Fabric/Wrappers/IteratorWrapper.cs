using System;
using System.Collections;

namespace Mliybs.Minecraft.Fabric.Wrappers;

[SuppressJavaClass]
public sealed partial class IteratorWrapper<T> : Java.Lang.Object, IClassRef, IEnumerator<T> where T : Java.Lang.Object, IClassRef
{
    internal static Names Names => IteratorWrapper.Names;

    public static Class ClassRef => IteratorWrapper.ClassRef;

    private readonly IEnumerator<T> _enumerator;

    [JavaConstructor]
    private IteratorWrapper(long hasNext, long next) : base(nint.Zero)
    {
        throw new NotSupportedException();
    }
    
    public unsafe IteratorWrapper(IEnumerator<T> enumerator) : base(nint.Zero)
    {
        _enumerator = enumerator;
        ObjectRef = IteratorWrapper_LongLongInvoke(Marshal.GetFunctionPointerForDelegate<WrapperStatics.BoolDelegate>(MoveNext), Marshal.GetFunctionPointerForDelegate<WrapperStatics.ObjectDelegate>(Next));
    }

    private nint Next() => Current.ObjectRef;

    public T Current => _enumerator.Current;

    object IEnumerator.Current => _enumerator.Current;

    public bool MoveNext() => _enumerator.MoveNext();

    public void Reset() => _enumerator.Reset();

    public void Dispose() => _enumerator.Dispose();
}

[MapName("com/mlinetles/nativeloader/wrappers/IteratorWrapper", false)]
public static partial class IteratorWrapper
{

}