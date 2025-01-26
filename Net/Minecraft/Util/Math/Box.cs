using Net.Minecraft.Util.Hit;

namespace Net.Minecraft.Util.Math;

[MapName("net/minecraft/class_238")]
public partial class Box : JavaObject, IClassRef<Box>, IFromHandle<Box>
{
    [JavaConstructor]
    public Box(double x1, double y1, double z1, double x2, double y2, double z2) : base(Box_DoubleDoubleDoubleDoubleDoubleDoubleInvoke(x1, y1, z1, x2, y2, z2))
    {}

    [JavaConstructor]
    public Box(BlockPos pos) : base(Box_BlockPosInvoke(pos))
    {}

    [JavaConstructor]
    public Box(Vec3d pos1, Vec3d pos2) : base(Box_Vec3dVec3dInvoke(pos1, pos2))
    {}

    [Signature("field_1323")]
    public partial double MinX { get; }

    [Signature("field_1322")]
    public partial double MinY { get; }

    [Signature("field_1321")]
    public partial double MinZ { get; }

    [Signature("field_1320")]
    public partial double MaxX { get; }

    [Signature("field_1325")]
    public partial double MaxY { get; }

    [Signature("field_1324")]
    public partial double MaxZ { get; }

    [Signature("method_19316")]
    public static partial Box From(BlockBox mutable);

    [Signature("method_29968")]
    public static partial Box From(Vec3d pos);

    [Signature("method_54784")]
    public static partial Box Enclosing(BlockPos pos1, BlockPos pos2);

    [Signature("method_35574")]
    public partial Box WithMinX(double minX);

    [Signature("method_35575")]
    public partial Box WithMinY(double minY);

    [Signature("method_35576")]
    public partial Box WithMinZ(double minZ);

    [Signature("method_35577")]
    public partial Box WithMaxX(double maxX);

    [Signature("method_35578")]
    public partial Box WithMaxY(double maxY);

    [Signature("method_35579")]
    public partial Box WithMaxZ(double maxZ);

    [Signature("method_1001")]
    public partial double GetMin(Direction.Axis axis);

    [Signature("method_990")]
    public partial double GetMax(Direction.Axis axis);

    [Signature("method_1002")]
    public partial Box Shrink(double x, double y, double z);

    [Signature("method_18804")]
    public partial Box Stretch(Vec3d scale);

    [Signature("method_1012")]
    public partial Box Stretch(double x, double y, double z);

    [Signature("method_1009")]
    public partial Box Expand(double x, double y, double z);

    [Signature("method_1014")]
    public partial Box Expand(double value);

    [Signature("method_999")]
    public partial Box Intersection(Box box);

    [Signature("method_991")]
    public partial Box Union(Box box);

    [Signature("method_989")]
    public partial Box Offset(double x, double y, double z);

    [Signature("method_996")]
    public partial Box Offset(BlockPos blockPos);

    [Signature("method_997")]
    public partial Box Offset(Vec3d vec);

    [Signature("method_994")]
    public partial bool Intersects(Box box);

    [Signature("method_1003")]
    public partial bool Intersects(double minX, double minY, double minZ, double maxX, double maxY, double maxZ);

    [Signature("method_993")]
    public partial bool Intersects(Vec3d pos1, Vec3d pos2);

    [Signature("method_1006")]
    public partial bool Contains(Vec3d pos);

    [Signature("method_1008")]
    public partial bool Contains(double x, double y, double z);

    [Signature("method_995")]
    public partial double GetAverageSideLength();

    [Signature("method_17939")]
    public partial double GetLengthX();

    [Signature("method_17940")]
    public partial double GetLengthY();

    [Signature("method_17941")]
    public partial double GetLengthZ();

    [Signature("method_35580")]
    public partial Box Contract(double x, double y, double z);

    [Signature("method_1011")]
    public partial Box Contract(double value);

    [Signature("method_992")]
    public partial Optional<Vec3d> Raycast(Vec3d min, Vec3d max);

    [Signature("method_1010")]
    public static partial BlockHitResult? Raycast(IIterable<Box> boxes, Vec3d from, Vec3d to, BlockPos pos);

    [Signature("method_49271")]
    public partial double SquaredMagnitude(Vec3d pos);

    [Signature("method_1013")]
    public partial bool IsNaN();

    [Signature("method_1005")]
    public partial Vec3d GetCenter();

    [Signature("method_30048")]
    public static partial Box Of(Vec3d center, double dx, double dy, double dz);
}
