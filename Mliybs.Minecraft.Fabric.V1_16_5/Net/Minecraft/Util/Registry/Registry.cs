using Mliybs.Minecraft.Fabric;

namespace Net.Minecraft.Util.Registry;

[MapName("net.minecraft.class_2378")]
public partial class Registry<T> : JavaClass, IClassRef, IFromHandle<Registry<T>> where T : JavaClass, IClassRef
{
}

public sealed partial class Registry : Registry<InternalClass>
{
    [Signature("field_11142")]
    public static DefaultedRegistry<Item.Item> Item { get; private set; } = default!;

    [Signature("method_10226")]
    public static partial TEntry Register<TRegistry, TEntry>(Registry<TRegistry> registry, string id, TEntry entry) where TRegistry : JavaClass, IClassRef where TEntry : TRegistry, IFromHandle<TEntry>;
}