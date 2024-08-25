using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace Mliybs.Minecraft.Fabric.V1_16_5;

public unsafe partial class Loader
{
    public static readonly ConcurrentDictionary<IntPtr, Func<IntPtr, object>> Factories = new(-1, 128);

    /// <summary>
    /// 映射运行时类名
    /// </summary>
    /// <param name="className">使用点格式，如net.minecraft.class_1</param>
    /// <returns></returns>
    internal static Names MapClassName(string className)
    {
        var @string = Resolver.MapClassName("intermediary", className);
        var handle = Env->Functions->GetStringUTFChars(Env, @string, out var isCopy);
        var name = Marshal.PtrToStringUTF8(handle);
        if (isCopy) Env->Functions->ReleaseStringUTFChars(Env, @string, handle);
        ThrowHelper.ThrowIfNull(name);
        return (className, className.Replace('.', '/'), name, name.Replace('.', '/'));
    }

    internal static string MapMethodName(string className, string methodName, string descriptor)
    {
        var @string = Resolver.MapMethodName("intermediary", className, methodName, descriptor);
        var handle = Env->Functions->GetStringUTFChars(Env, @string, out var isCopy);
        var name = Marshal.PtrToStringUTF8(handle);
        if (isCopy) Env->Functions->ReleaseStringUTFChars(Env, @string, handle);
        ThrowHelper.ThrowIfNull(name);
        return name.Replace('.', '/');
    }

    internal static string MapFieldName(string className, string fieldName, string descriptor)
    {
        var @string = Resolver.MapFieldName("intermediary", className, fieldName, descriptor);
        var handle = Env->Functions->GetStringUTFChars(Env, @string, out var isCopy);
        var name = Marshal.PtrToStringUTF8(handle);
        if (isCopy) Env->Functions->ReleaseStringUTFChars(Env, @string, handle);
        ThrowHelper.ThrowIfNull(name);
        return name.Replace('.', '/');
    }

    // DeleteLocalRef的参数为jobject
    // jmethodID与jfieldID不继承自jobject，不需要创建全局引用

    internal static IntPtr FindClass(string classSignature) =>
        NewGlobalRef(Env->Functions->FindClass(Env, classSignature));

    internal static IntPtr GetConstructorID(IntPtr classRef, string methodSignature) =>
        Env->Functions->GetMethodID(Env, classRef, "<init>", methodSignature);

    internal static IntPtr GetMethodID(IntPtr classRef, string methodName, string methodSignature) =>
        Env->Functions->GetMethodID(Env, classRef, methodName, methodSignature);

    internal static IntPtr GetStaticMethodID(IntPtr classRef, string methodName, string methodSignature) =>
        Env->Functions->GetStaticMethodID(Env, classRef, methodName, methodSignature);

    internal static IntPtr GetStaticObjectField(IntPtr classRef, string fieldSignature, string type)
    {
        var id = Env->Functions->GetStaticFieldID(Env, classRef, fieldSignature, type);
        return NewGlobalRef(Env->Functions->GetStaticObjectField(Env, classRef, id));
    }

    public static IntPtr NewString(string text) => Env->Functions->NewStringUTF(Env, text);

    public static IntPtr NewGlobalRef(IntPtr local)
    {
        var global = Env->Functions->NewGlobalRef(Env, local);
        Env->Functions->DeleteLocalRef(Env, local);
        return global;
    }

    public unsafe static bool IsSameObject(IntPtr handle, IntPtr obj) => Env->Functions->IsSameObject(Env, handle, obj);
}

public static class LoaderExtensions
{
    internal static IHandle AsHandle(this IntPtr handle) => new DefaultHandle(handle);

    internal static IHandle<T> AsHandle<T>(this IntPtr handle) => new DefaultHandle<T>(handle);

    // 在有可能会返回已有对象时，调用该函数
    internal static T ReturnCheck<T>(this T obj, Func<IntPtr, T>? factory, IntPtr handle, [CallerMemberName] string caller = default!) where T : JavaClass
    {
        if (IsSameObject(obj.ObjectRef, handle)) return obj;
        ThrowHelper.ThrowIfNull(factory, $"{caller}处缺少构造方法{nameof(factory)}");
        var global = NewGlobalRef(handle);
        return factory.Invoke(global);
    }

    internal static bool IsOverride(this System.Reflection.MethodInfo? info) =>
        info != info?.GetBaseDefinition();
}