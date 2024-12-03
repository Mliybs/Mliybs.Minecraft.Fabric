using System;
using System.Collections;

namespace Mliybs.Minecraft.Fabric.Wrappers;

[SuppressJavaClass]
public sealed partial class ListWrapper<T> : Java.Lang.Object, IClassRef<ListWrapper<Java.Lang.Object>>, IFromHandle<ListWrapper<T>>, IReadOnlyList<T> where T : Java.Lang.Object, IClassRef<T>
{
    internal static Names Names => ListWrapper.Names;

    public static Class<ListWrapper<Java.Lang.Object>> ClassRef => ListWrapper.ClassRef;

    private readonly System.Collections.Generic.IList<T> _list;

    [JavaConstructor]
    private ListWrapper(long handle) : base(nint.Zero)
    {
        throw new NotSupportedException();
    }

    public static ListWrapper<T> From(nint handle) => throw new NotSupportedException();

    public unsafe ListWrapper() : base(nint.Zero)
    {
        _list = new System.Collections.Generic.List<T>();
        var wrapper = new ListWrapperStruct()
        {
            Get = Marshal.GetFunctionPointerForDelegate<ListWrapperDelegates.GetDelegate>(Get),
            Size = Marshal.GetFunctionPointerForDelegate<ListWrapperDelegates.SizeDelegate>(Size)
        };
        ObjectRef = ListWrapper_LongInvoke((nint)(&wrapper));
    }

    public unsafe ListWrapper(IEnumerable<T> values) : base(nint.Zero)
    {
        _list = values.ToList();
        var wrapper = new ListWrapperStruct()
        {
            Get = Marshal.GetFunctionPointerForDelegate<ListWrapperDelegates.GetDelegate>(Get),
            Size = Marshal.GetFunctionPointerForDelegate<ListWrapperDelegates.SizeDelegate>(Size)
        };
        ObjectRef = ListWrapper_LongInvoke((nint)(&wrapper));
    }

    public unsafe ListWrapper(System.Collections.Generic.IList<T> list) : base(nint.Zero)
    {
        _list = list;
        var wrapper = new ListWrapperStruct()
        {
            Get = Marshal.GetFunctionPointerForDelegate<ListWrapperDelegates.GetDelegate>(Get),
            Size = Marshal.GetFunctionPointerForDelegate<ListWrapperDelegates.SizeDelegate>(Size)
        };
        ObjectRef = ListWrapper_LongInvoke((nint)(&wrapper));
    }

    public T this[int index]
    {
        get => _list[index];
        set => _list[index] = value;
    }

    private nint Get(int index) => this[index].ObjectRef;

    private int Size() => Count;

    public int IndexOf(T item) => _list.IndexOf(item);

    public void Insert(int index, T item) => _list.Insert(index, item);

    public void RemoveAt(int index) => _list.RemoveAt(index);

    public void Add(T item) => _list.Add(item);

    public void Clear() => _list.Clear();

    public bool Contains(T item) => _list.Contains(item);

    public bool Remove(T item) => _list.Remove(item);

    public void CopyTo(T[] array, int index) => _list.CopyTo(array, index);

    public int Count => _list.Count;

    public bool IsReadOnly => false;

    public IEnumerator<T> GetEnumerator() => _list.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => _list.GetEnumerator();

    public static implicit operator ListWrapper<T>(System.Collections.Generic.List<T> list) => new(list);
}

[MapName("com/mlinetles/nativeloader/wrappers/ListWrapper", false), StaticGeneric(typeof(ListWrapper<>))]
public static partial class ListWrapper
{

}

[StructLayout(LayoutKind.Sequential)]
internal struct ListWrapperStruct
{
    public nint Get;

    public nint Size;
}

internal static class ListWrapperDelegates
{
    public delegate nint GetDelegate(int index);

    public delegate int SizeDelegate();
}
