using Net.Minecraft.Registry;
using Net.FabricMC.Fabric.Api.Event;

namespace Net.FabricMC.Fabric.Api.ItemGroup.V1;

[MapName("net/fabricmc/fabric/api/itemgroup/v1/ItemGroupEvents", false)]
public partial class ItemGroupEvents : JavaObject, IClassRef<ItemGroupEvents>, IFromHandle<ItemGroupEvents>
{
    [MapName("ModifyEntriesAll", false)]
    public partial class ModifyEntriesAll : JavaObject, IFunctionalInterface<ModifyEntriesAll, ModifyEntriesAll.ModifyEntriesDelegate>, IClassRef<ModifyEntriesAll>, IFromHandle<ModifyEntriesAll>
    {
        [Signature("modifyEntries", false)]
        public partial void ModifyEntries(Minecraft.Item.ItemGroup group, FabricItemGroupEntries entries);

        public delegate void ModifyEntriesDelegate(Minecraft.Item.ItemGroup group, FabricItemGroupEntries entries);

        internal delegate void ModifyEntriesDelegateHandler(nint group, nint entries);

        internal static ModifyEntriesDelegateHandler? Handle(ModifyEntriesDelegate? @delegate) =>
            @delegate is null ? null : (group, entries) => @delegate.Invoke(Minecraft.Item.ItemGroup.From(group), FabricItemGroupEntries.From(entries));
        
        static ModifyEntriesAll IFunctionalInterface<ModifyEntriesAll, ModifyEntriesDelegate>.ToObject(ModifyEntriesDelegate @delegate) =>
            new(InvocationHandlerWrapper.GetProxyOf(ClassRef, Handle(@delegate)));
    }

    [MapName("ModifyEntries", false)]
    public partial class ModifyEntries : JavaObject, IFunctionalInterface<ModifyEntries, ModifyEntries.ModifyEntriesDelegate>, IClassRef<ModifyEntries>, IFromHandle<ModifyEntries>
    {
        [Signature("modifyEntries", false)]
        public partial void ModifyEntriesMethod(FabricItemGroupEntries entries);

        public delegate void ModifyEntriesDelegate(FabricItemGroupEntries entries);

        internal delegate void ModifyEntriesDelegateHandler(nint entries);

        internal static ModifyEntriesDelegateHandler? Handle(ModifyEntriesDelegate? @delegate) =>
            @delegate is null ? null : entries => @delegate.Invoke(FabricItemGroupEntries.From(entries));
        
        static ModifyEntries IFunctionalInterface<ModifyEntries, ModifyEntriesDelegate>.ToObject(ModifyEntriesDelegate @delegate) =>
            new(InvocationHandlerWrapper.GetProxyOf(ClassRef, Handle(@delegate)));
    }

    [Signature("MODIFY_ENTRIES_ALL", false)]
    public static Event<ModifyEntriesAll, ModifyEntriesAll.ModifyEntriesDelegate> MODIFY_ENTRIES_ALL { get; private set; }

    [Signature("modifyEntriesEvent", false)]
    public static partial Event<ModifyEntries, ModifyEntries.ModifyEntriesDelegate> ModifyEntriesEvent(RegistryKey<Minecraft.Item.ItemGroup> registryKey);
}
