using Java.Util.Stream;
using Net.Minecraft.Util;
using Net.Minecraft.Registry.Entry;
using Net.Minecraft.Registry.Tag;

namespace Net.Minecraft.Registry;

[JavaInterface(typeof(IRegistry<>))]
public partial class Registry<T> : JavaObject, IClassRef<Registry<T>>, IFromHandle<Registry<T>>, IRegistry<T>
    where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => Registry.Names;

    public static Class<Registry<JavaObject>> ClassRef => Registry.ClassRef;

    static Class<Registry<T>> IClassRef<Registry<T>>.ClassRef => Class.Proxy<Registry<T>>(ClassRef.ObjectRef);

    [Signature("method_30517")]
    public partial RegistryKey<Registry<T>> GetKey();

//     [Signature("method_39673")]
//     public partial com.mojang.serialization.Codec<T> GetCodec();

//     [Signature("method_40294")]
//     public partial com.mojang.serialization.Codec<RegistryEntry<T>> CreateEntryCodec();

    [Signature("method_10221")]
    public partial Identifier? GetId(T value);

    [Signature("method_29113")]
    public partial Optional<RegistryKey<T>> GetKey(T entry);

    [Signature("method_29107")]
    public partial T? Get(RegistryKey<T>? key);

    [Signature("method_10223")]
    public partial T? Get(Identifier? id);

//     [Signature("method_31139")]
//     com.mojang.serialization.Lifecycle GetEntryLifecycle(T entry);

//     [Signature("method_31138")]
//     com.mojang.serialization.Lifecycle GetLifecycle();

    [Signature("method_17966")]
    public partial Optional<T> GetOrEmpty(Identifier? id);

    [Signature("method_31189")]
    public partial Optional<T> GetOrEmpty(RegistryKey<T>? key);

    [Signature("method_31140")]
    public partial T GetOrThrow(RegistryKey<T> key);

    [Signature("method_10235")]
    public partial Java.Util.Set<Identifier> GetIds();

//     [Signature("method_29722")]
//     Set<Map.Entry<RegistryKey<T>,T>> GetEntrySet();

    [Signature("method_42021")]
    public partial Java.Util.Set<RegistryKey<T>> GetKeys();

    [Signature("method_10240")]
    public partial Optional<RegistryEntry.Reference<T>> GetRandom(Util.Math.Random.Random random);

    [Signature("method_10220")]
    public partial Stream<T> Stream();

    [Signature("method_10250")]
    public partial bool ContainsId(Identifier id);

    [Signature("method_35842")]
    public partial bool Contains(RegistryKey<T> key);

    [Signature("method_40276")]
    public partial Registry<T> Freeze();

    [Signature("method_40269")]
    public partial RegistryEntry.Reference<T> CreateEntry(T value);

    [Signature("method_40265")]
    public partial Optional<RegistryEntry.Reference<T>> GetEntry(int rawId);

    [Signature("method_40264")]
    public partial Optional<RegistryEntry.Reference<T>> GetEntry(RegistryKey<T> key);

    [Signature("method_47983")]
    public partial RegistryEntry<T> GetEntry(T value);

    [Signature("method_40290")]
    public partial RegistryEntry.Reference<T> EntryOf(RegistryKey<T> key);

    [Signature("method_40270")]
    public partial Stream<RegistryEntry.Reference<T>> StreamEntries();

//     [Signature("method_40266")]
//     Optional<RegistryEntryList.Named<T>> GetEntryList(TagKey<T> tag);

    [Signature("method_40286")]
    public partial Iterable<RegistryEntry<T>> IterateEntries(TagKey<T> tag);

//     [Signature("method_40260")]
//     RegistryEntryList.Named<T> GetOrCreateEntryList(TagKey<T> tag);

//     [Signature("method_40272")]
//     Stream<com.mojang.datafixers.util.Pair<TagKey<T>,RegistryEntryList.Named<T>>> StreamTagsAndEntries();

    [Signature("method_40273")]
    public partial Stream<TagKey<T>> StreamTags();

    [Signature("method_40278")]
    public partial void ClearTags();

    [Signature("method_40257")]
    public partial void PopulateTags(IMap<TagKey<T>, Java.Util.List<RegistryEntry<T>>> tagEntries);

    // [Signature("method_40295")]
    // public partial IndexedIterable<RegistryEntry<T>> GetIndexedEntries();

    // [Signature("method_46770")]
    // RegistryEntryOwner<T> GetEntryOwner();

    // [Signature("method_46771")]
    // RegistryWrapper.Impl<T> GetReadOnlyWrapper();

    // [Signature("method_46772")]
    // public partial RegistryWrapper.Impl<T> GetTagCreatingWrapper();
}

[MapName("net/minecraft/class_2378"), StaticGeneric(typeof(Registry<>))]
public static partial class Registry
{
    [Signature("method_10230"), ReturnCheck(nameof(entry))]
    public static partial TEntry Register<TRegistry, TEntry>(IRegistry<TRegistry> registry, Identifier id, TEntry entry) where TRegistry : JavaObject, IClassRef<TRegistry>, IFromHandle<TRegistry> where TEntry : JavaObject, TRegistry, IClassRef<TEntry>, IFromHandle<TEntry>;

    [Signature("method_10226"), ReturnCheck(nameof(entry))]
    public static partial TEntry Register<TRegistry, TEntry>(IRegistry<TRegistry> registry, string id, TEntry entry) where TRegistry : JavaObject, IClassRef<TRegistry>, IFromHandle<TRegistry> where TEntry : JavaObject, TRegistry, IClassRef<TEntry>, IFromHandle<TEntry>;

    [Signature("method_39197"), ReturnCheck(nameof(entry))]
    public static partial TEntry Register<TRegistry, TEntry>(IRegistry<TRegistry> registry, RegistryKey<TRegistry> key, TEntry entry) where TRegistry : JavaObject, IClassRef<TRegistry>, IFromHandle<TRegistry> where TEntry : JavaObject, TRegistry, IClassRef<TEntry>, IFromHandle<TEntry>;

//     [Signature("method_47984")]
//     static <T> RegistryEntry.Reference<T> RegisterReference(Registry<T> registry, RegistryKey<T> key, T entry);

//     [Signature("method_47985")]
//     static <T> RegistryEntry.Reference<T> RegisterReference(Registry<T> registry, Identifier id, T entry);
}

[JavaInterface(typeof(Registry<>))]
public partial interface IRegistry<T> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    RegistryKey<Registry<T>> GetKey();
}
