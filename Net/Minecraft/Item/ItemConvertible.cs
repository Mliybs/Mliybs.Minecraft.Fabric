namespace Net.Minecraft.Item;

[JavaInterface(typeof(IItemConvertible)), MapName("net/minecraft/class_1935")]
public partial class ItemConvertible : Java.Lang.Object, IClassRef, IFromHandle<ItemConvertible>, IItemConvertible
{
    [Signature("method_8389")]
    public partial Item AsItem();
}

[JavaInterface(typeof(ItemConvertible))]
public partial interface IItemConvertible : IJavaClass
{
    Item AsItem();
}