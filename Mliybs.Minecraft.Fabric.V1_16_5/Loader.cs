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

    [UnmanagedCallersOnly(EntryPoint = nameof(Load))]
    private unsafe static void Load(JNIEnv* env, IntPtr resolver)
    {
        // 加载全局JVM，主线程JNIEnv，映射器
        ThrowHelper.ThrowIfPtrIsNull(env);
        env->Functions->GetJavaVM(env, out jvm);
        _env = env;
        Resolver = new(resolver);
        // Console.WriteLine(JVM->Functions->AttachCurrentThread(JVM, out _env, IntPtr.Zero));
    }
}
