namespace Net.Minecraft.Util;

[MapName("net/minecraft/class_2960")]
public partial class Identifier : JavaObject, IClassRef<Identifier>, IFromHandle<Identifier>
{
    [JavaConstructor]
    public Identifier(string @namespace, string path) : base(Identifier_StringStringInvoke(@namespace, path))
    {}

    [JavaConstructor]
    public Identifier(string id) : base(Identifier_StringInvoke(id))
    {}

    [Signature("method_12838")]
    public static partial Identifier SplitOn(string id, char delimiter);

    [Signature("method_12829")]
    public static partial Identifier? TryParse(string id);

    [Signature("method_43902")]
    public static partial Identifier? Of(string @namespace, string path);

    [Signature("method_12832")]
    public partial string GetPath();

    [Signature("method_12836")]
    public partial string GetNamespace();

    [Signature("method_45136")]
    public partial Identifier WithPath(string path);

    [Signature("method_45138")]
    public partial Identifier WithPrefixedPath(string prefix);

    [Signature("method_48331")]
    public partial Identifier WithSuffixedPath(string suffix);
}
