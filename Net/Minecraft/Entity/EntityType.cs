using Com.Google.Common.Collect;
using Java.Util.Function;
using Java.Util.Stream;
using Java.Util;
using Net.Minecraft.Block;
using Net.Minecraft.Entity.Boss.Dragon;
using Net.Minecraft.Entity.Boss;
using Net.Minecraft.Entity.Decoration.Painting;
using Net.Minecraft.Entity.Decoration;
using Net.Minecraft.Entity.Mob;
using Net.Minecraft.Entity.Passive;
using Net.Minecraft.Entity.Player;
using Net.Minecraft.Entity.Projectile.Thrown;
using Net.Minecraft.Entity.Projectile;
using Net.Minecraft.Entity.Vehicle;
using Net.Minecraft.Item;
using Net.Minecraft.Nbt;
using Net.Minecraft.Registry.Entry;
using Net.Minecraft.Registry.Tag;
using Net.Minecraft.Resource.FeatureToggle;
using Net.Minecraft.Server.World;
using Net.Minecraft.Text;
using Net.Minecraft.Util.Math;
using Net.Minecraft.Util;
using Net.Minecraft.World;

namespace Net.Minecraft.Entity;

public partial class EntityType<T> : JavaObject, IClassRef<EntityType<T>>, IFromHandle<EntityType<T>> where T : Entity, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => EntityType.Names;

    public static Class<EntityType<Entity>> ClassRef => EntityType.ClassRef;

    static Class<EntityType<T>> IClassRef<EntityType<T>>.ClassRef => Class.Proxy<EntityType<T>>(ClassRef.ObjectRef);

    [Signature("method_5883")]
    public partial T? Create(World.World world);
}

#nullable disable
[MapName("net/minecraft/class_1299"), StaticGeneric(typeof(EntityType<>))]
public static partial class EntityType
{
    public static Class<EntityType<Entity>> ClassRef => _classRef;

    [Signature("field_38384")]
    public static EntityType<AllayEntity> ALLAY { get; private set; }

    [Signature("field_6083")]
    public static EntityType<AreaEffectCloudEntity> AREA_EFFECT_CLOUD { get; private set; }

    [Signature("field_6131")]
    public static EntityType<ArmorStandEntity> ARMOR_STAND { get; private set; }

    [Signature("field_6122")]
    public static EntityType<ArrowEntity> ARROW { get; private set; }

    [Signature("field_28315")]
    public static EntityType<AxolotlEntity> AXOLOTL { get; private set; }

    [Signature("field_6108")]
    public static EntityType<BatEntity> BAT { get; private set; }

    [Signature("field_20346")]
    public static EntityType<BeeEntity> BEE { get; private set; }

    [Signature("field_6099")]
    public static EntityType<BlazeEntity> BLAZE { get; private set; }

    // [Signature("field_42460")]
    // public static EntityType<DisplayEntity.BlockDisplayEntity> BLOCK_DISPLAY { get; private set; }

    [Signature("field_6121")]
    public static EntityType<BoatEntity> BOAT { get; private set; }

    [Signature("field_47244")]
    public static EntityType<BreezeEntity> BREEZE { get; private set; }

    [Signature("field_40116")]
    public static EntityType<CamelEntity> CAMEL { get; private set; }

    [Signature("field_16281")]
    public static EntityType<CatEntity> CAT { get; private set; }

    [Signature("field_6084")]
    public static EntityType<CaveSpiderEntity> CAVE_SPIDER { get; private set; }

    [Signature("field_38096")]
    public static EntityType<ChestBoatEntity> CHEST_BOAT { get; private set; }

    [Signature("field_6126")]
    public static EntityType<ChestMinecartEntity> CHEST_MINECART { get; private set; }

    [Signature("field_6132")]
    public static EntityType<ChickenEntity> CHICKEN { get; private set; }

    [Signature("field_6070")]
    public static EntityType<CodEntity> COD { get; private set; }

    [Signature("field_6136")]
    public static EntityType<CommandBlockMinecartEntity> COMMAND_BLOCK_MINECART { get; private set; }

    [Signature("field_6085")]
    public static EntityType<CowEntity> COW { get; private set; }

    [Signature("field_6046")]
    public static EntityType<CreeperEntity> CREEPER { get; private set; }

    [Signature("field_6087")]
    public static EntityType<DolphinEntity> DOLPHIN { get; private set; }

    [Signature("field_6067")]
    public static EntityType<DonkeyEntity> DONKEY { get; private set; }

    [Signature("field_6129")]
    public static EntityType<DragonFireballEntity> DRAGON_FIREBALL { get; private set; }

    [Signature("field_6123")]
    public static EntityType<DrownedEntity> DROWNED { get; private set; }

    [Signature("field_6144")]
    public static EntityType<EggEntity> EGG { get; private set; }

    [Signature("field_6086")]
    public static EntityType<ElderGuardianEntity> ELDER_GUARDIAN { get; private set; }

    [Signature("field_6110")]
    public static EntityType<EndCrystalEntity> END_CRYSTAL { get; private set; }

    [Signature("field_6116")]
    public static EntityType<EnderDragonEntity> ENDER_DRAGON { get; private set; }

    [Signature("field_6082")]
    public static EntityType<EnderPearlEntity> ENDER_PEARL { get; private set; }

    [Signature("field_6091")]
    public static EntityType<EndermanEntity> ENDERMAN { get; private set; }

    [Signature("field_6128")]
    public static EntityType<EndermiteEntity> ENDERMITE { get; private set; }

    [Signature("field_6090")]
    public static EntityType<EvokerEntity> EVOKER { get; private set; }

    [Signature("field_6060")]
    public static EntityType<EvokerFangsEntity> EVOKER_FANGS { get; private set; }

    [Signature("field_6064")]
    public static EntityType<ExperienceBottleEntity> EXPERIENCE_BOTTLE { get; private set; }

    [Signature("field_6044")]
    public static EntityType<ExperienceOrbEntity> EXPERIENCE_ORB { get; private set; }

    [Signature("field_6061")]
    public static EntityType<EyeOfEnderEntity> EYE_OF_ENDER { get; private set; }

    [Signature("field_6089")]
    public static EntityType<FallingBlockEntity> FALLING_BLOCK { get; private set; }

    [Signature("field_6133")]
    public static EntityType<FireworkRocketEntity> FIREWORK_ROCKET { get; private set; }

    [Signature("field_17943")]
    public static EntityType<FoxEntity> FOX { get; private set; }

    [Signature("field_37419")]
    public static EntityType<FrogEntity> FROG { get; private set; }

    [Signature("field_6080")]
    public static EntityType<FurnaceMinecartEntity> FURNACE_MINECART { get; private set; }

    [Signature("field_6107")]
    public static EntityType<GhastEntity> GHAST { get; private set; }

    [Signature("field_6095")]
    public static EntityType<GiantEntity> GIANT { get; private set; }

    [Signature("field_28401")]
    public static EntityType<GlowItemFrameEntity> GLOW_ITEM_FRAME { get; private set; }

    [Signature("field_28402")]
    public static EntityType<GlowSquidEntity> GLOW_SQUID { get; private set; }

    [Signature("field_30052")]
    public static EntityType<GoatEntity> GOAT { get; private set; }

    [Signature("field_6118")]
    public static EntityType<GuardianEntity> GUARDIAN { get; private set; }

    [Signature("field_21973")]
    public static EntityType<HoglinEntity> HOGLIN { get; private set; }

    [Signature("field_6058")]
    public static EntityType<HopperMinecartEntity> HOPPER_MINECART { get; private set; }

    [Signature("field_6139")]
    public static EntityType<HorseEntity> HORSE { get; private set; }

    [Signature("field_6071")]
    public static EntityType<HuskEntity> HUSK { get; private set; }

    [Signature("field_6065")]
    public static EntityType<IllusionerEntity> ILLUSIONER { get; private set; }

    [Signature("field_42623")]
    public static EntityType<InteractionEntity> INTERACTION { get; private set; }

    [Signature("field_6147")]
    public static EntityType<IronGolemEntity> IRON_GOLEM { get; private set; }

    [Signature("field_6052")]
    public static EntityType<ItemEntity> ITEM { get; private set; }

    // [Signature("field_42456")]
    // public static EntityType<DisplayEntity.ItemDisplayEntity> ITEM_DISPLAY { get; private set; }

    [Signature("field_6043")]
    public static EntityType<ItemFrameEntity> ITEM_FRAME { get; private set; }

    [Signature("field_6066")]
    public static EntityType<FireballEntity> FIREBALL { get; private set; }

    [Signature("field_6138")]
    public static EntityType<LeashKnotEntity> LEASH_KNOT { get; private set; }

    [Signature("field_6112")]
    public static EntityType<LightningEntity> LIGHTNING_BOLT { get; private set; }

    [Signature("field_6074")]
    public static EntityType<LlamaEntity> LLAMA { get; private set; }

    [Signature("field_6124")]
    public static EntityType<LlamaSpitEntity> LLAMA_SPIT { get; private set; }

    [Signature("field_6102")]
    public static EntityType<MagmaCubeEntity> MAGMA_CUBE { get; private set; }

    [Signature("field_33456")]
    public static EntityType<MarkerEntity> MARKER { get; private set; }

    [Signature("field_6096")]
    public static EntityType<MinecartEntity> MINECART { get; private set; }

    [Signature("field_6143")]
    public static EntityType<MooshroomEntity> MOOSHROOM { get; private set; }

    [Signature("field_6057")]
    public static EntityType<MuleEntity> MULE { get; private set; }

    [Signature("field_6081")]
    public static EntityType<OcelotEntity> OCELOT { get; private set; }

    [Signature("field_6120")]
    public static EntityType<PaintingEntity> PAINTING { get; private set; }

    [Signature("field_6146")]
    public static EntityType<PandaEntity> PANDA { get; private set; }

    [Signature("field_6104")]
    public static EntityType<ParrotEntity> PARROT { get; private set; }

    [Signature("field_6078")]
    public static EntityType<PhantomEntity> PHANTOM { get; private set; }

    [Signature("field_6093")]
    public static EntityType<PigEntity> PIG { get; private set; }

    [Signature("field_22281")]
    public static EntityType<PiglinEntity> PIGLIN { get; private set; }

    [Signature("field_25751")]
    public static EntityType<PiglinBruteEntity> PIGLIN_BRUTE { get; private set; }

    [Signature("field_6105")]
    public static EntityType<PillagerEntity> PILLAGER { get; private set; }

    [Signature("field_6042")]
    public static EntityType<PolarBearEntity> POLAR_BEAR { get; private set; }

    [Signature("field_6045")]
    public static EntityType<PotionEntity> POTION { get; private set; }

    [Signature("field_6062")]
    public static EntityType<PufferfishEntity> PUFFERFISH { get; private set; }

    [Signature("field_6140")]
    public static EntityType<RabbitEntity> RABBIT { get; private set; }

    [Signature("field_6134")]
    public static EntityType<RavagerEntity> RAVAGER { get; private set; }

    [Signature("field_6073")]
    public static EntityType<SalmonEntity> SALMON { get; private set; }

    [Signature("field_6115")]
    public static EntityType<SheepEntity> SHEEP { get; private set; }

    [Signature("field_6109")]
    public static EntityType<ShulkerEntity> SHULKER { get; private set; }

    [Signature("field_6100")]
    public static EntityType<ShulkerBulletEntity> SHULKER_BULLET { get; private set; }

    [Signature("field_6125")]
    public static EntityType<SilverfishEntity> SILVERFISH { get; private set; }

    [Signature("field_6137")]
    public static EntityType<SkeletonEntity> SKELETON { get; private set; }

    [Signature("field_6075")]
    public static EntityType<SkeletonHorseEntity> SKELETON_HORSE { get; private set; }

    [Signature("field_6069")]
    public static EntityType<SlimeEntity> SLIME { get; private set; }

    [Signature("field_6049")]
    public static EntityType<SmallFireballEntity> SMALL_FIREBALL { get; private set; }

    [Signature("field_42622")]
    public static EntityType<SnifferEntity> SNIFFER { get; private set; }

    [Signature("field_6047")]
    public static EntityType<SnowGolemEntity> SNOW_GOLEM { get; private set; }

    [Signature("field_6068")]
    public static EntityType<SnowballEntity> SNOWBALL { get; private set; }

    [Signature("field_6142")]
    public static EntityType<SpawnerMinecartEntity> SPAWNER_MINECART { get; private set; }

    [Signature("field_6135")]
    public static EntityType<SpectralArrowEntity> SPECTRAL_ARROW { get; private set; }

    [Signature("field_6079")]
    public static EntityType<SpiderEntity> SPIDER { get; private set; }

    [Signature("field_6114")]
    public static EntityType<SquidEntity> SQUID { get; private set; }

    [Signature("field_6098")]
    public static EntityType<StrayEntity> STRAY { get; private set; }

    [Signature("field_23214")]
    public static EntityType<StriderEntity> STRIDER { get; private set; }

    [Signature("field_37420")]
    public static EntityType<TadpoleEntity> TADPOLE { get; private set; }

    // [Signature("field_42457")]
    // public static EntityType<DisplayEntity.TextDisplayEntity> TEXT_DISPLAY { get; private set; }

    [Signature("field_6063")]
    public static EntityType<TntEntity> TNT { get; private set; }

    [Signature("field_6053")]
    public static EntityType<TntMinecartEntity> TNT_MINECART { get; private set; }

    [Signature("field_17714")]
    public static EntityType<TraderLlamaEntity> TRADER_LLAMA { get; private set; }

    [Signature("field_6127")]
    public static EntityType<TridentEntity> TRIDENT { get; private set; }

    [Signature("field_6111")]
    public static EntityType<TropicalFishEntity> TROPICAL_FISH { get; private set; }

    [Signature("field_6113")]
    public static EntityType<TurtleEntity> TURTLE { get; private set; }

    [Signature("field_6059")]
    public static EntityType<VexEntity> VEX { get; private set; }

    [Signature("field_6077")]
    public static EntityType<VillagerEntity> VILLAGER { get; private set; }

    [Signature("field_6117")]
    public static EntityType<VindicatorEntity> VINDICATOR { get; private set; }

    [Signature("field_17713")]
    public static EntityType<WanderingTraderEntity> WANDERING_TRADER { get; private set; }

    [Signature("field_38095")]
    public static EntityType<WardenEntity> WARDEN { get; private set; }

    [Signature("field_47243")]
    public static EntityType<WindChargeEntity> WIND_CHARGE { get; private set; }

    [Signature("field_6145")]
    public static EntityType<WitchEntity> WITCH { get; private set; }

    [Signature("field_6119")]
    public static EntityType<WitherEntity> WITHER { get; private set; }

    [Signature("field_6076")]
    public static EntityType<WitherSkeletonEntity> WITHER_SKELETON { get; private set; }

    [Signature("field_6130")]
    public static EntityType<WitherSkullEntity> WITHER_SKULL { get; private set; }

    [Signature("field_6055")]
    public static EntityType<WolfEntity> WOLF { get; private set; }

    [Signature("field_23696")]
    public static EntityType<ZoglinEntity> ZOGLIN { get; private set; }

    [Signature("field_6051")]
    public static EntityType<ZombieEntity> ZOMBIE { get; private set; }

    [Signature("field_6048")]
    public static EntityType<ZombieHorseEntity> ZOMBIE_HORSE { get; private set; }

    [Signature("field_6054")]
    public static EntityType<ZombieVillagerEntity> ZOMBIE_VILLAGER { get; private set; }

    [Signature("field_6050")]
    public static EntityType<ZombifiedPiglinEntity> ZOMBIFIED_PIGLIN { get; private set; }

    [Signature("field_6097")]
    public static EntityType<PlayerEntity> PLAYER { get; private set; }

    [Signature("field_6103")]
    public static EntityType<FishingBobberEntity> FISHING_BOBBER { get; private set; }
}