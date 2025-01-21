using Net.Minecraft.Block;
using Net.Minecraft.Client.World;
using Net.Minecraft.Entity;
using Net.Minecraft.Server.World;
using Net.Minecraft.Util.Math;

namespace Net.Minecraft.World;

[MapName("net/minecraft/class_3747"), JavaInterface(typeof(IModifiableTestableWorld))]
public partial class ModifiableTestableWorld : TestableWorld, IModifiableTestableWorld, IClassRef<ModifiableTestableWorld>, IFromHandle<ModifiableTestableWorld>
{
    public bool SetBlockState(BlockPos pos, BlockState state, int flags, int maxUpdateDepth) => ModifiableWorld.SetBlockStateProxy(ObjectRef, pos, state, flags, maxUpdateDepth);

    public bool SetBlockState(BlockPos pos, BlockState state, int flags) => ModifiableWorld.SetBlockStateProxy(ObjectRef, pos, state, flags);

    public bool RemoveBlock(BlockPos pos, bool move) => ModifiableWorld.RemoveBlockProxy(ObjectRef, pos, move);

    public bool BreakBlock(BlockPos pos, bool drop) => ModifiableWorld.BreakBlockProxy(ObjectRef, pos, drop);

    public bool BreakBlock(BlockPos pos, bool drop, Minecraft.Entity.Entity? breakingEntity) => ModifiableWorld.BreakBlockProxy(ObjectRef, pos, drop, breakingEntity);

    public bool BreakBlock(BlockPos pos, bool drop, Minecraft.Entity.Entity? breakingEntity, int maxUpdateDepth) => ModifiableWorld.BreakBlockProxy(ObjectRef, pos, drop, breakingEntity, maxUpdateDepth);

    public bool SpawnEntity(Minecraft.Entity.Entity entity) => ModifiableWorld.SpawnEntityProxy(ObjectRef, entity);
}

[JavaInterface(typeof(ModifiableTestableWorld))]
public partial interface IModifiableTestableWorld : ITestableWorld, IModifiableWorld
{}