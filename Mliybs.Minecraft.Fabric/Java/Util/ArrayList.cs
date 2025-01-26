using System.Runtime.CompilerServices;

namespace Java.Util;

[CollectionBuilder(typeof(ArrayList), nameof(ArrayList.Create))]
public partial class ArrayList<T> : AbstractList<T>, IClassRef<ArrayList<T>>, IFromHandle<ArrayList<T>> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => ArrayList.Names;

    public static Class<ArrayList<JavaObject>> ClassRef => ArrayList.ClassRef;

    static Class<ArrayList<T>> IClassRef<ArrayList<T>>.ClassRef => Class.Proxy<ArrayList<T>>(ClassRef.ObjectRef);

    [JavaConstructor]
    public ArrayList() : base(ArrayList_Invoke())
    {}

    [JavaConstructor]
    public ArrayList(ICollection<T> c) : base(ArrayList_Collection1Invoke(c))
    {}

    [JavaConstructor]
    public ArrayList(int initialCapacity) : base(ArrayList_IntInvoke(initialCapacity))
    {}
}

[MapName("java.util.ArrayList", false), StaticGeneric(typeof(ArrayList<>))]
public static partial class ArrayList
{
    public static ArrayList<T> Create<T>(ReadOnlySpan<T> span) where T : JavaObject, IClassRef<T>, IFromHandle<T>
    {
        var list = new ArrayList<T>(span.Length);
        foreach (var item in span) list.Add(item);
        return list;
    }
}