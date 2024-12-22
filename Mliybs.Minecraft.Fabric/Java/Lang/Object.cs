using System;

namespace Java.Lang;

[MapName("java.lang.Object", false), SuppressJavaClass]
public partial class Object : JavaClass, IClassRef<JavaObject>, IFromHandle<JavaObject>
{
    internal Object(nint handle) : base(handle)
    {}

    [Signature("getClass", false)]
    public partial Class<JavaObject> GetClass();

    [Signature("hashCode", false)]
    public partial int HashCode();

    [Signature("equals", false)]
    public partial bool Equals(JavaObject obj);

    [Signature("toString", false)]
    public override partial string ToString();

    public static JavaObject From(nint handle) => new(handle);
}