using System;

namespace Net.Minecraft.World;

[MapName("net/minecraft/class_5424"), JavaInterface(typeof(ILunarWorldView))]
public partial class LunarWorldView : Java.Lang.Object, IClassRef, IFromHandle<LunarWorldView>, ILunarWorldView
{
    public bool IsClient() => WorldView.IsClientProxy(ObjectRef);
}

[JavaInterface(typeof(LunarWorldView))]
public partial interface ILunarWorldView : IWorldView
{

}