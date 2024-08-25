namespace Net.Minecraft.Item;

public partial class Item
{
    public partial class Settings
    {
        internal static readonly IntPtr Food_ = GetMethodID(ClassRef,
            MapMethodName(Names.OriginName, "method_19265", $"(L{FoodComponent.Names.OriginSignature};)L{Names.OriginSignature};"),
            $"(L{FoodComponent.Names.MapSignature};)L{Names.MapSignature};");

        internal static readonly IntPtr Fireproof_ = GetMethodID(ClassRef,
            MapMethodName(Names.OriginName, "method_24359", $"()L{Names.OriginSignature};"),
            $"()L{Names.MapSignature};");

        internal static readonly IntPtr MaxCount_Int = GetMethodID(ClassRef,
            MapMethodName(Names.OriginName, "method_7889", $"(I)L{Names.OriginSignature};"),
            $"(I)L{Names.MapSignature};");

        internal static readonly IntPtr MaxDamage_Int = GetMethodID(ClassRef,
            MapMethodName(Names.OriginName, "method_7895", $"(I)L{Names.OriginSignature};"),
            $"(I)L{Names.MapSignature};");
    }
}