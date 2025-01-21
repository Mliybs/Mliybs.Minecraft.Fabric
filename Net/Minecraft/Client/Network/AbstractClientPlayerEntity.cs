using Net.Minecraft.Entity.Player;

namespace Net.Minecraft.Client.Network;

#if CLIENT
[MapName("net/minecraft/class_742")]
public partial class AbstractClientPlayerEntity : PlayerEntity, IClassRef<AbstractClientPlayerEntity>, IFromHandle<AbstractClientPlayerEntity>
{
}
#endif