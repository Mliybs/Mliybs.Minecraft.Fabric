using Java.Util.Function;
using Java.Util;
using Net.Minecraft.Client.World;
using Net.Minecraft.Entity.Ai;
using Net.Minecraft.Entity.Player;
using Net.Minecraft.Entity;
using Net.Minecraft.Server.World;
using Net.Minecraft.Util.Math;
using Net.Minecraft.Util.Shape;
using Net.Minecraft.Util;

namespace Net.Minecraft.World;

[MapName("net/minecraft/class_1924"), JavaInterface(typeof(IEntityView))]
public partial class EntityView : JavaObject, IClassRef<EntityView>, IFromHandle<EntityView>
{
    [Signature("method_8333")]
    public partial Java.Util.List<Minecraft.Entity.Entity> GetOtherEntities(Minecraft.Entity.Entity? except, Box box, Java.Util.Function.Predicate.PredicateDelegate<Minecraft.Entity.Entity> predicate);

    [Signature("method_18023")]
    public partial Java.Util.List<T> GetEntitiesByType<T>(TypeFilter<Minecraft.Entity.Entity, T> filter, Box box, Java.Util.Function.Predicate.PredicateDelegate<T> predicate) where T : Minecraft.Entity.Entity, IClassRef<T>, IFromHandle<T>;

    [Signature("method_8390")]
    public partial Java.Util.List<T> GetEntitiesByClass<T>(Class<T> entityClass, Box box, Java.Util.Function.Predicate.PredicateDelegate<T> predicate) where T : Minecraft.Entity.Entity, IClassRef<T>, IFromHandle<T>;

    [Signature("method_18456")]
    public partial Java.Util.List<PlayerEntity> GetPlayers();

    [Signature("method_8335")]
    public partial Java.Util.List<Minecraft.Entity.Entity> GetOtherEntities(Minecraft.Entity.Entity? except, Box box);

    [Signature("method_8611")]
    public partial bool DoesNotIntersectEntities(Minecraft.Entity.Entity? except, VoxelShape shape);

    [Signature("method_18467")]
    public partial Java.Util.List<T> GetNonSpectatingEntities<T>(Class<T> entityClass, Box box) where T : Minecraft.Entity.Entity, IClassRef<T>, IFromHandle<T>;

    [Signature("method_20743")]
    public partial Java.Util.List<VoxelShape> GetEntityCollisions(Minecraft.Entity.Entity? entity, Box box);

    [Signature("method_8604")]
    public partial PlayerEntity? GetClosestPlayer(double x, double y, double z, double maxDistance, Java.Util.Function.Predicate.PredicateDelegate<Minecraft.Entity.Entity>? targetPredicate);

    [Signature("method_18460")]
    public partial PlayerEntity? GetClosestPlayer(Minecraft.Entity.Entity entity, double maxDistance);

    [Signature("method_18459")]
    public partial PlayerEntity? GetClosestPlayer(double x, double y, double z, double maxDistance, bool ignoreCreative);

    [Signature("method_18458")]
    public partial bool IsPlayerInRange(double x, double y, double z, double range);

    [Signature("method_18462")]
    public partial PlayerEntity? GetClosestPlayer(TargetPredicate targetPredicate, LivingEntity entity);

    [Signature("method_18463")]
    public partial PlayerEntity? GetClosestPlayer(TargetPredicate targetPredicate, LivingEntity entity, double x, double y, double z);

    [Signature("method_18461")]
    public partial PlayerEntity? GetClosestPlayer(TargetPredicate targetPredicate, double x, double y, double z);

    [Signature("method_21726")]
    public partial T? GetClosestEntity<T, K>(Class<K> entityClass, TargetPredicate targetPredicate, LivingEntity? entity, double x, double y, double z, Box box) where T : LivingEntity, IClassRef<T>, IFromHandle<T> where K : JavaObject, T, IClassRef<K>, IFromHandle<K>;

    [Signature("method_18468")]
    public partial T? GetClosestEntity<T, K>(Java.Util.IList<K> entityList, TargetPredicate targetPredicate, LivingEntity? entity, double x, double y, double z) where T : LivingEntity, IClassRef<T>, IFromHandle<T> where K : JavaObject, T, IClassRef<K>, IFromHandle<K>;

    [Signature("method_18464")]
    public partial Java.Util.List<PlayerEntity> GetPlayers(TargetPredicate targetPredicate, LivingEntity entity, Box box);

    [Signature("method_18466")]
    public partial Java.Util.List<T> GetTargets<T>(Class<T> entityClass, TargetPredicate targetPredicate, LivingEntity targetingEntity, Box box) where T : LivingEntity, IClassRef<T>, IFromHandle<T>;

    [Signature("method_18470")]
    public partial PlayerEntity? GetPlayerByUuid(UUID uuid);
}

[JavaInterface(typeof(EntityView))]
public partial interface IEntityView
{
    Java.Util.List<Minecraft.Entity.Entity> GetOtherEntities(Minecraft.Entity.Entity? except, Box box, Java.Util.Function.Predicate.PredicateDelegate<Minecraft.Entity.Entity> predicate);

    Java.Util.List<T> GetEntitiesByType<T>(TypeFilter<Minecraft.Entity.Entity, T> filter, Box box, Java.Util.Function.Predicate.PredicateDelegate<T> predicate) where T : Minecraft.Entity.Entity, IClassRef<T>, IFromHandle<T>;

    public Java.Util.List<T> GetEntitiesByClass<T>(Class<T> entityClass, Box box, Java.Util.Function.Predicate.PredicateDelegate<T> predicate) where T : Minecraft.Entity.Entity, IClassRef<T>, IFromHandle<T> => EntityView.GetEntitiesByClassProxy(ObjectRef, entityClass, box, predicate);

    Java.Util.List<PlayerEntity> GetPlayers();

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
}