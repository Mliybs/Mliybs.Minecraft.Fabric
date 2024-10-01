using Org.Apache.Logging.Log4j;
using System.Diagnostics.CodeAnalysis;

namespace Mliybs.Minecraft.Fabric;

public static partial class Loader
{
    private unsafe static JavaVM* jvm = null;

    [ThreadStatic]
    private unsafe static JNIEnv* _env;

    internal unsafe static JavaVM* JVM => jvm;
    
    internal unsafe static JNIEnv* Env
    {
        get
        {
            if (_env == null) JVM->Functions->AttachCurrentThread(JVM, out _env, nint.Zero);
            return _env;
        }
    }

    [NotNull]
    internal static MappingResolver? Resolver { get; private set;}

    [NotNull]
    public static Logger? Logger { get; private set; }

    internal unsafe static void Load(nint env, nint resolver, nint logger)
    {
        // 加载全局JVM，主线程JNIEnv，映射器
        ThrowHelper.ThrowIfPtrIsZero(env);
        _env = (JNIEnv*)env;
        _env->Functions->GetJavaVM(_env, out jvm);
        Resolver = new(resolver);
        Logger = new(logger);
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Console.WriteLine(JVM->Functions->AttachCurrentThread(JVM, out _env, nint.Zero));
    }
}

public sealed class UnsafeAccessorLoader
{
    private UnsafeAccessorLoader() => throw new NotSupportedException();

    private static void Load(nint env, nint resolver, nint logger) => Loader.Load(env, resolver, logger);
}
