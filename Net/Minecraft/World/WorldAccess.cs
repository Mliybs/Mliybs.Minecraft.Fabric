using Net.Minecraft.Block;
using Net.Minecraft.Client.World;
using Net.Minecraft.Entity.Player;
using Net.Minecraft.Entity;
using Net.Minecraft.Fluid;
using Net.Minecraft.Particle;
using Net.Minecraft.Server.World;
using Net.Minecraft.Server;
using Net.Minecraft.Sound;
using Net.Minecraft.Util.Math.Random;
using Net.Minecraft.Util.Math;
using Net.Minecraft.World.Biome.Source;
using Net.Minecraft.World.Chunk;
using Net.Minecraft.World.Event;
using Net.Minecraft.World.Tick;

namespace Net.Minecraft.World;

[MapName("net/minecraft/class_1936"), JavaInterface(typeof(IWorldAccess))]
public partial class WorldAccess : RegistryWorldView, IWorldAccess, IClassRef<WorldAccess>, IFromHandle<WorldAccess>
{
    public long GetLunarTime() => LunarWorldView.GetLunarTimeProxy(ObjectRef);

    public float GetMoonSize() => LunarWorldView.GetMoonSizeProxy(ObjectRef);

    public float GetSkyAngle(float tickDelta) => LunarWorldView.GetSkyAngleProxy(ObjectRef, tickDelta);

    public int GetMoonPhase() => LunarWorldView.GetMoonPhaseProxy(ObjectRef);

    [Signature("method_39224")]
    public partial long GetTickOrder();

    [Signature("method_8397")]
    public partial QueryableTickScheduler<Minecraft.Block.Block> GetBlockTickScheduler();

    [Signature("method_39280")]
    public partial void ScheduleBlockTick(BlockPos pos, Minecraft.Block.Block block, int delay, TickPriority priority);

    [Signature("method_39279")]
    public partial void ScheduleBlockTick(BlockPos pos, Minecraft.Block.Block block, int delay);

    [Signature("method_8405")]
    public partial QueryableTickScheduler<Fluid.Fluid> GetFluidTickScheduler();

    [Signature("method_39282")]
    public partial void ScheduleFluidTick(BlockPos pos, Fluid.Fluid fluid, int delay, TickPriority priority);

    [Signature("method_39281")]
    public partial void ScheduleFluidTick(BlockPos pos, Fluid.Fluid fluid, int delay);

    [Signature("method_8401")]
    public partial WorldProperties GetLevelProperties();

    [Signature("method_8404")]
    public partial LocalDifficulty GetLocalDifficulty(BlockPos pos);

    [Signature("method_8503")]
    public partial MinecraftServer? GetServer();

    [Signature("method_8407")]
    public partial Difficulty GetDifficulty();

    [Signature("method_8398")]
    public partial ChunkManager GetChunkManager();

    [Signature("method_8409")]
    public partial Util.Math.Random.Random GetRandom();

    [Signature("method_8408")]
    public partial void UpdateNeighbors(BlockPos pos, Minecraft.Block.Block block);

    [Signature("method_42308")]
    public partial void ReplaceWithStateForNeighborUpdate(Direction direction, BlockState neighborState, BlockPos pos, BlockPos neighborPos, int flags, int maxUpdateDepth);

    [Signature("method_45447")]
    public partial void PlaySound(PlayerEntity? except, BlockPos pos, SoundEvent sound, SoundCategory category);

    [Signature("method_8396")]
    public partial void PlaySound(PlayerEntity? source, BlockPos pos, SoundEvent sound, SoundCategory category, float volume, float pitch);

    [Signature("method_8406")]
    public partial void AddParticle(ParticleEffect parameters, double x, double y, double z, double velocityX, double velocityY, double velocityZ);

    [Signature("method_8444")]
    public partial void SyncWorldEvent(PlayerEntity? player, int eventId, BlockPos pos, int data);

    [Signature("method_20290")]
    public partial void SyncWorldEvent(int eventId, BlockPos pos, int data);

    [Signature("method_32888")]
    public partial void EmitGameEvent(GameEvent @event, Vec3d emitterPos, GameEvent.Emitter emitter);

    [Signature("method_43275")]
    public partial void EmitGameEvent(Minecraft.Entity.Entity? entity, GameEvent @event, Vec3d pos);

    [Signature("method_33596")]
    public partial void EmitGameEvent(Minecraft.Entity.Entity? entity, GameEvent @event, BlockPos pos);

    [Signature("method_43276")]
    public partial void EmitGameEvent(GameEvent @event, BlockPos pos, GameEvent.Emitter emitter);
}

[JavaInterface(typeof(WorldAccess))]
public partial interface IWorldAccess : IRegistryWorldView, ILunarWorldView
{
    long GetTickOrder();

    QueryableTickScheduler<Minecraft.Block.Block> GetBlockTickScheduler();

    public void ScheduleBlockTick(BlockPos pos, Minecraft.Block.Block block, int delay, TickPriority priority) => WorldAccess.ScheduleBlockTickProxy(ObjectRef, pos, block, delay, priority);

    public void ScheduleBlockTick(BlockPos pos, Minecraft.Block.Block block, int delay) => WorldAccess.ScheduleBlockTickProxy(ObjectRef, pos, block, delay);

    QueryableTickScheduler<Fluid.Fluid> GetFluidTickScheduler();

    public void ScheduleFluidTick(BlockPos pos, Fluid.Fluid fluid, int delay, TickPriority priority) => WorldAccess.ScheduleFluidTickProxy(ObjectRef, pos, fluid, delay, priority);

    public void ScheduleFluidTick(BlockPos pos, Fluid.Fluid fluid, int delay) => WorldAccess.ScheduleFluidTickProxy(ObjectRef, pos, fluid, delay);

    WorldProperties GetLevelProperties();

    LocalDifficulty GetLocalDifficulty(BlockPos pos);

    MinecraftServer? GetServer();

    public Difficulty GetDifficulty() => WorldAccess.GetDifficultyProxy(ObjectRef);

    ChunkManager GetChunkManager();

    Util.Math.Random.Random GetRandom();

    public void UpdateNeighbors(BlockPos pos, Minecraft.Block.Block block) => WorldAccess.UpdateNeighborsProxy(ObjectRef, pos, block);

    public void ReplaceWithStateForNeighborUpdate(Direction direction, BlockState neighborState, BlockPos pos, BlockPos neighborPos, int flags, int maxUpdateDepth) => WorldAccess.ReplaceWithStateForNeighborUpdateProxy(ObjectRef, direction, neighborState, pos, neighborPos, flags, maxUpdateDepth);

    public void PlaySound(PlayerEntity? except, BlockPos pos, SoundEvent sound, SoundCategory category) => WorldAccess.PlaySoundProxy(ObjectRef, except, pos, sound, category);

    void PlaySound(PlayerEntity? source, BlockPos pos, SoundEvent sound, SoundCategory category, float volume, float pitch);

    void AddParticle(ParticleEffect parameters, double x, double y, double z, double velocityX, double velocityY, double velocityZ);

    void SyncWorldEvent(PlayerEntity? player, int eventId, BlockPos pos, int data);

    public void SyncWorldEvent(int eventId, BlockPos pos, int data) => WorldAccess.SyncWorldEventProxy(ObjectRef, eventId, pos, data);

    void EmitGameEvent(GameEvent @event, Vec3d emitterPos, GameEvent.Emitter emitter);

    public void EmitGameEvent(Minecraft.Entity.Entity? entity, GameEvent @event, Vec3d pos) => WorldAccess.EmitGameEventProxy(ObjectRef, entity, @event, pos);

    public void EmitGameEvent(Minecraft.Entity.Entity? entity, GameEvent @event, BlockPos pos) => WorldAccess.EmitGameEventProxy(ObjectRef, entity, @event, pos);

    public void EmitGameEvent(GameEvent @event, BlockPos pos, GameEvent.Emitter emitter) => WorldAccess.EmitGameEventProxy(ObjectRef, @event, pos, emitter);
}