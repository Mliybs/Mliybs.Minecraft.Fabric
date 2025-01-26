namespace Java.Util;

public partial class AbstractCollection<T> : JavaObject, ICollection<T>, IClassRef<AbstractCollection<T>>, IFromHandle<AbstractCollection<T>> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => AbstractCollection.Names;

    public static Class<AbstractCollection<JavaObject>> ClassRef => AbstractCollection.ClassRef;

    static Class<AbstractCollection<T>> IClassRef<AbstractCollection<T>>.ClassRef => Class.Proxy<AbstractCollection<T>>(ClassRef.ObjectRef);

    public int Size() => Collection<T>.SizeProxy(ObjectRef);

    public bool IsEmpty() => Collection<T>.IsEmptyProxy(ObjectRef);

    public bool Contains(JavaObject o) => Collection<T>.ContainsProxy(ObjectRef, o);

    public JavaArray<JavaObject> ToArray() => Collection<T>.ToArrayProxy(ObjectRef);

    public JavaArray<E> ToArray<E>(JavaArray<E> a) where E : JavaObject, IClassRef<E>, IFromHandle<E> => Collection<T>.ToArrayProxy(ObjectRef, a);

    public bool Add(T e) => Collection<T>.AddProxy(ObjectRef, e);

    public bool Remove(JavaObject o) => Collection<T>.RemoveProxy(ObjectRef, o);

    public bool ContainsAll<E>(ICollection<E> c) where E : JavaObject, IClassRef<E>, IFromHandle<E> => Collection<T>.ContainsAllProxy(ObjectRef, c);

    public bool AddAll<E>(ICollection<E> c) where E : T, IClassRef<E>, IFromHandle<E> => Collection<T>.AddAllProxy(ObjectRef, c);

    public bool RemoveAll<E>(ICollection<E> c) where E : JavaObject, IClassRef<E>, IFromHandle<E> => Collection<T>.RemoveAllProxy(ObjectRef, c);

    public void Clear() => Collection<T>.ClearProxy(ObjectRef);

    public Iterator<T> Iterator() => Iterable<T>.IteratorProxy(ObjectRef);

    public IEnumerator<T> GetEnumerator()
    {
        var iterator = Iterator();
        while (iterator.HasNext()) yield return iterator.Next();
    }
}

[MapName("java/util/AbstractCollection", false), StaticGeneric(typeof(AbstractCollection<>))]
public static partial class AbstractCollection
{}