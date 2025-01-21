namespace Net.Minecraft.Util.Math;

[MapName("net/minecraft/class_2374"), JavaInterface(typeof(IPosition))]
public partial class Position : JavaObject, IPosition, IClassRef<Position>, IFromHandle<Position>
{
    [Signature("method_10216")]
    public partial double GetX();

    [Signature("method_10214")]
    public partial double GetY();

    [Signature("method_10215")]
    public partial double GetZ();
}

[JavaInterface(typeof(Position))]
public partial interface IPosition
{
    double GetX();
    double GetY();
    double GetZ();
}