#if CLIENT
// using It.Unimi.Dsi.Fastutil.Objects;
using Java.Util.Function;
using Java.Util;
// using Net.Fabricmc.Api;
using Net.Minecraft.Block;
using Net.Minecraft.Client.Network;
using Net.Minecraft.Client.Render;
using Net.Minecraft.Client;
using Net.Minecraft.Entity.Player;
using Net.Minecraft.Entity;
using Net.Minecraft.Fluid;
using Net.Minecraft.Item.Map;
using Net.Minecraft.Item;
using Net.Minecraft.Nbt;
using Net.Minecraft.Network.Packet;
using Net.Minecraft.Particle;
using Net.Minecraft.Recipe;
using Net.Minecraft.Registry.Entry;
using Net.Minecraft.Registry;
using Net.Minecraft.Resource.FeatureToggle;
using Net.Minecraft.Scoreboard;
using Net.Minecraft.Sound;
using Net.Minecraft.Util.Crash;
using Net.Minecraft.Util.Math.Random;
using Net.Minecraft.Util.Math;
using Net.Minecraft.Util.Profiler;
using Net.Minecraft.Util.Shape;
using Net.Minecraft.World.Biome.Source;
using Net.Minecraft.World.Biome;
using Net.Minecraft.World.Chunk;
using Net.Minecraft.World.Dimension;
using Net.Minecraft.World.Entity;
using Net.Minecraft.World.Event;
using Net.Minecraft.World.Tick;
using Net.Minecraft.World;

namespace Net.Minecraft.Client.World;

[MapName("net/minecraft/class_638")]
public partial class ClientWorld : MCWorld, IClassRef<ClientWorld>, IFromHandle<ClientWorld>
{
    [Signature("method_41927")]
    public partial void HandlePlayerActionResponse(int sequence);

    [Signature("method_41928")]
    public partial void HandleBlockUpdate(BlockPos pos, BlockState state, int flags);

    [Signature("method_41926")]
    public partial void ProcessPendingUpdate(BlockPos pos, BlockState state, Vec3d playerPos);

    [Signature("method_41925")]
    internal partial PendingUpdateManager GetPendingUpdateManager();

    [Signature("method_38536")]
    public partial void EnqueueChunkUpdate(Runnable.RunnableDelegate updater);

    [Signature("method_38534")]
    public partial void RunQueuedChunkUpdates();

    [Signature("method_38743")]
    public partial bool HasNoChunkUpdaters();

    [Signature("method_28103")]
    public partial DimensionEffects GetDimensionEffects();

    // [Signature("method_8441")]
    // public partial void Tick(BooleanSupplier shouldKeepTicking);

    [Signature("method_29090")]
    private partial void TickTime();

    [Signature("method_29089")]
    public partial void SetTime(long time);

    [Signature("method_8435")]
    public partial void SetTimeOfDay(long timeOfDay);

    [Signature("method_18112")]
    public partial Iterable<MCEntity> GetEntities();

    [Signature("method_18116")]
    public partial void TickEntities();

    [Signature("method_18646")]
    public partial void TickEntity(MCEntity entity);

    [Signature("method_18647")]
    private partial void TickPassenger(MCEntity entity, MCEntity passenger);

    [Signature("method_18110")]
    public partial void UnloadBlockEntities(WorldChunk chunk);

    [Signature("method_23782")]
    public partial void ResetChunkColor(ChunkPos chunkPos);

    [Signature("method_23784")]
    public partial void ReloadColor();

    [Signature("method_18120")]
    public partial int GetRegularEntityCount();

    [Signature("method_53875")]
    public partial void AddEntity(MCEntity entity);

    [Signature("method_2945")]
    public partial void RemoveEntity(int entityId, MCEntity.RemovalReason removalReason);

    [Signature("method_2941")]
    public partial void DoRandomBlockDisplayTicks(int centerX, int centerY, int centerZ);

    [Signature("method_35752")]
    private partial MCBlock? GetBlockParticle();

    [Signature("method_2943")]
    public partial void RandomBlockDisplayTick(int centerX, int centerY, int centerZ, int radius, MCRandom random, MCBlock? block, BlockPos.Mutable pos);

    [Signature("method_2938")]
    private partial void AddParticle(BlockPos pos, BlockState state, ParticleEffect parameters, bool solidBelow);

    [Signature("method_2948")]
    private partial void AddParticle(BlockPos pos, ParticleEffect parameters, VoxelShape shape, double y);

    [Signature("method_2932")]
    private partial void AddParticle(double minX, double maxX, double minZ, double maxZ, double y, ParticleEffect parameters);

    [Signature("method_43207")]
    private partial void PlaySound(double x, double y, double z, SoundEvent @event, SoundCategory category, float volume, float pitch, bool useDistance, long seed);

    [Signature("method_2944")]
    public partial void SetScoreboard(MCScoreboard scoreboard);

    [Signature("method_2935")]
    public partial ClientChunkManager GetChunkManager();

    [Signature("method_47437")]
    public partial void PutClientsideMapState(string id, MapState state);

    [Signature("method_18113")]
    public partial void ScheduleBlockRenders(int x, int y, int z);

    [Signature("method_23783")]
    public partial float GetSkyBrightness(float tickDelta);

    [Signature("method_23777")]
    public partial Vec3d GetSkyColor(Vec3d cameraPos, float tickDelta);

    [Signature("method_23785")]
    public partial Vec3d GetCloudsColor(float tickDelta);

    [Signature("method_23787")]
    public partial float Method_23787(float float2);

    [Signature("method_23789")]
    public partial int GetLightningTicksLeft();

    [Signature("method_23780")]
    public partial int CalculateColor(BlockPos pos, ColorResolver colorResolver);

    [Signature("method_27873")]
    public partial void SetSpawnPos(BlockPos pos, float angle);

    [Signature("method_28104")]
    public partial ClientWorld.Properties GetLevelProperties();

    [Signature("method_35754")]
    protected partial Map<JavaString, MapState> GetMapStates();

    [Signature("method_35753")]
    protected partial void PutMapStates(IMap<JavaString, MapState> mapStates);

    [Signature("method_39023")]
    public partial void SetSimulationDistance(int simulationDistance);

    [Signature("method_39024")]
    public partial int GetSimulationDistance();

    [MapName("class_5271")]
    public partial class Properties : JavaObject, IMutableWorldProperties, IClassRef<Properties>, IFromHandle<Properties>
    {
        [Signature("method_177")]
        public partial void SetTime(long time);

        [Signature("method_165")]
        public partial void SetTimeOfDay(long timeOfDay);

        [Signature("method_27875")]
        public partial void SetDifficulty(Difficulty difficulty);

        [Signature("method_27876")]
        public partial void SetDifficultyLocked(bool difficultyLocked);

        [Signature("method_28105")]
        public partial double GetSkyDarknessHeight(HeightLimitView world);

        [Signature("method_28106")]
        public partial float GetHorizonShadingRatio();
    }
}
#endif