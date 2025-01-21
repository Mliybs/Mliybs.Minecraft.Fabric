namespace Net.Minecraft.Util.Math;

[MapName("net/minecraft/class_243")]
public partial class Vec3d : JavaObject, IPosition, IClassRef<Vec3d>, IFromHandle<Vec3d>
{
    // [Signature("field_38277")]
    // public static com.mojang.serialization.Codec<Vec3d> CODEC { get; private set; }

    [Signature("field_1353")]
    public static Vec3d ZERO { get; private set; }

    [Signature("field_1352")]
    public partial double X { get; }

    [Signature("field_1351")]
    public partial double Y { get; }

    [Signature("field_1350")]
    public partial double Z { get; }

    [JavaConstructor]
    public Vec3d(double x, double y, double z) : base(Vec3d_DoubleDoubleDoubleInvoke(x, y, z))
    {}

    public double GetX() => Position.GetXProxy(ObjectRef);

    public double GetY() => Position.GetYProxy(ObjectRef);

    public double GetZ() => Position.GetZProxy(ObjectRef);
    
    [Signature("method_24457")]
    public static partial Vec3d UnpackRgb(int rgb);

    [Signature("method_24954")]
    public static partial Vec3d Of(Vec3i vec);

    [Signature("method_49273")]
    public static partial Vec3d Add(Vec3i vec, double deltaX, double deltaY, double deltaZ);

    [Signature("method_24953")]
    public static partial Vec3d OfCenter(Vec3i vec);

    [Signature("method_24955")]
    public static partial Vec3d OfBottomCenter(Vec3i vec);

    [Signature("method_26410")]
    public static partial Vec3d OfCenter(Vec3i vec, double deltaY);

    [Signature("method_1035")]
    public partial Vec3d Relativize(Vec3d vec);

    [Signature("method_1029")]
    public partial Vec3d Normalize();

    [Signature("method_1026")]
    public partial double DotProduct(Vec3d vec);

    [Signature("method_1036")]
    public partial Vec3d CrossProduct(Vec3d vec);

    [Signature("method_1020")]
    public partial Vec3d Subtract(Vec3d vec);

    [Signature("method_1023")]
    public partial Vec3d Subtract(double x, double y, double z);

    [Signature("method_1019")]
    public partial Vec3d Add(Vec3d vec);

    [Signature("method_1031")]
    public partial Vec3d Add(double x, double y, double z);

    [Signature("method_24802")]
    public partial bool IsInRange(IPosition pos, double radius);

    [Signature("method_1022")]
    public partial double DistanceTo(Vec3d vec);

    [Signature("method_1025")]
    public partial double SquaredDistanceTo(Vec3d vec);

    [Signature("method_1028")]
    public partial double SquaredDistanceTo(double x, double y, double z);

    [Signature("method_55230")]
    public partial bool IsWithinRangeOf(Vec3d vec, double horizontalRange, double verticalRange);

    [Signature("method_1021")]
    public partial Vec3d Multiply(double value);

    [Signature("method_22882")]
    public partial Vec3d Negate();

    [Signature("method_18806")]
    public partial Vec3d Multiply(Vec3d vec);

    [Signature("method_18805")]
    public partial Vec3d Multiply(double x, double y, double z);

    // [Signature("method_49272")]
    // public partial Vec3d AddRandom(Random random, float multiplier);

    [Signature("method_1033")]
    public partial double Length();

    [Signature("method_1027")]
    public partial double LengthSquared();

    [Signature("method_37267")]
    public partial double HorizontalLength();

    [Signature("method_37268")]
    public partial double HorizontalLengthSquared();

    [Signature("method_35590")]
    public partial Vec3d Lerp(Vec3d to, double delta);

    [Signature("method_1037")]
    public partial Vec3d RotateX(float angle);

    [Signature("method_1024")]
    public partial Vec3d RotateY(float angle);

    [Signature("method_31033")]
    public partial Vec3d RotateZ(float angle);

    [Signature("method_1034")]
    public static partial Vec3d FromPolar(Vec2f polar);

    [Signature("method_1030")]
    public static partial Vec3d FromPolar(float pitch, float yaw);

    // [Signature("method_1032")]
    // public partial Vec3d FloorAlongAxes(EnumSet<Direction.Axis> axes);

    // [Signature("method_18043")]
    // public partial double GetComponentAlongAxis(Direction.Axis axis);

    // [Signature("method_38499")]
    // public partial Vec3d WithAxis(Direction.Axis axis, double value);

    [Signature("method_43206")]
    public partial Vec3d Offset(Direction direction, double value);

    // [Signature("method_46409")]
    // public partial Vector3f ToVector3f();
}
