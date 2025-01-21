using Net.Minecraft.Text;

namespace Net.Minecraft.Server.Command;

[MapName("net/minecraft/class_2165"), JavaInterface(typeof(ICommandOutput))]
public partial class CommandOutput : JavaObject, ICommandOutput, IClassRef<CommandOutput>, IFromHandle<CommandOutput>
{
    [Signature("method_43496")]
    public partial void SendMessage(IText message);

    [Signature("method_9200")]
    public partial bool ShouldReceiveFeedback();

    [Signature("method_9202")]
    public partial bool ShouldTrackOutput();

    [Signature("method_9201")]
    public partial bool ShouldBroadcastConsoleToOps();

    [Signature("method_36320")]
    public partial bool CannotBeSilenced();
}

[JavaInterface(typeof(CommandOutput))]
public partial interface ICommandOutput
{
    void SendMessage(IText message);
    bool ShouldReceiveFeedback();
    bool ShouldTrackOutput();
    bool ShouldBroadcastConsoleToOps();
    public bool CannotBeSilenced() => CommandOutput.CannotBeSilencedProxy(ObjectRef);
}