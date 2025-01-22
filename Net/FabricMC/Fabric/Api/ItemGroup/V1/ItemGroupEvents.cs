using Net.FabricMC.Fabric.Api.Event;

namespace Net.FabricMC.Fabric.Api.ItemGroup.V1;

[MapName("net/fabricmc/fabric/api/itemgroup/v1/ItemGroupEvents", false)]
public partial class ItemGroupEvents
{
    [MapName("ModifyEntriesAll", false)]
    public partial class ModifyEntriesAll : JavaObject, IFunctionalInterface<ModifyEntriesAll, >, IClassRef<ModifyEntriesAll>, IFromHandle<ModifyEntriesAll>
    {
        [Signature("modifyEntries", false)]
        public partial void ModifyEntries(Minecraft.Item.ItemGroup group, FabricItemGroupEntries entries);
    }

    [Signature("MODIFY_ENTRIES_ALL", false)]
    public static Event<ModifyEntriesAll, > MODIFY_ENTRIES_ALL { get; private set; }
}
