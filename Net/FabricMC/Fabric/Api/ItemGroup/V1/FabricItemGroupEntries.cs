using Java.Util.Function;
using Java.Util;
using Net.Minecraft.Item;
using Net.Minecraft.Resource.FeatureToggle;

namespace Net.FabricMC.Fabric.Api.ItemGroup.V1;

[MapName("net/fabricmc/fabric/api/itemgroup/v1/FabricItemGroupEntries", false)]
public partial class FabricItemGroupEntries : JavaObject, Minecraft.Item.ItemGroup.IEntries, IClassRef<FabricItemGroupEntries>, IFromHandle<FabricItemGroupEntries>
{
    public void Add(ItemStack stack, Minecraft.Item.ItemGroup.StackVisibility visibility) => Minecraft.Item.ItemGroup.Entries.AddProxy(ObjectRef, stack, visibility);

    public void Add(ItemStack stack) => Minecraft.Item.ItemGroup.Entries.AddProxy(ObjectRef, stack);

    public void Add(IItemConvertible item, Minecraft.Item.ItemGroup.StackVisibility visibility) => Minecraft.Item.ItemGroup.Entries.AddProxy(ObjectRef, item, visibility);

    public void Add(IItemConvertible item) => Minecraft.Item.ItemGroup.Entries.AddProxy(ObjectRef, item);

    public void AddAll(Java.Util.ICollection<ItemStack> stacks, Minecraft.Item.ItemGroup.StackVisibility visibility) => Minecraft.Item.ItemGroup.Entries.AddAllProxy(ObjectRef, stacks, visibility);

    public void AddAll(Java.Util.ICollection<ItemStack> stacks) => Minecraft.Item.ItemGroup.Entries.AddAllProxy(ObjectRef, stacks);

    [Signature("getContext", false)]
    public partial Minecraft.Item.ItemGroup.DisplayContext GetContext();

    [Signature("getEnabledFeatures", false)]
    public partial FeatureSet GetEnabledFeatures();

    [Signature("shouldShowOpRestrictedItems", false)]
    public partial bool ShouldShowOpRestrictedItems();

    [Signature("getDisplayStacks", false)]
    public partial Java.Util.List<ItemStack> GetDisplayStacks();

    [Signature("getSearchTabStacks", false)]
    public partial Java.Util.List<ItemStack> GetSearchTabStacks();

    [Signature("prepend", false)]
    public partial void Prepend(ItemStack stack);

    [Signature("prepend", false)]
    public partial void Prepend(ItemStack stack, Minecraft.Item.ItemGroup.StackVisibility visibility);

    [Signature("prepend", false)]
    public partial void Prepend(IItemConvertible item);

    [Signature("prepend", false)]
    public partial void Prepend(IItemConvertible item, Minecraft.Item.ItemGroup.StackVisibility visibility);

    [Signature("addAfter", false)]
    public partial void AddAfter(IItemConvertible afterLast, JavaArray<ItemStack> newStack);

    [Signature("addAfter", false)]
    public partial void AddAfter(ItemStack afterLast, JavaArray<ItemStack> newStack);

    [Signature("addAfter", false)]
    public partial void AddAfter(IItemConvertible afterLast, JavaArray<ItemConvertible> newItem);

    [Signature("addAfter", false)]
    public partial void AddAfter(ItemStack afterLast, JavaArray<ItemConvertible> newItem);

    [Signature("addAfter", false)]
    public partial void AddAfter(IItemConvertible afterLast, Java.Util.ICollection<ItemStack> newStacks);

    [Signature("addAfter", false)]
    public partial void AddAfter(ItemStack afterLast, Java.Util.ICollection<ItemStack> newStacks);

    [Signature("addAfter", false)]
    public partial void AddAfter(IItemConvertible afterLast, Java.Util.ICollection<ItemStack> newStacks, Minecraft.Item.ItemGroup.StackVisibility visibility);

    [Signature("addAfter", false)]
    public partial void AddAfter(ItemStack afterLast, Java.Util.ICollection<ItemStack> newStacks, Minecraft.Item.ItemGroup.StackVisibility visibility);

    [Signature("addAfter", false)]
    public partial void AddAfter(Java.Util.Function.Predicate.PredicateDelegate<ItemStack> afterLast, Java.Util.ICollection<ItemStack> newStacks, Minecraft.Item.ItemGroup.StackVisibility visibility);

    [Signature("addBefore", false)]
    public partial void AddBefore(IItemConvertible beforeFirst, JavaArray<ItemStack> newStack);

    [Signature("addBefore", false)]
    public partial void AddBefore(ItemStack beforeFirst, JavaArray<ItemStack> newStack);

    [Signature("addBefore", false)]
    public partial void AddBefore(IItemConvertible beforeFirst, JavaArray<ItemConvertible> newItem);

    [Signature("addBefore", false)]
    public partial void AddBefore(ItemStack beforeFirst, JavaArray<ItemConvertible> newItem);

    [Signature("addBefore", false)]
    public partial void AddBefore(IItemConvertible beforeFirst, Java.Util.ICollection<ItemStack> newStacks);

    [Signature("addBefore", false)]
    public partial void AddBefore(ItemStack beforeFirst, Java.Util.ICollection<ItemStack> newStacks);

    [Signature("addBefore", false)]
    public partial void AddBefore(IItemConvertible beforeFirst, Java.Util.ICollection<ItemStack> newStacks, Minecraft.Item.ItemGroup.StackVisibility visibility);

    [Signature("addBefore", false)]
    public partial void AddBefore(ItemStack beforeFirst, Java.Util.ICollection<ItemStack> newStacks, Minecraft.Item.ItemGroup.StackVisibility visibility);

    [Signature("addBefore", false)]
    public partial void AddBefore(Java.Util.Function.Predicate.PredicateDelegate<ItemStack> beforeFirst, Java.Util.ICollection<ItemStack> newStacks, Minecraft.Item.ItemGroup.StackVisibility visibility);
}
