using Net.Minecraft.Entity.Player;
using Net.Minecraft.Util;

namespace Net.Minecraft.Item;

partial class Item : IWrapper<Item>
{
    private static readonly System.Collections.Concurrent.ConcurrentBag<Delegate> KeepAlive = new();

    public static Class WrapperClassRef { get; } = FindClass("com/mlinetles/nativeloader/wrappers/ItemWrapper");

    public static nint WrapperConstructor { get; } = GetConstructorID(WrapperClassRef.ObjectRef, $"(L{Settings.Names.MapSignature};J)V");

    [JavaConstructor]
    public unsafe Item(Settings settings) : base(nint.Zero)
    {
        if (TryGetWrapper(out var wrapper))
        {
            ObjectRef = ((Method4Ptr)Env->Functions->NewObject)(Env, WrapperClassRef.ObjectRef, WrapperConstructor, settings.ObjectRef, (nint)(&wrapper));
        }

        else
        {
            ObjectRef = Item_SettingsInvoke(settings);
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

    protected static void Add(Delegate @delegate) => KeepAlive.Add(@delegate);

    [Signature("method_7836")]
    public virtual partial TypedActionResult<ItemStack> Use(World.World world, PlayerEntity user, Hand hand);

    protected virtual nint UseHandler(nint world, nint user, nint hand) => Use(World.World.From(world), PlayerEntity.From(user), Hand.From(hand)).ObjectRef;

    protected delegate nint UseHandlerDelegate(nint world, nint user, nint hand);

    [Signature("method_7876")]
    public virtual partial string GetTranslationKey();

    protected virtual nint GetTranslationKeyHandler() => NewString(GetTranslationKey());

    protected delegate nint GetTranslationKeyHandlerDelegate();

    [StructLayout(LayoutKind.Sequential)]
    public partial struct ItemWrapper
    {
        public nint UseHandler;

        public nint GetTranslationKeyHandler;
    }
}