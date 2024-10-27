namespace Net.Minecraft.Item;

[MapName("net/minecraft/class_4174")]
public partial class FoodComponent : JavaClass, IClassRef, IFromHandle<FoodComponent>
{
    [MapName("class_4175")]
    public partial class Builder : JavaClass, IConstructor, IFromHandle<Builder>
    {
        [JavaConstructor]
        public Builder() => Builder_Invoke();

        [Signature("method_19236")]
        public partial Builder Meat();

        [Signature("method_19237")]
        public partial Builder SaturationModifier(float saturationModifier);

        [Signature("method_19238")]
        public partial Builder Hunger(int hunger);

        [Signature("method_19240")]
        public partial Builder AlwaysEdible();

        [Signature("method_19242")]
        public partial FoodComponent Build();
    }
}