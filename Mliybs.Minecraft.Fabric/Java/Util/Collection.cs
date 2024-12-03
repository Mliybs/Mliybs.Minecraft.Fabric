using System;

namespace Java.Util;

[JavaInterface(typeof(ICollection<>))]
public partial class Collection<T> : Java.Lang.Iterable<T>, ICollection<T>, IClassRef<Collection<T>>, IFromHandle<Collection<T>> where T : Java.Lang.Object, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => Collection.Names;

    public static Class<Collection<Java.Lang.Object>> ClassRef => Collection.ClassRef;

    static Class<Collection<T>> IClassRef<Collection<T>>.ClassRef => new(ClassRef.ObjectRef);

    [Signature("size", false)]
    public partial int Size();

    [Signature("isEmpty", false)]
    public partial bool IsEmpty();

    [Signature("contains", false)]
    public partial bool Contains(Java.Lang.Object o);

    [Signature("toArray", false)]
    public partial JavaArray<Java.Lang.Object> ToArray();

    [Signature("toArray", false)]
    public partial JavaArray<E> ToArray<E>(JavaArray<E> a) where E : Java.Lang.Object, IClassRef<E>, IFromHandle<E>;

    [Signature("add", false)]
    public partial bool Add(T e);

    [Signature("remove", false)]
    public partial bool Remove(Java.Lang.Object o);

    [Signature("containsAll", false)]
    public partial bool ContainsAll<E>(ICollection<E> c) where E : Java.Lang.Object, IClassRef<E>, IFromHandle<E>;

    [Signature("addAll", false)]
    public partial bool AddAll<E>(ICollection<E> c) where E : T, IClassRef<E>, IFromHandle<E>;

    [Signature("removeAll", false)]
    public partial bool RemoveAll<E>(ICollection<E> c) where E : Java.Lang.Object, IClassRef<E>, IFromHandle<E>;

    [Signature("clear", false)]
    public partial void Clear();
}

[MapName("java.util.Collection", false), StaticGeneric(typeof(Collection<>))]
public static partial class Collection
{}

[JavaInterface(typeof(Collection<>))]
public partial interface ICollection<T> : Java.Lang.IIterable<T> where T : Java.Lang.Object, IClassRef<T>, IFromHandle<T>
{
    int Size();

    bool IsEmpty();

    bool Contains(Java.Lang.Object o);

    JavaArray<Java.Lang.Object> ToArray();

    JavaArray<E> ToArray<E>(JavaArray<E> a) where E : Java.Lang.Object, IClassRef<E>, IFromHandle<E>;

    bool Add(T e);

    bool Remove(Java.Lang.Object o);

    bool ContainsAll<E>(ICollection<E> c) where E : Java.Lang.Object, IClassRef<E>, IFromHandle<E>;

    bool AddAll<E>(ICollection<E> c) where E : T, IClassRef<E>, IFromHandle<E>;

    bool RemoveAll<E>(ICollection<E> c) where E : Java.Lang.Object, IClassRef<E>, IFromHandle<E>;

    void Clear();
}
