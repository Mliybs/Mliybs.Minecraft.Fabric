// using It.Unimi.Dsi.Fastutil.Ints;
// using It.Unimi.Dsi.Fastutil.Longs;
// using It.Unimi.Dsi.Fastutil.Objects;
// using Java.Io;
// using Java.Nio.File;
// using Java.Util.Concurrent;
using Java.Util.Function;
using Java.Util.Stream;
using Java.Util;
using Net.Minecraft.Block;
using Net.Minecraft.Entity.Boss.Dragon;
using Net.Minecraft.Entity.Damage;
using Net.Minecraft.Entity.Mob;
using Net.Minecraft.Entity.Player;
using Net.Minecraft.Entity;
using Net.Minecraft.Fluid;
using Net.Minecraft.Item.Map;
using Net.Minecraft.Network.Packet;
using Net.Minecraft.Particle;
using Net.Minecraft.Recipe;
using Net.Minecraft.Registry.Entry;
using Net.Minecraft.Registry.Tag;
using Net.Minecraft.Registry;
using Net.Minecraft.Resource.FeatureToggle;
using Net.Minecraft.Scoreboard;
using Net.Minecraft.Server.Command;
using Net.Minecraft.Server.Network;
using Net.Minecraft.Server;
using Net.Minecraft.Sound;
using Net.Minecraft.Structure;
using Net.Minecraft.Util.Crash;
using Net.Minecraft.Util.Math.Intprovider;
using Net.Minecraft.Util.Math.Random;
using Net.Minecraft.Util.Math;
using Net.Minecraft.Util;
using Net.Minecraft.Village.Raid;
using Net.Minecraft.World.Biome.Source;
using Net.Minecraft.World.Biome;
using Net.Minecraft.World.Chunk;
using Net.Minecraft.World.Dimension;
using Net.Minecraft.World.Entity;
using Net.Minecraft.World.Event.Listener;
using Net.Minecraft.World.Event;
using Net.Minecraft.World.Explosion;
using Net.Minecraft.World.Gen.Structure;
using Net.Minecraft.World.Gen;
using Net.Minecraft.World.Level.Storage;
using Net.Minecraft.World.Level;
using Net.Minecraft.World.Poi;
using Net.Minecraft.World.Spawner;
using Net.Minecraft.World.Tick;
using Net.Minecraft.World;

namespace Net.Minecraft.Server.World;

[MapName("net/minecraft/class_3218")]
public partial class ServerWorld : MCWorld, IStructureWorldAccess, IClassRef<ServerWorld>, IFromHandle<ServerWorld>
{
    public ServerWorld ToServerWorld() => ServerWorldAccess.ToServerWorldProxy(ObjectRef);

    public void SpawnEntityAndPassengers(Minecraft.Entity.Entity entity) => ServerWorldAccess.SpawnEntityAndPassengersProxy(ObjectRef, entity);

    public long GetSeed() => StructureWorldAccess.GetSeedProxy(ObjectRef);

    public bool IsValidForSetBlock(BlockPos pos) => StructureWorldAccess.IsValidForSetBlockProxy(ObjectRef, pos);

    public void SetCurrentlyGeneratingStructureName(Supplier.SupplierDelegate<JavaString>? structureName) => StructureWorldAccess.SetCurrentlyGeneratingStructureNameProxy(ObjectRef, structureName);

    [Signature("method_51837"), Obsolete]
    public partial void SetEnderDragonFight(EnderDragonFight? enderDragonFight);

    [Signature("method_27910")]
    public partial void SetWeather(int clearDuration, int rainDuration, bool raining, bool thundering);

    [Signature("method_27056")]
    public partial StructureAccessor GetStructureAccessor();

    // [Signature("method_18765")]
    // public partial void Tick(BooleanSupplier shouldKeepTicking);

    [Signature("method_29203")]
    protected partial void TickTime();

    [Signature("method_29199")]
    public partial void SetTimeOfDay(long timeOfDay);

    [Signature("method_29202")]
    public partial void TickSpawners(bool spawnMonsters, bool spawnAnimals);

    [Signature("method_18203")]
    public partial void TickChunk(WorldChunk chunk, int randomTickSpeed);

    [Signature("method_52370")]
    public partial void TickIceAndSnow(BlockPos pos);

    [Signature("method_18210")]
    protected partial BlockPos GetLightningPos(BlockPos pos);

    [Signature("method_14177")]
    public partial bool IsInBlockTick();

    [Signature("method_33144")]
    public partial bool IsSleepingEnabled();

    [Signature("method_8448")]
    public partial void UpdateSleepingPlayers();

    [Signature("method_14170")]
    public partial ServerScoreboard GetScoreboard();

    [Signature("method_14195")]
    public partial void ResetWeather();

    [Signature("method_14197")]
    public partial void ResetIdleTimeout();

    [Signature("method_18762")]
    public partial void TickEntity(Entity.Entity entity);

    [Signature("method_14176")]
    public partial void Save(ProgressListener? progressListener, bool flush, bool savingDisabled);

    // [Signature("method_18198")]
    // public partial <T extends Entity> List<? extends T> GetEntitiesByType(TypeFilter<Entity.Entity, T> filter, Predicate<? super T> predicate);

    // [Signature("method_47538")]
    // public partial <T extends Entity> void CollectEntitiesByType(TypeFilter<Entity,T> filter, Predicate<? super T> predicate, List<? super T> result);

    // [Signature("method_47539")]
    // public partial <T extends Entity> void CollectEntitiesByType(TypeFilter<Entity,T> filter, Predicate<? super T> predicate, List<? super T> result, int limit);

    [Signature("method_18776")]
    public partial Java.Util.List<EnderDragonEntity> GetAliveEnderDragons();

    [Signature("method_18766")]
    public partial Java.Util.List<ServerPlayerEntity> GetPlayers(JavaPredicate.PredicateDelegate<ServerPlayerEntity> predicate);

    [Signature("method_47540")]
    public partial Java.Util.List<ServerPlayerEntity> GetPlayers(JavaPredicate.PredicateDelegate<ServerPlayerEntity> predicate, int limit);

    [Signature("method_18779")]
    public partial ServerPlayerEntity? GetRandomAlivePlayer();

    [Signature("method_18768")]
    public partial bool TryLoadEntity(Entity.Entity entity);

    [Signature("method_18769")]
    public partial void OnDimensionChanged(Entity.Entity entity);

    [Signature("method_18207")]
    public partial void OnPlayerTeleport(ServerPlayerEntity player);

    [Signature("method_18211")]
    public partial void OnPlayerChangeDimension(ServerPlayerEntity player);

    [Signature("method_18213")]
    public partial void OnPlayerConnected(ServerPlayerEntity player);

    [Signature("method_18215")]
    public partial void OnPlayerRespawned(ServerPlayerEntity player);

    [Signature("method_30736")]
    public partial bool SpawnNewEntityAndPassengers(Entity.Entity entity);

    [Signature("method_18764")]
    public partial void UnloadEntities(WorldChunk chunk);

    [Signature("method_18770")]
    public partial void RemovePlayer(ServerPlayerEntity player, Entity.Entity.RemovalReason reason);

    [Signature("method_32819")]
    public partial int GetLogicalHeight();

    [Signature("method_14178")]
    public partial ServerChunkManager GetChunkManager();

    // [Signature("method_14196")]
    // public partial WorldTickScheduler<Block.Block> GetBlockTickScheduler();

    // [Signature("method_14179")]
    // public partial WorldTickScheduler<Fluid.Fluid> GetFluidTickScheduler();

    [Signature("method_14173")]
    public partial PortalForcer GetPortalForcer();

    [Signature("method_14183")]
    public partial StructureTemplateManager GetStructureTemplateManager();

    [Signature("method_14199")]
    public partial int SpawnParticles<T>(T particle, double x, double y, double z, int count, double deltaX, double deltaY, double deltaZ, double speed) where T : ParticleEffect, IClassRef<T>, IFromHandle<T>;

    [Signature("method_14166")]
    public partial bool SpawnParticles<T>(ServerPlayerEntity viewer, T particle, bool force, double x, double y, double z, int count, double deltaX, double deltaY, double deltaZ, double speed) where T : ParticleEffect, IClassRef<T>, IFromHandle<T>;

    [Signature("method_31424"), Obsolete]
    public partial Entity.Entity? GetDragonPart(int id);

    [Signature("method_14190")]
    public partial Entity.Entity? GetEntity(UUID uuid);

    [Signature("method_8487")]
    public partial BlockPos? LocateStructure(TagKey<Minecraft.World.Gen.Structure.Structure> structureTag, BlockPos pos, int radius, bool skipReferencedStructures);

//     [Signature("method_42108")]
//     @Nullable
// public @Nullable com.mojang.datafixers.util.Pair<BlockPos,RegistryEntry<Biome>> LocateBiome(Predicate<RegistryEntry<Biome>> predicate, BlockPos pos, int radius, int horizontalBlockCheckInterval, int verticalBlockCheckInterval);

    [Signature("method_17983")]
    public partial PersistentStateManager GetPersistentStateManager();

    [Signature("method_8554")]
    public partial void SetSpawnPos(BlockPos pos, float angle);

    // [Signature("method_17984")]
    // public partial LongSet GetForcedChunks();

    [Signature("method_17988")]
    public partial bool SetChunkForced(int x, int z, bool forced);

    [Signature("method_19494")]
    public partial PointOfInterestStorage GetPointOfInterestStorage();

    [Signature("method_19500")]
    public partial bool IsNearOccupiedPointOfInterest(BlockPos pos);

    [Signature("method_20588")]
    public partial bool IsNearOccupiedPointOfInterest(ChunkSectionPos sectionPos);

    [Signature("method_19497")]
    public partial bool IsNearOccupiedPointOfInterest(BlockPos pos, int maxDistance);

    [Signature("method_19498")]
    public partial int GetOccupiedPointOfInterestDistance(ChunkSectionPos pos);

    [Signature("method_19495")]
    public partial RaidManager GetRaidManager();

    [Signature("method_19502")]
    public partial Raid? GetRaidAt(BlockPos pos);

    [Signature("method_19503")]
    public partial bool HasRaidAt(BlockPos pos);

    [Signature("method_19496")]
    public partial void HandleInteraction(EntityInteraction interaction, Entity.Entity entity, InteractionObserver observer);

    // [Signature("method_21625")]
    // public partial void Dump(Path path)

    [Signature("method_23658")]
    public partial void ClearUpdatesInArea(BlockBox box);

    [Signature("method_27909")]
    public partial Iterable<Entity.Entity> IterateEntities();

    [Signature("method_28125")]
    public partial bool IsFlat();

    [Signature("method_29198")]
    public partial EnderDragonFight? GetEnderDragonFight();

    [Signature("method_31268")]
    public partial string GetDebugString();

    [Signature("method_29200")]
    public static partial void CreateEndSpawnPlatform(ServerWorld world);

    [Signature("method_31423")]
    public partial void LoadEntities(IStream<Entity.Entity> entities);

    [Signature("method_31426")]
    public partial void AddEntities(IStream<Entity.Entity> entities);

    [Signature("method_39223")]
    public partial void DisableTickSchedulers(WorldChunk chunk);

    [Signature("method_39778")]
    public partial void CacheStructures(Minecraft.World.Chunk.Chunk chunk);

    [Signature("method_37116")]
    public partial bool IsChunkLoaded(long chunkPos);

    [Signature("method_37118")]
    public partial bool ShouldTickEntity(BlockPos pos);

    [Signature("method_39999")]
    public partial bool ShouldTick(BlockPos pos);

    [Signature("method_39998")]
    public partial bool ShouldTick(ChunkPos pos);

    [Signature("method_51836")]
    public partial Util.Math.Random.Random GetOrCreateRandom(Identifier id);

    [Signature("method_52168")]
    public partial RandomSequencesState GetRandomSequences();
}
