using System;

namespace Net.Minecraft.World;

[MapName("net/minecraft/class_4538"), JavaInterface(typeof(IWorldView))]
public partial class WorldView : Java.Lang.Object, IClassRef, IFromHandle<WorldView>, IWorldView
{
    [Signature("method_8608")]
    public partial bool IsClient();
}

[JavaInterface(typeof(WorldView))]
public partial interface IWorldView
{
    bool IsClient();
}