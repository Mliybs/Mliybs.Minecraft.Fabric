namespace Net.Minecraft.Item;

[MapName("net/minecraft/class_1799")]
public partial class ItemStack : Java.Lang.Object, IClassRef<ItemStack>, IFromHandle<ItemStack>
{
    [JavaConstructor]
    public ItemStack(IItemConvertible item) : base(ItemStack_ItemConvertibleInvoke(item))
    {}

    [JavaConstructor]
    public ItemStack(IItemConvertible item, int count) : base(ItemStack_ItemConvertibleIntInvoke(item, count))
    {}
}
