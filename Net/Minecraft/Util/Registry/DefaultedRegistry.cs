namespace Net.Minecraft.Util.Registry;

public partial class DefaultedRegistry<T> : SimpleRegistry<T>, IFromHandle<DefaultedRegistry<T>> where T : Java.Lang.Object, IClassRef
{
    internal static Names Names => DefaultedRegistry.Names;

    public static Class ClassRef => DefaultedRegistry.ClassRef;
}

[MapName("net/minecraft/class_2348")]
public static partial class DefaultedRegistry
{

}