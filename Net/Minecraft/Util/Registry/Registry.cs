using Mliybs.Minecraft.Fabric;

namespace Net.Minecraft.Util.Registry;


public partial class Registry<T> : Java.Lang.Object, IClassRef, IFromHandle<Registry<T>> where T : Java.Lang.Object, IClassRef
{
    internal static Names Names => Registry.Names;

    public static Class ClassRef => Registry.ClassRef;
}

[MapName("net.minecraft.class_2378")]
public static partial class Registry
{
    [Signature("field_11142")]
    public static DefaultedRegistry<Item.Item> Item { get; private set; } = default!;

    [Signature("method_10226"), ReturnCheck(nameof(entry))]
    public static partial TEntry Register<TRegistry, TEntry>(Registry<TRegistry> registry, string id, TEntry entry) where TRegistry : Java.Lang.Object, IClassRef where TEntry : TRegistry, IFromHandle<TEntry>;
}