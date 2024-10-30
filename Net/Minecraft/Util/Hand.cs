using System;

namespace Net.Minecraft.Util;

[MapName("net/minecraft/class_1268")]
public sealed partial class Hand : Java.Lang.Object, IClassRef, IFromHandle<Hand>, IJavaEnum<Hand>
{
    [JavaEnum]
    public static Hand MAIN_HAND { get; private set; }

    [JavaEnum]
    public static Hand OFF_HAND { get; private set; }

    [Signature("valueOf", false)]
    public static partial Hand ValueOf(string name);
}