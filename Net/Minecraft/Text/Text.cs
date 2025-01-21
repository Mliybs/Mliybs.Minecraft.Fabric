using Net.Minecraft.Util;
using Net.Minecraft.Util.Math;

namespace Net.Minecraft.Text;

[MapName("net/minecraft/class_2561"), JavaInterface(typeof(IText))]
public partial class Text : JavaObject, IText, IClassRef<Text>, IFromHandle<Text>
{
    [Signature("method_10866")]
    public partial Style GetStyle();

    [Signature("method_10851")]
    public partial TextContent GetContent();

    [Signature("method_10858")]
    public partial string AsTruncatedString(int length);

    [Signature("method_10855")]
    public partial Java.Util.List<Text> GetSiblings();

    [Signature("method_54160")]
    public partial string? GetLiteralString();

    [Signature("method_27662")]
    public partial MutableText CopyContentOnly();

    [Signature("method_27661")]
    public partial MutableText Copy();

    [Signature("method_30937")]
    public partial OrderedText AsOrderedText();

    [Signature("method_44746")]
    public partial Java.Util.List<Text> WithoutStyle();

    [Signature("method_36136")]
    public partial Java.Util.List<Text> GetWithStyle(Style style);

    [Signature("method_44745")]
    public partial bool Contains(IText text);

    [Signature("method_30163")]
    public static partial Text Of(string? @string);

    [Signature("method_43470")]
    public static partial MutableText Literal(string @string);

    [Signature("method_43471")]
    public static partial MutableText Translatable(string key);

    [Signature("method_43469")]
    public static partial MutableText Translatable(string key, JavaArray<JavaObject> args);

    [Signature("method_54159")]
    public static partial MutableText StringifiedTranslatable(string key, JavaArray<JavaObject> args);

    [Signature("method_48321")]
    public static partial MutableText TranslatableWithFallback(string key, string? fallback);

    [Signature("method_48322")]
    public static partial MutableText TranslatableWithFallback(string key, string? fallback, JavaArray<JavaObject> args);

    [Signature("method_43473")]
    public static partial MutableText Empty();

    [Signature("method_43472")]
    public static partial MutableText Keybind(string @string);

    [Signature("method_43468")]
    public static partial MutableText Nbt(string rawPath, bool interpret, Optional<Text> separator, NbtDataSource dataSource);

    [Signature("method_43466")]
    public static partial MutableText Score(string name, string objective);

    [Signature("method_43467")]
    public static partial MutableText Selector(string pattern, Optional<Text> separator);

    // [Signature("method_54157")]
    // public static Text Of(Date date);

    // [Signature("method_54155")]
    // static Text Of(com.mojang.brigadier.Message message);

    [Signature("method_54158")]
    public static partial Text Of(UUID uuid);

    [Signature("method_54154")]
    public static partial Text Of(Identifier id);

    [Signature("method_54156")]
    public static partial Text Of(ChunkPos pos);
}

[JavaInterface(typeof(Text))]
public partial interface IText
{
    Style GetStyle();

    TextContent GetContent();

    string AsTruncatedString(int length);

    Java.Util.List<Text> GetSiblings();

    string? GetLiteralString();

    MutableText CopyContentOnly();

    MutableText Copy();

    OrderedText AsOrderedText();

    Java.Util.List<Text> WithoutStyle();

    Java.Util.List<Text> GetWithStyle(Style style);

    bool Contains(IText text);
}