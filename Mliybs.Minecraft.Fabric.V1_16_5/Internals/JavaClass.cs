namespace Mliybs.Minecraft.Fabric.V1_16_5.Internals;

public abstract class JavaClass
{
    private IntPtr objectRef = IntPtr.Zero;

    protected unsafe internal IntPtr ObjectRef
    {
        get => objectRef;
        set
        {
            if (objectRef != IntPtr.Zero) Env->Functions->DeleteGlobalRef(Env, objectRef);
            objectRef = NewGlobalRef(value);
        }
    }

    public JavaClass() {}

    public JavaClass(IntPtr handle) => ObjectRef = handle;

    unsafe ~JavaClass()
    {
        ThrowHelper.ThrowIfPtrIsZero(objectRef);
        Env->Functions->DeleteGlobalRef(Env, objectRef);
    }
}