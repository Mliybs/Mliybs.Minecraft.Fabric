using Java.Util;
using Net.Minecraft.Entity;
using Net.Minecraft.Nbt;

namespace Net.Minecraft.Entity.Effect;

[MapName("net/minecraft/class_1293")]
public partial class StatusEffectInstance : JavaObject, IClassRef<StatusEffectInstance>, IFromHandle<StatusEffectInstance>
{
    [JavaConstructor]
    public StatusEffectInstance(StatusEffect type) : base(StatusEffectInstance_StatusEffectInvoke(type))
    {}

    [JavaConstructor]
    public StatusEffectInstance(StatusEffect type, int duration) : base(StatusEffectInstance_StatusEffectIntInvoke(type, duration))
    {}

    [JavaConstructor]
    public StatusEffectInstance(StatusEffect type, int duration, int amplifier) : base(StatusEffectInstance_StatusEffectIntIntInvoke(type, duration, amplifier))
    {}

    [JavaConstructor]
    public StatusEffectInstance(StatusEffect type, int duration, int amplifier, bool ambient, bool visible) : base(StatusEffectInstance_StatusEffectIntIntBoolBoolInvoke(type, duration, amplifier, ambient, visible))
    {}

    [JavaConstructor]
    public StatusEffectInstance(StatusEffect type, int duration, int amplifier, bool ambient, bool showParticles, bool showIcon) : base(StatusEffectInstance_StatusEffectIntIntBoolBoolBoolInvoke(type, duration, amplifier, ambient, showParticles, showIcon))
    {}

    [JavaConstructor]
    public StatusEffectInstance(StatusEffect type, int duration, int amplifier, bool ambient, bool showParticles, bool showIcon, StatusEffectInstance? hiddenEffect, Optional<StatusEffectInstance.FactorCalculationData> factorCalculationData) : base(StatusEffectInstance_StatusEffectIntIntBoolBoolBoolStatusEffectInstanceOptional1Invoke(type, duration, amplifier, ambient, showParticles, showIcon, hiddenEffect, factorCalculationData))
    {}

    [JavaConstructor]
    public StatusEffectInstance(StatusEffectInstance instance) : base(StatusEffectInstance_StatusEffectInstanceInvoke(instance))
    {}

    public const int INFINITE = -1;

    [Signature("method_42129")]
    public partial Optional<StatusEffectInstance.FactorCalculationData> GetFactorCalculationData();

    [Signature("method_5590")]
    public partial bool Upgrade(StatusEffectInstance that);

    [Signature("method_48559")]
    public partial bool IsInfinite();

    [Signature("method_48557")]
    public partial bool IsDurationBelow(int duration);

    // [Signature("method_48558")]
    // public partial int MapDuration(Int2IntFunction mapper);

    [Signature("method_5579")]
    public partial StatusEffect GetEffectType();

    [Signature("method_5584")]
    public partial int GetDuration();

    [Signature("method_5578")]
    public partial int GetAmplifier();

    [Signature("method_5591")]
    public partial bool IsAmbient();

    [Signature("method_5581")]
    public partial bool ShouldShowParticles();

    [Signature("method_5592")]
    public partial bool ShouldShowIcon();

    [Signature("method_5585")]
    public partial bool Update(LivingEntity entity, Runnable overwriteCallback);

    [Signature("method_52523")]
    public partial void OnApplied(LivingEntity entity);

    [Signature("method_5586")]
    public partial string GetTranslationKey();

    [Signature("method_5582")]
    public partial NbtCompound WriteNbt(NbtCompound nbt);

    [Signature("method_5583")]
    public static partial StatusEffectInstance? FromNbt(NbtCompound nbt);

    [Signature("method_5587")]
    public partial int CompareTo(StatusEffectInstance statusEffectInstance);

    [MapName("class_7247")]
    public partial class FactorCalculationData : JavaObject, IClassRef<FactorCalculationData>, IFromHandle<FactorCalculationData>
    {
        [JavaConstructor]
        public FactorCalculationData(int paddingDuration, float factorStart, float factorTarget, float factorCurrent, int effectChangedTimestamp, float factorPreviousFrame, bool hadEffectLastTick) : base(FactorCalculationData_IntFloatFloatFloatIntFloatBoolInvoke(paddingDuration, factorStart, factorTarget, factorCurrent, effectChangedTimestamp, factorPreviousFrame, hadEffectLastTick))
        {}

        [JavaConstructor]
        public FactorCalculationData(int paddingDuration) : base(FactorCalculationData_IntInvoke(paddingDuration))
        {}

        [Signature("method_42136")]
        public partial void Update(StatusEffectInstance effect);

        [Signature("method_42134")]
        public partial float Lerp(LivingEntity entity, float tickDelta);
    }
}
