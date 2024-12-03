using Net.Minecraft.Resource.Featuretoggle;
using Net.Minecraft.Util;
using Net.Minecraft.Block;

namespace Net.Minecraft.Item;

[MapName("net/minecraft/class_1792")]
public partial class Item : Java.Lang.Object, IClassRef<Item>, IFromHandle<Item>, IWrapper<Item>, IItemConvertible, IToggleableFeature
{
    [JavaConstructor]
    public Item(Settings settings) : base(nint.Zero)
    {
        ObjectRef = Item_SettingsInvoke(settings);
    }

    [Signature("method_7880")]
    public static partial int GetRawId(Item item);

    [Signature("method_7875")]
    public static partial Item ByRawId(int id);

    [Signature("method_7867"), Obsolete("请使用Block.AsItem()")]
    public static partial Item FromBlock(Block.Block block);

    public virtual Item AsItem() => ItemConvertible.AsItemProxy(ObjectRef);

    protected virtual nint AsItemHandler() => AsItem().ObjectRef;

    protected delegate nint AsItemDelegate();

    public virtual FeatureSet GetRequiredFeatures() => ToggleableFeature.GetRequiredFeaturesProxy(ObjectRef);

    protected virtual bool TryGetWrapper(out Wrapper wrapper)
    {
        wrapper = default;
        return false;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Wrapper
    {
        
    }

    [MapName("class_1793")]
    public partial class Settings : Java.Lang.Object, IClassRef<Settings>, IFromHandle<Settings>
    {
        [JavaConstructor]
        public Settings() : base(Settings_Invoke())
        {}

        [Signature("method_19265")]
        public partial Settings Food(FoodComponent foodComponent);

        [Signature("method_7889")]
        public partial Settings MaxCount(int maxCount);

        [Signature("method_7898")]
        public partial Settings MaxDamageIfAbsent(int maxDamage);

        [Signature("method_7895")]
        public partial Settings MaxDamage(int maxDamage);

        [Signature("method_7896")]
        public partial Settings RecipeRemainder(Item recipeRemainder);

        [Signature("method_7894")]
        public partial Settings Rarity(Rarity rarity);

        [Signature("method_24359")]
        public partial Settings Fireproof();

        [Signature("method_45434")]
        public partial Settings Requires(JavaArray<FeatureFlag> features);
    }
}
