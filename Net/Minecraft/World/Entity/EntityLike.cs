using Java.Util.Stream;
using Net.Minecraft.Util.Math;

namespace Net.Minecraft.World.Entity;

[MapName("net/minecraft/class_5568"), JavaInterface(typeof(IEntityLike))]
public partial class EntityLike : JavaObject, IEntityLike, IClassRef<EntityLike>, IFromHandle<EntityLike>
{
    [Signature("method_5628")]
    public partial int GetId();

    [Signature("method_5667")]
    public partial UUID GetUuid();

    [Signature("method_24515")]
    public partial BlockPos GetBlockPos();

    [Signature("method_5829")]
    public partial Box GetBoundingBox();

    [Signature("method_31744")]
    public partial void SetChangeListener(EntityChangeListener changeListener);

    [Signature("method_24204")]
    public partial Stream<EntityLike> StreamSelfAndPassengers();

    [Signature("method_31748")]
    public partial Stream<EntityLike> StreamPassengersAndSelf();

    [Signature("method_31745")]
    public partial void SetRemoved(global::Net.Minecraft.Entity.Entity.RemovalReason reason);

    [Signature("method_31746")]
    public partial bool ShouldSave();

    [Signature("method_31747")]
    public partial bool IsPlayer();
}

[JavaInterface(typeof(EntityLike))]
public partial interface IEntityLike
{
    int GetId();

    UUID GetUuid();

    BlockPos GetBlockPos();

    Box GetBoundingBox();

    void SetChangeListener(EntityChangeListener changeListener);

    Stream<EntityLike> StreamSelfAndPassengers();

    Stream<EntityLike> StreamPassengersAndSelf();

    void SetRemoved(global::Net.Minecraft.Entity.Entity.RemovalReason reason);

    bool ShouldSave();

    bool IsPlayer();
}