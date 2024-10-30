namespace Net.Minecraft.Util.Registry;

public partial class SimpleRegistry<T> : MutableRegistry<T>, IFromHandle<SimpleRegistry<T>> where T : Java.Lang.Object, IClassRef
{
    internal static Names Names => SimpleRegistry.Names;

    public static Class ClassRef => SimpleRegistry.ClassRef;
}

[MapName("net/minecraft/class_2370")]
public static partial class SimpleRegistry
{

}