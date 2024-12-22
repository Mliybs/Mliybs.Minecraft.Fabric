using Net.Minecraft.Util;

namespace Net.Minecraft.Registry;

public partial class RegistryKey<T> : JavaObject, IClassRef<RegistryKey<T>>, IFromHandle<RegistryKey<T>>
    where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => RegistryKey.Names;

    public static Class<RegistryKey<JavaObject>> ClassRef => RegistryKey.ClassRef;

    static Class<RegistryKey<T>> IClassRef<RegistryKey<T>>.ClassRef => new(ClassRef.ObjectRef);

    [Signature("method_31163")]
    public partial bool IsOf<E>(RegistryKey<E> registry) where E : JavaObject, IRegistry<E>, IClassRef<E>, IFromHandle<E>;

    [Signature("method_39752")]
    public partial Optional<RegistryKey<TKey>> TryCast<TKey, TRegistry>(RegistryKey<TRegistry> registryRef)
        where TKey : JavaObject, IClassRef<TKey>, IFromHandle<TKey>
        where TRegistry : JavaObject, IRegistry<TKey>, IClassRef<TRegistry>, IFromHandle<TRegistry>;

    [Signature("method_29177")]
    public partial Identifier GetValue();

    [Signature("method_41185")]
    public partial Identifier GetRegistry();
}

[MapName("net/minecraft/class_5321"), StaticGeneric(typeof(RegistryKey<>))]
public static partial class RegistryKey
{
    // [Signature("method_39154")]
    // public static partial <T> com.mojang.serialization.Codec<RegistryKey<T>> CreateCodec(RegistryKey<? extends Registry<T>> registry);

    [Signature("method_29179")]
    public static partial RegistryKey<TKey> Of<TKey, TRegistry>(RegistryKey<TRegistry> registry, Identifier value)
        where TKey : JavaObject, IClassRef<TKey>, IFromHandle<TKey> where TRegistry : JavaObject, IRegistry<TKey>, IClassRef<TRegistry>, IFromHandle<TRegistry>;

    [Signature("method_29180")]
    public static partial RegistryKey<Registry<T>> OfRegistry<T>(Identifier registry) where T : JavaObject, IClassRef<T>, IFromHandle<T>;
}