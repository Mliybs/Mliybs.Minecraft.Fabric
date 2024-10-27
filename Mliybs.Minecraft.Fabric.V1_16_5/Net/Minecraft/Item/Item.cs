using Net.Minecraft.Util;

namespace Net.Minecraft.Item;

[MapName("net/minecraft/class_1792")]
public partial class Item : JavaClass, IClassRef, IFromHandle<Item>
{
    [MapName("class_1793")]
    public partial class Settings : JavaClass, IConstructor, IFromHandle<Settings>
    {
        [JavaConstructor]
        public Settings() => Settings_Invoke();

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
    }
}