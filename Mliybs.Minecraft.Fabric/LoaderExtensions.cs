using System.Text;

namespace Mliybs.Minecraft.Fabric;

unsafe partial class Loader
{
    /// <summary>
    /// 映射运行时类名
    /// </summary>
    /// <param name="className">使用点格式，如net.minecraft.class_1</param>
    /// <returns></returns>
    internal static Names MapClassName(string className)
    {
        var name = Resolver.MapClassName("intermediary", className);
        ThrowHelper.ThrowIfNull(name);
        return (className, className.Replace('.', '/'), name, name.Replace('.', '/'));
    }

    /// <summary>
    /// 映射运行时方法名
    /// </summary>
    /// <param name="className">使用Names.OriginName</param>
    /// <param name="methodName"></param>
    /// <param name="descriptor">使用Names.OriginSignature</param>
    /// <returns></returns>
    internal static string MapMethodName(string className, string methodName, string descriptor)
    {
        var name = Resolver.MapMethodName("intermediary", className, methodName, descriptor);
        ThrowHelper.ThrowIfNull(name);
        return name.Replace('.', '/');
    }

    /// <summary>
    /// 映射运行时字段名
    /// </summary>
    /// <param name="className">使用Names.OriginName</param>
    /// <param name="fieldName"></param>
    /// <param name="descriptor">使用Names.OriginSignature</param>
    /// <returns></returns>
    internal static string MapFieldName(string className, string fieldName, string descriptor)
    {
        var name = Resolver.MapFieldName("intermediary", className, fieldName, descriptor);
        ThrowHelper.ThrowIfNull(name);
        return name.Replace('.', '/');
    }

    // DeleteLocalRef的参数为jobject
    // jmethodID与jfieldID不继承自jobject，不需要创建全局引用
    // stackalloc加一的意义为NULL结尾的字符串
    // UTF8字面量结尾会额外有一个NULL（不在Span内）

    internal static Class<T> FindClass<T>(string classSignature) where T : JavaObject, IClassRef<T>, IFromHandle<T>
    {
        Span<byte> span = stackalloc byte[Encoding.UTF8.GetByteCount(classSignature) + 1];
        Encoding.UTF8.GetBytes(classSignature, span);
        fixed (byte* bytes = span)
        return new(Env->Functions->FindClass(Env, bytes));
    }

    internal static nint GetConstructorID(nint classRef, string methodSignature)
    {
        Span<byte> bytes = stackalloc byte[Encoding.UTF8.GetByteCount(methodSignature) + 1];
        Encoding.UTF8.GetBytes(methodSignature, bytes);
        fixed (byte* init = "<init>"u8)
        fixed (byte* sig = bytes)
        return Env->Functions->GetMethodID(Env, classRef, init, sig);
    }

    internal static nint GetMethodID(nint classRef, string methodName, string methodSignature)
    {
        Span<byte> nameSpan = stackalloc byte[Encoding.UTF8.GetByteCount(methodName) + 1];
        Span<byte> sigSpan = stackalloc byte[Encoding.UTF8.GetByteCount(methodSignature) + 1];
        Encoding.UTF8.GetBytes(methodName, nameSpan);
        Encoding.UTF8.GetBytes(methodSignature, sigSpan);
        fixed (byte* name = nameSpan)
        fixed (byte* sig = sigSpan)
        return Env->Functions->GetMethodID(Env, classRef, name, sig);
    }

    internal static nint GetFieldID(nint classRef, string fieldName, string fieldSignature)
    {
        Span<byte> nameSpan = stackalloc byte[Encoding.UTF8.GetByteCount(fieldName) + 1];
        Span<byte> sigSpan = stackalloc byte[Encoding.UTF8.GetByteCount(fieldSignature) + 1];
        Encoding.UTF8.GetBytes(fieldName, nameSpan);
        Encoding.UTF8.GetBytes(fieldSignature, sigSpan);
        fixed (byte* name = nameSpan)
        fixed (byte* sig = sigSpan)
        return Env->Functions->GetFieldID(Env, classRef, name, sig);
    }

    internal static nint GetStaticMethodID(nint classRef, string methodName, string methodSignature)
    {
        Span<byte> nameSpan = stackalloc byte[Encoding.UTF8.GetByteCount(methodName) + 1];
        Span<byte> sigSpan = stackalloc byte[Encoding.UTF8.GetByteCount(methodSignature) + 1];
        Encoding.UTF8.GetBytes(methodName, nameSpan);
        Encoding.UTF8.GetBytes(methodSignature, sigSpan);
        fixed (byte* name = nameSpan)
        fixed (byte* sig = sigSpan)
        return Env->Functions->GetStaticMethodID(Env, classRef, name, sig);
    }

    internal static nint GetStaticObjectField(nint classRef, string fieldSignature, string type)
    {
        Span<byte> sigSpan = stackalloc byte[Encoding.UTF8.GetByteCount(fieldSignature) + 1];
        Span<byte> typeSpan = stackalloc byte[Encoding.UTF8.GetByteCount(type) + 1];
        Encoding.UTF8.GetBytes(fieldSignature, sigSpan);
        Encoding.UTF8.GetBytes(type, typeSpan);
        fixed (byte* sig = sigSpan)
        fixed (byte* typePtr = typeSpan)
        {
            var id = Env->Functions->GetStaticFieldID(Env, classRef, sig, typePtr);
            return NewGlobalRef(Env->Functions->GetStaticObjectField(Env, classRef, id));
        }
    }

    internal static int GetStaticIntField(nint classRef, string fieldSignature, string type)
    {
        Span<byte> sigSpan = stackalloc byte[Encoding.UTF8.GetByteCount(fieldSignature) + 1];
        Span<byte> typeSpan = stackalloc byte[Encoding.UTF8.GetByteCount(type) + 1];
        Encoding.UTF8.GetBytes(fieldSignature, sigSpan);
        Encoding.UTF8.GetBytes(type, typeSpan);
        fixed (byte* sig = sigSpan)
        fixed (byte* typePtr = typeSpan)
        {
            var id = Env->Functions->GetStaticFieldID(Env, classRef, sig, typePtr);
            return Env->Functions->GetStaticIntField(Env, classRef, id);
        }
    }

    internal static short GetStaticShortField(nint classRef, string fieldSignature, string type)
    {
        Span<byte> sigSpan = stackalloc byte[Encoding.UTF8.GetByteCount(fieldSignature) + 1];
        Span<byte> typeSpan = stackalloc byte[Encoding.UTF8.GetByteCount(type) + 1];
        Encoding.UTF8.GetBytes(fieldSignature, sigSpan);
        Encoding.UTF8.GetBytes(type, typeSpan);
        fixed (byte* sig = sigSpan)
        fixed (byte* typePtr = typeSpan)
        {
            var id = Env->Functions->GetStaticFieldID(Env, classRef, sig, typePtr);
            return Env->Functions->GetStaticShortField(Env, classRef, id);
        }
    }

    internal static long GetStaticLongField(nint classRef, string fieldSignature, string type)
    {
        Span<byte> sigSpan = stackalloc byte[Encoding.UTF8.GetByteCount(fieldSignature) + 1];
        Span<byte> typeSpan = stackalloc byte[Encoding.UTF8.GetByteCount(type) + 1];
        Encoding.UTF8.GetBytes(fieldSignature, sigSpan);
        Encoding.UTF8.GetBytes(type, typeSpan);
        fixed (byte* sig = sigSpan)
        fixed (byte* typePtr = typeSpan)
        {
            var id = Env->Functions->GetStaticFieldID(Env, classRef, sig, typePtr);
            return Env->Functions->GetStaticLongField(Env, classRef, id);
        }
    }

    internal static sbyte GetStaticByteField(nint classRef, string fieldSignature, string type)
    {
        Span<byte> sigSpan = stackalloc byte[Encoding.UTF8.GetByteCount(fieldSignature) + 1];
        Span<byte> typeSpan = stackalloc byte[Encoding.UTF8.GetByteCount(type) + 1];
        Encoding.UTF8.GetBytes(fieldSignature, sigSpan);
        Encoding.UTF8.GetBytes(type, typeSpan);
        fixed (byte* sig = sigSpan)
        fixed (byte* typePtr = typeSpan)
        {
            var id = Env->Functions->GetStaticFieldID(Env, classRef, sig, typePtr);
            return Env->Functions->GetStaticByteField(Env, classRef, id);
        }
    }

    internal static bool GetStaticBooleanField(nint classRef, string fieldSignature, string type)
    {
        Span<byte> sigSpan = stackalloc byte[Encoding.UTF8.GetByteCount(fieldSignature) + 1];
        Span<byte> typeSpan = stackalloc byte[Encoding.UTF8.GetByteCount(type) + 1];
        Encoding.UTF8.GetBytes(fieldSignature, sigSpan);
        Encoding.UTF8.GetBytes(type, typeSpan);
        fixed (byte* sig = sigSpan)
        fixed (byte* typePtr = typeSpan)
        {
            var id = Env->Functions->GetStaticFieldID(Env, classRef, sig, typePtr);
            return Env->Functions->GetStaticBooleanField(Env, classRef, id).Boolean();
        }
    }

    internal static char GetStaticCharField(nint classRef, string fieldSignature, string type)
    {

        Span<byte> sigSpan = stackalloc byte[Encoding.UTF8.GetByteCount(fieldSignature) + 1];
        Span<byte> typeSpan = stackalloc byte[Encoding.UTF8.GetByteCount(type) + 1];
        Encoding.UTF8.GetBytes(fieldSignature, sigSpan);
        Encoding.UTF8.GetBytes(type, typeSpan);
        fixed (byte* sig = sigSpan)
        fixed (byte* typePtr = typeSpan)
        {
            var id = Env->Functions->GetStaticFieldID(Env, classRef, sig, typePtr);
            return Env->Functions->GetStaticCharField(Env, classRef, id);
        }
    }

    internal static float GetStaticFloatField(nint classRef, string fieldSignature, string type)
    {
        Span<byte> sigSpan = stackalloc byte[Encoding.UTF8.GetByteCount(fieldSignature) + 1];
        Span<byte> typeSpan = stackalloc byte[Encoding.UTF8.GetByteCount(type) + 1];
        Encoding.UTF8.GetBytes(fieldSignature, sigSpan);
        Encoding.UTF8.GetBytes(type, typeSpan);
        fixed (byte* sig = sigSpan)
        fixed (byte* typePtr = typeSpan)
        {
            var id = Env->Functions->GetStaticFieldID(Env, classRef, sig, typePtr);
            return Env->Functions->GetStaticFloatField(Env, classRef, id);
        }
    }

    internal static double GetStaticDoubleField(nint classRef, string fieldSignature, string type)
    {
        Span<byte> sigSpan = stackalloc byte[Encoding.UTF8.GetByteCount(fieldSignature) + 1];
        Span<byte> typeSpan = stackalloc byte[Encoding.UTF8.GetByteCount(type) + 1];
        Encoding.UTF8.GetBytes(fieldSignature, sigSpan);
        Encoding.UTF8.GetBytes(type, typeSpan);
        fixed (byte* sig = sigSpan)
        fixed (byte* typePtr = typeSpan)
        {
            var id = Env->Functions->GetStaticFieldID(Env, classRef, sig, typePtr);
            return Env->Functions->GetStaticDoubleField(Env, classRef, id);
        }
    }

    internal static int GetArrayLength(nint array) => Env->Functions->GetArrayLength(Env, array);

    internal static nint GetObjectArrayElement(nint array, int index) => Env->Functions->GetObjectArrayElement(Env, array, index);

    internal static void SetObjectArrayElement(nint array, int index, nint handle) => Env->Functions->SetObjectArrayElement(Env, array, index, handle);

    internal static nint NewObjectArray(int length, nint @class, nint initObject = 0) => Env->Functions->NewObjectArray(Env, length, @class, initObject);

    public static nint NewString(string? text)
    {
        if (text is null) return nint.Zero;
        fixed (char* chars = text)
        {
            return Env->Functions->NewString(Env, chars, text.Length);
        }
    }

    public static nint NewString(ReadOnlySpan<byte> text)
    {
        fixed (byte* handle = text)
        {
            return Env->Functions->NewStringUTF(Env, handle);
        }
    }

    public static string GetString(nint @string, bool isUtf8 = false)
    {
        if (@string == nint.Zero) return null!;
        if (isUtf8) return GetString((byte*)@string);
        var chars = Env->Functions->GetStringChars(Env, @string, out var isCopy);
        var result = new string(chars);
        if (isCopy.Boolean()) Env->Functions->ReleaseStringChars(Env, @string, chars);
        return result;
    }

    public static string GetString(byte* @string)
    {
        var span = MemoryMarshal.CreateReadOnlySpanFromNullTerminated(@string);
        return Encoding.UTF8.GetString(span);
    }

    public static string GetString(char* @string)
    {
        var span = MemoryMarshal.CreateReadOnlySpanFromNullTerminated(@string);
        return new string(span);
    }

    /// <summary>
    /// 根据局部引用创建全局引用
    /// 经此函数调用后的局部引用会被删除，切记不要在JavaClass的子类构造函数中使用外部参数传入的局部引用！
    /// </summary>
    /// <param name="local"></param>
    /// <returns></returns>
    internal static nint NewGlobalRef(nint local)
    {
        var global = Env->Functions->NewGlobalRef(Env, local);
        Env->Functions->DeleteLocalRef(Env, local);
        return global;
    }

    internal static bool IsSameObject(nint handle, nint obj) => Env->Functions->IsSameObject(Env, handle, obj).Boolean();

    internal static nint GetObjectClass(nint handle) => Env->Functions->GetObjectClass(Env, handle);

    internal static bool IsInstanceOf(nint handle, nint @class) => Env->Functions->IsInstanceOf(Env, handle, @class).Boolean();

    internal static void ExceptionCheck()
    {
        if (Env->Functions->ExceptionCheck(Env).Boolean())
        {
            var e = Env->Functions->ExceptionOccurred(Env);
            ExceptionClear();
            throw new JavaException(new(e));
        }
    }

    internal static void ExceptionClear() => Env->Functions->ExceptionClear(Env);

    internal static T From<T>(nint handle) where T : IFromHandle<T> => T.From(handle);

    public static nint GetObjectRef(JavaClass? obj) => obj?.ObjectRef ?? nint.Zero;

    public const byte TRUE = 1;

    public const byte FALSE = 0;
}

public static class LoaderExtensions
{
    internal static IHandle AsHandle(this nint handle) => new DefaultHandle(handle);

    internal static IHandle<T> AsHandle<T>(this nint handle) => new DefaultHandle<T>(handle);

    // 在有可能会返回已有对象时，调用该函数
    internal static T ReturnCheck<T>(this T obj, nint handle) where T : JavaObject, IFromHandle<T>
    {
        if (IsSameObject(obj?.ObjectRef ?? nint.Zero, handle)) return obj!;
        return T.From(handle);
    }

    public static T? Nullable<T>(this T obj) where T : JavaObject
    {
        if (obj?.IsNull ?? true) return null;
        return obj;
    }

    public static byte Boolean(this bool value) => value ? TRUE : FALSE;

    public static bool Boolean(this byte value) => value != 0;
}