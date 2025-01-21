using Net.Minecraft.Client.Render.Chunk;
using Net.Minecraft.Client.World;
using Net.Minecraft.Server.World;
using Net.Minecraft.Util.Math;
using Net.Minecraft.World.Chunk.Light;
using Net.Minecraft.World.Chunk;

namespace Net.Minecraft.World;

[MapName("net/minecraft/class_5539"), JavaInterface(typeof(IHeightLimitView))]
public partial class HeightLimitView : JavaObject, IHeightLimitView, IClassRef<HeightLimitView>, IFromHandle<HeightLimitView>
{
    [Signature("method_31605")]
    public partial int GetHeight();

    [Signature("method_31607")]
    public partial int GetBottomY();

    [Signature("method_31600")]
    public partial int GetTopY();

    [Signature("method_32890")]
    public partial int CountVerticalSections();

    [Signature("method_32891")]
    public partial int GetBottomSectionCoord();

    [Signature("method_31597")]
    public partial int GetTopSectionCoord();

    [Signature("method_31606")]
    public partial bool IsOutOfHeightLimit(BlockPos pos);

    [Signature("method_31601")]
    public partial bool IsOutOfHeightLimit(int y);

    [Signature("method_31602")]
    public partial int GetSectionIndex(int y);

    [Signature("method_31603")]
    public partial int SectionCoordToIndex(int coord);

    [Signature("method_31604")]
    public partial int SectionIndexToCoord(int index);

    [Signature("method_39034")]
    public static partial HeightLimitView Create(int bottomY, int height);
}

[JavaInterface(typeof(HeightLimitView))]
public partial interface IHeightLimitView
{
    int GetHeight();

    int GetBottomY();

    public int GetTopY() => HeightLimitView.GetTopYProxy(ObjectRef);

    public int CountVerticalSections() => HeightLimitView.CountVerticalSectionsProxy(ObjectRef);

    public int GetBottomSectionCoord() => HeightLimitView.GetBottomSectionCoordProxy(ObjectRef);

    public int GetTopSectionCoord() => HeightLimitView.GetTopSectionCoordProxy(ObjectRef);

    public bool IsOutOfHeightLimit(BlockPos pos) => HeightLimitView.IsOutOfHeightLimitProxy(ObjectRef, pos);

    public bool IsOutOfHeightLimit(int y) => HeightLimitView.IsOutOfHeightLimitProxy(ObjectRef, y);

    public int GetSectionIndex(int y) => HeightLimitView.GetSectionIndexProxy(ObjectRef, y);

    public int SectionCoordToIndex(int coord) => HeightLimitView.SectionCoordToIndexProxy(ObjectRef, coord);

    public int SectionIndexToCoord(int index) => HeightLimitView.SectionIndexToCoordProxy(ObjectRef, index);
}