using System.Diagnostics.CodeAnalysis;

namespace Mliybs.Minecraft.Fabric.Internals;

public abstract class JavaClass : IJavaClass, IEquatable<JavaClass>
{
    private nint objectRef = nint.Zero;

    private protected bool deleteOnFinalize = true;

    private protected bool disposed = false;

    private protected void SetObjectRef(nint handle) => objectRef = handle;

    internal unsafe nint ObjectRef
    {
        get => disposed ? throw new ObjectDisposedException(GetType().Name) : objectRef;
        set
        {
            if (disposed) throw new ObjectDisposedException(GetType().Name);
            if (objectRef != nint.Zero) Env->Functions->DeleteGlobalRef(Env, objectRef);
            if (value != nint.Zero) objectRef = NewGlobalRef(value);
            else objectRef = value;
        }
    }

    nint IJavaClass.ObjectRef
    {
        get => ObjectRef;
        set => ObjectRef = value;
    }

    public bool IsNull => objectRef == nint.Zero;

    public JavaClass() {}

    public JavaClass(nint handle) => ObjectRef = handle;

    unsafe ~JavaClass()
    {
        if (objectRef != 0 && deleteOnFinalize)
            Env->Functions->DeleteGlobalRef(Env, objectRef);
    }

    public bool Is<T>() where T : JavaObject, IClassRef<T>, IFromHandle<T>
    {
        return IsInstanceOf(objectRef, T.ClassRef.objectRef);
    }

    public bool Is<T>([NotNullWhen(true)] out T? obj) where T : JavaObject, IClassRef<T>, IFromHandle<T>
    {
        if (IsInstanceOf(objectRef, T.ClassRef.objectRef))
        {
            obj = T.From(objectRef);
            return true;
        }
        obj = default;
        return false;
    }

    public bool Is<T>(Predicate<T> predicate, [NotNullWhen(true)] out T? obj) where T : JavaObject, IClassRef<T>, IFromHandle<T>
    {
        if (IsInstanceOf(objectRef, T.ClassRef.objectRef))
        {
            var result = T.From(objectRef);
            if (predicate.Invoke(result))
            {
                obj = result;
                return true;
            }
        }
        obj = default;
        return false;
    }

    public T? As<T>() where T : JavaObject, IClassRef<T>, IFromHandle<T>
    {
        return IsInstanceOf(objectRef, T.ClassRef.objectRef) ? T.From(objectRef) : default;
    }

    [return: NotNull]
    public T To<T>() where T : JavaObject, IClassRef<T>, IFromHandle<T> =>
        As<T>() ?? throw new InvalidCastException();

    public bool InstanceOf<T>() where T : JavaObject, IClassRef<T>, IFromHandle<T> =>
        Is<T>();

    public static bool operator ==(JavaClass x, JavaClass y)
    {
        var xIsNull = x?.IsNull ?? true;

        var yIsNull = y?.IsNull ?? true;

        if (xIsNull || yIsNull)
            if (xIsNull && yIsNull) return true;
            else return false;

        else return IsSameObject(x!.objectRef, y!.objectRef);
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
        if (this is JavaObject obj) return obj.HashCode();
        return base.GetHashCode();
    }
}

public interface IJavaClass
{
    internal nint ObjectRef { get; set; }
}