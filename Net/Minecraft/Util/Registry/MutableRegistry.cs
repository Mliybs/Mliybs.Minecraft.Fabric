namespace Net.Minecraft.Util.Registry;

public partial class MutableRegistry<T> : Registry<T>, IFromHandle<MutableRegistry<T>> where T : Java.Lang.Object, IClassRef
{
    internal static Names Names => MutableRegistry.Names;

    public static Class ClassRef => MutableRegistry.ClassRef;
}

[MapName("net/minecraft/class_2385")]
public static partial class MutableRegistry
{

}