using Mliybs.Minecraft.Fabric.Handlers;
using System.Diagnostics.CodeAnalysis;

namespace Net.Minecraft.Item;

partial class Item : IWrapper<Item>
{
    public static nint WrapperClassRef { get; } = FindClass("com/mlinetles/nativeloader/wrappers/ItemWrapper");

    public static nint WrapperConstructor { get; } = GetConstructorID(WrapperClassRef, $"(L{Settings.Names.MapSignature};J)V");

    [JavaConstructor]
    public unsafe Item(Settings settings)
    {
        if (TryGetWrapper(out var wrapper))
        {
            ObjectRef = ((Method4Ptr)Env->Functions->NewObject)(Env, WrapperClassRef, WrapperConstructor, settings.ObjectRef, (nint)(&wrapper));
        }

        else
        {
            Item_SettingsInvoke(settings);
        }
    }

    /// <summary>
    /// 该方法由源生成器自动生成，请勿覆写此方法！
    /// </summary>
    /// <param name="wrapper"></param>
    /// <returns></returns>
    protected virtual bool TryGetWrapper(out ItemWrapper wrapper)
    {
        wrapper = default;
        return false;
    }

    [Signature("method_7876")]
    public virtual partial string GetTranslationKey();

    protected virtual nint GetTranslationKeyHandler() => NewString(GetTranslationKey());

    protected delegate nint GetTranslationKeyHandlerDelegate();

    [StructLayout(LayoutKind.Sequential)]
    public partial struct ItemWrapper
    {
        public nint GetTranslationKeyHandler;
    }
}