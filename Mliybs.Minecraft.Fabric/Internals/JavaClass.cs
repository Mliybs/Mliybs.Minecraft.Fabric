namespace Mliybs.Minecraft.Fabric.Internals;

public abstract class JavaClass : IEquatable<JavaClass>
{
    private nint objectRef = nint.Zero;

    protected internal unsafe nint ObjectRef
    {
        get => objectRef;
        set
        {
            if (objectRef != nint.Zero) Env->Functions->DeleteGlobalRef(Env, objectRef);
            objectRef = NewGlobalRef(value);
        }
    }

    public bool IsNull => objectRef == nint.Zero;

    public JavaClass() {}

    public JavaClass(nint handle) => ObjectRef = handle;

    unsafe ~JavaClass()
    {
        if (objectRef != 0)
            Env->Functions->DeleteGlobalRef(Env, objectRef);
    }

    public static bool operator ==(JavaClass x, JavaClass y)
    {
        if (x is null || y is null)
            if (x is null && y is null) return true;
            else return false;

        else
            if (x.objectRef == nint.Zero)
                if (y.objectRef == nint.Zero) return true;
                else return false;

            else
                if (y.objectRef == nint.Zero) return false;
                else return IsSameObject(x.objectRef, y.objectRef);
    }

    public static bool operator !=(JavaClass x, JavaClass y) => !(x == y);

    public bool Equals(JavaClass? obj)
    {
        if (obj is not null) return this == obj;
        return objectRef == nint.Zero;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) return objectRef == nint.Zero;
        if (obj is JavaClass @class) return this == @class;
        return false;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}