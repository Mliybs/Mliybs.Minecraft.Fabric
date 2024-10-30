using System;

namespace Net.Minecraft.World;

[MapName("net/minecraft/class_1936"), JavaInterface(typeof(IWorldAccess))]
public partial class WorldAccess : Java.Lang.Object, IClassRef, IFromHandle<WorldAccess>, IWorldAccess
{
    public bool IsClient() => WorldView.IsClientProxy(ObjectRef);
}

[JavaInterface(typeof(WorldAccess))]
public partial interface IWorldAccess : IRegistryWorldView, ILunarWorldView
{

}