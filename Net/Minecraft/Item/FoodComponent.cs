using Net.Minecraft.Entity.Effect;

namespace Net.Minecraft.Item;

[MapName("net/minecraft/class_4174"), FromMode(FromModes.SimpleFrom)]
public partial class FoodComponent : JavaObject, IClassRef<FoodComponent>, IFromHandle<FoodComponent>
{
    [Signature("method_19230")]
    public partial int GetHunger();

    [Signature("method_19231")]
    public partial float GetSaturationModifier();

    [Signature("method_19232")]
    public partial bool IsMeat();

    [Signature("method_19233")]
    public partial bool IsAlwaysEdible();

    [Signature("method_19234")]
    public partial bool IsSnack();

    // [Signature("method_19235")]
    // public partial List<com.mojang.datafixers.util.Pair<StatusEffectInstance,Float>> GetStatusEffects();

    [MapName("class_4175")]
    public partial class Builder : JavaObject, IClassRef<Builder>, IFromHandle<Builder>
    {
        [JavaConstructor]
        public Builder() : base(Builder_Invoke())
        {}

        [Signature("method_19238")]
        public partial Builder Hunger(int hunger);

        [Signature("method_19237")]
        public partial Builder SaturationModifier(float saturationModifier);

        [Signature("method_19236")]
        public partial Builder Meat();

        [Signature("method_19240")]
        public partial Builder AlwaysEdible();

        [Signature("method_19241")]
        public partial Builder Snack();

        [Signature("method_19239")]
        public partial Builder StatusEffect(StatusEffectInstance effect, float chance);

        [Signature("method_19242")]
        public partial FoodComponent Build();
    }
}
