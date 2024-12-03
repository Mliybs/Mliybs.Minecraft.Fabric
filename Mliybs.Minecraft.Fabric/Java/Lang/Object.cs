using System;

namespace Java.Lang;

[MapName("java.lang.Object", false), SuppressJavaClass]
public partial class Object : JavaClass, IClassRef<Object>, IFromHandle<Object>
{
    internal Object(nint handle) : base(handle)
    {}

    public static Object From(nint handle) => new(handle);
}
