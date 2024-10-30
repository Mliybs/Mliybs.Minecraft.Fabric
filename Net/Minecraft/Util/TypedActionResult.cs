using System;
using System.Collections.Generic;

namespace Net.Minecraft.Util
{
    public partial class TypedActionResult<T> : Java.Lang.Object, IClassRef, IFromHandle<TypedActionResult<T>> where T : Java.Lang.Object, IClassRef, IFromHandle<T>
    {
        internal static Names Names => TypedActionResult.Names;

        public static Class ClassRef => TypedActionResult.ClassRef;

        [JavaConstructor]
        public TypedActionResult(ActionResult result, T value) : base(TypedActionResult_ActionResultObjectInvoke(result, value))
        {}

        [Signature("method_5466")]
        public partial T GetValue();

        [Signature("method_5467")]
        public partial ActionResult GetResult();
    }

    [MapName("net/minecraft/class_1271")]
    public static partial class TypedActionResult
    {
        [Signature("method_22427")]
        public static partial TypedActionResult<TData> Success<TData>(TData data) where TData : Java.Lang.Object, IClassRef, IFromHandle<TData>;

        [Signature("method_29237")]
        public static partial TypedActionResult<TData> Success<TData>(TData data, bool swingHand) where TData : Java.Lang.Object, IClassRef, IFromHandle<TData>;

        [Signature("method_22428")]
        public static partial TypedActionResult<TData> Consume<TData>(TData data) where TData : Java.Lang.Object, IClassRef, IFromHandle<TData>;

        [Signature("method_22430")]
        public static partial TypedActionResult<TData> Pass<TData>(TData data) where TData : Java.Lang.Object, IClassRef, IFromHandle<TData>;

        [Signature("method_22431")]
        public static partial TypedActionResult<TData> Fail<TData>(TData data) where TData : Java.Lang.Object, IClassRef, IFromHandle<TData>;
    }
}
