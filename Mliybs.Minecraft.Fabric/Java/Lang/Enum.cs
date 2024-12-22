using System;

namespace Java.Lang;

[SuppressJavaClass]
public partial class Enum<T> : JavaObject, IClassRef<Enum<T>>, IFromHandle<Enum<T>> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => Enum.Names;

    public static Class<Enum<JavaObject>> ClassRef => Enum.ClassRef;

    static Class<Enum<T>> IClassRef<Enum<T>>.ClassRef => Class.Proxy<Enum<T>>(ClassRef.ObjectRef);

    internal Enum(nint handle) : base(handle)
    {}

    public static Enum<T> From(nint handle) => new(handle);
}

[MapName("java.lang.Enum", false), StaticGeneric(typeof(Enum<>))]
public static partial class Enum
{}