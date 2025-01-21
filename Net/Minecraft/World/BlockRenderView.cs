using Net.Minecraft.Client.Render.Chunk;
using Net.Minecraft.Client.World;
using Net.Minecraft.Server.World;
using Net.Minecraft.Util.Math;
using Net.Minecraft.World.Biome;
using Net.Minecraft.World.Chunk.Light;

namespace Net.Minecraft.World;

[MapName("net/minecraft/class_1920"), JavaInterface(typeof(IBlockRenderView))]
public partial class BlockRenderView : BlockView, IBlockRenderView, IClassRef<BlockRenderView>, IFromHandle<BlockRenderView>
{
    [Signature("method_24852")]
    public partial float GetBrightness(Direction direction, bool shaded);

    [Signature("method_22336")]
    public partial LightingProvider GetLightingProvider();

    [Signature("method_23752")]
    public partial int GetColor(BlockPos pos, ColorResolver colorResolver);

    [Signature("method_8314")]
    public partial int GetLightLevel(LightType type, BlockPos pos);

    [Signature("method_22335")]
    public partial int GetBaseLightLevel(BlockPos pos, int ambientDarkness);

    [Signature("method_8311")]
    public partial bool IsSkyVisible(BlockPos pos);
}

[JavaInterface(typeof(BlockRenderView))]
public partial interface IBlockRenderView : IBlockView
{
    float GetBrightness(Direction direction, bool shaded);

    LightingProvider GetLightingProvider();

    int GetColor(BlockPos pos, ColorResolver colorResolver);

    public int GetLightLevel(LightType type, BlockPos pos) => BlockRenderView.GetLightLevelProxy(ObjectRef, type, pos);

    public int GetBaseLightLevel(BlockPos pos, int ambientDarkness) => BlockRenderView.GetBaseLightLevelProxy(ObjectRef, pos, ambientDarkness);

    public bool IsSkyVisible(BlockPos pos) => BlockRenderView.IsSkyVisibleProxy(ObjectRef, pos);
}