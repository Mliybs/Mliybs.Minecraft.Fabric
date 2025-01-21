using Net.Minecraft.Client.World;
using Net.Minecraft.Server.World;
using Net.Minecraft.Util.Math;

namespace Net.Minecraft.World;

[MapName("net/minecraft/class_8235"), JavaInterface(typeof(IRedstoneView))]
public partial class RedstoneView : BlockView, IRedstoneView, IClassRef<RedstoneView>, IFromHandle<RedstoneView>
{
    [Signature("method_49805")]
    public partial int GetStrongRedstonePower(BlockPos pos, Direction direction);

    [Signature("method_49809")]
    public partial int GetReceivedStrongRedstonePower(BlockPos pos);

    [Signature("method_49806")]
    public partial int GetEmittedRedstonePower(BlockPos pos, Direction direction, bool onlyFromGate);

    [Signature("method_49807")]
    public partial bool IsEmittingRedstonePower(BlockPos pos, Direction direction);

    [Signature("method_49808")]
    public partial int GetEmittedRedstonePower(BlockPos pos, Direction direction);

    [Signature("method_49803")]
    public partial bool IsReceivingRedstonePower(BlockPos pos);

    [Signature("method_49804")]
    public partial int GetReceivedRedstonePower(BlockPos pos);
}

[JavaInterface(typeof(RedstoneView))]
public partial interface IRedstoneView : IBlockView
{
    public int GetStrongRedstonePower(BlockPos pos, Direction direction) => RedstoneView.GetStrongRedstonePowerProxy(ObjectRef, pos, direction);

    public int GetReceivedStrongRedstonePower(BlockPos pos) => RedstoneView.GetReceivedStrongRedstonePowerProxy(ObjectRef, pos);

    public int GetEmittedRedstonePower(BlockPos pos, Direction direction, bool onlyFromGate) => RedstoneView.GetEmittedRedstonePowerProxy(ObjectRef, pos, direction, onlyFromGate);

    public bool IsEmittingRedstonePower(BlockPos pos, Direction direction) => RedstoneView.IsEmittingRedstonePowerProxy(ObjectRef, pos, direction);

    public int GetEmittedRedstonePower(BlockPos pos, Direction direction) => RedstoneView.GetEmittedRedstonePowerProxy(ObjectRef, pos, direction);

    public bool IsReceivingRedstonePower(BlockPos pos) => RedstoneView.IsReceivingRedstonePowerProxy(ObjectRef, pos);

    public int GetReceivedRedstonePower(BlockPos pos) => RedstoneView.GetReceivedRedstonePowerProxy(ObjectRef, pos);
}