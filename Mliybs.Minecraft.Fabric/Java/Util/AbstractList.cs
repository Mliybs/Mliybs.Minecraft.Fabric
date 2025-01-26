namespace Java.Util;

public partial class AbstractList<T> : AbstractCollection<T>, IList<T>, IClassRef<AbstractList<T>>, IFromHandle<AbstractList<T>> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => AbstractList.Names;

    public static Class<AbstractList<JavaObject>> ClassRef => AbstractList.ClassRef;

    static Class<AbstractList<T>> IClassRef<AbstractList<T>>.ClassRef => Class.Proxy<AbstractList<T>>(ClassRef.ObjectRef);
    
    public bool AddAll<E>(int index, ICollection<E> c) where E : JavaObject, T, IClassRef<E>, IFromHandle<E> => List<T>.AddAllProxy(ObjectRef, index, c);
    
    public T Get(int index) => List<T>.GetProxy(ObjectRef, index);
    
    public T Set(int index, T element) => List<T>.SetProxy(ObjectRef, index, element);
    
    public void Add(int index, T element) => List<T>.AddProxy(ObjectRef, index, element);
    
    public T Remove(int index) => List<T>.RemoveProxy(ObjectRef, index);
    
    public int IndexOf(JavaObject o) => List<T>.IndexOfProxy(ObjectRef, o);
    
    public int LastIndexOf(JavaObject o) => List<T>.LastIndexOfProxy(ObjectRef, o);
    
    public List<T> SubList(int fromIndex, int toIndex) => List<T>.SubListProxy(ObjectRef, fromIndex, toIndex);
}

[MapName("java/util/AbstractList", false), StaticGeneric(typeof(AbstractList<>))]
public static partial class AbstractList
{}