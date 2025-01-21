using Java.Util.Function;
using Java.Util.Stream;
using Java.Util;
using Net.Minecraft.Block.Entity;
using Net.Minecraft.Block;
using Net.Minecraft.Client.Render.Chunk;
using Net.Minecraft.Client.World;
using Net.Minecraft.Fluid;
using Net.Minecraft.Server.World;
using Net.Minecraft.Util.Hit;
using Net.Minecraft.Util.Math;
using Net.Minecraft.Util.Shape;
using Net.Minecraft.World.Chunk.Light;
using Net.Minecraft.World.Chunk;

namespace Net.Minecraft.World;

[MapName("net/minecraft/class_1922"), JavaInterface(typeof(IBlockView))]
public partial class BlockView : HeightLimitView, IBlockView, IClassRef<BlockView>, IFromHandle<BlockView>
{
    [Signature("method_8321")]
    public partial BlockEntity? GetBlockEntity(BlockPos pos);

    [Signature("method_35230")]
    public partial Optional<T> GetBlockEntity<T>(BlockPos pos, BlockEntityType<T> type) where T : BlockEntity, IClassRef<T>, IFromHandle<T>;

    [Signature("method_8320")]
    public partial BlockState GetBlockState(BlockPos pos);

    [Signature("method_8316")]
    public partial FluidState GetFluidState(BlockPos pos);

    [Signature("method_8317")]
    public partial int GetLuminance(BlockPos pos);

    [Signature("method_8315")]
    public partial int GetMaxLightLevel();

    [Signature("method_29546")]
    public partial Stream<BlockState> GetStatesInBox(Box box);

    [Signature("method_32880")]
    public partial BlockHitResult Raycast(BlockStateRaycastContext context);

    [Signature("method_17742")]
    public partial BlockHitResult Raycast(RaycastContext context);

    [Signature("method_17745")]
    public partial BlockHitResult? RaycastBlock(Vec3d start, Vec3d end, BlockPos pos, VoxelShape shape, BlockState state);

    [Signature("method_30346")]
    public partial double GetDismountHeight(VoxelShape blockCollisionShape, Supplier.SupplierDelegate<VoxelShape> belowBlockCollisionShapeGetter);

    [Signature("method_30347")]
    public partial double GetDismountHeight(BlockPos pos);

    // [Signature("method_17744")]
    // public static T Raycast<T,C>(Vec3d start, Vec3d end, C context, BiFunction<C,BlockPos,T> blockHitFactory, Function<C,T> missFactory);
}

[JavaInterface(typeof(BlockView))]
public partial interface IBlockView : IHeightLimitView
{
    BlockEntity? GetBlockEntity(BlockPos pos);

    public Optional<T> GetBlockEntity<T>(BlockPos pos, BlockEntityType<T> type) where T : BlockEntity, IClassRef<T>, IFromHandle<T> => BlockView.GetBlockEntityProxy(ObjectRef, pos, type);

    BlockState GetBlockState(BlockPos pos);

    FluidState GetFluidState(BlockPos pos);

    public int GetLuminance(BlockPos pos) => BlockView.GetLuminanceProxy(ObjectRef, pos);

    public int GetMaxLightLevel() => BlockView.GetMaxLightLevelProxy(ObjectRef);

    public Stream<BlockState> GetStatesInBox(Box box) => BlockView.GetStatesInBoxProxy(ObjectRef, box);

    public BlockHitResult Raycast(BlockStateRaycastContext context) => BlockView.RaycastProxy(ObjectRef, context);

    public BlockHitResult Raycast(RaycastContext context) => BlockView.RaycastProxy(ObjectRef, context);

    public BlockHitResult? RaycastBlock(Vec3d start, Vec3d end, BlockPos pos, VoxelShape shape, BlockState state) => BlockView.RaycastBlockProxy(ObjectRef, start, end, pos, shape, state);

    public double GetDismountHeight(VoxelShape blockCollisionShape, Supplier.SupplierDelegate<VoxelShape> belowBlockCollisionShapeGetter) => BlockView.GetDismountHeightProxy(ObjectRef, blockCollisionShape, belowBlockCollisionShapeGetter);

    public double GetDismountHeight(BlockPos pos) => BlockView.GetDismountHeightProxy(ObjectRef, pos);
}