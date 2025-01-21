// using Java.IO;
using Java.Lang;
using Java.Util.Function;
using Java.Util;
using Net.Minecraft.Block.Entity;
using Net.Minecraft.Block;
using Net.Minecraft.Client.Render.Chunk;
using Net.Minecraft.Client.World;
using Net.Minecraft.Entity.Damage;
using Net.Minecraft.Entity.Player;
using Net.Minecraft.Entity.Ai;
using Net.Minecraft.Entity;
using Net.Minecraft.Fluid;
using Net.Minecraft.Item.Map;
using Net.Minecraft.Nbt;
using Net.Minecraft.Network.Packet;
using Net.Minecraft.Particle;
using Net.Minecraft.Recipe;
using Net.Minecraft.Registry.Entry;
using Net.Minecraft.Registry;
using Net.Minecraft.Resource.FeatureToggle;
using Net.Minecraft.Scoreboard;
using Net.Minecraft.Server.Command;
using Net.Minecraft.Server.World;
using Net.Minecraft.Server;
using Net.Minecraft.Sound;
using Net.Minecraft.Util.Crash;
using Net.Minecraft.Util.Math.Random;
using Net.Minecraft.Util.Math;
using Net.Minecraft.Util.Profiler;
using Net.Minecraft.Util.Shape;
using Net.Minecraft.Util.Hit;
using Net.Minecraft.Util;
using Net.Minecraft.World.Biome.Source;
using Net.Minecraft.World.Biome;
using Net.Minecraft.World.Block;
using Net.Minecraft.World.Border;
using Net.Minecraft.World.Chunk.Light;
using Net.Minecraft.World.Chunk;
using Net.Minecraft.World.Dimension;
using Net.Minecraft.World.Entity;
using Net.Minecraft.World.Explosion;
using Net.Minecraft.World.Event;
using Net.Minecraft.World.Gen.Chunk;
using Net.Minecraft.World.Tick;

namespace Net.Minecraft.World;

[MapName("net/minecraft/class_1937")]
public partial class World : JavaObject, IWorldAccess, IClassRef<World>, IFromHandle<World>
{
    public Java.Util.List<Minecraft.Entity.Entity> GetOtherEntities(Minecraft.Entity.Entity? except, Box box, Java.Util.Function.Predicate.PredicateDelegate<Minecraft.Entity.Entity> predicate) => EntityView.GetOtherEntitiesProxy(ObjectRef, except, box, predicate);

    public Java.Util.List<T> GetEntitiesByType<T>(TypeFilter<Minecraft.Entity.Entity, T> filter, Box box, Java.Util.Function.Predicate.PredicateDelegate<T> predicate) where T : Minecraft.Entity.Entity, IClassRef<T>, IFromHandle<T> => EntityView.GetEntitiesByTypeProxy(ObjectRef, filter, box, predicate);

    public Java.Util.List<T> GetEntitiesByClass<T>(Class<T> entityClass, Box box, Java.Util.Function.Predicate.PredicateDelegate<T> predicate) where T : Minecraft.Entity.Entity, IClassRef<T>, IFromHandle<T> => EntityView.GetEntitiesByClassProxy(ObjectRef, entityClass, box, predicate);

    public Java.Util.List<PlayerEntity> GetPlayers() => EntityView.GetPlayersProxy(ObjectRef);

    public Java.Util.List<Minecraft.Entity.Entity> GetOtherEntities(Minecraft.Entity.Entity? except, Box box) => EntityView.GetOtherEntitiesProxy(ObjectRef, except, box);

    public Java.Util.List<T> GetNonSpectatingEntities<T>(Class<T> entityClass, Box box) where T : Minecraft.Entity.Entity, IClassRef<T>, IFromHandle<T> => EntityView.GetNonSpectatingEntitiesProxy(ObjectRef, entityClass, box);

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

    public Chunk.Chunk? GetChunk(int chunkX, int chunkZ, ChunkStatus leastStatus, bool create) => WorldView.GetChunkProxy(ObjectRef, chunkX, chunkZ, leastStatus, create);

    [Obsolete]
    public bool IsChunkLoaded(int chunkX, int chunkZ) => WorldView.IsChunkLoadedProxy(ObjectRef, chunkX, chunkZ);

    public int GetTopY(Heightmap.Type heightmap, int x, int z) => WorldView.GetTopYProxy(ObjectRef, heightmap, x, z);

    public int GetAmbientDarkness() => WorldView.GetAmbientDarknessProxy(ObjectRef);

    public BiomeAccess GetBiomeAccess() => WorldView.GetBiomeAccessProxy(ObjectRef);

    public RegistryEntry<Biome.Biome> GetBiome(BlockPos pos) => WorldView.GetBiomeProxy(ObjectRef, pos);

    public Java.Util.Stream.Stream<BlockState> GetStatesInBoxIfLoaded(Box box) => WorldView.GetStatesInBoxIfLoadedProxy(ObjectRef, box);

    public RegistryEntry<Biome.Biome> GetGeneratorStoredBiome(int biomeX, int biomeY, int biomeZ) => WorldView.GetGeneratorStoredBiomeProxy(ObjectRef, biomeX, biomeY, biomeZ);

    public bool IsClient() => WorldView.IsClientProxy(ObjectRef);

    [Obsolete]
    public int GetSeaLevel() => WorldView.GetSeaLevelProxy(ObjectRef);

    public DimensionType GetDimension() => WorldView.GetDimensionProxy(ObjectRef);

    public BlockPos GetTopPosition(Heightmap.Type heightmap, BlockPos pos) => WorldView.GetTopPositionProxy(ObjectRef, heightmap, pos);

    public bool IsAir(BlockPos pos) => WorldView.IsAirProxy(ObjectRef, pos);

    public bool IsSkyVisibleAllowingSea(BlockPos pos) => WorldView.IsSkyVisibleAllowingSeaProxy(ObjectRef, pos);

    public float GetPhototaxisFavor(BlockPos pos) => WorldView.GetPhototaxisFavorProxy(ObjectRef, pos);

    [Obsolete]
    public float GetBrightness(BlockPos pos) => WorldView.GetBrightnessProxy(ObjectRef, pos);

    public Chunk.Chunk GetChunk(BlockPos pos) => WorldView.GetChunkProxy(ObjectRef, pos);

    public Chunk.Chunk GetChunk(int chunkX, int chunkZ) => WorldView.GetChunkProxy(ObjectRef, chunkX, chunkZ);

    public Chunk.Chunk GetChunk(int chunkX, int chunkZ, ChunkStatus status) => WorldView.GetChunkProxy(ObjectRef, chunkX, chunkZ, status);

    public bool IsWater(BlockPos pos) => WorldView.IsWaterProxy(ObjectRef, pos);

    public bool ContainsFluid(Box box) => WorldView.ContainsFluidProxy(ObjectRef, box);

    public int GetLightLevel(BlockPos pos) => WorldView.GetLightLevelProxy(ObjectRef, pos);

    public int GetLightLevel(BlockPos pos, int ambientDarkness) => WorldView.GetLightLevelProxy(ObjectRef, pos, ambientDarkness);

    [Obsolete]
    public bool IsPosLoaded(int x, int z) => WorldView.IsPosLoadedProxy(ObjectRef, x, z);

    [Obsolete]
    public bool IsChunkLoaded(BlockPos pos) => WorldView.IsChunkLoadedProxy(ObjectRef, pos);

    [Obsolete]
    public bool IsRegionLoaded(BlockPos min, BlockPos max) => WorldView.IsRegionLoadedProxy(ObjectRef, min, max);

    [Obsolete]
    public bool IsRegionLoaded(int minX, int minY, int minZ, int maxX, int maxY, int maxZ) => WorldView.IsRegionLoadedProxy(ObjectRef, minX, minY, minZ, maxX, maxY, maxZ);

    [Obsolete]
    public bool IsRegionLoaded(int minX, int minZ, int maxX, int maxZ) => WorldView.IsRegionLoadedProxy(ObjectRef, minX, minZ, maxX, maxZ);

    public DynamicRegistryManager GetRegistryManager() => WorldView.GetRegistryManagerProxy(ObjectRef);

    public FeatureSet GetEnabledFeatures() => WorldView.GetEnabledFeaturesProxy(ObjectRef);

    // public RegistryWrapper<T> CreateCommandRegistryWrapper<T, K, V>(IRegistryKey<V> registryRef) where T : JavaObject, IClassRef<T>, IFromHandle<T> where K : JavaObject, T, IClassRef<K>, IFromHandle<K> where V : JavaObject, IRegistry<K>, IClassRef<V>, IFromHandle<V>;

    public float GetBrightness(Direction direction, bool shaded) => BlockRenderView.GetBrightnessProxy(ObjectRef, direction, shaded);

    public LightingProvider GetLightingProvider() => BlockRenderView.GetLightingProviderProxy(ObjectRef);

    public int GetColor(BlockPos pos, ColorResolver colorResolver) => BlockRenderView.GetColorProxy(ObjectRef, pos, colorResolver);

    public int GetLightLevel(LightType type, BlockPos pos) => BlockRenderView.GetLightLevelProxy(ObjectRef, type, pos);

    public int GetBaseLightLevel(BlockPos pos, int ambientDarkness) => BlockRenderView.GetBaseLightLevelProxy(ObjectRef, pos, ambientDarkness);

    public bool IsSkyVisible(BlockPos pos) => BlockRenderView.IsSkyVisibleProxy(ObjectRef, pos);

    public BlockEntity? GetBlockEntity(BlockPos pos) => BlockView.GetBlockEntityProxy(ObjectRef, pos);

    public Optional<T> GetBlockEntity<T>(BlockPos pos, BlockEntityType<T> type) where T : BlockEntity, IClassRef<T>, IFromHandle<T> => BlockView.GetBlockEntityProxy(ObjectRef, pos, type);

    public BlockState GetBlockState(BlockPos pos) => BlockView.GetBlockStateProxy(ObjectRef, pos);

    public FluidState GetFluidState(BlockPos pos) => BlockView.GetFluidStateProxy(ObjectRef, pos);

    public int GetLuminance(BlockPos pos) => BlockView.GetLuminanceProxy(ObjectRef, pos);

    public int GetMaxLightLevel() => BlockView.GetMaxLightLevelProxy(ObjectRef);

    public Java.Util.Stream.Stream<BlockState> GetStatesInBox(Box box) => BlockView.GetStatesInBoxProxy(ObjectRef, box);

    public BlockHitResult Raycast(BlockStateRaycastContext context) => BlockView.RaycastProxy(ObjectRef, context);

    public BlockHitResult Raycast(RaycastContext context) => BlockView.RaycastProxy(ObjectRef, context);

    public BlockHitResult? RaycastBlock(Vec3d start, Vec3d end, BlockPos pos, VoxelShape shape, BlockState state) => BlockView.RaycastBlockProxy(ObjectRef, start, end, pos, shape, state);

    public double GetDismountHeight(VoxelShape blockCollisionShape, Supplier.SupplierDelegate<VoxelShape> belowBlockCollisionShapeGetter) => BlockView.GetDismountHeightProxy(ObjectRef, blockCollisionShape, belowBlockCollisionShapeGetter);

    public double GetDismountHeight(BlockPos pos) => BlockView.GetDismountHeightProxy(ObjectRef, pos);

    public int GetHeight() => HeightLimitView.GetHeightProxy(ObjectRef);

    public int GetBottomY() => HeightLimitView.GetBottomYProxy(ObjectRef);

    public int GetTopY() => HeightLimitView.GetTopYProxy(ObjectRef);

    public int CountVerticalSections() => HeightLimitView.CountVerticalSectionsProxy(ObjectRef);

    public int GetBottomSectionCoord() => HeightLimitView.GetBottomSectionCoordProxy(ObjectRef);

    public int GetTopSectionCoord() => HeightLimitView.GetTopSectionCoordProxy(ObjectRef);

    public bool IsOutOfHeightLimit(BlockPos pos) => HeightLimitView.IsOutOfHeightLimitProxy(ObjectRef, pos);

    public bool IsOutOfHeightLimit(int y) => HeightLimitView.IsOutOfHeightLimitProxy(ObjectRef, y);

    public int GetSectionIndex(int y) => HeightLimitView.GetSectionIndexProxy(ObjectRef, y);

    public int SectionCoordToIndex(int coord) => HeightLimitView.SectionCoordToIndexProxy(ObjectRef, coord);

    public int SectionIndexToCoord(int index) => HeightLimitView.SectionIndexToCoordProxy(ObjectRef, index);

    public WorldBorder GetWorldBorder() => CollisionView.GetWorldBorderProxy(ObjectRef);

    public BlockView? GetChunkAsView(int chunkX, int chunkZ) => CollisionView.GetChunkAsViewProxy(ObjectRef, chunkX, chunkZ);

    public bool DoesNotIntersectEntities(Minecraft.Entity.Entity? except, VoxelShape shape) => CollisionView.DoesNotIntersectEntitiesProxy(ObjectRef, except, shape);

    public bool CanPlace(BlockState state, BlockPos pos, ShapeContext context) => CollisionView.CanPlaceProxy(ObjectRef, state, pos, context);

    public bool DoesNotIntersectEntities(Minecraft.Entity.Entity entity) => CollisionView.DoesNotIntersectEntitiesProxy(ObjectRef, entity);

    public bool IsSpaceEmpty(Box box) => CollisionView.IsSpaceEmptyProxy(ObjectRef, box);

    public bool IsSpaceEmpty(Minecraft.Entity.Entity entity) => CollisionView.IsSpaceEmptyProxy(ObjectRef, entity);

    public bool IsSpaceEmpty(Minecraft.Entity.Entity? entity, Box box) => CollisionView.IsSpaceEmptyProxy(ObjectRef, entity, box);

    public bool IsBlockSpaceEmpty(Minecraft.Entity.Entity? entity, Box box) => CollisionView.IsBlockSpaceEmptyProxy(ObjectRef, entity, box);

    public Java.Util.List<VoxelShape> GetEntityCollisions(Minecraft.Entity.Entity? entity, Box box) => CollisionView.GetEntityCollisionsProxy(ObjectRef, entity, box);

    public Iterable<VoxelShape> GetCollisions(Minecraft.Entity.Entity? entity, Box box) => CollisionView.GetCollisionsProxy(ObjectRef, entity, box);

    public Iterable<VoxelShape> GetBlockCollisions(Minecraft.Entity.Entity? entity, Box box) => CollisionView.GetBlockCollisionsProxy(ObjectRef, entity, box);

    public bool CanCollide(Minecraft.Entity.Entity? entity, Box box) => CollisionView.CanCollideProxy(ObjectRef, entity, box);

    public Optional<BlockPos> FindSupportingBlockPos(Minecraft.Entity.Entity entity, Box box) => CollisionView.FindSupportingBlockPosProxy(ObjectRef, entity, box);

    public Optional<Vec3d> FindClosestCollision(Minecraft.Entity.Entity? entity, VoxelShape shape, Vec3d target, double x, double y, double z) => CollisionView.FindClosestCollisionProxy(ObjectRef, entity, shape, target, x, y, z);

    public int GetStrongRedstonePower(BlockPos pos, Direction direction) => RedstoneView.GetStrongRedstonePowerProxy(ObjectRef, pos, direction);

    public int GetReceivedStrongRedstonePower(BlockPos pos) => RedstoneView.GetReceivedStrongRedstonePowerProxy(ObjectRef, pos);

    public int GetEmittedRedstonePower(BlockPos pos, Direction direction, bool onlyFromGate) => RedstoneView.GetEmittedRedstonePowerProxy(ObjectRef, pos, direction, onlyFromGate);

    public bool IsEmittingRedstonePower(BlockPos pos, Direction direction) => RedstoneView.IsEmittingRedstonePowerProxy(ObjectRef, pos, direction);

    public int GetEmittedRedstonePower(BlockPos pos, Direction direction) => RedstoneView.GetEmittedRedstonePowerProxy(ObjectRef, pos, direction);

    public bool IsReceivingRedstonePower(BlockPos pos) => RedstoneView.IsReceivingRedstonePowerProxy(ObjectRef, pos);

    public int GetReceivedRedstonePower(BlockPos pos) => RedstoneView.GetReceivedRedstonePowerProxy(ObjectRef, pos);

    public RegistryEntry<Biome.Biome> GetBiomeForNoiseGen(int biomeX, int biomeY, int biomeZ) => BiomeAccess.Storage.GetBiomeForNoiseGenProxy(ObjectRef, biomeX, biomeY, biomeZ);

    public bool TestBlockState(BlockPos pos, Java.Util.Function.Predicate.PredicateDelegate<BlockState> state) => TestableWorld.TestBlockStateProxy(ObjectRef, pos, state);

    public bool TestFluidState(BlockPos pos, Java.Util.Function.Predicate.PredicateDelegate<FluidState> state) => TestableWorld.TestFluidStateProxy(ObjectRef, pos, state);

    public bool SetBlockState(BlockPos pos, BlockState state, int flags, int maxUpdateDepth) => ModifiableWorld.SetBlockStateProxy(ObjectRef, pos, state, flags, maxUpdateDepth);

    public bool SetBlockState(BlockPos pos, BlockState state, int flags) => ModifiableWorld.SetBlockStateProxy(ObjectRef, pos, state, flags);

    public bool RemoveBlock(BlockPos pos, bool move) => ModifiableWorld.RemoveBlockProxy(ObjectRef, pos, move);

    public bool BreakBlock(BlockPos pos, bool drop) => ModifiableWorld.BreakBlockProxy(ObjectRef, pos, drop);

    public bool BreakBlock(BlockPos pos, bool drop, Minecraft.Entity.Entity? breakingEntity) => ModifiableWorld.BreakBlockProxy(ObjectRef, pos, drop, breakingEntity);

    public bool BreakBlock(BlockPos pos, bool drop, Minecraft.Entity.Entity? breakingEntity, int maxUpdateDepth) => ModifiableWorld.BreakBlockProxy(ObjectRef, pos, drop, breakingEntity, maxUpdateDepth);

    public bool SpawnEntity(Minecraft.Entity.Entity entity) => ModifiableWorld.SpawnEntityProxy(ObjectRef, entity);

    public long GetLunarTime() => LunarWorldView.GetLunarTimeProxy(ObjectRef);

    public float GetMoonSize() => LunarWorldView.GetMoonSizeProxy(ObjectRef);

    public float GetSkyAngle(float tickDelta) => LunarWorldView.GetSkyAngleProxy(ObjectRef, tickDelta);

    public int GetMoonPhase() => LunarWorldView.GetMoonPhaseProxy(ObjectRef);

    public long GetTickOrder() => WorldAccess.GetTickOrderProxy(ObjectRef);

    public QueryableTickScheduler<Minecraft.Block.Block> GetBlockTickScheduler() => WorldAccess.GetBlockTickSchedulerProxy(ObjectRef);

    public void ScheduleBlockTick(BlockPos pos, Minecraft.Block.Block block, int delay, TickPriority priority) => WorldAccess.ScheduleBlockTickProxy(ObjectRef, pos, block, delay, priority);

    public void ScheduleBlockTick(BlockPos pos, Minecraft.Block.Block block, int delay) => WorldAccess.ScheduleBlockTickProxy(ObjectRef, pos, block, delay);

    public QueryableTickScheduler<Fluid.Fluid> GetFluidTickScheduler() => WorldAccess.GetFluidTickSchedulerProxy(ObjectRef);

    public void ScheduleFluidTick(BlockPos pos, Fluid.Fluid fluid, int delay, TickPriority priority) => WorldAccess.ScheduleFluidTickProxy(ObjectRef, pos, fluid, delay, priority);

    public void ScheduleFluidTick(BlockPos pos, Fluid.Fluid fluid, int delay) => WorldAccess.ScheduleFluidTickProxy(ObjectRef, pos, fluid, delay);

    public WorldProperties GetLevelProperties() => WorldAccess.GetLevelPropertiesProxy(ObjectRef);

    public LocalDifficulty GetLocalDifficulty(BlockPos pos) => WorldAccess.GetLocalDifficultyProxy(ObjectRef, pos);

    public MinecraftServer? GetServer() => WorldAccess.GetServerProxy(ObjectRef);

    public Difficulty GetDifficulty() => WorldAccess.GetDifficultyProxy(ObjectRef);

    public ChunkManager GetChunkManager() => WorldAccess.GetChunkManagerProxy(ObjectRef);

    public Util.Math.Random.Random GetRandom() => WorldAccess.GetRandomProxy(ObjectRef);

    public void UpdateNeighbors(BlockPos pos, Minecraft.Block.Block block) => WorldAccess.UpdateNeighborsProxy(ObjectRef, pos, block);

    public void ReplaceWithStateForNeighborUpdate(Direction direction, BlockState neighborState, BlockPos pos, BlockPos neighborPos, int flags, int maxUpdateDepth) => WorldAccess.ReplaceWithStateForNeighborUpdateProxy(ObjectRef, direction, neighborState, pos, neighborPos, flags, maxUpdateDepth);

    public void PlaySound(PlayerEntity? except, BlockPos pos, SoundEvent sound, SoundCategory category) => WorldAccess.PlaySoundProxy(ObjectRef, except, pos, sound, category);

    public void PlaySound(PlayerEntity? source, BlockPos pos, SoundEvent sound, SoundCategory category, float volume, float pitch) => WorldAccess.PlaySoundProxy(ObjectRef, source, pos, sound, category, volume, pitch);

    public void AddParticle(ParticleEffect parameters, double x, double y, double z, double velocityX, double velocityY, double velocityZ) => WorldAccess.AddParticleProxy(ObjectRef, parameters, x, y, z, velocityX, velocityY, velocityZ);

    public void SyncWorldEvent(PlayerEntity? player, int eventId, BlockPos pos, int data) => WorldAccess.SyncWorldEventProxy(ObjectRef, player, eventId, pos, data);

    public void SyncWorldEvent(int eventId, BlockPos pos, int data) => WorldAccess.SyncWorldEventProxy(ObjectRef, eventId, pos, data);

    public void EmitGameEvent(GameEvent @event, Vec3d emitterPos, GameEvent.Emitter emitter) => WorldAccess.EmitGameEventProxy(ObjectRef, @event, emitterPos, emitter);

    public void EmitGameEvent(Minecraft.Entity.Entity? entity, GameEvent @event, Vec3d pos) => WorldAccess.EmitGameEventProxy(ObjectRef, entity, @event, pos);

    public void EmitGameEvent(Minecraft.Entity.Entity? entity, GameEvent @event, BlockPos pos) => WorldAccess.EmitGameEventProxy(ObjectRef, entity, @event, pos);

    public void EmitGameEvent(GameEvent @event, BlockPos pos, GameEvent.Emitter emitter) => WorldAccess.EmitGameEventProxy(ObjectRef, @event, pos, emitter);

    [Signature("field_9236")]
    public partial bool IsClientProperty { get; }

    [Signature("method_24794")]
    public partial bool IsInBuildLimit(BlockPos pos);

    [Signature("method_25953")]
    public static partial bool IsValid(BlockPos pos);

    [Signature("method_8500")]
    public partial WorldChunk GetWorldChunk(BlockPos pos);

    [Signature("method_19282")]
    public partial void OnBlockChanged(BlockPos pos, BlockState oldBlock, BlockState newBlock);

    [Signature("method_31595")]
    public partial void AddBlockBreakParticles(BlockPos pos, BlockState state);

    [Signature("method_8501")]
    public partial bool SetBlockState(BlockPos pos, BlockState state);

    [Signature("method_8413")]
    public partial void UpdateListeners(BlockPos pos, BlockState oldState, BlockState newState, int flags);

    [Signature("method_16109")]
    public partial void ScheduleBlockRerenderIfNeeded(BlockPos pos, BlockState old, BlockState updated);

    [Signature("method_8452")]
    public partial void UpdateNeighborsAlways(BlockPos pos, Minecraft.Block.Block sourceBlock);

    [Signature("method_8508")]
    public partial void UpdateNeighborsExcept(BlockPos pos, Minecraft.Block.Block sourceBlock, Direction direction);

    [Signature("method_8492")]
    public partial void UpdateNeighbor(BlockPos pos, Minecraft.Block.Block sourceBlock, BlockPos sourcePos);

    [Signature("method_41410")]
    public partial void UpdateNeighbor(BlockState state, BlockPos pos, Minecraft.Block.Block sourceBlock, BlockPos sourcePos, bool notify);

    [Signature("method_8530")]
    public partial bool IsDay();

    [Signature("method_23886")]
    public partial bool IsNight();

    [Signature("method_45445")]
    public partial void PlaySound(Minecraft.Entity.Entity? source, BlockPos pos, SoundEvent sound, SoundCategory category, float volume, float pitch);

    [Signature("method_8465")]
    public partial void PlaySound(PlayerEntity? source, double x, double y, double z, IRegistryEntry<SoundEvent> sound, SoundCategory category, float volume, float pitch, long seed);

    [Signature("method_47967")]
    public partial void PlaySound(PlayerEntity? source, double x, double y, double z, SoundEvent sound, SoundCategory category, float volume, float pitch, long seed);

    [Signature("method_8449")]
    public partial void PlaySoundFromEntity(PlayerEntity? source, Minecraft.Entity.Entity entity, IRegistryEntry<SoundEvent> sound, SoundCategory category, float volume, float pitch, long seed);

    [Signature("method_54762")]
    public partial void PlaySound(PlayerEntity? source, double x, double y, double z, SoundEvent sound, SoundCategory category);

    [Signature("method_43128")]
    public partial void PlaySound(PlayerEntity? source, double x, double y, double z, SoundEvent sound, SoundCategory category, float volume, float pitch);

    [Signature("method_43129")]
    public partial void PlaySoundFromEntity(PlayerEntity? source, Minecraft.Entity.Entity entity, SoundEvent sound, SoundCategory category, float volume, float pitch);

    [Signature("method_45446")]
    public partial void PlaySoundAtBlockCenter(BlockPos pos, SoundEvent sound, SoundCategory category, float volume, float pitch, bool useDistance);

    [Signature("method_55116")]
    public partial void PlaySoundFromEntity(Minecraft.Entity.Entity entity, SoundEvent sound, SoundCategory category, float volume, float pitch);

    [Signature("method_8486")]
    public partial void PlaySound(double x, double y, double z, SoundEvent sound, SoundCategory category, float volume, float pitch, bool useDistance);

    [Signature("method_8466")]
    public partial void AddParticle(ParticleEffect parameters, bool alwaysSpawn, double x, double y, double z, double velocityX, double velocityY, double velocityZ);

    [Signature("method_8494")]
    public partial void AddImportantParticle(ParticleEffect parameters, double x, double y, double z, double velocityX, double velocityY, double velocityZ);

    [Signature("method_17452")]
    public partial void AddImportantParticle(ParticleEffect parameters, bool alwaysSpawn, double x, double y, double z, double velocityX, double velocityY, double velocityZ);

    [Signature("method_8442")]
    public partial float GetSkyAngleRadians(float tickDelta);

    [Signature("method_31594")]
    public partial void AddBlockEntityTicker(BlockEntityTickInvoker ticker);

    [Signature("method_18472")]
    public partial void TickEntity<T>(Consumer.ConsumerDelegate<T> tickConsumer, T entity) where T : Minecraft.Entity.Entity, IClassRef<T>, IFromHandle<T>;

    [Signature("method_38989")]
    public partial bool ShouldUpdatePostDeath(Minecraft.Entity.Entity entity);

    [Signature("method_39425")]
    public partial bool ShouldTickBlocksInChunk(long chunkPos);

    [Signature("method_41411")]
    public partial bool ShouldTickBlockPos(BlockPos pos);

    [Signature("method_8437")]
    public partial Explosion.Explosion CreateExplosion(Minecraft.Entity.Entity? entity, double x, double y, double z, float power, ExplosionSourceType explosionSourceType);

    [Signature("method_8537")]
    public partial Explosion.Explosion CreateExplosion(Minecraft.Entity.Entity? entity, double x, double y, double z, float power, bool createFire, ExplosionSourceType explosionSourceType);

    [Signature("method_46407")]
    public partial Explosion.Explosion CreateExplosion(Minecraft.Entity.Entity? entity, DamageSource? damageSource, ExplosionBehavior? behavior, Vec3d pos, float power, bool createFire, ExplosionSourceType explosionSourceType);

    [Signature("method_55117")]
    public partial Explosion.Explosion CreateExplosion(Minecraft.Entity.Entity? entity, DamageSource? damageSource, ExplosionBehavior? behavior, double x, double y, double z, float power, bool createFire, ExplosionSourceType explosionSourceType);

    [Signature("method_8454")]
    public partial Explosion.Explosion CreateExplosion(Minecraft.Entity.Entity? entity, DamageSource? damageSource, ExplosionBehavior? behavior, double x, double y, double z, float power, bool createFire, ExplosionSourceType explosionSourceType, ParticleEffect particle, ParticleEffect emitterParticle, SoundEvent soundEvent);

    [Signature("method_46668")]
    public partial Explosion.Explosion CreateExplosion(Minecraft.Entity.Entity? entity, DamageSource? damageSource, ExplosionBehavior? behavior, double x, double y, double z, float power, bool createFire, ExplosionSourceType explosionSourceType, bool particles, ParticleEffect particle, ParticleEffect emitterParticle, SoundEvent soundEvent);

    [Signature("method_31419")]
    public partial string AsString();

    [Signature("method_8438")]
    public partial void AddBlockEntity(BlockEntity blockEntity);

    [Signature("method_8544")]
    public partial void RemoveBlockEntity(BlockPos pos);

    [Signature("method_8477")]
    public partial bool CanSetBlock(BlockPos pos);

    [Signature("method_24368")]
    public partial bool IsDirectionSolid(BlockPos pos, Minecraft.Entity.Entity entity, Direction direction);

    [Signature("method_8515")]
    public partial bool IsTopSolid(BlockPos pos, Minecraft.Entity.Entity entity);

    [Signature("method_8533")]
    public partial void CalculateAmbientDarkness();

    [Signature("method_8424")]
    public partial void SetMobSpawnOptions(bool spawnMonsters, bool spawnAnimals);

    [Signature("method_43126")]
    public partial BlockPos GetSpawnPos();

    [Signature("method_43127")]
    public partial float GetSpawnAngle();

    [Signature("method_47574")]
    public partial void CollectEntitiesByType<T, K>(TypeFilter<Minecraft.Entity.Entity, T> filter, Box box, Java.Util.Function.Predicate.PredicateDelegate<T> predicate, Java.Util.IList<K> result) where T : Minecraft.Entity.Entity, K, IClassRef<T>, IFromHandle<T> where K : JavaObject, IClassRef<K>, IFromHandle<K>;

    [Signature("method_47575")]
    public partial void CollectEntitiesByType<T, K>(TypeFilter<Minecraft.Entity.Entity, T> filter, Box box, Java.Util.Function.Predicate.PredicateDelegate<T> predicate, Java.Util.IList<K> result, int limit) where T : Minecraft.Entity.Entity, K, IClassRef<T>, IFromHandle<T> where K : JavaObject, IClassRef<K>, IFromHandle<K>;

    [Signature("method_8469")]
    public partial Minecraft.Entity.Entity? GetEntityById(int id);

    [Signature("method_8524")]
    public partial void MarkDirty(BlockPos pos);

    [Signature("method_8525")]
    public partial void Disconnect();

    [Signature("method_8510")]
    public partial long GetTime();

    [Signature("method_8532")]
    public partial long GetTimeOfDay();

    [Signature("method_8505")]
    public partial bool CanPlayerModifyAt(PlayerEntity player, BlockPos pos);

    [Signature("method_8421")]
    public partial void SendEntityStatus(Minecraft.Entity.Entity entity, sbyte status);

    [Signature("method_48760")]
    public partial void SendEntityDamage(Minecraft.Entity.Entity entity, DamageSource damageSource);

    [Signature("method_8427")]
    public partial void AddSyncedBlockEvent(BlockPos pos, Minecraft.Block.Block block, int type, int data);

    [Signature("method_8450")]
    public partial GameRules GetGameRules();

    [Signature("method_54719")]
    public partial TickManager GetTickManager();

    [Signature("method_8478")]
    public partial float GetThunderGradient(float delta);

    [Signature("method_8496")]
    public partial void SetThunderGradient(float thunderGradient);

    [Signature("method_8430")]
    public partial float GetRainGradient(float delta);

    [Signature("method_8519")]
    public partial void SetRainGradient(float rainGradient);

    [Signature("method_8546")]
    public partial bool IsThundering();

    [Signature("method_8419")]
    public partial bool IsRaining();

    [Signature("method_8520")]
    public partial bool HasRain(BlockPos pos);

    [Signature("method_17891")]
    public partial MapState? GetMapState(string id);

    [Signature("method_17890")]
    public partial void PutMapState(string id, MapState state);

    [Signature("method_17889")]
    public partial int GetNextMapId();

    [Signature("method_8474")]
    public partial void SyncGlobalEvent(int eventId, BlockPos pos, int data);

    [Signature("method_8538")]
    public partial CrashReportSection AddDetailsToCrashReport(CrashReport report);

    [Signature("method_8517")]
    public partial void SetBlockBreakingInfo(int entityId, BlockPos pos, int progress);

    [Signature("method_8547")]
    public partial void AddFireworkParticle(double x, double y, double z, double velocityX, double velocityY, double velocityZ, NbtCompound? nbt);

    [Signature("method_8428")]
    public partial Scoreboard.Scoreboard GetScoreboard();

    [Signature("method_8455")]
    public partial void UpdateComparators(BlockPos pos, Minecraft.Block.Block block);

    [Signature("method_8509")]
    public partial void SetLightningTicksLeft(int lightningTicksLeft);

    [Signature("method_8522")]
    public partial void SendPacket<T>(Packet<T> packet) where T : JavaObject, Network.Listener.IPacketListener, IClassRef<T>, IFromHandle<T>;

    [Signature("method_44013")]
    public partial RegistryKey<DimensionType> GetDimensionKey();

    [Signature("method_40134")]
    public partial RegistryEntry<DimensionType> GetDimensionEntry();

    [Signature("method_27983")]
    public partial RegistryKey<World> GetRegistryKey();

    [Signature("method_8433")]
    public partial RecipeManager GetRecipeManager();

    [Signature("method_8536")]
    public partial BlockPos GetRandomPosInChunk(int x, int y, int z, int int2);

    [Signature("method_8458")]
    public partial bool IsSavingDisabled();

    [Signature("method_16107")]
    public partial Profiler GetProfiler();

    [Signature("method_24367")]
    public partial Supplier<Profiler> GetProfilerSupplier();

    [Signature("method_27982")]
    public partial bool IsDebugWorld();

    [Signature("method_48963")]
    public partial DamageSources GetDamageSources();

    [MapName("class_7867")]
    public partial class ExplosionSourceType : Enum<ExplosionSourceType>, IClassRef<ExplosionSourceType>, IFromHandle<ExplosionSourceType>
    {
        [Signature("field_40888")]
        public static ExplosionSourceType NONE { get; private set; }

        [Signature("field_40889")]
        public static ExplosionSourceType BLOCK { get; private set; }

        [Signature("field_40890")]
        public static ExplosionSourceType MOB { get; private set; }

        [Signature("field_40891")]
        public static ExplosionSourceType TNT { get; private set; }

        [Signature("field_47332")]
        public static ExplosionSourceType BLOW { get; private set; }
    }
}
