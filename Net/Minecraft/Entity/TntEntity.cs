using Net.Minecraft.Block;
using Net.Minecraft.Entity.Data;
using Net.Minecraft.Nbt;
using Net.Minecraft.Scoreboard;
using Net.Minecraft.Server.Command;
using Net.Minecraft.Util;
using Net.Minecraft.World.Entity;
using Net.Minecraft.World;

namespace Net.Minecraft.Entity;

[MapName("net/minecraft/class_1541")]
public partial class TntEntity : Entity, IOwnable, IClassRef<TntEntity>, IFromHandle<TntEntity>
{
    [JavaConstructor]
    public TntEntity(EntityType<TntEntity> type, MCWorld world) : base(TntEntity_EntityType1WorldInvoke(type, world))
    {}

    [JavaConstructor]
    public TntEntity(MCWorld world, double x, double y, double z, LivingEntity? igniter) : base(TntEntity_WorldDoubleDoubleDoubleLivingEntityInvoke(world, x, y, z, igniter))
    {}

    Entity? IOwnable.GetOwner() => Ownable.GetOwnerProxy(ObjectRef);

    [Signature("method_6971")]
    private partial void Explode();

    [Signature("method_6970")]
    public partial LivingEntity? GetOwner();

    [Signature("method_6967")]
    public partial void SetFuse(int fuse);

    [Signature("method_6969")]
    public partial int GetFuse();

    [Signature("method_54455")]
    public partial void SetBlockState(BlockState state);

    [Signature("method_54456")]
    public partial BlockState GetBlockState();
}
