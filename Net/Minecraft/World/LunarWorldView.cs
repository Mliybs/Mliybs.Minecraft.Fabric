namespace Net.Minecraft.World;

[MapName("net/minecraft/class_5424"), JavaInterface(typeof(ILunarWorldView))]
public partial class LunarWorldView : WorldView, IClassRef<LunarWorldView>, IFromHandle<LunarWorldView>
{
    [Signature("method_30271")]
    public partial long GetLunarTime();

    [Signature("method_30272")]
    public partial float GetMoonSize();

    [Signature("method_30274")]
    public partial float GetSkyAngle(float tickDelta);

    [Signature("method_30273")]
    public partial int GetMoonPhase();
}

[JavaInterface(typeof(LunarWorldView))]
public partial interface ILunarWorldView : IWorldView
{
    long GetLunarTime();

    public float GetMoonSize() => LunarWorldView.GetMoonSizeProxy(ObjectRef);

    public float GetSkyAngle(float tickDelta) => LunarWorldView.GetSkyAngleProxy(ObjectRef, tickDelta);

    public int GetMoonPhase() => LunarWorldView.GetMoonPhaseProxy(ObjectRef);
}