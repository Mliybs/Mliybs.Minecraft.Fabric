using Java.Util.Stream;
using Net.Minecraft.Block;
using Net.Minecraft.Client.World;
using Net.Minecraft.Registry.Entry;
using Net.Minecraft.Registry;
using Net.Minecraft.Resource.FeatureToggle;
using Net.Minecraft.Server.World;
using Net.Minecraft.Util.Math;
using Net.Minecraft.Util.Shape;
using Net.Minecraft.World.Border;
using Net.Minecraft.World.Biome.Source;
using Net.Minecraft.World.Biome;
using Net.Minecraft.World.Chunk;
using Net.Minecraft.World.Dimension;

namespace Net.Minecraft.World;

[MapName("net/minecraft/class_4538"), JavaInterface(typeof(IWorldView))]
public partial class WorldView : BlockRenderView, IWorldView, ICollisionView, IRedstoneView, BiomeAccess.IStorage, IClassRef<WorldView>, IFromHandle<WorldView>
{
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

    [Signature("method_8402")]
    public partial Chunk.Chunk? GetChunk(int chunkX, int chunkZ, ChunkStatus leastStatus, bool create);

    [Signature("method_8393"), Obsolete]
    public partial bool IsChunkLoaded(int chunkX, int chunkZ);

    [Signature("method_8624")]
    public partial int GetTopY(Heightmap.Type heightmap, int x, int z);

    [Signature("method_8594")]
    public partial int GetAmbientDarkness();

    [Signature("method_22385")]
    public partial BiomeAccess GetBiomeAccess();

    [Signature("method_23753")]
    public partial RegistryEntry<Biome.Biome> GetBiome(BlockPos pos);

    [Signature("method_29556")]
    public partial Stream<BlockState> GetStatesInBoxIfLoaded(Box box);

    [Signature("method_22387")]
    public partial RegistryEntry<Biome.Biome> GetGeneratorStoredBiome(int biomeX, int biomeY, int biomeZ);

    [Signature("method_8608")]
    public partial bool IsClient();

    [Signature("method_8615"), Obsolete]
    public partial int GetSeaLevel();

    [Signature("method_8597")]
    public partial DimensionType GetDimension();

    [Signature("method_8598")]
    public partial BlockPos GetTopPosition(Heightmap.Type heightmap, BlockPos pos);

    [Signature("method_22347")]
    public partial bool IsAir(BlockPos pos);

    [Signature("method_22348")]
    public partial bool IsSkyVisibleAllowingSea(BlockPos pos);

    [Signature("method_42309")]
    public partial float GetPhototaxisFavor(BlockPos pos);

    [Signature("method_22349"), Obsolete]
    public partial float GetBrightness(BlockPos pos);

    [Signature("method_22350")]
    public partial Chunk.Chunk GetChunk(BlockPos pos);

    [Signature("method_8392")]
    public partial Chunk.Chunk GetChunk(int chunkX, int chunkZ);

    [Signature("method_22342")]
    public partial Chunk.Chunk GetChunk(int chunkX, int chunkZ, ChunkStatus status);

    [Signature("method_22351")]
    public partial bool IsWater(BlockPos pos);

    [Signature("method_22345")]
    public partial bool ContainsFluid(Box box);

    [Signature("method_22339")]
    public partial int GetLightLevel(BlockPos pos);

    [Signature("method_22346")]
    public partial int GetLightLevel(BlockPos pos, int ambientDarkness);

    [Signature("method_33598"), Obsolete]
    public partial bool IsPosLoaded(int x, int z);

    [Signature("method_22340"), Obsolete]
    public partial bool IsChunkLoaded(BlockPos pos);

    [Signature("method_22343"), Obsolete]
    public partial bool IsRegionLoaded(BlockPos min, BlockPos max);

    [Signature("method_22341"), Obsolete]
    public partial bool IsRegionLoaded(int minX, int minY, int minZ, int maxX, int maxY, int maxZ);

    [Signature("method_33597"), Obsolete]
    public partial bool IsRegionLoaded(int minX, int minZ, int maxX, int maxZ);

    [Signature("method_30349")]
    public partial DynamicRegistryManager GetRegistryManager();

    [Signature("method_45162")]
    public partial FeatureSet GetEnabledFeatures();

    // [Signature("method_45448")]
    // public partial RegistryWrapper<T> CreateCommandRegistryWrapper<T, K, V>(IRegistryKey<V> registryRef) where T : JavaObject, IClassRef<T>, IFromHandle<T> where K : JavaObject, T, IClassRef<K>, IFromHandle<K> where V : JavaObject, IRegistry<K>, IClassRef<V>, IFromHandle<V>;
}

[JavaInterface(typeof(WorldView))]
public partial interface IWorldView : IBlockRenderView, ICollisionView, IRedstoneView, BiomeAccess.IStorage
{
    Chunk.Chunk? GetChunk(int chunkX, int chunkZ, ChunkStatus leastStatus, bool create);

    [Obsolete]
    bool IsChunkLoaded(int chunkX, int chunkZ);

    int GetTopY(Heightmap.Type heightmap, int x, int z);

    int GetAmbientDarkness();

    BiomeAccess GetBiomeAccess();

    public RegistryEntry<Biome.Biome> GetBiome(BlockPos pos) => WorldView.GetBiomeProxy(ObjectRef, pos);

    public Stream<BlockState> GetStatesInBoxIfLoaded(Box box) => WorldView.GetStatesInBoxIfLoadedProxy(ObjectRef, box);

    RegistryEntry<Biome.Biome> GetGeneratorStoredBiome(int biomeX, int biomeY, int biomeZ);

    bool IsClient();

    [Obsolete]
    int GetSeaLevel();

    DimensionType GetDimension();

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

    DynamicRegistryManager GetRegistryManager();

    FeatureSet GetEnabledFeatures();

    // public RegistryWrapper<T> CreateCommandRegistryWrapper<T, K, V>(IRegistryKey<V> registryRef) where T : JavaObject, IClassRef<T>, IFromHandle<T> where K : JavaObject, T, IClassRef<K>, IFromHandle<K> where V : JavaObject, IRegistry<K>, IClassRef<V>, IFromHandle<V>;
}