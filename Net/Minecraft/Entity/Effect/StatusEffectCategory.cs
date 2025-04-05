namespace Net.Minecraft.Entity.Effect;

[MapName("net/minecraft/class_4081")]
public partial class StatusEffectCategory : Enum<StatusEffectCategory>, IClassRef<StatusEffectCategory>, IFromHandle<StatusEffectCategory>
{
    [Signature("field_18271")]
    public static StatusEffectCategory BENEFICIAL { get; private set; }

    [Signature("field_18272")]
    public static StatusEffectCategory HARMFUL { get; private set; }

    [Signature("field_18273")]
    public static StatusEffectCategory NEUTRAL { get; private set; }
}
