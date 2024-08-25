using System.Diagnostics.CodeAnalysis;
using Net.Minecraft.Util.Registry;

namespace Mliybs.Minecraft.Fabric.V1_16_5;

public partial class Loader
{
    private unsafe static JavaVM* jvm = null;

    [ThreadStatic]
    private unsafe static JNIEnv* _env;

    public unsafe static JavaVM* JVM => jvm;
    
    public unsafe static JNIEnv* Env
    {
        get
        {
            if (_env == null) JVM->Functions->AttachCurrentThread(JVM, out _env, IntPtr.Zero);
            return _env;
        }
    }

    [NotNull]
    public static MappingResolver? Resolver { get; private set;}

    private unsafe static void Load(nint env, IntPtr resolver)
    {
        // 加载全局JVM，主线程JNIEnv，映射器
        ThrowHelper.ThrowIfPtrIsZero(env);
        _env = (JNIEnv*)env;
        _env->Functions->GetJavaVM(_env, out jvm);
        Resolver = new(resolver);
        // Console.WriteLine(JVM->Functions->AttachCurrentThread(JVM, out _env, IntPtr.Zero));
    }
}
