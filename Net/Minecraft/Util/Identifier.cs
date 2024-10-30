namespace Net.Minecraft.Util;

[MapName("net/minecraft/class_2960")]
public partial class Identifier : Java.Lang.Object, IConstructor, IFromHandle<Identifier>
{
    [JavaConstructor]
    public Identifier(string id) : base(Identifier_StringInvoke(id))
    {}

    [JavaConstructor]
    public Identifier(string @namespace, string path) : base(Identifier_StringStringInvoke(@namespace, path))
    {}

    [Signature("method_12836")]
    public partial string GetNamespace();

    [Signature("method_12832")]
    public partial string GetPath();
}