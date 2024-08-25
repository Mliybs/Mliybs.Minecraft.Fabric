namespace Net.Minecraft.Util.Registry;

public unsafe partial class Registry<T>
{
}

public partial class Registry
{
    public static readonly DefaultedRegistry<Item.Item> Item = new(GetStaticObjectField(ClassRef, MapFieldName(Names.OriginName, "field_11142", $"L{DefaultedRegistry.Names.OriginSignature};"), $"L{DefaultedRegistry.Names.MapSignature};"));

    internal static readonly IntPtr Register_RegistryStringObject = GetStaticMethodID(ClassRef, MapMethodName(Names.OriginName, "method_10226", $"(L{Names.OriginSignature};Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;"), $"(L{Names.MapSignature};Ljava/lang/String;Ljava/lang/Object;)Ljava/lang/Object;");
}