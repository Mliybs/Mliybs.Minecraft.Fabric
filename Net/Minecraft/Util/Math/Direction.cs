namespace Net.Minecraft.Util.Math;

[MapName("net/minecraft/class_2350")]
public partial class Direction : JavaObject, IClassRef<Direction>, IFromHandle<Direction>
{
    [Signature("field_11033")]
    public static Direction DOWN { get; private set; }

    [Signature("field_11036")]
    public static Direction UP { get; private set; }

    [Signature("field_11043")]
    public static Direction NORTH { get; private set; }

    [Signature("field_11035")]
    public static Direction SOUTH { get; private set; }

    [Signature("field_11039")]
    public static Direction WEST { get; private set; }

    [Signature("field_11034")]
    public static Direction EAST { get; private set; }

    [MapName("class_2351")]
    public partial class Axis : Enum<Axis>, IClassRef<Axis>, IFromHandle<Axis>
    {
        [Signature("field_11048")]
        public static Axis X { get; private set; }

        [Signature("field_11052")]
        public static Axis Y { get; private set; }

        [Signature("field_11051")]
        public static Axis Z { get; private set; }
    }

    [MapName("class_2352")]
    public partial class AxisDirection : Enum<AxisDirection>, IClassRef<AxisDirection>, IFromHandle<AxisDirection>
    {
        [Signature("field_11056")]
        public static AxisDirection POSITIVE { get; private set; }

        [Signature("field_11060")]
        public static AxisDirection NEGATIVE { get; private set; }
    }

    [MapName("class_2353")]
    public partial class Type : Enum<Type>, IClassRef<Type>, IFromHandle<Type>
    {
        [Signature("field_11062")]
        public static Type HORIZONTAL { get; private set; }

        [Signature("field_11064")]
        public static Type VERTICAL { get; private set; }
    }
}
