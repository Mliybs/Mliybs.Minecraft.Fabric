namespace Net.FabricMC.Loader.Api;

public partial class MappingResolver : JavaObject, IClassRef<MappingResolver>, IFromHandle<MappingResolver>
{
    public static Class<MappingResolver> ClassRef { get; } = FindClass<MappingResolver>("net/fabricmc/loader/api/MappingResolver");

    internal static readonly nint MapClassName_ = GetMethodID(ClassRef.ObjectRef, "mapClassName", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");

    internal static readonly nint MapMethodName_ = GetMethodID(ClassRef.ObjectRef, "mapMethodName", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");

    internal static readonly nint MapFieldName_ = GetMethodID(ClassRef.ObjectRef, "mapFieldName", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");

    public unsafe nint MapClassName(string @namespace, string className) =>
        ((Method4Ptr)Env->Functions->CallObjectMethod)(Env, ObjectRef, MapClassName_, NewString(@namespace), NewString(className));

    public unsafe nint MapClassName(ReadOnlySpan<byte> @namespace, string className) =>
        ((Method4Ptr)Env->Functions->CallObjectMethod)(Env, ObjectRef, MapClassName_, NewString(@namespace), NewString(className));

    public unsafe nint MapMethodName(string @namespace, string owner, string name, string descriptor) =>
        ((Method6Ptr)Env->Functions->CallObjectMethod)(Env, ObjectRef, MapMethodName_, NewString(@namespace), NewString(owner), NewString(name), NewString(descriptor));

    public unsafe nint MapMethodName(ReadOnlySpan<byte> @namespace, string owner, string name, string descriptor) =>
        ((Method6Ptr)Env->Functions->CallObjectMethod)(Env, ObjectRef, MapMethodName_, NewString(@namespace), NewString(owner), NewString(name), NewString(descriptor));

    public unsafe nint MapFieldName(string @namespace, string owner, string name, string descriptor) =>
        ((Method6Ptr)Env->Functions->CallObjectMethod)(Env, ObjectRef, MapFieldName_, NewString(@namespace), NewString(owner), NewString(name), NewString(descriptor));

    public unsafe nint MapFieldName(ReadOnlySpan<byte> @namespace, string owner, string name, string descriptor) =>
        ((Method6Ptr)Env->Functions->CallObjectMethod)(Env, ObjectRef, MapFieldName_, NewString(@namespace), NewString(owner), NewString(name), NewString(descriptor));
}
