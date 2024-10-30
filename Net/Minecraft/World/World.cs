using Net.Minecraft.Block.Entity;

namespace Net.Minecraft.World;

[MapName("net.minecraft.class_1937")]
public partial class World : Java.Lang.Object, IClassRef, IFromHandle<World>, IWorldAccess
{
    //[Signature("field_9236")]
    //public bool ISCLIENT { get; private set; }

    [Signature("method_8447")]
    public partial void AddBlockEntities(Collection<BlockEntity> blockEntities);

    public bool IsClient() => WorldView.IsClientProxy(ObjectRef);
}