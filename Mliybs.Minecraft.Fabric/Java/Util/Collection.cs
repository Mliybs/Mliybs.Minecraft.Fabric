using System;

namespace Java.Util;

[JavaInterface(typeof(ICollection<>))]
public partial class Collection<T> : Java.Lang.Object, ICollection<T>, IClassRef, IFromHandle<Collection<T>> where T : Java.Lang.Object, IClassRef, IFromHandle<T>
{
    internal static Names Names => Collection.Names;

    public static Class ClassRef => Collection.ClassRef;
}

[MapName("java.util.Collection", false)]
public static partial class Collection
{}

[JavaInterface(typeof(Collection<>))]
public partial interface ICollection<T> where T : Java.Lang.Object, IClassRef, IFromHandle<T>
{
}