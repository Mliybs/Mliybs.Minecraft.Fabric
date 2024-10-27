namespace Net.Minecraft.Util.Registry;

[MapName("net/minecraft/class_2348")]
public partial class DefaultedRegistry<T> : SimpleRegistry<T>, IFromHandle<DefaultedRegistry<T>> where T : JavaClass, IClassRef
{
}

public sealed partial class DefaultedRegistry : DefaultedRegistry<InternalClass>
{
}