namespace Java.Util;

[JavaInterface(typeof(ISet<>))]
public partial class Set<T> : Collection<T>, IClassRef<Set<T>>, IFromHandle<Set<T>> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => Set.Names;

    public static Class<Set<JavaObject>> ClassRef => Set.ClassRef;

    static Class<Set<T>> IClassRef<Set<T>>.ClassRef => Class.Proxy<Set<T>>(ClassRef.ObjectRef);
}

[MapName("java/util/Set", false), StaticGeneric(typeof(Set<>))]
public static partial class Set
{}

[JavaInterface(typeof(Set<>))]
public partial interface ISet<T> : ICollection<T> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{}