using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Mliybs.Minecraft.Fabric.Wrappers
{
    [MapName("com/mlinetles/nativeloader/wrappers/InvocationHandlerWrapper", false)]
    internal partial class InvocationHandlerWrapper : JavaObject, IClassRef<InvocationHandlerWrapper>, IFromHandle<InvocationHandlerWrapper>
    {
        private static int _id = 0;

        private static readonly ConcurrentDictionary<int, Delegate> KeepAlive = new(-1, 16);

        [Signature("getProxyOf", false)]
        private static nint GetProxyOf<T>(Class<T> @class, long handle, int id) where T : JavaObject, IClassRef<T>, IFromHandle<T>
        {
            throw new NotSupportedException();
        }

        public unsafe static nint GetProxyOf<T, K>(Class<K> @class, T? @delegate) where T : Delegate where K : JavaObject, IClassRef<K>, IFromHandle<K>
        {
            var id = Interlocked.Increment(ref _id);
            JValue* @params = stackalloc JValue[3];
            @params[0].l = @class.ObjectRef;
            @params[1].j = @delegate is null ? nint.Zero : Marshal.GetFunctionPointerForDelegate(@delegate);
            @params[2].i = id;
            var result = Env->Functions->CallStaticObjectMethodA(Env, ClassRef.ObjectRef, GetProxyOf_ClassLongInt, @params);
            if (@delegate is not null) KeepAlive.TryAdd(id, @delegate);
            return result;
        }

        [Signature("setOnFinalize", false)]
        private static partial void SetOnFinalize(long handle);

        private static void OnFinalize(int id)
        {
            KeepAlive.TryRemove(id, out _);
        }

        private static void OnFinalizeInitialize()
        {
            SetOnFinalize(Marshal.GetFunctionPointerForDelegate<WrapperStatics.IntVoidDelegate>(OnFinalize));
        }
    }
}
