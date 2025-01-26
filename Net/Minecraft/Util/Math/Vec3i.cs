namespace Net.Minecraft.Util.Math;

[MapName("net/minecraft/class_2382")]
public partial class Vec3i : JavaObject, IClassRef<Vec3i>, IFromHandle<Vec3i>
{
    // [Signature("method_39677")]
    // public static partial com.mojang.serialization.Codec<Vec3i> CreateOffsetCodec(int maxAbsValue);

    [Signature("method_10263")]
    public partial int GetX();

    [Signature("method_10264")]
    public partial int GetY();

    [Signature("method_10260")]
    public partial int GetZ();

    [Signature("method_20787")]
    protected partial Vec3i SetX(int x);

    [Signature("method_10099")]
    protected partial Vec3i SetY(int y);

    [Signature("method_20788")]
    protected partial Vec3i SetZ(int z);

    [Signature("method_34592")]
    public partial Vec3i Add(int x, int y, int z);

    [Signature("method_35853")]
    public partial Vec3i Add(Vec3i vec);

    [Signature("method_35852")]
    public partial Vec3i Subtract(Vec3i vec);

    [Signature("method_35862")]
    public partial Vec3i Multiply(int scale);

    [Signature("method_30931")]
    public partial Vec3i Up();

    [Signature("method_30930")]
    public partial Vec3i Up(int distance);

    [Signature("method_23228")]
    public partial Vec3i Down();

    [Signature("method_23227")]
    public partial Vec3i Down(int distance);

    [Signature("method_35861")]
    public partial Vec3i North();

    [Signature("method_35860")]
    public partial Vec3i North(int distance);

    [Signature("method_35859")]
    public partial Vec3i South();

    [Signature("method_35858")]
    public partial Vec3i South(int distance);

    [Signature("method_35857")]
    public partial Vec3i West();

    [Signature("method_35856")]
    public partial Vec3i West(int distance);

    [Signature("method_35855")]
    public partial Vec3i East();

    [Signature("method_35854")]
    public partial Vec3i East(int distance);

    [Signature("method_35851")]
    public partial Vec3i Offset(Direction direction);

    [Signature("method_23226")]
    public partial Vec3i Offset(Direction direction, int distance);

    [Signature("method_35850")]
    public partial Vec3i Offset(Direction.Axis axis, int distance);

    [Signature("method_10259")]
    public partial Vec3i CrossProduct(Vec3i vec);

    [Signature("method_19771")]
    public partial bool IsWithinDistance(Vec3i vec, double distance);

    [Signature("method_19769")]
    public partial bool IsWithinDistance(IPosition pos, double distance);

    [Signature("method_10262")]
    public partial double GetSquaredDistance(Vec3i vec);

    [Signature("method_19770")]
    public partial double GetSquaredDistance(IPosition pos);

    [Signature("method_10268")]
    public partial double GetSquaredDistanceFromCenter(double x, double y, double z);

    [Signature("method_40081")]
    public partial double GetSquaredDistance(double x, double y, double z);

    [Signature("method_19455")]
    public partial int GetManhattanDistance(Vec3i vec);

    // [Signature("method_30558")]
    // public partial int GetComponentAlongAxis(Direction.Axis axis);

    [Signature("method_23854")]
    public partial string ToShortString();
}
