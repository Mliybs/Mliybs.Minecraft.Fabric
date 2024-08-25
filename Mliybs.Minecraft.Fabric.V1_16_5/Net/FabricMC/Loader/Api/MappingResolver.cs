namespace Net.FabricMC.Loader.Api;

public class MappingResolver(IntPtr handle) : JavaClass(handle), IClassRef
{
    public static IntPtr ClassRef { get; } = FindClass("net/fabricmc/loader/api/MappingResolver");

    internal static readonly IntPtr MapClassName_ = GetMethodID(ClassRef, "mapClassName", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");

    internal static readonly IntPtr MapMethodName_ = GetMethodID(ClassRef, "mapMethodName", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");

    internal static readonly IntPtr MapFieldName_ = GetMethodID(ClassRef, "mapFieldName", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");

    public unsafe IntPtr MapClassName(string @namespace, string className) =>
        ((Method4Ptr)Env->Functions->CallObjectMethod)(Env, ObjectRef, MapClassName_, NewString(@namespace), NewString(className));
    
    public unsafe IntPtr MapMethodName(string @namespace, string owner, string name, string descriptor) =>
        ((Method6Ptr)Env->Functions->CallObjectMethod)(Env, ObjectRef, MapMethodName_, NewString(@namespace), NewString(owner), NewString(name), NewString(descriptor));
    
    public unsafe IntPtr MapFieldName(string @namespace, string owner, string name, string descriptor) =>
        ((Method6Ptr)Env->Functions->CallObjectMethod)(Env, ObjectRef, MapFieldName_, NewString(@namespace), NewString(owner), NewString(name), NewString(descriptor));
}