using Net.Minecraft.Util;
using Net.Minecraft.Registry;

namespace Net.Minecraft.Registry.Tag;

public partial class TagKey<T> : Java.Lang.Record, IClassRef<TagKey<T>>, IFromHandle<TagKey<T>>
    where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => TagKey.Names;

    public static Class<TagKey<JavaObject>> ClassRef => TagKey.ClassRef;

    static Class<TagKey<T>> IClassRef<TagKey<T>>.ClassRef => Class.Proxy<TagKey<T>>(ClassRef.ObjectRef);

    [JavaConstructor, Obsolete]
    public TagKey(RegistryKey<Registry<T>> registry, Identifier id) : base(TagKey_RegistryKey1IdentifierInvoke(registry, id))
    {}
}

[MapName("net/minecraft/class_6862"), StaticGeneric(typeof(TagKey<>))]
public static partial class TagKey
{
}