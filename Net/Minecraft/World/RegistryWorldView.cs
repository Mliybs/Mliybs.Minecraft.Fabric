using Java.Util.Function;
using Java.Util;
using Net.Minecraft.Entity.Ai;
using Net.Minecraft.Entity.Player;
using Net.Minecraft.Entity;
using Net.Minecraft.Util.Math;
using Net.Minecraft.Util.Shape;
using Net.Minecraft.Util;
using Net.Minecraft.Block.Entity;
using Net.Minecraft.Block;
using Net.Minecraft.Client.World;
using Net.Minecraft.Fluid;
using Net.Minecraft.Server.World;

namespace Net.Minecraft.World;

[MapName("net/minecraft/class_5423"), JavaInterface(typeof(IRegistryWorldView))]
public partial class RegistryWorldView : WorldView, IRegistryWorldView, IClassRef<RegistryWorldView>, IFromHandle<RegistryWorldView>
{
    public Java.Util.List<Minecraft.Entity.Entity> GetOtherEntities(Minecraft.Entity.Entity? except, Box box, Java.Util.Function.Predicate.PredicateDelegate<Minecraft.Entity.Entity> predicate) => EntityView.GetOtherEntitiesProxy(ObjectRef, except, box, predicate);

    public Java.Util.List<T> GetEntitiesByType<T>(TypeFilter<Minecraft.Entity.Entity, T> filter, Box box, Java.Util.Function.Predicate.PredicateDelegate<T> predicate) where T : Minecraft.Entity.Entity, IClassRef<T>, IFromHandle<T> => EntityView.GetEntitiesByTypeProxy(ObjectRef, filter, box, predicate);

    public Java.Util.List<T> GetEntitiesByClass<T>(Class<T> entityClass, Box box, Java.Util.Function.Predicate.PredicateDelegate<T> predicate) where T : Minecraft.Entity.Entity, IClassRef<T>, IFromHandle<T> => EntityView.GetEntitiesByClassProxy(ObjectRef, entityClass, box, predicate);

    public Java.Util.List<PlayerEntity> GetPlayers() => EntityView.GetPlayersProxy(ObjectRef);

    public Java.Util.List<Minecraft.Entity.Entity> GetOtherEntities(Minecraft.Entity.Entity? except, Box box) => EntityView.GetOtherEntitiesProxy(ObjectRef, except, box);

    public bool DoesNotIntersectEntities(Minecraft.Entity.Entity? except, VoxelShape shape) => EntityView.DoesNotIntersectEntitiesProxy(ObjectRef, except, shape);

    public Java.Util.List<T> GetNonSpectatingEntities<T>(Class<T> entityClass, Box box) where T : Minecraft.Entity.Entity, IClassRef<T>, IFromHandle<T> => EntityView.GetNonSpectatingEntitiesProxy(ObjectRef, entityClass, box);

    public Java.Util.List<VoxelShape> GetEntityCollisions(Minecraft.Entity.Entity? entity, Box box) => EntityView.GetEntityCollisionsProxy(ObjectRef, entity, box);

    public PlayerEntity? GetClosestPlayer(double x, double y, double z, double maxDistance, Java.Util.Function.Predicate.PredicateDelegate<Minecraft.Entity.Entity>? targetPredicate) => EntityView.GetClosestPlayerProxy(ObjectRef, x, y, z, maxDistance, targetPredicate);

    public PlayerEntity? GetClosestPlayer(Minecraft.Entity.Entity entity, double maxDistance) => EntityView.GetClosestPlayerProxy(ObjectRef, entity, maxDistance);

    public PlayerEntity? GetClosestPlayer(double x, double y, double z, double maxDistance, bool ignoreCreative) => EntityView.GetClosestPlayerProxy(ObjectRef, x, y, z, maxDistance, ignoreCreative);

    public bool IsPlayerInRange(double x, double y, double z, double range) => EntityView.IsPlayerInRangeProxy(ObjectRef, x, y, z, range);

    public PlayerEntity? GetClosestPlayer(TargetPredicate targetPredicate, LivingEntity entity) => EntityView.GetClosestPlayerProxy(ObjectRef, targetPredicate, entity);

    public PlayerEntity? GetClosestPlayer(TargetPredicate targetPredicate, LivingEntity entity, double x, double y, double z) => EntityView.GetClosestPlayerProxy(ObjectRef, targetPredicate, entity, x, y, z);

    public PlayerEntity? GetClosestPlayer(TargetPredicate targetPredicate, double x, double y, double z) => EntityView.GetClosestPlayerProxy(ObjectRef, targetPredicate, x, y, z);

    public T? GetClosestEntity<T, K>(Class<K> entityClass, TargetPredicate targetPredicate, LivingEntity? entity, double x, double y, double z, Box box) where T : LivingEntity, IClassRef<T>, IFromHandle<T> where K : JavaObject, T, IClassRef<K>, IFromHandle<K> => EntityView.GetClosestEntityProxy<T, K>(ObjectRef, entityClass, targetPredicate, entity, x, y, z, box);

    public T? GetClosestEntity<T, K>(Java.Util.IList<K> entityList, TargetPredicate targetPredicate, LivingEntity? entity, double x, double y, double z) where T : LivingEntity, IClassRef<T>, IFromHandle<T> where K : JavaObject, T, IClassRef<K>, IFromHandle<K> => EntityView.GetClosestEntityProxy<T, K>(ObjectRef, entityList, targetPredicate, entity, x, y, z);

    public Java.Util.List<PlayerEntity> GetPlayers(TargetPredicate targetPredicate, LivingEntity entity, Box box) => EntityView.GetPlayersProxy(ObjectRef, targetPredicate, entity, box);

    public Java.Util.List<T> GetTargets<T>(Class<T> entityClass, TargetPredicate targetPredicate, LivingEntity targetingEntity, Box box) where T : LivingEntity, IClassRef<T>, IFromHandle<T> => EntityView.GetTargetsProxy(ObjectRef, entityClass, targetPredicate, targetingEntity, box);

    public PlayerEntity? GetPlayerByUuid(UUID uuid) => EntityView.GetPlayerByUuidProxy(ObjectRef, uuid);

    public bool TestBlockState(BlockPos pos, Java.Util.Function.Predicate.PredicateDelegate<BlockState> state) => TestableWorld.TestBlockStateProxy(ObjectRef, pos, state);

    public bool TestFluidState(BlockPos pos, Java.Util.Function.Predicate.PredicateDelegate<FluidState> state) => TestableWorld.TestFluidStateProxy(ObjectRef, pos, state);

    public bool SetBlockState(BlockPos pos, BlockState state, int flags, int maxUpdateDepth) => ModifiableWorld.SetBlockStateProxy(ObjectRef, pos, state, flags, maxUpdateDepth);

    public bool SetBlockState(BlockPos pos, BlockState state, int flags) => ModifiableWorld.SetBlockStateProxy(ObjectRef, pos, state, flags);

    public bool RemoveBlock(BlockPos pos, bool move) => ModifiableWorld.RemoveBlockProxy(ObjectRef, pos, move);

    public bool BreakBlock(BlockPos pos, bool drop) => ModifiableWorld.BreakBlockProxy(ObjectRef, pos, drop);

    public bool BreakBlock(BlockPos pos, bool drop, Minecraft.Entity.Entity? breakingEntity) => ModifiableWorld.BreakBlockProxy(ObjectRef, pos, drop, breakingEntity);

    public bool BreakBlock(BlockPos pos, bool drop, Minecraft.Entity.Entity? breakingEntity, int maxUpdateDepth) => ModifiableWorld.BreakBlockProxy(ObjectRef, pos, drop, breakingEntity, maxUpdateDepth);

    public bool SpawnEntity(Minecraft.Entity.Entity entity) => ModifiableWorld.SpawnEntityProxy(ObjectRef, entity);
}

[JavaInterface(typeof(RegistryWorldView))]
public partial interface IRegistryWorldView : IEntityView, IWorldView, IModifiableTestableWorld
{
}