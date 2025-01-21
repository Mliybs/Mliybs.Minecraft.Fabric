using Net.Minecraft.Block;
using Net.Minecraft.Client.World;
using Net.Minecraft.Entity;
using Net.Minecraft.Server.World;
using Net.Minecraft.Util.Math;

namespace Net.Minecraft.World;

[MapName("net/minecraft/class_1945"), JavaInterface(typeof(IModifiableWorld))]
public partial class ModifiableWorld : JavaObject, IModifiableWorld, IClassRef<ModifiableWorld>, IFromHandle<ModifiableWorld>
{
    [Signature("method_30092")]
    public partial bool SetBlockState(BlockPos pos, BlockState state, int flags, int maxUpdateDepth);

    [Signature("method_8652")]
    public partial bool SetBlockState(BlockPos pos, BlockState state, int flags);

    [Signature("method_8650")]
    public partial bool RemoveBlock(BlockPos pos, bool move);

    [Signature("method_22352")]
    public partial bool BreakBlock(BlockPos pos, bool drop);

    [Signature("method_8651")]
    public partial bool BreakBlock(BlockPos pos, bool drop, Minecraft.Entity.Entity? breakingEntity);

    [Signature("method_30093")]
    public partial bool BreakBlock(BlockPos pos, bool drop, Minecraft.Entity.Entity? breakingEntity, int maxUpdateDepth);

    [Signature("method_8649")]
    public partial bool SpawnEntity(Minecraft.Entity.Entity entity);
}

[JavaInterface(typeof(ModifiableWorld))]
public partial interface IModifiableWorld
{
    bool SetBlockState(BlockPos pos, BlockState state, int flags, int maxUpdateDepth);

    public bool SetBlockState(BlockPos pos, BlockState state, int flags) => ModifiableWorld.SetBlockStateProxy(ObjectRef, pos, state, flags);

    bool RemoveBlock(BlockPos pos, bool move);

    public bool BreakBlock(BlockPos pos, bool drop) => ModifiableWorld.BreakBlockProxy(ObjectRef, pos, drop);

    public bool BreakBlock(BlockPos pos, bool drop, Minecraft.Entity.Entity? breakingEntity) => ModifiableWorld.BreakBlockProxy(ObjectRef, pos, drop, breakingEntity);

    bool BreakBlock(BlockPos pos, bool drop, Minecraft.Entity.Entity? breakingEntity, int maxUpdateDepth);

    public bool SpawnEntity(Minecraft.Entity.Entity entity) => ModifiableWorld.SpawnEntityProxy(ObjectRef, entity);
}