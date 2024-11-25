using System.Diagnostics.CodeAnalysis;

namespace Mliybs.Minecraft.Fabric.Internals;

public abstract class JavaClass : IJavaClass, IEquatable<JavaClass>
{
    private nint objectRef = nint.Zero;

    protected internal unsafe nint ObjectRef
    {
        get => objectRef;
        set
        {
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
        if (objectRef != 0)
            Env->Functions->DeleteGlobalRef(Env, objectRef);
    }

    public bool Is<T>() where T : Java.Lang.Object, IClassRef
    {
        return IsInstanceOf(objectRef, T.ClassRef.objectRef);
    }

    public bool Is<T>([NotNullWhen(true)] out T? obj) where T : Java.Lang.Object, IClassRef, IFromHandle<T>
    {
        if (IsInstanceOf(objectRef, T.ClassRef.objectRef))
        {
            obj = T.From(objectRef);
            return true;
        }
        obj = default;
        return false;
    }

    public bool Is<T>(Predicate<T> predicate, [NotNullWhen(true)] out T? obj) where T : Java.Lang.Object, IClassRef, IFromHandle<T>
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

    public T? As<T>() where T : Java.Lang.Object, IClassRef, IFromHandle<T>
    {
        return IsInstanceOf(objectRef, T.ClassRef.objectRef) ? T.From(objectRef) : default;
    }

    [return: NotNull]
    public T To<T>() where T : Java.Lang.Object, IClassRef, IFromHandle<T> =>
        As<T>() ?? throw new InvalidCastException();

    public bool InstanceOf<T>() where T : Java.Lang.Object, IClassRef, IFromHandle<T> =>
        Is<T>();

    public static bool operator ==(JavaClass x, JavaClass y)
    {
        if ((x?.IsNull ?? true) || (y?.IsNull ?? true))
            if ((x?.IsNull ?? true) && (y?.IsNull ?? true)) return true;
            else return false;

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

public interface IJavaClass
{
    protected internal nint ObjectRef { get; set; }
}