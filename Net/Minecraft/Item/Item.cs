using Net.Minecraft.Util;

namespace Net.Minecraft.Item;

[MapName("net/minecraft/class_1792")]
public partial class Item : Java.Lang.Object, IClassRef, IFromHandle<Item>
{
    [Signature("method_7880")]
    public static partial int GetRawId(Item item);

    [Signature("method_7875")]
    public static partial Item ByRawId(int id);

    [MapName("class_1793")]
    public partial class Settings : Java.Lang.Object, IConstructor, IFromHandle<Settings>
    {
        [JavaConstructor]
        public Settings() : base(Settings_Invoke())
        {}

        [Signature("method_24359")]
        public partial Settings Fireproof();

        [Signature("method_19265")]
        public partial Settings Food(FoodComponent foodComponent);

        [Signature("method_7889")]
        public partial Settings MaxCount(int maxCount);

        [Signature("method_7894")]
        public partial Settings Rarity(Rarity rarity);

        [Signature("method_7895")]
        public partial Settings MaxDamage(int maxDamage);

        [Signature("method_7898")]
        public partial Settings MaxDamageIfAbsent(int maxDamage);

        [Signature("method_7896")]
        public partial Settings RecipeRemainder(Item recipeRemainder);

        [Signature("method_7892")]
        public partial Settings Group(ItemGroup group);
    }
}