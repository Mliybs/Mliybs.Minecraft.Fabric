using Net.Minecraft.Util;
using Net.Minecraft.Item;

namespace Net.Minecraft.Entity;

[MapName("net/minecraft/class_1309")]
public partial class LivingEntity : Entity, IAttackable, IClassRef<LivingEntity>, IFromHandle<LivingEntity>
{
    public LivingEntity? GetLastAttacker() => Attackable.GetLastAttackerProxy(ObjectRef);

    [Signature("method_5998")]
    public partial ItemStack GetStackInHand(Hand hand);
}
