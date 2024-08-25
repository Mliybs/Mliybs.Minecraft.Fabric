using Mliybs.Minecraft.Fabric;

namespace Net.Minecraft.Util.Registry;

public abstract partial class Registry<T> : JavaClass, IClassRef where T : JavaClass, IClassRef
{
    internal static readonly Names Names = MapClassName("net.minecraft.class_2378");

    public static IntPtr ClassRef { get; } = FindClass(Names.MapSignature);

    protected Registry() {}

    public Registry(IntPtr handle) : base(handle) {}
}

public sealed partial class Registry : Registry<InternalClass>
{
    private Registry() => throw new NotSupportedException();

    // Register返回entry自身
    public unsafe static TEntry Register<TRegistry, TEntry>(Registry<TRegistry> registry, string id, TEntry entry) where TRegistry : JavaClass, IClassRef where TEntry : TRegistry
    {
        return entry.ReturnCheck(null, ((Method5Ptr)Env->Functions->CallStaticObjectMethod)(Env, ClassRef, Register_RegistryStringObject, registry.ObjectRef, NewString(id), entry.ObjectRef));
    }
}