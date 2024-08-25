namespace Mliybs.Minecraft.Fabric.V1_16_5.Internals;

internal class StringWrapper(IntPtr handle) : JavaClass(handle), IClassRef
{
    public static IntPtr ClassRef { get; } = FindClass("com/mlinetles/nativeloader/wrappers/StringWrapper");

    internal static readonly IntPtr GetString_ = GetMethodID(ClassRef, "getString", "()Ljava/lang/String;");

    internal static readonly IntPtr SetString_ = GetMethodID(ClassRef, "setString", "(Ljava/lang/String;)V");

    public unsafe IntPtr String
    {
        get
        {
            return ((Method2Ptr)Env->Functions->CallObjectMethod)(Env, ObjectRef, GetString_);
        }

        set
        {
            ((Method3Ptr)Env->Functions->CallObjectMethod)(Env, ObjectRef, SetString_, value);
        }
    }
}