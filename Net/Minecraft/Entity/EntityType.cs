namespace Net.Minecraft.Entity;

public partial class EntityType<T> : JavaObject, IClassRef<EntityType<T>>, IFromHandle<EntityType<T>> where T : Entity, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => EntityType.Names;

    public static Class<EntityType<Entity>> ClassRef => EntityType.ClassRef;

    static Class<EntityType<T>> IClassRef<EntityType<T>>.ClassRef => Class.Proxy<EntityType<T>>(ClassRef.ObjectRef);

    [Signature("method_5883")]
    public partial T? Create(World.World world);
}

[MapName("net/minecraft/class_1299"), StaticGeneric(typeof(EntityType<>))]
public static partial class EntityType
{
    public static Class<EntityType<Entity>> ClassRef => _classRef;
}