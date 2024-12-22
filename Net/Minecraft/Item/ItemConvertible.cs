namespace Net.Minecraft.Item;

[MapName("net/minecraft/class_1935"), JavaInterface(typeof(IItemConvertible))]
public partial class ItemConvertible : JavaObject, IClassRef<ItemConvertible>, IFromHandle<ItemConvertible>, IItemConvertible
{
    [Signature("method_8389")]
    public partial Item AsItem();
}

[JavaInterface(typeof(ItemConvertible))]
public partial interface IItemConvertible
{
    Item AsItem();
}
