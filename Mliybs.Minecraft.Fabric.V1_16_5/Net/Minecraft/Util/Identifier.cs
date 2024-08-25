namespace Net.Minecraft.Util;

public class Identifier : JavaClass, IClassRef
{
    internal static readonly Names Names = MapClassName("net.minecraft.class_2960");

    public static IntPtr ClassRef { get; } = FindClass(Names.MapSignature);

    public static IntPtr[] Constructors { get; } = [GetConstructorID(ClassRef, "(Ljava/lang/String;)V"),
        GetConstructorID(ClassRef, "(Ljava/lang/String;Ljava/lang/String;)V")];

    public unsafe Identifier(string id)
    {
        ObjectRef = ((Method3Ptr)Env->Functions->NewObject)(Env, ClassRef, Constructors[0], NewString(id));
    }

    public unsafe Identifier(string @namespace, string path)
    {
        ObjectRef = ((Method4Ptr)Env->Functions->NewObject)(Env, ClassRef, Constructors[0], NewString(@namespace), NewString(path));
    }
}