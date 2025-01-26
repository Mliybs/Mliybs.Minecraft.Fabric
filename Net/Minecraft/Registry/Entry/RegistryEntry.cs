using Java.Util.Stream;
using Net.Minecraft.Registry;
using Net.Minecraft.Registry.Tag;
using Net.Minecraft.Util;

namespace Net.Minecraft.Registry.Entry;

[JavaInterface(typeof(IRegistryEntry<>))]
public partial class RegistryEntry<T> : JavaObject, IClassRef<RegistryEntry<T>>, IFromHandle<RegistryEntry<T>> where T  : JavaObject, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => RegistryEntry.Names;

    public static Class<RegistryEntry<JavaObject>> ClassRef => RegistryEntry.ClassRef;

    static Class<RegistryEntry<T>> IClassRef<RegistryEntry<T>>.ClassRef => Class.Proxy<RegistryEntry<T>>(ClassRef.ObjectRef);

    [Signature("comp_349")]
    public partial T Value();

    [Signature("method_40227")]
    public partial bool HasKeyAndValue();

    [Signature("method_40226")]
    public partial bool MatchesId(Identifier id);

    [Signature("method_40225")]
    public partial bool MatchesKey(RegistryKey<T> key);

    [Signature("method_40224")]
    public partial bool Matches(JavaPredicate.PredicateDelegate<RegistryKey<T>> predicate);

    [Signature("method_40220")]
    public partial bool IsIn(TagKey<T> tag);

    [Signature("method_40228")]
    public partial Stream<TagKey<T>> StreamTags();

    // [Signature("method_40229")]
    // public partial com.mojang.datafixers.util.Either<RegistryKey<T>,T> GetKeyOrValue();

    [Signature("method_40230")]
    public partial Optional<RegistryKey<T>> GetKey();

    // [Signature("method_40231")]
    // public partial RegistryEntry.Type GetType();

    // [Signature("method_46745")]
    // public partial bool OwnerEquals(RegistryEntryOwner<T> owner);
}

[MapName("net/minecraft/class_6880"), StaticGeneric(typeof(RegistryEntry<>))]
public static partial class RegistryEntry
{
    [Signature("method_40223")]
    public static partial RegistryEntry<T> Of<T>(T value) where T : JavaObject, IClassRef<T>, IFromHandle<T>;

    public partial class Reference<T> : JavaObject, IRegistryEntry<T>, IClassRef<Reference<T>>, IFromHandle<Reference<T>> where T : JavaObject, IClassRef<T>, IFromHandle<T>
    {
        internal static Names Names => Reference.Names;

        public static Class<Reference<JavaObject>> ClassRef => Reference.ClassRef;

        static Class<Reference<T>> IClassRef<Reference<T>>.ClassRef => Class.Proxy<Reference<T>>(ClassRef.ObjectRef);

        public T Value() => RegistryEntry<T>.ValueProxy(ObjectRef);

        public bool HasKeyAndValue() => RegistryEntry<T>.HasKeyAndValueProxy(ObjectRef);

        public bool MatchesId(Identifier id) => RegistryEntry<T>.MatchesIdProxy(ObjectRef, id);

        public bool MatchesKey(RegistryKey<T> key) => RegistryEntry<T>.MatchesKeyProxy(ObjectRef, key);

        public bool Matches(JavaPredicate.PredicateDelegate<RegistryKey<T>> predicate) => RegistryEntry<T>.MatchesProxy(ObjectRef, predicate);

        public bool IsIn(TagKey<T> tag) => RegistryEntry<T>.IsInProxy(ObjectRef, tag);

        public Stream<TagKey<T>> StreamTags() => RegistryEntry<T>.StreamTagsProxy(ObjectRef);

        // com.mojang.datafixers.util.Either<RegistryKey<T>,T> GetKeyOrValue();

        public Optional<RegistryKey<T>> GetKey() => RegistryEntry<T>.GetKeyProxy(ObjectRef);

        // RegistryEntry.Type GetType();

        // bool OwnerEquals(RegistryEntryOwner<T> owner);
    }

    [MapName("class_6883"), StaticGeneric(typeof(Reference<>))]
    public static partial class Reference
    {
    }
}

[JavaInterface(typeof(RegistryEntry<>))]
public partial interface IRegistryEntry<T> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    T Value();

    bool HasKeyAndValue();

    bool MatchesId(Identifier id);

    bool MatchesKey(RegistryKey<T> key);

    bool Matches(JavaPredicate.PredicateDelegate<RegistryKey<T>> predicate);

    bool IsIn(TagKey<T> tag);

    Stream<TagKey<T>> StreamTags();

    // com.mojang.datafixers.util.Either<RegistryKey<T>,T> GetKeyOrValue();

    Optional<RegistryKey<T>> GetKey();

    // RegistryEntry.Type GetType();

    // bool OwnerEquals(RegistryEntryOwner<T> owner);
}
