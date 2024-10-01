using System;
using System.Collections.Generic;

namespace Java.Lang
{
    [SuppressJavaClass]
    public sealed partial class Class : JavaClass, IClassRef, IFromHandle<Class>
    {
        internal static Names Names { get; } = (null!, null!, "java.lang.Class", "java/lang/Class");

        public static nint ClassRef { get; } = FindClass("java/lang/Class");

        internal Class(nint handle)
        {
            ObjectRef = handle;
        }

        [Signature("forName", false)]
        public static partial Class ForName(string className);

        public static Class From(nint handle)
        {
            return new(handle);
        }
    }
}
