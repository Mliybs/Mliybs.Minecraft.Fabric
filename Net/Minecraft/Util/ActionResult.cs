namespace Net.Minecraft.Util;

[MapName("net/minecraft/class_1269")]
public partial class ActionResult : Java.Lang.Enum<ActionResult>, IClassRef<ActionResult>, IFromHandle<ActionResult>
{
    [Signature("field_5812")]
    public static ActionResult SUCCESS { get; private set;}
    
    [Signature("field_21466")]
    public static ActionResult CONSUME { get; private set;}
    
    [Signature("field_33562")]
    public static ActionResult CONSUME_PARTIAL { get; private set;}
    
    [Signature("field_5811")]
    public static ActionResult PASS { get; private set;}
    
    [Signature("field_5814")]
    public static ActionResult FAIL { get; private set;}

    [Signature("method_23665")]
    public partial bool IsAccepted();

    [Signature("method_23666")]
    public partial bool ShouldSwingHand();

    [Signature("method_36360")]
    public partial bool ShouldIncrementStat();

    [Signature("method_29236")]
    public static partial ActionResult Success(bool swingHand);

    [Signature("values", false)]
    public static partial JavaArray<ActionResult> Values();

    [Signature("valueOf", false)]
    public static partial ActionResult ValueOf(string name);
}
