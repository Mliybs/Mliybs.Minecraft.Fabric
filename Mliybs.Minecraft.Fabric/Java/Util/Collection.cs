using System;

namespace Java.Util;

[JavaInterface(typeof(ICollection<>)), FromMode(FromModes.SimpleFrom)]
public partial class Collection<T> : Iterable<T>, ICollection<T>, IClassRef<Collection<T>>, IFromHandle<Collection<T>> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => Collection.Names;

    public static Class<Collection<JavaObject>> ClassRef => Collection.ClassRef;

    static Class<Collection<T>> IClassRef<Collection<T>>.ClassRef => Class.Proxy<Collection<T>>(ClassRef.ObjectRef);

    [Signature("size", false)]
    public partial int Size();

    [Signature("isEmpty", false)]
    public partial bool IsEmpty();

    [Signature("contains", false)]
    public partial bool Contains(JavaObject o);

    [Signature("toArray", false)]
    public partial JavaArray<JavaObject> ToArray();

    [Signature("toArray", false)]
    public partial JavaArray<E> ToArray<E>(JavaArray<E> a) where E : JavaObject, IClassRef<E>, IFromHandle<E>;

    [Signature("add", false)]
    public partial bool Add(T e);

    [Signature("remove", false)]
    public partial bool Remove(JavaObject o);

    [Signature("containsAll", false)]
    public partial bool ContainsAll<E>(ICollection<E> c) where E : JavaObject, IClassRef<E>, IFromHandle<E>;

    [Signature("addAll", false)]
    public partial bool AddAll<E>(ICollection<E> c) where E : T, IClassRef<E>, IFromHandle<E>;

    [Signature("removeAll", false)]
    public partial bool RemoveAll<E>(ICollection<E> c) where E : JavaObject, IClassRef<E>, IFromHandle<E>;

    [Signature("clear", false)]
    public partial void Clear();
}

[MapName("java.util.Collection", false), StaticGeneric(typeof(Collection<>))]
public static partial class Collection
{}

[JavaInterface(typeof(Collection<>))]
public partial interface ICollection<T> : IIterable<T> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    int Size();

    bool IsEmpty();

    bool Contains(JavaObject o);

    JavaArray<JavaObject> ToArray();

    JavaArray<E> ToArray<E>(JavaArray<E> a) where E : JavaObject, IClassRef<E>, IFromHandle<E>;

    bool Add(T e);

    bool Remove(JavaObject o);

    bool ContainsAll<E>(ICollection<E> c) where E : JavaObject, IClassRef<E>, IFromHandle<E>;

    bool AddAll<E>(ICollection<E> c) where E : T, IClassRef<E>, IFromHandle<E>;

    bool RemoveAll<E>(ICollection<E> c) where E : JavaObject, IClassRef<E>, IFromHandle<E>;

    void Clear();
}
