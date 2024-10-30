using System;

namespace Net.Minecraft.Entity.Effect;

[MapName("net/minecraft/class_1293")]
public partial class StatusEffectInstance : Java.Lang.Object, IClassRef, IFromHandle<StatusEffectInstance>
{
    [JavaConstructor]
    public StatusEffectInstance(StatusEffect effect) : base(StatusEffectInstance_StatusEffectInvoke(effect))
    { }

    [JavaConstructor]
    public StatusEffectInstance(StatusEffect type, int duration) : base(StatusEffectInstance_StatusEffectIntInvoke(type, duration))
    { }

    [JavaConstructor]
    public StatusEffectInstance(StatusEffect type, int duration, int amplifier) : base(StatusEffectInstance_StatusEffectIntIntInvoke(type, duration, amplifier))
    { }

    [JavaConstructor]
    public StatusEffectInstance(StatusEffect type, int duration, int amplifier, bool ambient, bool visible) : base(StatusEffectInstance_StatusEffectIntIntBoolBoolInvoke(type, duration, amplifier, ambient, visible))
    { }

    [JavaConstructor]
    public StatusEffectInstance(StatusEffect type, int duration, int amplifier, bool ambient, bool showParticles, bool showIcon) : base(StatusEffectInstance_StatusEffectIntIntBoolBoolBoolInvoke(type, duration, amplifier, ambient, showParticles, showIcon))
    { }

    [JavaConstructor]
    public StatusEffectInstance(StatusEffect type, int duration, int amplifier, bool ambient, bool showParticles, bool showIcon, StatusEffectInstance? hiddenEffect) : base(StatusEffectInstance_StatusEffectIntIntBoolBoolBoolStatusEffectInstanceInvoke(type, duration, amplifier, ambient, showParticles, showIcon, hiddenEffect))
    { }

    [JavaConstructor]
    public StatusEffectInstance(StatusEffectInstance statusEffectInstance) : base(StatusEffectInstance_StatusEffectInstanceInvoke(statusEffectInstance))
    { }
}