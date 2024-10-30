using Net.Minecraft.Entity.Effect;

namespace Net.Minecraft.Item;

[MapName("net/minecraft/class_4174")]
public partial class FoodComponent : Java.Lang.Object, IClassRef, IFromHandle<FoodComponent>
{
    [MapName("class_4175")]
    public partial class Builder : Java.Lang.Object, IConstructor, IFromHandle<Builder>
    {
        [JavaConstructor]
        public Builder() : base(Builder_Invoke())
        {}

        [Signature("method_19241")]
        public partial Builder Snack();

        [Signature("method_19236")]
        public partial Builder Meat();

        [Signature("method_19237")]
        public partial Builder SaturationModifier(float saturationModifier);

        [Signature("method_19238")]
        public partial Builder Hunger(int hunger);

        [Signature("method_19240")]
        public partial Builder AlwaysEdible();

        [Signature("method_19239")]
        public partial Builder StatusEffect(StatusEffectInstance effect, float chance);

        [Signature("method_19242")]
        public partial FoodComponent Build();
    }
}