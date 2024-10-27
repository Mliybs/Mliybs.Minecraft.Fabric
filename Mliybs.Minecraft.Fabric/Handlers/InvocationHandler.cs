using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mliybs.Minecraft.Fabric.Handlers
{
    internal partial class InvocationHandler : JavaClass, IClassRef, IFromHandle<InvocationHandler>
    {
        public static nint ClassRef { get; } = FindClass("com/mlinetles/nativeloader/wrappers/InvocationHandlerWrapper");

        [Signature("getProxyOf", false)]
        public unsafe static nint GetProxyOf(Class @class, nint handle)
        {
            return ((delegate* unmanaged[Cdecl]<JNIEnv*, nint, nint, nint, nint, nint>)Env->Functions->CallStaticObjectMethod)(Env, ClassRef, GetProxyOf_ClassObject, @class.ObjectRef, handle);
        }
    }
}
