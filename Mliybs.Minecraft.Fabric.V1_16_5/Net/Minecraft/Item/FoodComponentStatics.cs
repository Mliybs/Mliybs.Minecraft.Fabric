namespace Net.Minecraft.Item;

public partial class FoodComponent
{
    public partial class Builder
    {
        internal static readonly IntPtr AlwaysEdible_ = GetMethodID(ClassRef,
            MapMethodName(Names.OriginName, "method_19240", $"()L{Names.OriginSignature};"),
            $"()L{Names.MapSignature};");
        
        internal static readonly IntPtr Build_ = GetMethodID(ClassRef,
            MapMethodName(Names.OriginName, "method_19242", $"()L{FoodComponent.Names.OriginSignature};"),
            $"()L{FoodComponent.Names.MapSignature};");
    }
}