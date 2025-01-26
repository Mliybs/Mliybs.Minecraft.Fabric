using Java.Util.Stream;

namespace Net.Minecraft.Util.Math;

[MapName("net/minecraft/class_2338")]
public partial class BlockPos : Vec3i, IClassRef<BlockPos>, IFromHandle<BlockPos>
{
    [JavaConstructor]
    public BlockPos(int x, int y, int z) : base(BlockPos_IntIntIntInvoke(x, y, z))
    {}

    [JavaConstructor]
    public BlockPos(Vec3i pos) : base(BlockPos_Vec3iInvoke(pos))
    {}

    [Signature("method_10060")]
    public static partial long Offset(long value, Direction direction);

    [Signature("method_10096")]
    public static partial long Add(long value, int x, int y, int z);

    [Signature("method_10061")]
    public static partial int UnpackLongX(long packedPos);

    [Signature("method_10071")]
    public static partial int UnpackLongY(long packedPos);

    [Signature("method_10083")]
    public static partial int UnpackLongZ(long packedPos);

    [Signature("method_10092")]
    public static partial BlockPos FromLong(long packedPos);

    [Signature("method_49637")]
    public static partial BlockPos OfFloored(double x, double y, double z);

    [Signature("method_49638")]
    public static partial BlockPos OfFloored(Position pos);

    [Signature("method_10063")]
    public partial long AsLong();

    [Signature("method_10064")]
    public static partial long AsLong(int x, int y, int z);

    [Signature("method_10091")]
    public static partial long RemoveChunkSectionLocalY(long y);

    [Signature("method_10069")]
    public partial BlockPos Add(int int2, int int3, int int4);

    [Signature("method_46558")]
    public partial Vec3d ToCenterPos();

    [Signature("method_10081")]
    public partial BlockPos Add(Vec3i vec3i);

    [Signature("method_10059")]
    public partial BlockPos Subtract(Vec3i vec3i);

    [Signature("method_35830")]
    public partial BlockPos Multiply(int int2);

    [Signature("method_10084")]
    public partial BlockPos Up();

    [Signature("method_10086")]
    public partial BlockPos Up(int distance);

    [Signature("method_10074")]
    public partial BlockPos Down();

    [Signature("method_10087")]
    public partial BlockPos Down(int int2);

    [Signature("method_10095")]
    public partial BlockPos North();

    [Signature("method_10076")]
    public partial BlockPos North(int distance);

    [Signature("method_10072")]
    public partial BlockPos South();

    [Signature("method_10077")]
    public partial BlockPos South(int distance);

    [Signature("method_10067")]
    public partial BlockPos West();

    [Signature("method_10088")]
    public partial BlockPos West(int distance);

    [Signature("method_10078")]
    public partial BlockPos East();

    [Signature("method_10089")]
    public partial BlockPos East(int distance);

    [Signature("method_10093")]
    public partial BlockPos Offset(Direction direction);

    [Signature("method_10079")]
    public partial BlockPos Offset(Direction direction, int int2);

    [Signature("method_30513")]
    public partial BlockPos Offset(Direction.Axis axis, int int2);

    [Signature("method_10070")]
    public partial BlockPos Rotate(BlockRotation rotation);

    [Signature("method_33096")]
    public partial BlockPos WithY(int y);

    [Signature("method_10062")]
    public partial BlockPos ToImmutable();

    [Signature("method_25503")]
    public partial Mutable MutableCopy();

    [Signature("method_34848")]
    public static partial Iterable<BlockPos> IterateRandomly(Random.Random random, int count, BlockPos around, int range);

    [Signature("method_51686"), Obsolete]
    public static partial Stream<BlockPos> StreamSouthEastSquare(BlockPos pos);

    [Signature("method_27156")]
    public static partial Iterable<BlockPos> IterateRandomly(Random.Random random, int count, int minX, int minY, int minZ, int maxX, int maxY, int maxZ);

    [Signature("method_25996")]
    public static partial Iterable<BlockPos> IterateOutwards(BlockPos center, int rangeX, int rangeY, int rangeZ);

    [Signature("method_25997")]
    public static partial Optional<BlockPos> FindClosest(BlockPos pos, int horizontalRange, int verticalRange, Java.Util.Function.Predicate.PredicateDelegate<BlockPos> condition);

    [Signature("method_25998")]
    public static partial Stream<BlockPos> StreamOutwards(BlockPos center, int maxX, int maxY, int maxZ);

    [Signature("method_10097")]
    public static partial Iterable<BlockPos> Iterate(BlockPos start, BlockPos end);

    [Signature("method_20437")]
    public static partial Stream<BlockPos> Stream(BlockPos start, BlockPos end);

    [Signature("method_23627")]
    public static partial Stream<BlockPos> Stream(BlockBox box);

    [Signature("method_29715")]
    public static partial Stream<BlockPos> Stream(Box box);

    [Signature("method_17962")]
    public static partial Stream<BlockPos> Stream(int startX, int startY, int startZ, int endX, int endY, int endZ);

    [Signature("method_10094")]
    public static partial Iterable<BlockPos> Iterate(int startX, int startY, int startZ, int endX, int endY, int endZ);

    [Signature("method_30512")]
    public static partial Iterable<Mutable> IterateInSquare(BlockPos center, int radius, Direction firstDirection, Direction secondDirection);

    // [Signature("method_49925")]
    // public static partial int IterateRecursively(BlockPos pos, int maxDepth, int maxIterations, BiConsumer<BlockPos,Consumer<BlockPos>> nextQueuer, Java.Util.Function.Predicate.PredicateDelegate<BlockPos> callback);

    [MapName("class_2339")]
    public partial class Mutable : BlockPos, IClassRef<Mutable>, IFromHandle<Mutable>
    {
        [JavaConstructor]
        public Mutable() : base(Mutable_Invoke())
        {}

        [JavaConstructor]
        public Mutable(int x, int y, int z) : base(Mutable_IntIntIntInvoke(x, y, z))
        {}

        [JavaConstructor]
        public Mutable(double x, double y, double z) : base(Mutable_DoubleDoubleDoubleInvoke(x, y, z))
        {}

        [Signature("method_10069")]
        public partial BlockPos Add(int int2, int int3, int int4);

        [Signature("method_35830")]
        public partial BlockPos Multiply(int int2);

        [Signature("method_10079")]
        public partial BlockPos Offset(Direction direction, int int2);

        [Signature("method_30513")]
        public partial BlockPos Offset(Direction.Axis axis, int int2);

        [Signature("method_10103")]
        public partial Mutable Set(int x, int y, int z);

        [Signature("method_10102")]
        public partial Mutable Set(double x, double y, double z);

        [Signature("method_10101")]
        public partial Mutable Set(Vec3i pos);

        [Signature("method_16363")]
        public partial Mutable Set(long pos);

        [Signature("method_17965")]
        public partial Mutable Set(AxisCycleDirection axis, int x, int y, int z);

        [Signature("method_25505")]
        public partial Mutable Set(Vec3i pos, Direction direction);

        [Signature("method_25504")]
        public partial Mutable Set(Vec3i pos, int x, int y, int z);

        [Signature("method_35831")]
        public partial Mutable Set(Vec3i vec1, Vec3i vec2);

        [Signature("method_10098")]
        public partial Mutable Move(Direction direction);

        [Signature("method_10104")]
        public partial Mutable Move(Direction direction, int distance);

        [Signature("method_10100")]
        public partial Mutable Move(int dx, int dy, int dz);

        [Signature("method_30927")]
        public partial Mutable Move(Vec3i vec);

        [Signature("method_27158")]
        public partial Mutable Clamp(Direction.Axis axis, int min, int max);
    }
}
