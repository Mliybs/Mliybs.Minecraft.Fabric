namespace Net.Minecraft.Resource.FeatureToggle;

[MapName("net/minecraft/class_7695"), JavaInterface(typeof(IToggleableFeature))]
public partial class ToggleableFeature : JavaObject, IClassRef<ToggleableFeature>, IFromHandle<ToggleableFeature>, IToggleableFeature
{
    [Signature("method_45322")]
    public partial FeatureSet GetRequiredFeatures();
}

[JavaInterface(typeof(ToggleableFeature))]
public partial interface IToggleableFeature
{
    FeatureSet GetRequiredFeatures();
}
