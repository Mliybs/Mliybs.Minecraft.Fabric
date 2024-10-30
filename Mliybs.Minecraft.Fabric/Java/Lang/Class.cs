using System;
using System.Collections.Generic;

namespace Java.Lang
{
    [MapName("java.lang.Class", false), SuppressJavaClass]
    public sealed partial class Class : Java.Lang.Object, IClassRef, IFromHandle<Class>
    {
        internal Class(nint handle) : base(handle)
        {}

        [Signature("forName", false)]
        public static partial Class ForName(string className);

        public static Class From(nint handle) => new(handle);
    }
}
