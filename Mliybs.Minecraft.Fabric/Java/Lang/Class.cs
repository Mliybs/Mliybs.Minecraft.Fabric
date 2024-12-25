using System;
using System.Collections.Generic;

namespace Java.Lang
{
    // 不要动关于ClassRef的代码
    [SuppressJavaClass]
    public partial class Class<T> : JavaObject, IClassRef<Class<T>>, IFromHandle<Class<T>> where T : JavaObject, IClassRef<T>, IFromHandle<T>
    {
        internal static Names Names => Class.Names;

        public unsafe static Class<Class<JavaObject>> ClassRef => Class.classRef ??= new(Env->Functions->FindClass(Env, Names.MapSignature));

        static Class<Class<T>> IClassRef<Class<T>>.ClassRef => Class.Proxy<Class<T>>(ClassRef.ObjectRef);

        internal Class(nint handle) : base(handle)
        {}

        public static Class<T> From(nint handle) => new(handle);
    }

    public static partial class Class
    {
        internal static Class<Class<JavaObject>>? classRef = null;

        internal static Names Names { get; } = ("java.lang.Class", "java/lang/Class", "java.lang.Class", "java/lang/Class");

        public unsafe static Class<Class<JavaObject>> ClassRef => classRef ??= new(Env->Functions->FindClass(Env, Names.MapSignature));

        [Signature("forName", false)]
        public static partial Class<JavaObject> ForName(string className);

        public static Class<T> Proxy<T>(nint handle) where T : JavaObject, IClassRef<T>, IFromHandle<T>
        {
            return new ClassProxy<T>(handle);
        }
    }

    [SuppressJavaClass]
    internal partial class ClassProxy<T> : Class<T> where T : JavaObject, IClassRef<T>, IFromHandle<T>
    {
        internal ClassProxy(nint handle) : base(nint.Zero)
        {
            deleteOnFinalize = false;
            SetObjectRef(handle);
        }
    }
}
