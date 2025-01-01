using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
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
        var name = GetString(Resolver.MapClassName("intermediary", className));
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
        var name = GetString(Resolver.MapMethodName("intermediary", className, methodName, descriptor));
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
        var name = GetString(Resolver.MapFieldName("intermediary", className, fieldName, descriptor));
        ThrowHelper.ThrowIfNull(name);
        return name.Replace('.', '/');
    }

    // DeleteLocalRef的参数为jobject
    // jmethodID与jfieldID不继承自jobject，不需要创建全局引用
    // 因为对于类和方法签名来说只会出现ASCII字符，所以可以直接使用.NET的自动封送
    // 直接使用中文会乱码

    internal static Class<T> FindClass<T>(string classSignature) where T : JavaObject, IClassRef<T>, IFromHandle<T> =>
        new(Env->Functions->FindClass(Env, classSignature));

    internal static nint GetConstructorID(nint classRef, string methodSignature) =>
        Env->Functions->GetMethodID(Env, classRef, "<init>", methodSignature);

    internal static nint GetMethodID(nint classRef, string methodName, string methodSignature) =>
        Env->Functions->GetMethodID(Env, classRef, methodName, methodSignature);

    internal static nint GetFieldID(nint classRef, string fieldName, string fieldSignature) =>
        Env->Functions->GetFieldID(Env, classRef, fieldName, fieldSignature);

    internal static nint GetStaticMethodID(nint classRef, string methodName, string methodSignature) =>
        Env->Functions->GetStaticMethodID(Env, classRef, methodName, methodSignature);

    internal static nint GetStaticObjectField(nint classRef, string fieldSignature, string type)
    {
        var id = Env->Functions->GetStaticFieldID(Env, classRef, fieldSignature, type);
        return NewGlobalRef(Env->Functions->GetStaticObjectField(Env, classRef, id));
    }

    internal static int GetStaticIntField(nint classRef, string fieldSignature, string type)
    {
        var id = Env->Functions->GetStaticFieldID(Env, classRef, fieldSignature, type);
        return Env->Functions->GetStaticIntField(Env, classRef, id);
    }

    internal static short GetStaticShortField(nint classRef, string fieldSignature, string type)
    {
        var id = Env->Functions->GetStaticFieldID(Env, classRef, fieldSignature, type);
        return Env->Functions->GetStaticShortField(Env, classRef, id);
    }

    internal static long GetStaticLongField(nint classRef, string fieldSignature, string type)
    {
        var id = Env->Functions->GetStaticFieldID(Env, classRef, fieldSignature, type);
        return Env->Functions->GetStaticLongField(Env, classRef, id);
    }

    internal static sbyte GetStaticByteField(nint classRef, string fieldSignature, string type)
    {
        var id = Env->Functions->GetStaticFieldID(Env, classRef, fieldSignature, type);
        return Env->Functions->GetStaticByteField(Env, classRef, id);
    }

    internal static bool GetStaticBooleanField(nint classRef, string fieldSignature, string type)
    {
        var id = Env->Functions->GetStaticFieldID(Env, classRef, fieldSignature, type);
        return Env->Functions->GetStaticBooleanField(Env, classRef, id);
    }

    internal static char GetStaticCharField(nint classRef, string fieldSignature, string type)
    {
        var id = Env->Functions->GetStaticFieldID(Env, classRef, fieldSignature, type);
        return Env->Functions->GetStaticCharField(Env, classRef, id);
    }

    internal static float GetStaticFloatField(nint classRef, string fieldSignature, string type)
    {
        var id = Env->Functions->GetStaticFieldID(Env, classRef, fieldSignature, type);
        return Env->Functions->GetStaticFloatField(Env, classRef, id);
    }

    internal static double GetStaticDoubleField(nint classRef, string fieldSignature, string type)
    {
        var id = Env->Functions->GetStaticFieldID(Env, classRef, fieldSignature, type);
        return Env->Functions->GetStaticDoubleField(Env, classRef, id);
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
        if (isCopy) Env->Functions->ReleaseStringChars(Env, @string, chars);
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

    internal static bool IsSameObject(nint handle, nint obj) => Env->Functions->IsSameObject(Env, handle, obj);

    internal static nint GetObjectClass(nint handle) => Env->Functions->GetObjectClass(Env, handle);

    internal static bool IsInstanceOf(nint handle, nint @class) => Env->Functions->IsInstanceOf(Env, handle, @class);

    internal static bool ExceptionCheck() => Env->Functions->ExceptionCheck(Env);

    internal static void ExceptionDescribe() => Env->Functions->ExceptionDescribe(Env);

    internal static void ExceptionClear() => Env->Functions->ExceptionClear(Env);

    internal static T From<T>(nint handle) where T : IFromHandle<T> => T.From(handle);

    public static nint GetObjectRef(JavaClass? obj) => obj?.ObjectRef ?? nint.Zero;
}

public static class LoaderExtensions
{
    internal static IHandle AsHandle(this nint handle) => new DefaultHandle(handle);

    internal static IHandle<T> AsHandle<T>(this nint handle) => new DefaultHandle<T>(handle);

    // 在有可能会返回已有对象时，调用该函数
    internal static T ReturnCheck<T>(this T obj, nint handle, [CallerMemberName] string caller = default!) where T : JavaObject, IFromHandle<T>
    {
        if (IsSameObject(obj.ObjectRef, handle)) return obj;
        var global = NewGlobalRef(handle);
        return T.From(global);
    }

    public static T? Nullable<T>(this T obj) where T : JavaObject
    {
        if (obj?.IsNull ?? true) return null;
        return obj;
    }
}