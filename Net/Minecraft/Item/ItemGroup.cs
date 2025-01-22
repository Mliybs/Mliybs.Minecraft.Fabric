namespace Net.Minecraft.Item;

[MapName("net/minecraft/class_1761")]
public partial class ItemGroup : JavaObject, IClassRef<ItemGroup>, IFromHandle<ItemGroup>
{
    [MapName("class_7913")]
    public partial class Builder : JavaObject, IClassRef<Builder>, IFromHandle<Builder>
    {}

    [MapName("class_8128")]
    public partial class DisplayContext : Record, IClassRef<DisplayContext>, IFromHandle<DisplayContext>
    {}
    
    [JavaInterface(typeof(Entries))]
    public partial interface IEntries
    {
        void Add(ItemStack stack, StackVisibility visibility);

        public void Add(ItemStack stack) => Entries.AddProxy(ObjectRef, stack);

        public void Add(IItemConvertible item, StackVisibility visibility) => Entries.AddProxy(ObjectRef, item, visibility);

        public void Add(IItemConvertible item) => Entries.AddProxy(ObjectRef, item);

        public void AddAll(Java.Util.ICollection<ItemStack> stacks, StackVisibility visibility) => Entries.AddAllProxy(ObjectRef, stacks, visibility);

        public void AddAll(Java.Util.ICollection<ItemStack> stacks) => Entries.AddAllProxy(ObjectRef, stacks);
    }

    [MapName("class_7704"), JavaInterface(typeof(IEntries))]
    public partial class Entries : JavaObject, IClassRef<Entries>, IFromHandle<Entries>, IEntries
    {
        [Signature("method_45417")]
        public partial void Add(ItemStack stack, StackVisibility visibility);

        [Signature("method_45420")]
        public partial void Add(ItemStack stack);

        [Signature("method_45422")]
        public partial void Add(IItemConvertible item, StackVisibility visibility);

        [Signature("method_45421")]
        public partial void Add(IItemConvertible item);

        [Signature("method_45424")]
        public partial void AddAll(Java.Util.ICollection<ItemStack> stacks, StackVisibility visibility);

        [Signature("method_45423")]
        public partial void AddAll(Java.Util.ICollection<ItemStack> stacks);
    }

    [MapName("class_7914")]
    public partial class EntryCollector : JavaObject, IClassRef<EntryCollector>, IFromHandle<EntryCollector>
    {
        [Signature("accept")]
        public partial void Accept(DisplayContext displayContext, IEntries entries);

        public delegate void EntryCollectorDelegate(DisplayContext displayContext, IEntries entries);

        internal delegate void EntryCollectorDelegateHandler(nint displayContext, nint entries);

        internal static EntryCollectorDelegateHandler? Handle(EntryCollectorDelegate? @delegate) =>
            @delegate is null ? null : (displayContext, entries) => @delegate.Invoke(DisplayContext.From(displayContext), Entries.From(entries));
    }

    #nullable disable
    [MapName("class_7915")]
    public partial class Row : Enum<Row>, IClassRef<Row>, IFromHandle<Row>
    {
        [Signature("field_41049")]
        public static Row TOP { get; private set; }

        [Signature("field_41050")]
        public static Row BOTTOM { get; private set; }
    }

    [MapName("class_7705")]
    public partial class StackVisibility : Enum<StackVisibility>, IClassRef<StackVisibility>, IFromHandle<StackVisibility>
    {
        [Signature("field_40191")]
        public static StackVisibility PARENT_AND_SEARCH_TABS { get; private set; }

        [Signature("field_40192")]
        public static StackVisibility PARENT_TAB_ONLY { get; private set; }

        [Signature("field_40193")]
        public static StackVisibility SEARCH_TAB_ONLY { get; private set; }
    }

    [MapName("class_7916")]
    public partial class Type : Enum<Type>, IClassRef<Type>, IFromHandle<Type>
    {
        [Signature("field_41052")]
        public static Type CATEGORY { get; private set; }

        [Signature("field_41053")]
        public static Type INVENTORY { get; private set; }

        [Signature("field_41054")]
        public static Type HOTBAR { get; private set; }

        [Signature("field_41055")]
        public static Type SEARCH { get; private set; }
    }
    #nullable restore
}
