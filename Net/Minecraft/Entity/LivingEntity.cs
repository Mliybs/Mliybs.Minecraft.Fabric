using Com.Google.Common.Collect;
using Java.Lang;
using Java.Util.Function;
using Java.Util;
using Net.Minecraft.Block;
using Net.Minecraft.Command.Argument;
using Net.Minecraft.Enchantment;
using Net.Minecraft.Entity.Ai.Brain;
using Net.Minecraft.Entity.Ai;
using Net.Minecraft.Entity.Attribute;
using Net.Minecraft.Entity.Boss.Dragon;
using Net.Minecraft.Entity.Boss;
using Net.Minecraft.Entity.Damage;
using Net.Minecraft.Entity.Data;
using Net.Minecraft.Entity.Decoration;
using Net.Minecraft.Entity.Effect;
using Net.Minecraft.Entity.Mob;
using Net.Minecraft.Entity.Player;
using Net.Minecraft.Entity.Projectile;
using Net.Minecraft.Entity.Vehicle;
using Net.Minecraft.Fluid;
using Net.Minecraft.Inventory;
using Net.Minecraft.Item;
using Net.Minecraft.Nbt;
using Net.Minecraft.Network.Packet.S2c.Play;
using Net.Minecraft.Registry.Entry;
using Net.Minecraft.Registry.Tag;
using Net.Minecraft.Scoreboard;
using Net.Minecraft.Server.Command;
using Net.Minecraft.Sound;
using Net.Minecraft.Util.Collection;
using Net.Minecraft.Util.Math.Random;
using Net.Minecraft.Util.Math;
using Net.Minecraft.Util;
using Net.Minecraft.World.Entity;
using Net.Minecraft.World;

namespace Net.Minecraft.Entity;

[MapName("net/minecraft/class_1309")]
public partial class LivingEntity : Entity, IAttackable, IClassRef<LivingEntity>, IFromHandle<LivingEntity>
{
    public LivingEntity? GetLastAttacker() => Attackable.GetLastAttackerProxy(ObjectRef);

    // [Signature("method_18868")]
    // public partial Brain<?> GetBrain();

    // [Signature("method_28306")]
    // protected Brain.Profile<?> CreateBrainProfile();

    // [Signature("method_18867")]
    // protected Brain<?> DeserializeBrain(com.mojang.serialization.Dynamic<?> dynamic);

    [Signature("method_5973")]
    public partial bool CanTarget<T>(EntityType<T> type) where T : Entity, IClassRef<T>, IFromHandle<T>;

    // [Signature("method_26827")]
    // public static partial DefaultAttributeContainer.Builder CreateLivingAttributes();

    [Signature("method_6094")]
    public partial bool CanBreatheInWater();

    [Signature("method_6024")]
    public partial float GetLeaningPitch(float tickDelta);

    [Signature("method_27302")]
    public partial bool ShouldDisplaySoulSpeedEffects();

    [Signature("method_25937")]
    protected partial void DisplaySoulSpeedEffects();

    [Signature("method_27303")]
    protected partial bool IsOnSoulSpeedBlock();

    [Signature("method_29500")]
    protected partial bool ShouldRemoveSoulSpeedBoost(BlockState landingState);

    [Signature("method_29501")]
    protected partial void RemoveSoulSpeedBoost();

    [Signature("method_29502")]
    protected partial void AddSoulSpeedBoostIfNeeded();

    [Signature("method_32324")]
    protected partial void RemovePowderSnowSlow();

    [Signature("method_32325")]
    protected partial void AddPowderSnowSlowIfNeeded();

    [Signature("method_6126")]
    protected partial void ApplyMovementEffects(BlockPos pos);

    [Signature("method_6109")]
    public partial bool IsBaby();

    [Signature("method_17825")]
    public partial float GetScaleFactor();

    [Signature("method_29920")]
    protected partial bool ShouldSwimInFluids();

    [Signature("method_6108")]
    protected partial void UpdatePostDeath();

    [Signature("method_6054")]
    public partial bool ShouldDropXp();

    [Signature("method_27071")]
    protected partial bool ShouldDropLoot();

    [Signature("method_6130")]
    protected partial int GetNextAirUnderwater(int air);

    [Signature("method_6064")]
    protected partial int GetNextAirOnLand(int air);

    [Signature("method_6110")]
    public partial int GetXpToDrop();

    [Signature("method_6071")]
    protected partial bool ShouldAlwaysDropXp();

    [Signature("method_6051")]
    public partial Util.Math.Random.Random GetRandom();

    [Signature("method_6065")]
    public partial LivingEntity? GetAttacker();

    [Signature("method_6117")]
    public partial int GetLastAttackedTime();

    [Signature("method_29505")]
    public partial void SetAttacking(PlayerEntity? attacking);

    [Signature("method_6015")]
    public partial void SetAttacker(LivingEntity? attacker);

    [Signature("method_6052")]
    public partial LivingEntity? GetAttacking();

    [Signature("method_6083")]
    public partial int GetLastAttackTime();

    [Signature("method_6114")]
    public partial void OnAttacking(Entity target);

    [Signature("method_6131")]
    public partial int GetDespawnCounter();

    [Signature("method_16826")]
    public partial void SetDespawnCounter(int despawnCounter);

    [Signature("method_35053")]
    public partial bool HasNoDrag();

    [Signature("method_35054")]
    public partial void SetNoDrag(bool noDrag);

    [Signature("method_44201")]
    protected partial bool IsArmorSlot(EquipmentSlot slot);

    [Signature("method_6116")]
    public partial void OnEquipStack(EquipmentSlot slot, ItemStack oldStack, ItemStack newStack);

    [Signature("method_6050")]
    protected partial void TickStatusEffects();

    [Signature("method_6027")]
    protected partial void UpdatePotionVisibility();

    [Signature("method_18390")]
    public partial double GetAttackDistanceScalingFactor(Entity? entity);

    [Signature("method_18395")]
    public partial bool CanTarget(LivingEntity target);

    [Signature("method_18391")]
    public partial bool IsTarget(LivingEntity entity, TargetPredicate predicate);

    [Signature("method_33190")]
    public partial bool CanTakeDamage();

    [Signature("method_36608")]
    public partial bool IsPartOfGame();

    [Signature("method_6089")]
    public static partial bool ContainsOnlyAmbientEffects(Java.Util.ICollection<StatusEffectInstance> effects);

    [Signature("method_6069")]
    protected partial void ClearPotionSwirls();

    [Signature("method_6012")]
    public partial bool ClearStatusEffects();

    [Signature("method_6026")]
    public partial Java.Util.Collection<StatusEffectInstance> GetStatusEffects();

    [Signature("method_6088")]
    public partial Map<StatusEffect, StatusEffectInstance> GetActiveStatusEffects();

    [Signature("method_6059")]
    public partial bool HasStatusEffect(StatusEffect effect);

    [Signature("method_6112")]
    public partial StatusEffectInstance? GetStatusEffect(StatusEffect effect);

    [Signature("method_6092")]
    public partial bool AddStatusEffect(StatusEffectInstance effect);

    [Signature("method_37222")]
    public partial bool AddStatusEffect(StatusEffectInstance effect, Entity? source);

    [Signature("method_6049")]
    public partial bool CanHaveStatusEffect(StatusEffectInstance effect);

    [Signature("method_26082")]
    public partial void SetStatusEffect(StatusEffectInstance effect, Entity? source);

    [Signature("method_5999")]
    public partial bool IsUndead();

    [Signature("method_6111")]
    public partial StatusEffectInstance? RemoveStatusEffectInternal(StatusEffect? type);

    [Signature("method_6016")]
    public partial bool RemoveStatusEffect(StatusEffect type);

    [Signature("method_6020")]
    protected partial void OnStatusEffectApplied(StatusEffectInstance effect, Entity? source);

    [Signature("method_52197")]
    public partial void SendEffectToControllingPlayer(StatusEffectInstance effect);

    [Signature("method_6009")]
    protected partial void OnStatusEffectUpgraded(StatusEffectInstance effect, bool reapplyEffect, Entity? source);

    [Signature("method_6129")]
    protected partial void OnStatusEffectRemoved(StatusEffectInstance effect);

    [Signature("method_6025")]
    public partial void Heal(float amount);

    [Signature("method_6032")]
    public partial float GetHealth();

    [Signature("method_6033")]
    public partial void SetHealth(float health);

    [Signature("method_29504")]
    public partial bool IsDead();

    [Signature("method_6090")]
    protected partial void TakeShieldHit(LivingEntity attacker);

    [Signature("method_6060")]
    protected partial void Knockback(LivingEntity target);

    [Signature("method_6081")]
    public partial DamageSource? GetRecentDamageSource();

    [Signature("method_6013")]
    protected partial void PlayHurtSound(DamageSource source);

    [Signature("method_6061")]
    public partial bool BlockedByShield(DamageSource source);

    [Signature("method_6078")]
    public partial void OnDeath(DamageSource damageSource);

    [Signature("method_23733")]
    protected partial void OnKilledBy(LivingEntity? adversary);

    [Signature("method_16080")]
    protected partial void Drop(DamageSource source);

    [Signature("method_16078")]
    protected partial void DropInventory();

    [Signature("method_23883")]
    protected partial void DropXp();

    [Signature("method_6099")]
    protected partial void DropEquipment(DamageSource source, int lootingMultiplier, bool allowDrops);

    [Signature("method_5989")]
    public partial Identifier GetLootTable();

    [Signature("method_51851")]
    public partial long GetLootTableSeed();

    [Signature("method_16077")]
    protected partial void DropLoot(DamageSource damageSource, bool causedByPlayer);

    [Signature("method_6005")]
    public partial void TakeKnockback(double strength, double x, double z);

    [Signature("method_48761")]
    public partial void TiltScreen(double deltaX, double deltaZ);

    [Signature("method_6011")]
    protected partial SoundEvent? GetHurtSound(DamageSource source);

    [Signature("method_6002")]
    protected partial SoundEvent? GetDeathSound();

    [Signature("method_41329")]
    public partial void DisableExperienceDropping();

    [Signature("method_41330")]
    public partial bool IsExperienceDroppingDisabled();

    [Signature("method_48157")]
    public partial float GetDamageTiltYaw();

    [Signature("method_53510")]
    protected partial Box GetHitbox();

    // [Signature("method_39760")]
    // public partial LivingEntity.FallSounds GetFallSounds();

    [Signature("method_18807")]
    protected partial SoundEvent GetDrinkSound(ItemStack stack);

    [Signature("method_18869")]
    public partial SoundEvent GetEatSound(ItemStack stack);

    [Signature("method_24832")]
    public partial Optional<BlockPos> GetClimbingPos();

    [Signature("method_6101")]
    public partial bool IsClimbing();

    [Signature("method_23329")]
    protected partial int ComputeFallDamage(float fallDistance, float damageMultiplier);

    [Signature("method_23328")]
    protected partial void PlayBlockFallSound();

    [Signature("method_6096")]
    public partial int GetArmor();

    [Signature("method_6105")]
    protected partial void DamageArmor(DamageSource source, float amount);

    [Signature("method_36977")]
    protected partial void DamageHelmet(DamageSource source, float amount);

    [Signature("method_6056")]
    protected partial void DamageShield(float amount);

    [Signature("method_6132")]
    protected partial float ApplyArmorToDamage(DamageSource source, float amount);

    [Signature("method_6036")]
    protected partial float ModifyAppliedDamage(DamageSource source, float amount);

    [Signature("method_6074")]
    protected partial void ApplyDamage(DamageSource source, float amount);

    [Signature("method_6066")]
    public partial DamageTracker GetDamageTracker();

    [Signature("method_6124")]
    public partial LivingEntity? GetPrimeAdversary();

    [Signature("method_6063")]
    public partial float GetMaxHealth();

    [Signature("method_52541")]
    public partial float GetMaxAbsorption();

    [Signature("method_6022")]
    public partial int GetStuckArrowCount();

    [Signature("method_6097")]
    public partial void SetStuckArrowCount(int stuckArrowCount);

    [Signature("method_21753")]
    public partial int GetStingerCount();

    [Signature("method_21755")]
    public partial void SetStingerCount(int stingerCount);

    [Signature("method_6104")]
    public partial void SwingHand(Hand hand);

    [Signature("method_23667")]
    public partial void SwingHand(Hand hand, bool fromServerPlayer);

    [Signature("method_6119")]
    protected partial void TickHandSwing();

    [Signature("method_5996")]
    public partial EntityAttributeInstance? GetAttributeInstance(EntityAttribute attribute);

    [Signature("method_45325")]
    public partial double GetAttributeValue(RegistryEntry<EntityAttribute> attribute);

    [Signature("method_26825")]
    public partial double GetAttributeValue(EntityAttribute attribute);

    [Signature("method_45326")]
    public partial double GetAttributeBaseValue(RegistryEntry<EntityAttribute> attribute);

    [Signature("method_26826")]
    public partial double GetAttributeBaseValue(EntityAttribute attribute);

    [Signature("method_6127")]
    public partial AttributeContainer GetAttributes();

    [Signature("method_6046")]
    public partial EntityGroup GetGroup();

    [Signature("method_6047")]
    public partial ItemStack GetMainHandStack();

    [Signature("method_6079")]
    public partial ItemStack GetOffHandStack();

    [Signature("method_24518")]
    public partial bool IsHolding(Item.Item item);

    [Signature("method_24520")]
    public partial bool IsHolding(Java.Util.Function.Predicate.PredicateDelegate<ItemStack> predicate);

    [Signature("method_5998")]
    public partial ItemStack GetStackInHand(Hand hand);

    [Signature("method_6122")]
    public partial void SetStackInHand(Hand hand, ItemStack stack);

    [Signature("method_6084")]
    public partial bool HasStackEquipped(EquipmentSlot slot);

    [Signature("method_6118")]
    public partial ItemStack GetEquippedStack(EquipmentSlot slot);

    [Signature("method_37410")]
    protected partial void ProcessEquippedStack(ItemStack stack);

    [Signature("method_18396")]
    public partial float GetArmorVisibility();

    [Signature("method_6107")]
    protected partial float GetSoundVolume();

    [Signature("method_6017")]
    public partial float GetSoundPitch();

    [Signature("method_6062")]
    protected partial bool IsImmobile();

    [Signature("method_6106")]
    protected partial float GetJumpVelocity();

    [Signature("method_37416")]
    public partial float GetJumpBoostVelocityModifier();

    [Signature("method_6043")]
    protected partial void Jump();

    [Signature("method_6093")]
    protected partial void KnockDownwards();

    [Signature("method_6010")]
    protected partial void SwimUpward(TagKey<Fluid.Fluid> fluid);

    [Signature("method_6120")]
    protected partial float GetBaseMovementSpeedMultiplier();

    [Signature("method_26319")]
    public partial bool CanWalkOnFluid(FluidState state);

    [Signature("method_6091")]
    public partial void Travel(Vec3d movementInput);

    [Signature("method_49481")]
    protected partial void TickControlled(PlayerEntity controllingPlayer, Vec3d movementInput);

    [Signature("method_49482")]
    protected partial Vec3d GetControlledMovementInput(PlayerEntity controllingPlayer, Vec3d movementInput);

    [Signature("method_49485")]
    protected partial float GetSaddledSpeed(PlayerEntity controllingPlayer);

    [Signature("method_29242")]
    public partial void UpdateLimbs(bool flutter);

    [Signature("method_48565")]
    protected partial void UpdateLimbs(float posDelta);

    [Signature("method_26318")]
    public partial Vec3d ApplyMovementInput(Vec3d movementInput, float slipperiness);

    [Signature("method_26317")]
    public partial Vec3d ApplyFluidMovingSpeed(double gravity, bool falling, Vec3d motion);

    [Signature("method_49484")]
    protected partial float GetOffGroundSpeed();

    [Signature("method_6029")]
    public partial float GetMovementSpeed();

    [Signature("method_6125")]
    public partial void SetMovementSpeed(float movementSpeed);

    [Signature("method_6121")]
    public partial bool TryAttack(Entity target);

    [Signature("method_45324")]
    public partial bool AreItemsDifferent(ItemStack stack, ItemStack stack2);

    [Signature("method_6031")]
    protected partial float TurnHead(float bodyRotation, float headRotation);

    [Signature("method_53964")]
    protected partial float GetMaxRelativeHeadRotation();

    [Signature("method_6007")]
    public partial void TickMovement();

    [Signature("method_29503")]
    public partial bool HurtByWater();

    [Signature("method_6023")]
    protected partial void TickNewAi();

    [Signature("method_6070")]
    protected partial void TickCramming();

    [Signature("method_6035")]
    protected partial void TickRiptide(Box a, Box b);

    [Signature("method_6087")]
    protected partial void PushAway(Entity entity);

    [Signature("method_5997")]
    protected partial void AttackLivingEntity(LivingEntity target);

    [Signature("method_6123")]
    public partial bool IsUsingRiptide();

    [Signature("method_6100")]
    public partial void SetJumping(bool jumping);

    [Signature("method_29499")]
    public partial void TriggerItemPickedUpByEntityCriteria(ItemEntity item);

    [Signature("method_6103")]
    public partial void SendPickup(Entity item, int count);

    [Signature("method_6057")]
    public partial bool CanSee(Entity entity);

    [Signature("method_6055")]
    public partial float GetHandSwingProgress(float tickDelta);

    [Signature("method_31079")]
    public static partial Vec3d PositionInPortal(Vec3d pos);

    [Signature("method_6067")]
    public partial float GetAbsorptionAmount();

    [Signature("method_6073")]
    public partial void SetAbsorptionAmount(float absorptionAmount);

    [Signature("method_52544")]
    protected partial void SetAbsorptionAmountUnclamped(float absorptionAmount);

    [Signature("method_6000")]
    public partial void EnterCombat();

    [Signature("method_6044")]
    public partial void EndCombat();

    [Signature("method_6008")]
    protected partial void MarkEffectsDirty();

    [Signature("method_6068")]
    public partial Arm GetMainArm();

    [Signature("method_6115")]
    public partial bool IsUsingItem();

    [Signature("method_6058")]
    public partial Hand GetActiveHand();

    [Signature("method_37119")]
    protected partial void TickItemStackUsage(ItemStack stack);

    [Signature("method_6085")]
    protected partial void SetLivingFlag(int mask, bool value);

    [Signature("method_6019")]
    public partial void SetCurrentHand(Hand hand);

    [Signature("method_6098")]
    protected partial void SpawnConsumptionEffects(ItemStack stack, int particleCount);

    [Signature("method_6040")]
    protected partial void ConsumeItem();

    [Signature("method_6030")]
    public partial ItemStack GetActiveItem();

    [Signature("method_6014")]
    public partial int GetItemUseTimeLeft();

    [Signature("method_6048")]
    public partial int GetItemUseTime();

    [Signature("method_6075")]
    public partial void StopUsingItem();

    [Signature("method_6021")]
    public partial void ClearActiveItem();

    [Signature("method_6039")]
    public partial bool IsBlocking();

    [Signature("method_21754")]
    public partial bool IsHoldingOntoLadder();

    [Signature("method_6128")]
    public partial bool IsFallFlying();

    [Signature("method_6003")]
    public partial int GetRoll();

    [Signature("method_6082")]
    public partial bool Teleport(double x, double y, double z, bool particleEffects);

    [Signature("method_6086")]
    public partial bool IsAffectedBySplashPotions();

    [Signature("method_6102")]
    public partial bool IsMobOrPlayer();

    [Signature("method_6006")]
    public partial void SetNearbySongPlaying(BlockPos songPosition, bool playing);

    [Signature("method_18397")]
    public partial bool CanEquip(ItemStack stack);

    // [Signature("method_24831")]
    // public partial ImmutableList<EntityPose> GetPoses();

    [Signature("method_24833")]
    public partial Box GetBoundingBox(EntityPose pose);

    [Signature("method_52542")]
    protected partial bool WouldNotSuffocateInPose(EntityPose pose);

    [Signature("method_18398")]
    public partial Optional<BlockPos> GetSleepingPosition();

    [Signature("method_18402")]
    public partial void SetSleepingPosition(BlockPos pos);

    [Signature("method_18399")]
    public partial void ClearSleepingPosition();

    [Signature("method_6113")]
    public partial bool IsSleeping();

    [Signature("method_18403")]
    public partial void Sleep(BlockPos pos);

    [Signature("method_18400")]
    public partial void WakeUp();

    [Signature("method_18401")]
    public partial Direction? GetSleepingDirection();

    [Signature("method_18394")]
    protected partial float GetActiveEyeHeight(EntityPose pose, EntityDimensions dimensions);

    [Signature("method_18808")]
    public partial ItemStack GetProjectileType(ItemStack stack);

    [Signature("method_18866")]
    public partial ItemStack EatFood(World.World world, ItemStack stack);

    [Signature("method_20235")]
    public partial void SendEquipmentBreakStatus(EquipmentSlot slot);

    [Signature("method_20236")]
    public partial void SendToolBreakStatus(Hand hand);

    [Signature("method_32326")]
    public static partial EquipmentSlot GetPreferredEquipmentSlot(ItemStack stack);

    [Signature("method_42149")]
    public partial bool DisablesShield();

    [Signature("method_52539")]
    protected partial void Method_52539(int int2, double double2);
}
