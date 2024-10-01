using System;
using System.Collections.Generic;

namespace Net.Minecraft.Util
{
    [MapName("net/minecraft/class_1271")]
    public partial class TypedActionResult<T> : JavaClass, IClassRef, IFromHandle<TypedActionResult<T>> where T : JavaClass, IClassRef, IFromHandle<T>
    {
        [JavaConstructor]
        public TypedActionResult(ActionResult result, T value)
        {
            TypedActionResult_ActionResultObjectInvoke(result, value);
        }

        [Signature("method_5466")]
        public partial T GetValue();

        [Signature("method_5467")]
        public partial ActionResult GetResult();
    }

    public sealed partial class TypedActionResult : TypedActionResult<InternalClass>
    {
        [Signature("method_22427")]
        public static partial TypedActionResult<TData> Success<TData>(TData data) where TData : JavaClass, IClassRef, IFromHandle<TData>;

        [Signature("method_29237")]
        public static partial TypedActionResult<TData> Success<TData>(TData data, bool swingHand) where TData : JavaClass, IClassRef, IFromHandle<TData>;

        [Signature("method_22428")]
        public static partial TypedActionResult<TData> Consume<TData>(TData data) where TData : JavaClass, IClassRef, IFromHandle<TData>;

        [Signature("method_22430")]
        public static partial TypedActionResult<TData> Pass<TData>(TData data) where TData : JavaClass, IClassRef, IFromHandle<TData>;

        [Signature("method_22431")]
        public static partial TypedActionResult<TData> Fail<TData>(TData data) where TData : JavaClass, IClassRef, IFromHandle<TData>;
    }
}
