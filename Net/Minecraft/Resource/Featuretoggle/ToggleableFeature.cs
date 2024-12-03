namespace Net.Minecraft.Resource.Featuretoggle;

[MapName("net/minecraft/class_7695"), JavaInterface(typeof(IToggleableFeature))]
public partial class ToggleableFeature : Java.Lang.Object, IClassRef<ToggleableFeature>, IFromHandle<ToggleableFeature>, IToggleableFeature
{
    [Signature("method_45322")]
    public partial FeatureSet GetRequiredFeatures();
}

[JavaInterface(typeof(ToggleableFeature))]
public partial interface IToggleableFeature
{
    FeatureSet GetRequiredFeatures();
}
