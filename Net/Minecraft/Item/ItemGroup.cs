namespace Net.Minecraft.Item;

[MapName("net/minecraft/class_1761")]
public partial class ItemGroup : JavaObject, IClassRef<ItemGroup>, IFromHandle<ItemGroup>
{
    [Signature("method_47307")]
    public static partial Builder Create(Row location, int column);

    [Signature("method_7737")]
    public partial Text.Text GetDisplayName();

    [Signature("method_7747")]
    public partial ItemStack GetIcon();

    [Signature("method_7742")]
    public partial string GetTexture();

    [Signature("method_7754")]
    public partial bool ShouldRenderName();

    [Signature("method_7756")]
    public partial bool HasScrollbar();

    [Signature("method_7743")]
    public partial int GetColumn();

    [Signature("method_47309")]
    public partial ItemGroup.Row GetRow();

    [Signature("method_47310")]
    public partial bool HasStacks();

    [Signature("method_47311")]
    public partial bool ShouldDisplay();

    [Signature("method_7752")]
    public partial bool IsSpecial();

    [Signature("method_47312")]
    public partial ItemGroup.Type GetType();

    [Signature("method_47306")]
    public partial void UpdateEntries(ItemGroup.DisplayContext displayContext);

    [Signature("method_47313")]
    public partial Java.Util.Collection<ItemStack> GetDisplayStacks();

    [Signature("method_45414")]
    public partial Java.Util.Collection<ItemStack> GetSearchTabStacks();

    [Signature("method_45412")]
    public partial bool Contains(ItemStack stack);

    [Signature("method_47308")]
    public partial void SetSearchProviderReloader(Java.Util.Function.Consumer.ConsumerDelegate<Java.Util.List<ItemStack>> searchProviderReloader);

    [Signature("method_47314")]
    public partial void ReloadSearchProvider();

    [MapName("class_7913")]
    public partial class Builder : JavaObject, IClassRef<Builder>, IFromHandle<Builder>
    {
        [JavaConstructor]
        public Builder(Row row, int column) : base(Builder_RowIntInvoke(row, column))
        {}

        [Signature("method_47321")]
        public partial Builder DisplayName(Text.IText displayName);

        [Signature("method_47320")]
        public partial Builder Icon(Java.Util.Function.Supplier.SupplierDelegate<ItemStack> iconSupplier);

        [Signature("method_47317")]
        public partial Builder Entries(EntryCollector.EntryCollectorDelegate entryCollector);

        [Signature("method_47315")]
        public partial Builder Special();

        [Signature("method_47322")]
        public partial Builder NoRenderedName();

        [Signature("method_47323")]
        public partial Builder NoScrollbar();

        [Signature("method_47318")]
        protected partial Builder Type(ItemGroup.Type type);

        [Signature("method_47319")]
        public partial Builder Texture(string texture);

        [Signature("method_47324")]
        public partial ItemGroup Build();
    }

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
