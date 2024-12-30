namespace Net.Minecraft.Entity;

[MapName("net/minecraft/class_8149"), JavaInterface(typeof(IAttackable))]
public partial class Attackable : JavaObject, IAttackable, IClassRef<Attackable>, IFromHandle<Attackable>
{
    [Signature("method_49107")]
    public partial LivingEntity? GetLastAttacker();
}

[JavaInterface(typeof(Attackable))]
public partial interface IAttackable
{
    LivingEntity? GetLastAttacker();
}
