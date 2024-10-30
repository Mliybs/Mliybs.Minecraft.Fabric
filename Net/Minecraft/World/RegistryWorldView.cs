using System;

namespace Net.Minecraft.World;

[MapName("net/minecraft/class_5423"), JavaInterface(typeof(IRegistryWorldView))]
public partial class RegistryWorldView : Java.Lang.Object, IClassRef, IFromHandle<RegistryWorldView>, IRegistryWorldView
{
    public bool IsClient() => WorldView.IsClientProxy(ObjectRef);
}

[JavaInterface(typeof(RegistryWorldView))]
public partial interface IRegistryWorldView : IWorldView
{
}