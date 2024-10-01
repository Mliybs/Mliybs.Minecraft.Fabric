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

    internal static nint FindClass(string classSignature) =>
        NewGlobalRef(Env->Functions->FindClass(Env, classSignature));

    internal static nint GetConstructorID(nint classRef, string methodSignature) =>
        Env->Functions->GetMethodID(Env, classRef, "<init>", methodSignature);

    internal static nint GetMethodID(nint classRef, string methodName, string methodSignature) =>
        Env->Functions->GetMethodID(Env, classRef, methodName, methodSignature);

    internal static nint GetStaticMethodID(nint classRef, string methodName, string methodSignature) =>
        Env->Functions->GetStaticMethodID(Env, classRef, methodName, methodSignature);

    internal static nint GetStaticObjectField(nint classRef, string fieldSignature, string type)
    {
        var id = Env->Functions->GetStaticFieldID(Env, classRef, fieldSignature, type);
        return NewGlobalRef(Env->Functions->GetStaticObjectField(Env, classRef, id));
    }

    internal static int GetArrayLength(nint array) => Env->Functions->GetArrayLength(Env, array);

    internal static nint GetObjectArrayElement(nint array, int index) => Env->Functions->GetObjectArrayElement(Env, array, index);

    internal static void SetObjectArrayElement(nint array, int index, nint handle) => Env->Functions->SetObjectArrayElement(Env, array, index, handle);

    public static nint NewString(string text)
    {
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

    public static string GetString(nint @string)
    {
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

    internal static nint NewGlobalRef(nint local)
    {
        var global = Env->Functions->NewGlobalRef(Env, local);
        Env->Functions->DeleteLocalRef(Env, local);
        return global;
    }

    internal static bool IsSameObject(nint handle, nint obj) => Env->Functions->IsSameObject(Env, handle, obj);

    internal static bool ExceptionCheck() => Env->Functions->ExceptionCheck(Env);

    internal static void ExceptionDescribe() => Env->Functions->ExceptionDescribe(Env);

    internal static void ExceptionClear() => Env->Functions->ExceptionClear(Env);

    public static nint GetObjectRef(JavaClass? obj) => obj?.ObjectRef ?? nint.Zero;
}

public static class LoaderExtensions
{
    internal static IHandle AsHandle(this nint handle) => new DefaultHandle(handle);

    internal static IHandle<T> AsHandle<T>(this nint handle) => new DefaultHandle<T>(handle);

    // 在有可能会返回已有对象时，调用该函数
    internal static T ReturnCheck<T>(this T obj, nint handle, [CallerMemberName] string caller = default!) where T : JavaClass, IClassRef, IFromHandle<T>
    {
        if (IsSameObject(obj.ObjectRef, handle)) return obj;
        var global = NewGlobalRef(handle);
        return T.From(global);
    }
}