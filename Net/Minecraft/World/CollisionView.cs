using Java.Util;
using Net.Minecraft.Block;
using Net.Minecraft.Client.World;
using Net.Minecraft.Entity;
using Net.Minecraft.Server.World;
using Net.Minecraft.Util.Math;
using Net.Minecraft.Util.Shape;
using Net.Minecraft.World.Border;
using Net.Minecraft.World.Chunk;

namespace Net.Minecraft.World;

[MapName("net/minecraft/class_1941"), JavaInterface(typeof(ICollisionView))]
public partial class CollisionView : BlockView, ICollisionView, IClassRef<CollisionView>, IFromHandle<CollisionView>
{
    [Signature("method_8621")]
    public partial WorldBorder GetWorldBorder();

    [Signature("method_22338")]
    public partial BlockView? GetChunkAsView(int chunkX, int chunkZ);

    [Signature("method_8611")]
    public partial bool DoesNotIntersectEntities(Minecraft.Entity.Entity? except, VoxelShape shape);

    [Signature("method_8628")]
    public partial bool CanPlace(BlockState state, BlockPos pos, ShapeContext context);

    [Signature("method_8606")]
    public partial bool DoesNotIntersectEntities(Minecraft.Entity.Entity entity);

    [Signature("method_18026")]
    public partial bool IsSpaceEmpty(Box box);

    [Signature("method_17892")]
    public partial bool IsSpaceEmpty(Minecraft.Entity.Entity entity);

    [Signature("method_8587")]
    public partial bool IsSpaceEmpty(Minecraft.Entity.Entity? entity, Box box);

    [Signature("method_52569")]
    public partial bool IsBlockSpaceEmpty(Minecraft.Entity.Entity? entity, Box box);

    [Signature("method_20743")]
    public partial Java.Util.List<VoxelShape> GetEntityCollisions(Minecraft.Entity.Entity? entity, Box box);

    [Signature("method_8600")]
    public partial Iterable<VoxelShape> GetCollisions(Minecraft.Entity.Entity? entity, Box box);

    [Signature("method_20812")]
    public partial Iterable<VoxelShape> GetBlockCollisions(Minecraft.Entity.Entity? entity, Box box);

    [Signature("method_39454")]
    public partial bool CanCollide(Minecraft.Entity.Entity? entity, Box box);

    [Signature("method_51718")]
    public partial Optional<BlockPos> FindSupportingBlockPos(Minecraft.Entity.Entity entity, Box box);

    [Signature("method_33594")]
    public partial Optional<Vec3d> FindClosestCollision(Minecraft.Entity.Entity? entity, VoxelShape shape, Vec3d target, double x, double y, double z);
}

[JavaInterface(typeof(CollisionView))]
public partial interface ICollisionView : IBlockView
{
    WorldBorder GetWorldBorder();

    BlockView? GetChunkAsView(int chunkX, int chunkZ);

    public bool DoesNotIntersectEntities(Minecraft.Entity.Entity? except, VoxelShape shape) => CollisionView.DoesNotIntersectEntitiesProxy(ObjectRef, except, shape);

    public bool CanPlace(BlockState state, BlockPos pos, ShapeContext context) => CollisionView.CanPlaceProxy(ObjectRef, state, pos, context);

    public bool DoesNotIntersectEntities(Minecraft.Entity.Entity entity) => CollisionView.DoesNotIntersectEntitiesProxy(ObjectRef, entity);

    public bool IsSpaceEmpty(Box box) => CollisionView.IsSpaceEmptyProxy(ObjectRef, box);

    public bool IsSpaceEmpty(Minecraft.Entity.Entity entity) => CollisionView.IsSpaceEmptyProxy(ObjectRef, entity);

    public bool IsSpaceEmpty(Minecraft.Entity.Entity? entity, Box box) => CollisionView.IsSpaceEmptyProxy(ObjectRef, entity, box);

    public bool IsBlockSpaceEmpty(Minecraft.Entity.Entity? entity, Box box) => CollisionView.IsBlockSpaceEmptyProxy(ObjectRef, entity, box);

    Java.Util.List<VoxelShape> GetEntityCollisions(Minecraft.Entity.Entity? entity, Box box);

    public Iterable<VoxelShape> GetCollisions(Minecraft.Entity.Entity? entity, Box box) => CollisionView.GetCollisionsProxy(ObjectRef, entity, box);

    public Iterable<VoxelShape> GetBlockCollisions(Minecraft.Entity.Entity? entity, Box box) => CollisionView.GetBlockCollisionsProxy(ObjectRef, entity, box);

    public bool CanCollide(Minecraft.Entity.Entity? entity, Box box) => CollisionView.CanCollideProxy(ObjectRef, entity, box);

    public Optional<BlockPos> FindSupportingBlockPos(Minecraft.Entity.Entity entity, Box box) => CollisionView.FindSupportingBlockPosProxy(ObjectRef, entity, box);

    public Optional<Vec3d> FindClosestCollision(Minecraft.Entity.Entity? entity, VoxelShape shape, Vec3d target, double x, double y, double z) => CollisionView.FindClosestCollisionProxy(ObjectRef, entity, shape, target, x, y, z);
}