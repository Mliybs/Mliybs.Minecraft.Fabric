using System;

namespace Java.Lang;

[MapName("java.lang.Object", false), SuppressJavaClass]
public partial class Object : JavaClass, IClassRef<Object>, IFromHandle<Object>
{
    internal Object(nint handle) : base(handle)
    {}

    [Signature("getClass", false)]
    public partial Class<Object> GetClass();

    [Signature("hashCode", false)]
    public partial int HashCode();

    [Signature("equals", false)]
    public partial bool Equals(Object obj);

    [Signature("toString", false)]
    public override partial string ToString();

    public static Object From(nint handle) => new(handle);
}
