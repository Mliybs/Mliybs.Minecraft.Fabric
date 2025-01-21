using Java.Util.Function;
using Java.Util;
using Net.Minecraft.Block.Entity;
using Net.Minecraft.Block;
using Net.Minecraft.Client.World;
using Net.Minecraft.Fluid;
using Net.Minecraft.Server.World;
using Net.Minecraft.Util.Math;

namespace Net.Minecraft.World;

[MapName("net/minecraft/class_3746"), JavaInterface(typeof(ITestableWorld))]
public partial class TestableWorld : JavaObject, ITestableWorld, IClassRef<TestableWorld>, IFromHandle<TestableWorld>
{
    [Signature("method_16358")]
    public partial bool TestBlockState(BlockPos pos, Java.Util.Function.Predicate.PredicateDelegate<BlockState> state);

    [Signature("method_35237")]
    public partial bool TestFluidState(BlockPos pos, Java.Util.Function.Predicate.PredicateDelegate<FluidState> state);

    [Signature("method_35230")]
    public partial Optional<T> GetBlockEntity<T>(BlockPos pos, BlockEntityType<T> type) where T : BlockEntity, IClassRef<T>, IFromHandle<T>;

    [Signature("method_8598")]
    public partial BlockPos GetTopPosition(Heightmap.Type heightmap, BlockPos pos);
}

[JavaInterface(typeof(TestableWorld))]
public partial interface ITestableWorld
{
    bool TestBlockState(BlockPos pos, Java.Util.Function.Predicate.PredicateDelegate<BlockState> state);

    bool TestFluidState(BlockPos pos, Java.Util.Function.Predicate.PredicateDelegate<FluidState> state);

    Optional<T> GetBlockEntity<T>(BlockPos pos, BlockEntityType<T> type) where T : BlockEntity, IClassRef<T>, IFromHandle<T>;

    BlockPos GetTopPosition(Heightmap.Type heightmap, BlockPos pos);
}