using Net.Minecraft.Item;
using Net.Minecraft.Util;
using System;

namespace Net.Minecraft.Entity;

[MapName("net/minecraft/class_1309")]
public partial class LivingEntity : Entity, IClassRef, IFromHandle<LivingEntity>
{
    [Signature("method_5998")]
    public partial ItemStack GetStackInHand(Hand hand);
}