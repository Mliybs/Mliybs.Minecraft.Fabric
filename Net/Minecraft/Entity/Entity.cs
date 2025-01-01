using Java.Util.Stream;
using Net.Minecraft.Entity.Data;
using Net.Minecraft.Entity.Player;
using Net.Minecraft.Entity.Damage;
using Net.Minecraft.Nbt;
using Net.Minecraft.Item;
using Net.Minecraft.Fluid;
using Net.Minecraft.Registry.Tag;
using Net.Minecraft.Util;
using Net.Minecraft.Util.Hit;
using Net.Minecraft.Util.Math;
using Net.Minecraft.Util.Shape;
using Net.Minecraft.Util.Crash;
using Net.Minecraft.Sound;
using Net.Minecraft.Block;
using Net.Minecraft.Block.Piston;
using Net.Minecraft.World;
using Net.Minecraft.World.Event;
using Net.Minecraft.World.Entity;
using Net.Minecraft.World.Explosion;
using Net.Minecraft.Server;
using Net.Minecraft.Server.World;
using Net.Minecraft.Server.Network;
using Net.Minecraft.Server.Command;
using Net.Minecraft.Scoreboard;
using Net.Minecraft.Network.Packet.S2c.Play;
using Net.Minecraft.Inventory;
using Net.Minecraft.Text;

namespace Net.Minecraft.Entity;

[MapName("net/minecraft/class_1297")]
public partial class Entity : JavaObject, INameable, IEntityLike, ICommandOutput, IScoreHolder, IClassRef<Entity>, IFromHandle<Entity>
{
    public Text.Text GetName() => Nameable.GetNameProxy(ObjectRef);

    public bool HasCustomName() => Nameable.HasCustomNameProxy(ObjectRef);

    public Text.Text GetDisplayName() => Nameable.GetDisplayNameProxy(ObjectRef);

    public Text.Text? GetCustomName() => Nameable.GetCustomNameProxy(ObjectRef);

    public int GetId() => EntityLike.GetIdProxy(ObjectRef);

    public UUID GetUuid() => EntityLike.GetUuidProxy(ObjectRef);

    public BlockPos GetBlockPos() => EntityLike.GetBlockPosProxy(ObjectRef);

    public Box GetBoundingBox() => EntityLike.GetBoundingBoxProxy(ObjectRef);

    public void SetChangeListener(EntityChangeListener changeListener) => EntityLike.SetChangeListenerProxy(ObjectRef, changeListener);

    public Stream<EntityLike> StreamSelfAndPassengers() => EntityLike.StreamSelfAndPassengersProxy(ObjectRef);

    public Stream<EntityLike> StreamPassengersAndSelf() => EntityLike.StreamPassengersAndSelfProxy(ObjectRef);

    public void SetRemoved(RemovalReason reason) => EntityLike.SetRemovedProxy(ObjectRef, reason);

    public bool ShouldSave() => EntityLike.ShouldSaveProxy(ObjectRef);

    public bool IsPlayer() => EntityLike.IsPlayerProxy(ObjectRef);

    public void SendMessage(Text.Text message) => CommandOutput.SendMessageProxy(ObjectRef, message);
    
    public bool ShouldReceiveFeedback() => CommandOutput.ShouldReceiveFeedbackProxy(ObjectRef);
    
    public bool ShouldTrackOutput() => CommandOutput.ShouldTrackOutputProxy(ObjectRef);
    
    public bool ShouldBroadcastConsoleToOps() => CommandOutput.ShouldBroadcastConsoleToOpsProxy(ObjectRef);

    public bool CannotBeSilenced() => CommandOutput.CannotBeSilencedProxy(ObjectRef);

    public string GetNameForScoreboard() => ScoreHolder.GetNameForScoreboardProxy(ObjectRef);

    // public Text.Text? GetDisplayName() => ScoreHolder.GetDisplayNameProxy(ObjectRef);

    public Text.Text GetStyledDisplayName() => ScoreHolder.GetStyledDisplayNameProxy(ObjectRef);

    [Signature("method_30632")]
    public partial bool CollidesWithStateAtPos(BlockPos pos, BlockState state);

    [Signature("method_22861")]
    public partial int GetTeamColorValue();

    [Signature("method_7325")]
    public partial bool IsSpectator();

    [Signature("method_18375")]
    public partial void Detach();

    [Signature("method_43391")]
    public partial void UpdateTrackedPosition(double x, double y, double z);

    [Signature("method_43389")]
    public partial TrackedPosition GetTrackedPosition();

    [Signature("method_5864")]
    public partial EntityType<Entity> GetType();

    [Signature("method_5838")]
    public partial void SetId(int id);

    [Signature("method_5752")]
    public partial Set<JavaString> GetCommandTags();

    [Signature("method_5780")]
    public partial bool AddCommandTag(string tag);

    [Signature("method_5738")]
    public partial bool RemoveCommandTag(string tag);

    [Signature("method_5768")]
    public partial void Kill();

    [Signature("method_31472")]
    public partial void Discard();

    [Signature("method_5693")]
    protected partial void InitDataTracker();

    [Signature("method_5841")]
    public partial DataTracker GetDataTracker();

    [Signature("method_5650")]
    public partial void Remove(Entity.RemovalReason reason);

    [Signature("method_36209")]
    public partial void OnRemoved();

    [Signature("method_18380")]
    public partial void SetPose(EntityPose pose);

    [Signature("method_18376")]
    public partial EntityPose GetPose();

    [Signature("method_41328")]
    public partial bool IsInPose(EntityPose pose);

    [Signature("method_24516")]
    public partial bool IsInRange(Entity entity, double radius);

    [Signature("method_43259")]
    public partial bool IsInRange(Entity entity, double horizontalRadius, double verticalRadius);

    [Signature("method_5710")]
    protected partial void SetRotation(float yaw, float pitch);

    [Signature("method_33574")]
    public partial void SetPosition(Vec3d pos);

    [Signature("method_5814")]
    public partial void SetPosition(double x, double y, double z);

    [Signature("method_33332")]
    protected partial Box CalculateBoundingBox();

    [Signature("method_23311")]
    protected partial void RefreshPosition();

    [Signature("method_5872")]
    public partial void ChangeLookDirection(double cursorDeltaX, double cursorDeltaY);

    [Signature("method_5773")]
    public partial void Tick();

    [Signature("method_5670")]
    public partial void BaseTick();

    [Signature("method_33572")]
    public partial void SetOnFire(bool onFire);

    [Signature("method_31473")]
    public partial void AttemptTickInVoid();

    [Signature("method_30229")]
    public partial void ResetPortalCooldown();

    [Signature("method_51850")]
    public partial void SetPortalCooldown(int portalCooldown);

    [Signature("method_51848")]
    public partial int GetPortalCooldown();

    [Signature("method_30230")]
    public partial bool HasPortalCooldown();

    [Signature("method_5760")]
    protected partial void TickPortalCooldown();

    [Signature("method_5741")]
    public partial int GetMaxNetherPortalTime();

    [Signature("method_5730")]
    public partial void SetOnFireFromLava();

    [Signature("method_5639")]
    public partial void SetOnFireFor(int seconds);

    [Signature("method_20803")]
    public partial void SetFireTicks(int fireTicks);

    [Signature("method_20802")]
    public partial int GetFireTicks();

    [Signature("method_5646")]
    public partial void Extinguish();

    [Signature("method_5825")]
    protected partial void TickInVoid();

    [Signature("method_5654")]
    public partial bool DoesNotCollide(double offsetX, double offsetY, double offsetZ);

    [Signature("method_5629")]
    private partial bool DoesNotCollide(Box box);

    [Signature("method_24830")]
    public partial void SetOnGround(bool onGround);

    [Signature("method_52208")]
    public partial void SetOnGround(bool onGround, Vec3d movement);

    [Signature("method_51849")]
    public partial bool IsSupportedBy(BlockPos pos);

    [Signature("method_51703")]
    protected partial void UpdateSupportingBlockPos(bool onGround, Vec3d? movement);

    [Signature("method_24828")]
    public partial bool IsOnGround();

    [Signature("method_5784")]
    public partial void Move(MovementType movementType, Vec3d movement);

    [Signature("method_39759")]
    protected partial bool HasCollidedSoftly(Vec3d adjustedMovement);

    [Signature("method_36974")]
    protected partial void TryCheckBlockCollision();

    [Signature("method_36975")]
    protected partial void PlayExtinguishSound();

    [Signature("method_46395")]
    public partial void ExtinguishWithSound();

    [Signature("method_33573")]
    protected partial void AddAirTravelEffects();

    [Signature("method_43260"), Obsolete]
    public partial BlockPos GetLandingPos();

    [Signature("method_23314")]
    protected partial BlockPos GetVelocityAffectingPos();

    [Signature("method_23312")]
    public partial BlockPos GetSteppingPos();

    [Signature("method_43258")]
    protected partial BlockPos GetPosWithYOffset(float offset);

    [Signature("method_23313")]
    protected partial float GetJumpVelocityMultiplier();

    [Signature("method_23326")]
    protected partial float GetVelocityMultiplier();

    [Signature("method_18796")]
    protected partial Vec3d AdjustMovementForSneaking(Vec3d movement, MovementType type);

    [Signature("method_18794")]
    protected partial Vec3d AdjustMovementForPiston(Vec3d movement);

    [Signature("method_20736")]
    public static partial Vec3d AdjustMovementForCollisions(Entity? entity, Vec3d movement, Box entityBoundingBox, World.World world, Java.Util.List<VoxelShape> collisions);

    [Signature("method_5867")]
    protected partial float CalculateNextStepSoundDistance();

    [Signature("method_5737")]
    protected partial SoundEvent GetSwimSound();

    [Signature("method_5625")]
    protected partial SoundEvent GetSplashSound();

    [Signature("method_5672")]
    protected partial SoundEvent GetHighSpeedSplashSound();

    [Signature("method_5852")]
    protected partial void CheckBlockCollision();

    [Signature("method_5622")]
    protected partial void OnBlockCollision(BlockState state);

    [Signature("method_32875")]
    public partial void EmitGameEvent(GameEvent @event, Entity? entity);

    [Signature("method_32876")]
    public partial void EmitGameEvent(GameEvent @event);

    [Signature("method_51295")]
    protected partial void PlaySwimSound();

    [Signature("method_49788")]
    protected partial BlockPos GetStepSoundPos(BlockPos pos);

    [Signature("method_49787")]
    protected partial void PlayCombinationStepSounds(BlockState primaryState, BlockState secondaryState);

    [Signature("method_51296")]
    protected partial void PlaySecondaryStepSound(BlockState state);

    [Signature("method_5712")]
    protected partial void PlayStepSound(BlockPos pos, BlockState state);

    [Signature("method_5734")]
    protected partial void PlaySwimSound(float volume);

    [Signature("method_5801")]
    protected partial void AddFlapEffects();

    [Signature("method_5776")]
    protected partial bool IsFlappingWings();

    [Signature("method_5783")]
    public partial void PlaySound(SoundEvent sound, float volume, float pitch);

    [Signature("method_43077")]
    public partial void PlaySoundIfNotSilent(SoundEvent @event);

    [Signature("method_5701")]
    public partial bool IsSilent();

    [Signature("method_5803")]
    public partial void SetSilent(bool silent);

    [Signature("method_5740")]
    public partial bool HasNoGravity();

    [Signature("method_5875")]
    public partial void SetNoGravity(bool noGravity);

    [Signature("method_33570")]
    protected partial Entity.MoveEffect GetMoveEffect();

    [Signature("method_33189")]
    public partial bool OccludeVibrationSignals();

    [Signature("method_5623")]
    protected partial void Fall(double heightDifference, bool onGround, BlockState state, BlockPos landedPosition);

    [Signature("method_5753")]
    public partial bool IsFireImmune();

    [Signature("method_5747")]
    public partial bool HandleFallDamage(float fallDistance, float damageMultiplier, DamageSource damageSource);

    [Signature("method_5799")]
    public partial bool IsTouchingWater();

    [Signature("method_5721")]
    public partial bool IsTouchingWaterOrRain();

    [Signature("method_5637")]
    public partial bool IsWet();

    [Signature("method_5816")]
    public partial bool IsInsideWaterOrBubbleColumn();

    [Signature("method_52535")]
    public partial bool IsInFluid();

    [Signature("method_5869")]
    public partial bool IsSubmergedInWater();

    [Signature("method_5790")]
    public partial void UpdateSwimming();

    [Signature("method_5876")]
    protected partial bool UpdateWaterState();

    [Signature("method_5746")]
    protected partial void OnSwimmingStart();

    [Signature("method_43261"), Obsolete]
    protected partial BlockState GetLandingBlockState();

    [Signature("method_25936")]
    public partial BlockState GetSteppingBlockState();

    [Signature("method_27298")]
    public partial bool ShouldSpawnSprintingParticles();

    [Signature("method_5839")]
    protected partial void SpawnSprintingParticles();

    [Signature("method_5777")]
    public partial bool IsSubmergedIn(TagKey<Fluid.Fluid> fluidTag);

    [Signature("method_5771")]
    public partial bool IsInLava();

    [Signature("method_5724")]
    public partial void UpdateVelocity(float speed, Vec3d movementInput);

    [Signature("method_5718"), Obsolete]
    public partial float GetBrightnessAtEyes();

    [Signature("method_5641")]
    public partial void UpdatePositionAndAngles(double x, double y, double z, float yaw, float pitch);

    [Signature("method_30634")]
    public partial void UpdatePosition(double x, double y, double z);

    [Signature("method_29495")]
    public partial void RefreshPositionAfterTeleport(Vec3d pos);

    [Signature("method_24203")]
    public partial void RefreshPositionAfterTeleport(double x, double y, double z);

    [Signature("method_5725")]
    public partial void RefreshPositionAndAngles(BlockPos pos, float yaw, float pitch);

    [Signature("method_5808")]
    public partial void RefreshPositionAndAngles(double x, double y, double z, float yaw, float pitch);

    [Signature("method_22862")]
    public partial void ResetPosition();

    [Signature("method_5739")]
    public partial float DistanceTo(Entity entity);

    [Signature("method_5649")]
    public partial double SquaredDistanceTo(double x, double y, double z);

    [Signature("method_5858")]
    public partial double SquaredDistanceTo(Entity entity);

    [Signature("method_5707")]
    public partial double SquaredDistanceTo(Vec3d vector);

    [Signature("method_5694")]
    public partial void OnPlayerCollision(PlayerEntity player);

    [Signature("method_5697")]
    public partial void PushAwayFrom(Entity entity);

    [Signature("method_5762")]
    public partial void AddVelocity(double deltaX, double deltaY, double deltaZ);

    [Signature("method_5785")]
    protected partial void ScheduleVelocityUpdate();

    [Signature("method_5643")]
    public partial bool Damage(DamageSource source, float amount);

    [Signature("method_5828")]
    public partial Vec3d GetRotationVec(float tickDelta);

    [Signature("method_5695")]
    public partial float GetPitch(float tickDelta);

    [Signature("method_5705")]
    public partial float GetYaw(float tickDelta);

    [Signature("method_5631")]
    protected partial Vec3d GetRotationVector(float pitch, float yaw);

    [Signature("method_18864")]
    public partial Vec3d GetOppositeRotationVector(float tickDelta);

    [Signature("method_18863")]
    protected partial Vec3d GetOppositeRotationVector(float pitch, float yaw);

    [Signature("method_33571")]
    public partial Vec3d GetEyePos();

    [Signature("method_5836")]
    public partial Vec3d GetCameraPosVec(float tickDelta);

    [Signature("method_31166")]
    public partial Vec3d GetClientCameraPosVec(float tickDelta);

    [Signature("method_30950")]
    public partial Vec3d GetLerpedPos(float delta);

    [Signature("method_5745")]
    public partial HitResult Raycast(double maxDistance, float tickDelta, bool includeFluids);

    [Signature("method_49108")]
    public partial bool CanBeHitByProjectile();

    [Signature("method_5863")]
    public partial bool CanHit();

    [Signature("method_5810")]
    public partial bool IsPushable();

    [Signature("method_5716")]
    public partial void UpdateKilledAdvancementCriterion(Entity entityKilled, int score, DamageSource damageSource);

    [Signature("method_5727")]
    public partial bool ShouldRender(double cameraX, double cameraY, double cameraZ);

    [Signature("method_5640")]
    public partial bool ShouldRender(double distance);

    [Signature("method_5786")]
    public partial bool SaveSelfNbt(NbtCompound nbt);

    [Signature("method_5662")]
    public partial bool SaveNbt(NbtCompound nbt);

    [Signature("method_5647")]
    public partial NbtCompound WriteNbt(NbtCompound nbt);

    [Signature("method_5651")]
    public partial void ReadNbt(NbtCompound nbt);

    [Signature("method_5638")]
    protected partial bool ShouldSetPositionOnLoad();

    [Signature("method_5653")]
    protected partial string? GetSavedEntityId();

    [Signature("method_5749")]
    protected partial void ReadCustomDataFromNbt(NbtCompound nbt);

    [Signature("method_5652")]
    protected partial void WriteCustomDataToNbt(NbtCompound nbt);

    // [Signature("method_5846")]
    // protected partial NbtList ToNbtList(double[] values);

    // [Signature("method_5726")]
    // protected partial NbtList ToNbtList(float[] values);

    [Signature("method_5706")]
    public partial ItemEntity? DropItem(ItemConvertible item);

    [Signature("method_5870")]
    public partial ItemEntity? DropItem(ItemConvertible item, int yOffset);

    [Signature("method_5775")]
    public partial ItemEntity? DropStack(ItemStack stack);

    [Signature("method_5699")]
    public partial ItemEntity? DropStack(ItemStack stack, float yOffset);

    [Signature("method_5805")]
    public partial bool IsAlive();

    [Signature("method_5757")]
    public partial bool IsInsideWall();

    [Signature("method_5688")]
    public partial ActionResult Interact(PlayerEntity player, Hand hand);

    [Signature("method_30949")]
    public partial bool CollidesWith(Entity other);

    [Signature("method_30948")]
    public partial bool IsCollidable();

    [Signature("method_5842")]
    public partial void TickRiding();

    [Signature("method_24201")]
    public partial void UpdatePassengerPosition(Entity passenger);

    [Signature("method_5865")]
    protected partial void UpdatePassengerPosition(Entity passenger, Entity.PositionUpdater.PositionUpdaterDelegate positionUpdater);

    [Signature("method_5644")]
    public partial void OnPassengerLookAround(Entity passenger);

    [Signature("method_52536")]
    public partial float GetRidingOffset(Entity vehicle);

    [Signature("method_52537")]
    protected partial float GetUnscaledRidingOffset(Entity vehicle);

    [Signature("method_52538")]
    public partial Vec3d GetPassengerRidingPos(Entity passenger);

    // [Signature("method_52533")]
    // protected partial Vector3f GetPassengerAttachmentPos(Entity passenger, EntityDimensions dimensions, float scaleFactor);

    [Signature("method_5804")]
    public partial bool StartRiding(Entity entity);

    [Signature("method_5709")]
    public partial bool IsLiving();

    [Signature("method_5873")]
    public partial bool StartRiding(Entity entity, bool force);

    [Signature("method_5860")]
    protected partial bool CanStartRiding(Entity entity);

    [Signature("method_5772")]
    public partial void RemoveAllPassengers();

    [Signature("method_29239")]
    public partial void DismountVehicle();

    [Signature("method_5848")]
    public partial void StopRiding();

    [Signature("method_5627")]
    protected partial void AddPassenger(Entity passenger);

    [Signature("method_5793")]
    protected partial void RemovePassenger(Entity passenger);

    [Signature("method_5818")]
    protected partial bool CanAddPassenger(Entity passenger);

    [Signature("method_48921")]
    protected partial bool CouldAcceptPassenger();

    [Signature("method_5759")]
    public partial void UpdateTrackedPositionAndAngles(double x, double y, double z, float yaw, float pitch, int interpolationSteps);

    [Signature("method_53830")]
    public partial double GetLerpTargetX();

    [Signature("method_53827")]
    public partial double GetLerpTargetY();

    [Signature("method_53828")]
    public partial double GetLerpTargetZ();

    [Signature("method_53829")]
    public partial float GetLerpTargetPitch();

    [Signature("method_53831")]
    public partial float GetLerpTargetYaw();

    [Signature("method_5683")]
    public partial void UpdateTrackedHeadRotation(float yaw, int interpolationSteps);

    [Signature("method_5871")]
    public partial float GetTargetingMargin();

    [Signature("method_5720")]
    public partial Vec3d GetRotationVector();

    [Signature("method_40123")]
    public partial Vec3d GetHandPosOffset(Item.Item item);

    [Signature("method_5802")]
    public partial Vec2f GetRotationClient();

    [Signature("method_5663")]
    public partial Vec3d GetRotationVecClient();

    [Signature("method_5717")]
    public partial void SetInNetherPortal(BlockPos pos);

    [Signature("method_18379")]
    protected partial void TickPortal();

    [Signature("method_5806")]
    public partial int GetDefaultPortalCooldown();

    [Signature("method_5750")]
    public partial void SetVelocityClient(double x, double y, double z);

    [Signature("method_48922")]
    public partial void OnDamaged(DamageSource damageSource);

    [Signature("method_5711")]
    public partial void HandleStatus(sbyte status);

    [Signature("method_5879")]
    public partial void AnimateDamage(float yaw);

    [Signature("method_5877")]
    public partial Iterable<ItemStack> GetHandItems();

    [Signature("method_5661")]
    public partial Iterable<ItemStack> GetArmorItems();

    [Signature("method_5743")]
    public partial Iterable<ItemStack> GetItemsEquipped();

    [Signature("method_5673")]
    public partial void EquipStack(EquipmentSlot slot, ItemStack stack);

    [Signature("method_5809")]
    public partial bool IsOnFire();

    [Signature("method_5765")]
    public partial bool HasVehicle();

    [Signature("method_5782")]
    public partial bool HasPassengers();

    [Signature("method_49693")]
    public partial bool ShouldDismountUnderwater();

    [Signature("method_52534")]
    public partial bool ShouldControlVehicles();

    [Signature("method_5660")]
    public partial void SetSneaking(bool sneaking);

    [Signature("method_5715")]
    public partial bool IsSneaking();

    [Signature("method_21749")]
    public partial bool BypassesSteppingEffects();

    [Signature("method_21750")]
    public partial bool BypassesLandingEffects();

    [Signature("method_21751")]
    public partial bool IsSneaky();

    [Signature("method_21752")]
    public partial bool IsDescending();

    [Signature("method_18276")]
    public partial bool IsInSneakingPose();

    [Signature("method_5624")]
    public partial bool IsSprinting();

    [Signature("method_5728")]
    public partial void SetSprinting(bool sprinting);

    [Signature("method_5681")]
    public partial bool IsSwimming();

    [Signature("method_20232")]
    public partial bool IsInSwimmingPose();

    [Signature("method_20448")]
    public partial bool IsCrawling();

    [Signature("method_5796")]
    public partial void SetSwimming(bool swimming);

    [Signature("method_36361")]
    public partial bool IsGlowingLocal();

    [Signature("method_5834")]
    public partial void SetGlowing(bool glowing);

    [Signature("method_5851")]
    public partial bool IsGlowing();

    [Signature("method_5767")]
    public partial bool IsInvisible();

    [Signature("method_5756")]
    public partial bool IsInvisibleTo(PlayerEntity player);

    [Signature("method_52172")]
    public partial bool IsOnRail();

    // [Signature("method_42147")]
    // public partial void UpdateEventHandler(BiConsumer<EntityGameEventHandler<?>, ServerWorld> callback);

    [Signature("method_5781")]
    public partial Team? GetScoreboardTeam();

    [Signature("method_5722")]
    public partial bool IsTeammate(Entity other);

    [Signature("method_5645")]
    public partial bool IsTeamPlayer(AbstractTeam team);

    [Signature("method_5648")]
    public partial void SetInvisible(bool invisible);

    [Signature("method_5795")]
    protected partial bool GetFlag(int index);

    [Signature("method_5729")]
    protected partial void SetFlag(int index, bool value);

    [Signature("method_5748")]
    public partial int GetMaxAir();

    [Signature("method_5669")]
    public partial int GetAir();

    [Signature("method_5855")]
    public partial void SetAir(int air);

    [Signature("method_32312")]
    public partial int GetFrozenTicks();

    [Signature("method_32317")]
    public partial void SetFrozenTicks(int frozenTicks);

    [Signature("method_32313")]
    public partial float GetFreezingScale();

    [Signature("method_32314")]
    public partial bool IsFrozen();

    [Signature("method_32315")]
    public partial int GetMinFreezeDamageTicks();

    [Signature("method_5800")]
    public partial void OnStruckByLightning(ServerWorld world, LightningEntity lightning);

    [Signature("method_5700")]
    public partial void OnBubbleColumnSurfaceCollision(bool drag);

    [Signature("method_5764")]
    public partial void OnBubbleColumnCollision(bool drag);

    [Signature("method_5874")]
    public partial bool OnKilledOther(ServerWorld world, LivingEntity other);

    [Signature("method_45318")]
    public partial void LimitFallDistance();

    [Signature("method_38785")]
    public partial void OnLanding();

    [Signature("method_5632")]
    protected partial void PushOutOfBlocks(double x, double y, double z);

    [Signature("method_5844")]
    public partial void SlowMovement(BlockState state, Vec3d multiplier);

    [Signature("method_23315")]
    protected partial Text.Text GetDefaultName();

    [Signature("method_5779")]
    public partial bool IsPartOf(Entity entity);

    [Signature("method_5791")]
    public partial float GetHeadYaw();

    [Signature("method_5847")]
    public partial void SetHeadYaw(float headYaw);

    [Signature("method_5636")]
    public partial void SetBodyYaw(float bodyYaw);

    [Signature("method_5732")]
    public partial bool IsAttackable();

    [Signature("method_5698")]
    public partial bool HandleAttack(Entity attacker);

    [Signature("method_5679")]
    public partial bool IsInvulnerableTo(DamageSource damageSource);

    [Signature("method_5655")]
    public partial bool IsInvulnerable();

    [Signature("method_5684")]
    public partial void SetInvulnerable(bool invulnerable);

    [Signature("method_5719")]
    public partial void CopyPositionAndRotation(Entity entity);

    [Signature("method_5878")]
    public partial void CopyFrom(Entity original);

    [Signature("method_5731")]
    public partial Entity? MoveToWorld(ServerWorld destination);

    [Signature("method_30076")]
    protected partial void RemoveFromDimension();

    [Signature("method_30329")]
    protected partial TeleportTarget? GetTeleportTarget(ServerWorld destination);

    // [Signature("method_30633")]
    // protected partial Vec3d PositionInPortal(Direction.Axis portalAxis, BlockLocating.Rectangle portalRect);

    // [Signature("method_30330")]
    // protected partial Optional<BlockLocating.Rectangle> GetPortalRect(ServerWorld destWorld, BlockPos destPos, bool destIsNether, WorldBorder worldBorder);

    [Signature("method_5822")]
    public partial bool CanUsePortals();

    [Signature("method_5774")]
    public partial float GetEffectiveExplosionResistance(Explosion explosion, BlockView world, BlockPos pos, BlockState blockState, FluidState fluidState, float max);

    [Signature("method_5853")]
    public partial bool CanExplosionDestroyBlock(Explosion explosion, BlockView world, BlockPos pos, BlockState state, float explosionPower);

    [Signature("method_5850")]
    public partial int GetSafeFallDistance();

    [Signature("method_5696")]
    public partial bool CanAvoidTraps();

    [Signature("method_5819")]
    public partial void PopulateCrashReport(CrashReportSection section);

    [Signature("method_5862")]
    public partial bool DoesRenderOnFire();

    [Signature("method_5826")]
    public partial void SetUuid(UUID uuid);

    [Signature("method_5845")]
    public partial string GetUuidAsString();

    [Signature("method_5675")]
    public partial bool IsPushedByFluids();

    [Signature("method_5824")]
    public static partial double GetRenderDistanceMultiplier();

    [Signature("method_5840")]
    public static partial void SetRenderDistanceMultiplier(double value);

    [Signature("method_5665")]
    public partial void SetCustomName(Text.Text? name);

    [Signature("method_5880")]
    public partial void SetCustomNameVisible(bool visible);

    [Signature("method_5807")]
    public partial bool IsCustomNameVisible();

    [Signature("method_20620")]
    public partial void Teleport(double destX, double destY, double destZ);

    [Signature("method_48105")]
    public partial bool Teleport(ServerWorld world, double destX, double destY, double destZ, Set<PositionFlag> flags, float yaw, float pitch);

    [Signature("method_33567")]
    public partial void RequestTeleportAndDismount(double destX, double destY, double destZ);

    [Signature("method_5859")]
    public partial void RequestTeleport(double destX, double destY, double destZ);

    [Signature("method_45166")]
    public partial void RequestTeleportOffset(double offsetX, double offsetY, double offsetZ);

    [Signature("method_5733")]
    public partial bool ShouldRenderName();

    // [Signature("method_48850")]
    // public partial void OnDataTrackerUpdate(List<DataTracker.SerializedEntry<?>> dataEntries);

    // [Signature("method_5674")]
    // public partial void OnTrackedDataSet(TrackedData<?> data);

    [Signature("method_46396"), Obsolete]
    protected partial void ReinitDimensions();

    [Signature("method_18382")]
    public partial void CalculateDimensions();

    [Signature("method_5735")]
    public partial Direction GetHorizontalFacing();

    [Signature("method_5755")]
    public partial Direction GetMovementDirection();

    [Signature("method_5769")]
    protected partial HoverEvent GetHoverEvent();

    [Signature("method_5680")]
    public partial bool CanBeSpectated(ServerPlayerEntity spectator);

    [Signature("method_5830")]
    public partial Box GetVisibilityBoundingBox();

    [Signature("method_5857")]
    public partial void SetBoundingBox(Box boundingBox);

    [Signature("method_18378")]
    protected partial float GetEyeHeight(EntityPose pose, EntityDimensions dimensions);

    [Signature("method_18381")]
    public partial float GetEyeHeight(EntityPose pose);

    [Signature("method_5751")]
    public partial float GetStandingEyeHeight();

    [Signature("method_45321")]
    public partial Vec3d GetLeashOffset(float tickDelta);

    [Signature("method_29919")]
    protected partial Vec3d GetLeashOffset();

    [Signature("method_32318")]
    public partial StackReference GetStackReference(int mappedIndex);

    [Signature("method_5770")]
    public partial World.World GetEntityWorld();

    [Signature("method_5682")]
    public partial MinecraftServer? GetServer();

    [Signature("method_5664")]
    public partial ActionResult InteractAt(PlayerEntity player, Vec3d hitPos, Hand hand);

    [Signature("method_5659")]
    public partial bool IsImmuneToExplosion(Explosion explosion);

    [Signature("method_5723")]
    public partial void ApplyDamageEffects(LivingEntity attacker, Entity target);

    [Signature("method_5837")]
    public partial void OnStartedTrackingBy(ServerPlayerEntity player);

    [Signature("method_5742")]
    public partial void OnStoppedTrackingBy(ServerPlayerEntity player);

    [Signature("method_5832")]
    public partial float ApplyRotation(BlockRotation rotation);

    [Signature("method_5763")]
    public partial float ApplyMirror(BlockMirror mirror);

    [Signature("method_5833")]
    public partial bool EntityDataRequiresOperator();

    [Signature("method_5642")]
    public partial LivingEntity? GetControllingPassenger();

    [Signature("method_42148")]
    public partial bool HasControllingPassenger();

    [Signature("method_5685")]
    public partial Java.Util.List<Entity> GetPassengerList();

    [Signature("method_31483")]
    public partial Entity? GetFirstPassenger();

    [Signature("method_5626")]
    public partial bool HasPassenger(Entity passenger);

    [Signature("method_5703")]
    public partial bool HasPassenger(Java.Util.Function.Predicate<Entity> predicate);

    [Signature("method_5736")]
    public partial Iterable<Entity> GetPassengersDeep();

    [Signature("method_54757")]
    public partial int GetPlayerPassengers();

    [Signature("method_5817")]
    public partial bool HasPlayerRider();

    [Signature("method_5668")]
    public partial Entity GetRootVehicle();

    [Signature("method_5794")]
    public partial bool IsConnectedThroughVehicle(Entity entity);

    [Signature("method_5821")]
    public partial bool HasPassengerDeep(Entity passenger);

    [Signature("method_5787")]
    public partial bool IsLogicalSideForUpdatingMovement();

    [Signature("method_6034")]
    public partial bool CanMoveVoluntarily();

    [Signature("method_24826")]
    protected static partial Vec3d GetPassengerDismountOffset(double vehicleWidth, double passengerWidth, float passengerYaw);

    [Signature("method_24829")]
    public partial Vec3d UpdatePassengerForDismount(LivingEntity passenger);

    [Signature("method_5854")]
    public partial Entity? GetVehicle();

    [Signature("method_49694")]
    public partial Entity? GetControllingVehicle();

    [Signature("method_5657")]
    public partial PistonBehavior GetPistonBehavior();

    [Signature("method_5634")]
    public partial SoundCategory GetSoundCategory();

    [Signature("method_5676")]
    protected partial int GetBurningDuration();

    [Signature("method_5671")]
    public partial ServerCommandSource GetCommandSource();

    [Signature("method_5691")]
    protected partial int GetPermissionLevel();

    [Signature("method_5687")]
    public partial bool HasPermissionLevel(int permissionLevel);

    // [Signature("method_5702")]
    // public partial void LookAt(EntityAnchorArgumentType.EntityAnchor anchorPoint, Vec3d target);

    [Signature("method_5692")]
    public partial bool UpdateMovementInFluid(TagKey<Fluid.Fluid> tag, double speed);

    [Signature("method_33724")]
    public partial bool IsRegionUnloaded();

    [Signature("method_5861")]
    public partial double GetFluidHeight(TagKey<Fluid.Fluid> fluid);

    [Signature("method_29241")]
    public partial double GetSwimHeight();

    [Signature("method_17681")]
    public partial float GetWidth();

    [Signature("method_17682")]
    public partial float GetHeight();

    [Signature("method_51152")]
    public partial float GetNameLabelHeight();

    // [Signature("method_18002")]
    // public partial Packet<ClientPlayPacketListener> CreateSpawnPacket();

    [Signature("method_18377")]
    public partial EntityDimensions GetDimensions(EntityPose pose);

    [Signature("method_19538")]
    public partial Vec3d GetPos();

    [Signature("method_43390")]
    public partial Vec3d GetSyncedPos();

    [Signature("method_36601")]
    public partial BlockState GetBlockStateAtPos();

    [Signature("method_31476")]
    public partial ChunkPos GetChunkPos();

    [Signature("method_18798")]
    public partial Vec3d GetVelocity();

    [Signature("method_18799")]
    public partial void SetVelocity(Vec3d velocity);

    [Signature("method_45319")]
    public partial void AddVelocity(Vec3d velocity);

    [Signature("method_18800")]
    public partial void SetVelocity(double x, double y, double z);

    [Signature("method_31477")]
    public partial int GetBlockX();

    [Signature("method_23317")]
    public partial double GetX();

    [Signature("method_23316")]
    public partial double OffsetX(double widthScale);

    [Signature("method_23322")]
    public partial double GetParticleX(double widthScale);

    [Signature("method_31478")]
    public partial int GetBlockY();

    [Signature("method_23318")]
    public partial double GetY();

    [Signature("method_23323")]
    public partial double GetBodyY(double heightScale);

    [Signature("method_23319")]
    public partial double GetRandomBodyY();

    [Signature("method_23320")]
    public partial double GetEyeY();

    [Signature("method_31479")]
    public partial int GetBlockZ();

    [Signature("method_23321")]
    public partial double GetZ();

    [Signature("method_23324")]
    public partial double OffsetZ(double widthScale);

    [Signature("method_23325")]
    public partial double GetParticleZ(double widthScale);

    [Signature("method_23327")]
    public partial void SetPos(double x, double y, double z);

    [Signature("method_5982")]
    public partial void CheckDespawn();

    [Signature("method_30951")]
    public partial Vec3d GetLeashPos(float delta);

    [Signature("method_31471")]
    public partial void OnSpawnPacket(EntitySpawnS2CPacket packet);

    [Signature("method_31480")]
    public partial ItemStack? GetPickBlockStack();

    [Signature("method_32319")]
    public partial void SetInPowderSnow(bool inPowderSnow);

    [Signature("method_32316")]
    public partial bool CanFreeze();

    [Signature("method_40071")]
    public partial bool ShouldEscapePowderSnow();

    [Signature("method_36454")]
    public partial float GetYaw();

    [Signature("method_43078")]
    public partial float GetBodyYaw();

    [Signature("method_36456")]
    public partial void SetYaw(float yaw);

    [Signature("method_36455")]
    public partial float GetPitch();

    [Signature("method_36457")]
    public partial void SetPitch(float pitch);

    [Signature("method_48155")]
    public partial bool CanSprintAsVehicle();

    [Signature("method_49476")]
    public partial float GetStepHeight();

    [Signature("method_49477")]
    public partial void SetStepHeight(float stepHeight);

    [Signature("method_31481")]
    public partial bool IsRemoved();

    [Signature("method_35049")]
    public partial Entity.RemovalReason? GetRemovalReason();

    [Signature("method_31482")]
    protected partial void UnsetRemoved();

    [Signature("method_36971")]
    public partial bool CanModifyAt(World.World world, BlockPos pos);

    [Signature("method_37908")]
    public partial World.World GetWorld();

    [Signature("method_51502")]
    protected partial void SetWorld(World.World world);

    [Signature("method_48923")]
    public partial DamageSources GetDamageSources();

    [Signature("method_52532")]
    protected partial void LerpPosAndRotation(int step, double x, double y, double z, double yaw, double pitch);

    [MapName("class_5529")]
    public partial class RemovalReason : Enum<RemovalReason>, IClassRef<RemovalReason>, IFromHandle<RemovalReason>
    {
        [Signature("field_26998")]
        public static RemovalReason KILLED { get; private set; }
        
        [Signature("field_26999")]
        public static RemovalReason DISCARDED { get; private set; }
        
        [Signature("field_27000")]
        public static RemovalReason UNLOADED_TO_CHUNK { get; private set; }
        
        [Signature("field_27001")]
        public static RemovalReason UNLOADED_WITH_PLAYER { get; private set; }

        [Signature("field_27002")]
        public static RemovalReason CHANGED_DIMENSION { get; private set; }
    }

    [MapName("class_5799")]
    public partial class MoveEffect : Enum<MoveEffect>, IClassRef<MoveEffect>, IFromHandle<MoveEffect>
    {
        [Signature("field_28630")]
        public static MoveEffect NONE { get; private set; }

        [Signature("field_28631")]
        public static MoveEffect SOUNDS { get; private set; }

        [Signature("field_28632")]
        public static MoveEffect EVENTS { get; private set; }

        [Signature("field_28633")]
        public static MoveEffect ALL { get; private set; }
    }

    [MapName("class_4738")]
    public partial class PositionUpdater : JavaObject, IClassRef<PositionUpdater>, IFromHandle<PositionUpdater>
    {
        [Signature("accept", false)]
        public partial void Accept(Entity entity, double x, double y, double z);

        public delegate void PositionUpdaterDelegate(Entity entity, double x, double y, double z);

        public delegate void PositionUpdaterDelegateHandler(nint entity, double x, double y, double z);

        internal static PositionUpdaterDelegateHandler Handle(PositionUpdaterDelegate @delegate) => (entity, x, y, z) => @delegate(Entity.From(entity), x, y, z);
    }
}
