namespace Net.Minecraft.Entity;

[MapName("net/minecraft/class_8046"), JavaInterface(typeof(IOwnable))]
public partial class Ownable : JavaObject, IClassRef<Ownable>, IFromHandle<Ownable>
{
    [Signature("method_24921")]
    public partial Entity? GetOwner();
}

[JavaInterface(typeof(Ownable))]
public partial interface IOwnable
{
    Entity? GetOwner();
}