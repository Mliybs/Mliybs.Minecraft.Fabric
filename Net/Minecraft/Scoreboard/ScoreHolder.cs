namespace Net.Minecraft.Scoreboard;

[MapName("net/minecraft/class_9015"), JavaInterface(typeof(IScoreHolder))]
public partial class ScoreHolder : JavaObject, IScoreHolder, IClassRef<ScoreHolder>, IFromHandle<ScoreHolder>
{
    [Signature("method_5820")]
    public partial string GetNameForScoreboard();

    [Signature("method_5476")]
    public partial Text.Text? GetDisplayName();

    [Signature("method_55423")]
    public partial Text.Text GetStyledDisplayName();

    [Signature("method_55422")]
    public static partial ScoreHolder FromName(string name);
}

[JavaInterface(typeof(ScoreHolder))]
public partial interface IScoreHolder
{
    string GetNameForScoreboard();

    public Text.Text? GetDisplayName() => ScoreHolder.GetDisplayNameProxy(ObjectRef);

    public Text.Text GetStyledDisplayName() => ScoreHolder.GetStyledDisplayNameProxy(ObjectRef);
}