using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Mliybs.Minecraft.Fabric.Wrappers
{
    [MapName("com/mlinetles/nativeloader/wrappers/InvocationHandlerWrapper", false)]
    internal partial class InvocationHandlerWrapper : Java.Lang.Object, IClassRef, IFromHandle<InvocationHandlerWrapper>
    {
        private static readonly ConcurrentBag<Delegate> KeepAlive = new();

        [Signature("getProxyOf", false)]
        private static nint GetProxyOf(Class @class, long handle)
        {
            throw new NotSupportedException();
        }

        public unsafe static nint GetProxyOf<T>(Class @class, T @delegate) where T : Delegate
        {
            JValue* @params = stackalloc JValue[2];
            @params[0].l = @class.ObjectRef;
            @params[1].j = Marshal.GetFunctionPointerForDelegate(@delegate);
            var result = Env->Functions->CallStaticObjectMethodA(Env, ClassRef.ObjectRef, GetProxyOf_ClassLong, @params);
            KeepAlive.Add(@delegate);
            return result;
        }
    }
}
