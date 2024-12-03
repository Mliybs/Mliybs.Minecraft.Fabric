using System;
using System.Collections.Generic;

namespace Java.Lang
{
    [SuppressJavaClass]
    public sealed partial class Class<T> : Java.Lang.Object, IClassRef<Class<Java.Lang.Object>>, IFromHandle<Class<T>> where T : Java.Lang.Object
    {
        internal static Names Names => Class.Names;

        public unsafe static Class<Class<Java.Lang.Object>> ClassRef => Class.classRef ??= new(Env->Functions->FindClass(Env, Names.MapSignature));

        internal Class(nint handle) : base(handle)
        {}

        public static Class<T> From(nint handle) => new(handle);
    }

    public static partial class Class
    {
        internal static Class<Class<Java.Lang.Object>>? classRef = null;

        internal static Names Names { get; } = ("java.lang.Class", "java/lang/Class", "java.lang.Class", "java/lang/Class");

        public unsafe static Class<Class<Java.Lang.Object>> ClassRef => classRef ??= new(Env->Functions->FindClass(Env, Names.MapSignature));

        [Signature("forName", false)]
        public static partial Class<Java.Lang.Object> ForName(string className);
    }
}
