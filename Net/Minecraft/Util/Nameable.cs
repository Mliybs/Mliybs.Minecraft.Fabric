namespace Net.Minecraft.Util;

[MapName("net/minecraft/class_1275"), JavaInterface(typeof(INameable))]
public partial class Nameable : JavaObject, INameable, IClassRef<Nameable>, IFromHandle<Nameable>
{
    [Signature("method_5477")]
    public partial Text.Text GetName();

    [Signature("method_16914")]
    public partial bool HasCustomName();

    [Signature("method_5476")]
    public partial Text.Text GetDisplayName();

    [Signature("method_5797")]
    public partial Text.Text? GetCustomName();
}

[JavaInterface(typeof(Nameable))]
public partial interface INameable
{
    Text.Text GetName();

    public bool HasCustomName() => Nameable.HasCustomNameProxy(ObjectRef);

    public Text.Text GetDisplayName() => Nameable.GetDisplayNameProxy(ObjectRef);

    public Text.Text? GetCustomName() => Nameable.GetCustomNameProxy(ObjectRef);
}