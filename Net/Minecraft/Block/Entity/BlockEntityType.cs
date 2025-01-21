namespace Net.Minecraft.Block.Entity;

public partial class BlockEntityType<T> : JavaObject, IClassRef<BlockEntityType<T>>, IFromHandle<BlockEntityType<T>> where T : BlockEntity, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => BlockEntityType.Names;

    public static Class<BlockEntityType<BlockEntity>> ClassRef => BlockEntityType.ClassRef;

    static Class<BlockEntityType<T>> IClassRef<BlockEntityType<T>>.ClassRef => Class.Proxy<BlockEntityType<T>>(ClassRef.ObjectRef);
}

[MapName("net/minecraft/class_2591"), StaticGeneric(typeof(BlockEntityType<>))]
public static partial class BlockEntityType
{
    public static Class<BlockEntityType<BlockEntity>> ClassRef => _classRef;
}