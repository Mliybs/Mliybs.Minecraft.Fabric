using Net.Minecraft.Util;

namespace Net.Minecraft.Text;

[MapName("net/minecraft/class_5250")]
public partial class MutableText : JavaObject, IText, IClassRef<MutableText>, IFromHandle<MutableText>
{
    public Style GetStyle() => Text.GetStyleProxy(ObjectRef);

    public TextContent GetContent() => Text.GetContentProxy(ObjectRef);

    public string AsTruncatedString(int length) => Text.AsTruncatedStringProxy(ObjectRef, length);

    public Java.Util.List<Text> GetSiblings() => Text.GetSiblingsProxy(ObjectRef);

    public string? GetLiteralString() => Text.GetLiteralStringProxy(ObjectRef);

    public MutableText CopyContentOnly() => Text.CopyContentOnlyProxy(ObjectRef);

    public MutableText Copy() => Text.CopyProxy(ObjectRef);

    public OrderedText AsOrderedText() => Text.AsOrderedTextProxy(ObjectRef);

    public Java.Util.List<Text> WithoutStyle() => Text.WithoutStyleProxy(ObjectRef);

    public Java.Util.List<Text> GetWithStyle(Style style) => Text.GetWithStyleProxy(ObjectRef, style);

    public bool Contains(IText text) => Text.ContainsProxy(ObjectRef, text);

    [Signature("method_43477")]
    public static partial MutableText Of(TextContent content);

    [Signature("method_10862")]
    public partial MutableText SetStyle(Style style);

    [Signature("method_27693")]
    public partial MutableText Append(string text);

    [Signature("method_10852")]
    public partial MutableText Append(Text text);

    // [Signature("method_27694")]
    // public partial MutableText Styled(UnaryOperator<Style> styleUpdater);

    [Signature("method_27696")]
    public partial MutableText FillStyle(Style styleOverride);

    [Signature("method_27695")]
    public partial MutableText Formatted(JavaArray<Formatting> formattings);

    [Signature("method_27692")]
    public partial MutableText Formatted(Formatting formatting);

    [Signature("method_54663")]
    public partial MutableText WithColor(int color);
}
