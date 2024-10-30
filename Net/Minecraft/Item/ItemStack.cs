using System;

namespace Net.Minecraft.Item;

[MapName("net/minecraft/class_1799")]
public partial class ItemStack : Java.Lang.Object, IClassRef, IFromHandle<ItemStack>
{
    [JavaConstructor]
    public ItemStack(IItemConvertible item) : base(ItemStack_ItemConvertibleInvoke(item))
    {}

    [JavaConstructor]
    public ItemStack(IItemConvertible item, int count) : base(ItemStack_ItemConvertibleIntInvoke(item, count))
    {}

    [Signature("method_7960")]
    public partial bool IsEmpty();

    [Signature("method_7909")]
    public partial Item GetItem();

    [Signature("method_7933")]
    public partial void Increment(int amount);

    [Signature("method_7934")]
    public partial void Decrement(int amount);
}