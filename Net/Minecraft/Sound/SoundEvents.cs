using Net.Minecraft.Registry.Entry;

namespace Net.Minecraft.Sound;

[MapName("net/minecraft/class_3417")]
public partial class SoundEvents : JavaObject, IClassRef<SoundEvents>, IFromHandle<SoundEvents>
{
    [Signature("field_38365")]
    public static SoundEvent ENTITY_ALLAY_AMBIENT_WITH_ITEM { get; private set; }

    [Signature("field_38366")]
    public static SoundEvent ENTITY_ALLAY_AMBIENT_WITHOUT_ITEM { get; private set; }

    [Signature("field_38367")]
    public static SoundEvent ENTITY_ALLAY_DEATH { get; private set; }

    [Signature("field_38369")]
    public static SoundEvent ENTITY_ALLAY_HURT { get; private set; }

    [Signature("field_38370")]
    public static SoundEvent ENTITY_ALLAY_ITEM_GIVEN { get; private set; }

    [Signature("field_38371")]
    public static SoundEvent ENTITY_ALLAY_ITEM_TAKEN { get; private set; }

    [Signature("field_38923")]
    public static SoundEvent ENTITY_ALLAY_ITEM_THROWN { get; private set; }

    [Signature("field_14564")]
    public static RegistryEntry.Reference<SoundEvent> AMBIENT_CAVE { get; private set; }

    [Signature("field_23790")]
    public static RegistryEntry.Reference<SoundEvent> AMBIENT_BASALT_DELTAS_ADDITIONS { get; private set; }

    [Signature("field_23791")]
    public static RegistryEntry.Reference<SoundEvent> AMBIENT_BASALT_DELTAS_LOOP { get; private set; }

    [Signature("field_23792")]
    public static RegistryEntry.Reference<SoundEvent> AMBIENT_BASALT_DELTAS_MOOD { get; private set; }

    [Signature("field_22451")]
    public static RegistryEntry.Reference<SoundEvent> AMBIENT_CRIMSON_FOREST_ADDITIONS { get; private set; }

    [Signature("field_22452")]
    public static RegistryEntry.Reference<SoundEvent> AMBIENT_CRIMSON_FOREST_LOOP { get; private set; }

    [Signature("field_22453")]
    public static RegistryEntry.Reference<SoundEvent> AMBIENT_CRIMSON_FOREST_MOOD { get; private set; }

    [Signature("field_22454")]
    public static RegistryEntry.Reference<SoundEvent> AMBIENT_NETHER_WASTES_ADDITIONS { get; private set; }

    [Signature("field_22455")]
    public static RegistryEntry.Reference<SoundEvent> AMBIENT_NETHER_WASTES_LOOP { get; private set; }

    [Signature("field_22456")]
    public static RegistryEntry.Reference<SoundEvent> AMBIENT_NETHER_WASTES_MOOD { get; private set; }

    [Signature("field_22457")]
    public static RegistryEntry.Reference<SoundEvent> AMBIENT_SOUL_SAND_VALLEY_ADDITIONS { get; private set; }

    [Signature("field_22458")]
    public static RegistryEntry.Reference<SoundEvent> AMBIENT_SOUL_SAND_VALLEY_LOOP { get; private set; }

    [Signature("field_22459")]
    public static RegistryEntry.Reference<SoundEvent> AMBIENT_SOUL_SAND_VALLEY_MOOD { get; private set; }

    [Signature("field_22460")]
    public static RegistryEntry.Reference<SoundEvent> AMBIENT_WARPED_FOREST_ADDITIONS { get; private set; }

    [Signature("field_22461")]
    public static RegistryEntry.Reference<SoundEvent> AMBIENT_WARPED_FOREST_LOOP { get; private set; }

    [Signature("field_22462")]
    public static RegistryEntry.Reference<SoundEvent> AMBIENT_WARPED_FOREST_MOOD { get; private set; }

    [Signature("field_14756")]
    public static SoundEvent AMBIENT_UNDERWATER_ENTER { get; private set; }

    [Signature("field_14828")]
    public static SoundEvent AMBIENT_UNDERWATER_EXIT { get; private set; }

    [Signature("field_14951")]
    public static SoundEvent AMBIENT_UNDERWATER_LOOP { get; private set; }

    [Signature("field_15028")]
    public static SoundEvent AMBIENT_UNDERWATER_LOOP_ADDITIONS { get; private set; }

    [Signature("field_15068")]
    public static SoundEvent AMBIENT_UNDERWATER_LOOP_ADDITIONS_RARE { get; private set; }

    [Signature("field_15178")]
    public static SoundEvent AMBIENT_UNDERWATER_LOOP_ADDITIONS_ULTRA_RARE { get; private set; }

    [Signature("field_26979")]
    public static SoundEvent BLOCK_AMETHYST_BLOCK_BREAK { get; private set; }

    [Signature("field_26980")]
    public static SoundEvent BLOCK_AMETHYST_BLOCK_CHIME { get; private set; }

    [Signature("field_26981")]
    public static SoundEvent BLOCK_AMETHYST_BLOCK_FALL { get; private set; }

    [Signature("field_26982")]
    public static SoundEvent BLOCK_AMETHYST_BLOCK_HIT { get; private set; }

    [Signature("field_26940")]
    public static SoundEvent BLOCK_AMETHYST_BLOCK_PLACE { get; private set; }

    [Signature("field_43154")]
    public static SoundEvent BLOCK_AMETHYST_BLOCK_RESONATE { get; private set; }

    [Signature("field_26941")]
    public static SoundEvent BLOCK_AMETHYST_BLOCK_STEP { get; private set; }

    [Signature("field_26942")]
    public static SoundEvent BLOCK_AMETHYST_CLUSTER_BREAK { get; private set; }

    [Signature("field_26943")]
    public static SoundEvent BLOCK_AMETHYST_CLUSTER_FALL { get; private set; }

    [Signature("field_26944")]
    public static SoundEvent BLOCK_AMETHYST_CLUSTER_HIT { get; private set; }

    [Signature("field_26945")]
    public static SoundEvent BLOCK_AMETHYST_CLUSTER_PLACE { get; private set; }

    [Signature("field_26946")]
    public static SoundEvent BLOCK_AMETHYST_CLUSTER_STEP { get; private set; }

    [Signature("field_21891")]
    public static SoundEvent BLOCK_ANCIENT_DEBRIS_BREAK { get; private set; }

    [Signature("field_21906")]
    public static SoundEvent BLOCK_ANCIENT_DEBRIS_STEP { get; private set; }

    [Signature("field_21929")]
    public static SoundEvent BLOCK_ANCIENT_DEBRIS_PLACE { get; private set; }

    [Signature("field_21930")]
    public static SoundEvent BLOCK_ANCIENT_DEBRIS_HIT { get; private set; }

    [Signature("field_21936")]
    public static SoundEvent BLOCK_ANCIENT_DEBRIS_FALL { get; private set; }

    [Signature("field_14542")]
    public static SoundEvent BLOCK_ANVIL_BREAK { get; private set; }

    [Signature("field_14665")]
    public static SoundEvent BLOCK_ANVIL_DESTROY { get; private set; }

    [Signature("field_14727")]
    public static SoundEvent BLOCK_ANVIL_FALL { get; private set; }

    [Signature("field_14927")]
    public static SoundEvent BLOCK_ANVIL_HIT { get; private set; }

    [Signature("field_14833")]
    public static SoundEvent BLOCK_ANVIL_LAND { get; private set; }

    [Signature("field_14785")]
    public static SoundEvent BLOCK_ANVIL_PLACE { get; private set; }

    [Signature("field_14695")]
    public static SoundEvent BLOCK_ANVIL_STEP { get; private set; }

    [Signature("field_14559")]
    public static SoundEvent BLOCK_ANVIL_USE { get; private set; }

    [Signature("field_15191")]
    public static SoundEvent ITEM_ARMOR_EQUIP_CHAIN { get; private set; }

    [Signature("field_15103")]
    public static SoundEvent ITEM_ARMOR_EQUIP_DIAMOND { get; private set; }

    [Signature("field_14966")]
    public static SoundEvent ITEM_ARMOR_EQUIP_ELYTRA { get; private set; }

    [Signature("field_14883")]
    public static SoundEvent ITEM_ARMOR_EQUIP_GENERIC { get; private set; }

    [Signature("field_14761")]
    public static SoundEvent ITEM_ARMOR_EQUIP_GOLD { get; private set; }

    [Signature("field_14862")]
    public static SoundEvent ITEM_ARMOR_EQUIP_IRON { get; private set; }

    [Signature("field_14581")]
    public static SoundEvent ITEM_ARMOR_EQUIP_LEATHER { get; private set; }

    [Signature("field_21866")]
    public static SoundEvent ITEM_ARMOR_EQUIP_NETHERITE { get; private set; }

    [Signature("field_14684")]
    public static SoundEvent ITEM_ARMOR_EQUIP_TURTLE { get; private set; }

    [Signature("field_15118")]
    public static SoundEvent ENTITY_ARMOR_STAND_BREAK { get; private set; }

    [Signature("field_15186")]
    public static SoundEvent ENTITY_ARMOR_STAND_FALL { get; private set; }

    [Signature("field_14897")]
    public static SoundEvent ENTITY_ARMOR_STAND_HIT { get; private set; }

    [Signature("field_14969")]
    public static SoundEvent ENTITY_ARMOR_STAND_PLACE { get; private set; }

    [Signature("field_15151")]
    public static SoundEvent ENTITY_ARROW_HIT { get; private set; }

    [Signature("field_15224")]
    public static SoundEvent ENTITY_ARROW_HIT_PLAYER { get; private set; }

    [Signature("field_14600")]
    public static SoundEvent ENTITY_ARROW_SHOOT { get; private set; }

    [Signature("field_14675")]
    public static SoundEvent ITEM_AXE_STRIP { get; private set; }

    [Signature("field_29541")]
    public static SoundEvent ITEM_AXE_SCRAPE { get; private set; }

    [Signature("field_29542")]
    public static SoundEvent ITEM_AXE_WAX_OFF { get; private set; }

    [Signature("field_28287")]
    public static SoundEvent ENTITY_AXOLOTL_ATTACK { get; private set; }

    [Signature("field_28288")]
    public static SoundEvent ENTITY_AXOLOTL_DEATH { get; private set; }

    [Signature("field_28289")]
    public static SoundEvent ENTITY_AXOLOTL_HURT { get; private set; }

    [Signature("field_28290")]
    public static SoundEvent ENTITY_AXOLOTL_IDLE_AIR { get; private set; }

    [Signature("field_28291")]
    public static SoundEvent ENTITY_AXOLOTL_IDLE_WATER { get; private set; }

    [Signature("field_28292")]
    public static SoundEvent ENTITY_AXOLOTL_SPLASH { get; private set; }

    [Signature("field_28293")]
    public static SoundEvent ENTITY_AXOLOTL_SWIM { get; private set; }

    [Signature("field_28560")]
    public static SoundEvent BLOCK_AZALEA_BREAK { get; private set; }

    [Signature("field_28561")]
    public static SoundEvent BLOCK_AZALEA_FALL { get; private set; }

    [Signature("field_28562")]
    public static SoundEvent BLOCK_AZALEA_HIT { get; private set; }

    [Signature("field_28563")]
    public static SoundEvent BLOCK_AZALEA_PLACE { get; private set; }

    [Signature("field_28564")]
    public static SoundEvent BLOCK_AZALEA_STEP { get; private set; }

    [Signature("field_28565")]
    public static SoundEvent BLOCK_AZALEA_LEAVES_BREAK { get; private set; }

    [Signature("field_28566")]
    public static SoundEvent BLOCK_AZALEA_LEAVES_FALL { get; private set; }

    [Signature("field_28567")]
    public static SoundEvent BLOCK_AZALEA_LEAVES_HIT { get; private set; }

    [Signature("field_28558")]
    public static SoundEvent BLOCK_AZALEA_LEAVES_PLACE { get; private set; }

    [Signature("field_28559")]
    public static SoundEvent BLOCK_AZALEA_LEAVES_STEP { get; private set; }

    [Signature("field_14740")]
    public static SoundEvent BLOCK_BAMBOO_BREAK { get; private set; }

    [Signature("field_14906")]
    public static SoundEvent BLOCK_BAMBOO_FALL { get; private set; }

    [Signature("field_14811")]
    public static SoundEvent BLOCK_BAMBOO_HIT { get; private set; }

    [Signature("field_14719")]
    public static SoundEvent BLOCK_BAMBOO_PLACE { get; private set; }

    [Signature("field_14635")]
    public static SoundEvent BLOCK_BAMBOO_STEP { get; private set; }

    [Signature("field_14629")]
    public static SoundEvent BLOCK_BAMBOO_SAPLING_BREAK { get; private set; }

    [Signature("field_15227")]
    public static SoundEvent BLOCK_BAMBOO_SAPLING_HIT { get; private set; }

    [Signature("field_15125")]
    public static SoundEvent BLOCK_BAMBOO_SAPLING_PLACE { get; private set; }

    [Signature("field_40057")]
    public static SoundEvent BLOCK_BAMBOO_WOOD_BREAK { get; private set; }

    [Signature("field_40058")]
    public static SoundEvent BLOCK_BAMBOO_WOOD_FALL { get; private set; }

    [Signature("field_40059")]
    public static SoundEvent BLOCK_BAMBOO_WOOD_HIT { get; private set; }

    [Signature("field_40060")]
    public static SoundEvent BLOCK_BAMBOO_WOOD_PLACE { get; private set; }

    [Signature("field_40061")]
    public static SoundEvent BLOCK_BAMBOO_WOOD_STEP { get; private set; }

    [Signature("field_40062")]
    public static SoundEvent BLOCK_BAMBOO_WOOD_DOOR_CLOSE { get; private set; }

    [Signature("field_40063")]
    public static SoundEvent BLOCK_BAMBOO_WOOD_DOOR_OPEN { get; private set; }

    [Signature("field_40064")]
    public static SoundEvent BLOCK_BAMBOO_WOOD_TRAPDOOR_CLOSE { get; private set; }

    [Signature("field_40065")]
    public static SoundEvent BLOCK_BAMBOO_WOOD_TRAPDOOR_OPEN { get; private set; }

    [Signature("field_40066")]
    public static SoundEvent BLOCK_BAMBOO_WOOD_BUTTON_CLICK_OFF { get; private set; }

    [Signature("field_40067")]
    public static SoundEvent BLOCK_BAMBOO_WOOD_BUTTON_CLICK_ON { get; private set; }

    [Signature("field_40068")]
    public static SoundEvent BLOCK_BAMBOO_WOOD_PRESSURE_PLATE_CLICK_OFF { get; private set; }

    [Signature("field_40069")]
    public static SoundEvent BLOCK_BAMBOO_WOOD_PRESSURE_PLATE_CLICK_ON { get; private set; }

    [Signature("field_40070")]
    public static SoundEvent BLOCK_BAMBOO_WOOD_FENCE_GATE_CLOSE { get; private set; }

    [Signature("field_40071")]
    public static SoundEvent BLOCK_BAMBOO_WOOD_FENCE_GATE_OPEN { get; private set; }

    [Signature("field_17603")]
    public static SoundEvent BLOCK_BARREL_CLOSE { get; private set; }

    [Signature("field_17604")]
    public static SoundEvent BLOCK_BARREL_OPEN { get; private set; }

    [Signature("field_21867")]
    public static SoundEvent BLOCK_BASALT_BREAK { get; private set; }

    [Signature("field_21868")]
    public static SoundEvent BLOCK_BASALT_STEP { get; private set; }

    [Signature("field_21869")]
    public static SoundEvent BLOCK_BASALT_PLACE { get; private set; }

    [Signature("field_21870")]
    public static SoundEvent BLOCK_BASALT_HIT { get; private set; }

    [Signature("field_21871")]
    public static SoundEvent BLOCK_BASALT_FALL { get; private set; }

    [Signature("field_15009")]
    public static SoundEvent ENTITY_BAT_AMBIENT { get; private set; }

    [Signature("field_14911")]
    public static SoundEvent ENTITY_BAT_DEATH { get; private set; }

    [Signature("field_14746")]
    public static SoundEvent ENTITY_BAT_HURT { get; private set; }

    [Signature("field_14845")]
    public static SoundEvent ENTITY_BAT_LOOP { get; private set; }

    [Signature("field_14610")]
    public static SoundEvent ENTITY_BAT_TAKEOFF { get; private set; }

    [Signature("field_14703")]
    public static SoundEvent BLOCK_BEACON_ACTIVATE { get; private set; }

    [Signature("field_15045")]
    public static SoundEvent BLOCK_BEACON_AMBIENT { get; private set; }

    [Signature("field_19344")]
    public static SoundEvent BLOCK_BEACON_DEACTIVATE { get; private set; }

    [Signature("field_14891")]
    public static SoundEvent BLOCK_BEACON_POWER_SELECT { get; private set; }

    [Signature("field_20602")]
    public static SoundEvent ENTITY_BEE_DEATH { get; private set; }

    [Signature("field_20603")]
    public static SoundEvent ENTITY_BEE_HURT { get; private set; }

    [Signature("field_20604")]
    public static SoundEvent ENTITY_BEE_LOOP_AGGRESSIVE { get; private set; }

    [Signature("field_20605")]
    public static SoundEvent ENTITY_BEE_LOOP { get; private set; }

    [Signature("field_20606")]
    public static SoundEvent ENTITY_BEE_STING { get; private set; }

    [Signature("field_20607")]
    public static SoundEvent ENTITY_BEE_POLLINATE { get; private set; }

    [Signature("field_20608")]
    public static SoundEvent BLOCK_BEEHIVE_DRIP { get; private set; }

    [Signature("field_20609")]
    public static SoundEvent BLOCK_BEEHIVE_ENTER { get; private set; }

    [Signature("field_20610")]
    public static SoundEvent BLOCK_BEEHIVE_EXIT { get; private set; }

    [Signature("field_20611")]
    public static SoundEvent BLOCK_BEEHIVE_SHEAR { get; private set; }

    [Signature("field_20612")]
    public static SoundEvent BLOCK_BEEHIVE_WORK { get; private set; }

    [Signature("field_17265")]
    public static SoundEvent BLOCK_BELL_USE { get; private set; }

    [Signature("field_19167")]
    public static SoundEvent BLOCK_BELL_RESONATE { get; private set; }

    [Signature("field_28568")]
    public static SoundEvent BLOCK_BIG_DRIPLEAF_BREAK { get; private set; }

    [Signature("field_28569")]
    public static SoundEvent BLOCK_BIG_DRIPLEAF_FALL { get; private set; }

    [Signature("field_28570")]
    public static SoundEvent BLOCK_BIG_DRIPLEAF_HIT { get; private set; }

    [Signature("field_28571")]
    public static SoundEvent BLOCK_BIG_DRIPLEAF_PLACE { get; private set; }

    [Signature("field_28572")]
    public static SoundEvent BLOCK_BIG_DRIPLEAF_STEP { get; private set; }

    [Signature("field_14991")]
    public static SoundEvent ENTITY_BLAZE_AMBIENT { get; private set; }

    [Signature("field_14734")]
    public static SoundEvent ENTITY_BLAZE_BURN { get; private set; }

    [Signature("field_14580")]
    public static SoundEvent ENTITY_BLAZE_DEATH { get; private set; }

    [Signature("field_14842")]
    public static SoundEvent ENTITY_BLAZE_HURT { get; private set; }

    [Signature("field_14970")]
    public static SoundEvent ENTITY_BLAZE_SHOOT { get; private set; }

    [Signature("field_14886")]
    public static SoundEvent ENTITY_BOAT_PADDLE_LAND { get; private set; }

    [Signature("field_15171")]
    public static SoundEvent ENTITY_BOAT_PADDLE_WATER { get; private set; }

    [Signature("field_21872")]
    public static SoundEvent BLOCK_BONE_BLOCK_BREAK { get; private set; }

    [Signature("field_21873")]
    public static SoundEvent BLOCK_BONE_BLOCK_FALL { get; private set; }

    [Signature("field_21874")]
    public static SoundEvent BLOCK_BONE_BLOCK_HIT { get; private set; }

    [Signature("field_21875")]
    public static SoundEvent BLOCK_BONE_BLOCK_PLACE { get; private set; }

    [Signature("field_21876")]
    public static SoundEvent BLOCK_BONE_BLOCK_STEP { get; private set; }

    [Signature("field_33433")]
    public static SoundEvent ITEM_BONE_MEAL_USE { get; private set; }

    [Signature("field_17481")]
    public static SoundEvent ITEM_BOOK_PAGE_TURN { get; private set; }

    [Signature("field_17482")]
    public static SoundEvent ITEM_BOOK_PUT { get; private set; }

    [Signature("field_17605")]
    public static SoundEvent BLOCK_BLASTFURNACE_FIRE_CRACKLE { get; private set; }

    [Signature("field_14826")]
    public static SoundEvent ITEM_BOTTLE_EMPTY { get; private set; }

    [Signature("field_14779")]
    public static SoundEvent ITEM_BOTTLE_FILL { get; private set; }

    [Signature("field_15029")]
    public static SoundEvent ITEM_BOTTLE_FILL_DRAGONBREATH { get; private set; }

    [Signature("field_47192")]
    public static SoundEvent ENTITY_BREEZE_INHALE { get; private set; }

    [Signature("field_47193")]
    public static SoundEvent ENTITY_BREEZE_IDLE_GROUND { get; private set; }

    [Signature("field_47194")]
    public static SoundEvent ENTITY_BREEZE_IDLE_AIR { get; private set; }

    [Signature("field_47195")]
    public static SoundEvent ENTITY_BREEZE_SHOOT { get; private set; }

    [Signature("field_47196")]
    public static SoundEvent ENTITY_BREEZE_JUMP { get; private set; }

    [Signature("field_47197")]
    public static SoundEvent ENTITY_BREEZE_LAND { get; private set; }

    [Signature("field_47198")]
    public static SoundEvent ENTITY_BREEZE_SLIDE { get; private set; }

    [Signature("field_47199")]
    public static SoundEvent ENTITY_BREEZE_DEATH { get; private set; }

    [Signature("field_47200")]
    public static SoundEvent ENTITY_BREEZE_HURT { get; private set; }

    [Signature("field_14978")]
    public static SoundEvent BLOCK_BREWING_STAND_BREW { get; private set; }

    [Signature("field_43155")]
    public static SoundEvent ITEM_BRUSH_BRUSHING_GENERIC { get; private set; }

    [Signature("field_43156")]
    public static SoundEvent ITEM_BRUSH_BRUSHING_SAND { get; private set; }

    [Signature("field_43157")]
    public static SoundEvent ITEM_BRUSH_BRUSHING_GRAVEL { get; private set; }

    [Signature("field_43158")]
    public static SoundEvent ITEM_BRUSH_BRUSHING_SAND_COMPLETE { get; private set; }

    [Signature("field_43159")]
    public static SoundEvent ITEM_BRUSH_BRUSHING_GRAVEL_COMPLETE { get; private set; }

    [Signature("field_15065")]
    public static SoundEvent BLOCK_BUBBLE_COLUMN_BUBBLE_POP { get; private set; }

    [Signature("field_15161")]
    public static SoundEvent BLOCK_BUBBLE_COLUMN_UPWARDS_AMBIENT { get; private set; }

    [Signature("field_19195")]
    public static SoundEvent BLOCK_BUBBLE_COLUMN_UPWARDS_INSIDE { get; private set; }

    [Signature("field_14650")]
    public static SoundEvent BLOCK_BUBBLE_COLUMN_WHIRLPOOL_AMBIENT { get; private set; }

    [Signature("field_19196")]
    public static SoundEvent BLOCK_BUBBLE_COLUMN_WHIRLPOOL_INSIDE { get; private set; }

    [Signature("field_14834")]
    public static SoundEvent ITEM_BUCKET_EMPTY { get; private set; }

    [Signature("field_28294")]
    public static SoundEvent ITEM_BUCKET_EMPTY_AXOLOTL { get; private set; }

    [Signature("field_14912")]
    public static SoundEvent ITEM_BUCKET_EMPTY_FISH { get; private set; }

    [Signature("field_15010")]
    public static SoundEvent ITEM_BUCKET_EMPTY_LAVA { get; private set; }

    [Signature("field_27847")]
    public static SoundEvent ITEM_BUCKET_EMPTY_POWDER_SNOW { get; private set; }

    [Signature("field_37300")]
    public static SoundEvent ITEM_BUCKET_EMPTY_TADPOLE { get; private set; }

    [Signature("field_15126")]
    public static SoundEvent ITEM_BUCKET_FILL { get; private set; }

    [Signature("field_28295")]
    public static SoundEvent ITEM_BUCKET_FILL_AXOLOTL { get; private set; }

    [Signature("field_14568")]
    public static SoundEvent ITEM_BUCKET_FILL_FISH { get; private set; }

    [Signature("field_15202")]
    public static SoundEvent ITEM_BUCKET_FILL_LAVA { get; private set; }

    [Signature("field_27846")]
    public static SoundEvent ITEM_BUCKET_FILL_POWDER_SNOW { get; private set; }

    [Signature("field_37301")]
    public static SoundEvent ITEM_BUCKET_FILL_TADPOLE { get; private set; }

    [Signature("field_34375")]
    public static SoundEvent ITEM_BUNDLE_DROP_CONTENTS { get; private set; }

    [Signature("field_34376")]
    public static SoundEvent ITEM_BUNDLE_INSERT { get; private set; }

    [Signature("field_34377")]
    public static SoundEvent ITEM_BUNDLE_REMOVE_ONE { get; private set; }

    [Signature("field_26947")]
    public static SoundEvent BLOCK_CAKE_ADD_CANDLE { get; private set; }

    [Signature("field_26948")]
    public static SoundEvent BLOCK_CALCITE_BREAK { get; private set; }

    [Signature("field_26949")]
    public static SoundEvent BLOCK_CALCITE_STEP { get; private set; }

    [Signature("field_26950")]
    public static SoundEvent BLOCK_CALCITE_PLACE { get; private set; }

    [Signature("field_26951")]
    public static SoundEvent BLOCK_CALCITE_HIT { get; private set; }

    [Signature("field_26952")]
    public static SoundEvent BLOCK_CALCITE_FALL { get; private set; }

    [Signature("field_40072")]
    public static SoundEvent ENTITY_CAMEL_AMBIENT { get; private set; }

    [Signature("field_40073")]
    public static SoundEvent ENTITY_CAMEL_DASH { get; private set; }

    [Signature("field_40074")]
    public static SoundEvent ENTITY_CAMEL_DASH_READY { get; private set; }

    [Signature("field_40075")]
    public static SoundEvent ENTITY_CAMEL_DEATH { get; private set; }

    [Signature("field_40076")]
    public static SoundEvent ENTITY_CAMEL_EAT { get; private set; }

    [Signature("field_40077")]
    public static SoundEvent ENTITY_CAMEL_HURT { get; private set; }

    [Signature("field_40078")]
    public static SoundEvent ENTITY_CAMEL_SADDLE { get; private set; }

    [Signature("field_40079")]
    public static SoundEvent ENTITY_CAMEL_SIT { get; private set; }

    [Signature("field_40080")]
    public static SoundEvent ENTITY_CAMEL_STAND { get; private set; }

    [Signature("field_40081")]
    public static SoundEvent ENTITY_CAMEL_STEP { get; private set; }

    [Signature("field_40082")]
    public static SoundEvent ENTITY_CAMEL_STEP_SAND { get; private set; }

    [Signature("field_17483")]
    public static SoundEvent BLOCK_CAMPFIRE_CRACKLE { get; private set; }

    [Signature("field_26953")]
    public static SoundEvent BLOCK_CANDLE_AMBIENT { get; private set; }

    [Signature("field_26954")]
    public static SoundEvent BLOCK_CANDLE_BREAK { get; private set; }

    [Signature("field_26955")]
    public static SoundEvent BLOCK_CANDLE_EXTINGUISH { get; private set; }

    [Signature("field_26956")]
    public static SoundEvent BLOCK_CANDLE_FALL { get; private set; }

    [Signature("field_26957")]
    public static SoundEvent BLOCK_CANDLE_HIT { get; private set; }

    [Signature("field_26958")]
    public static SoundEvent BLOCK_CANDLE_PLACE { get; private set; }

    [Signature("field_26959")]
    public static SoundEvent BLOCK_CANDLE_STEP { get; private set; }

    [Signature("field_15051")]
    public static SoundEvent ENTITY_CAT_AMBIENT { get; private set; }

    [Signature("field_16440")]
    public static SoundEvent ENTITY_CAT_STRAY_AMBIENT { get; private set; }

    [Signature("field_14971")]
    public static SoundEvent ENTITY_CAT_DEATH { get; private set; }

    [Signature("field_16439")]
    public static SoundEvent ENTITY_CAT_EAT { get; private set; }

    [Signature("field_14938")]
    public static SoundEvent ENTITY_CAT_HISS { get; private set; }

    [Signature("field_16438")]
    public static SoundEvent ENTITY_CAT_BEG_FOR_FOOD { get; private set; }

    [Signature("field_14867")]
    public static SoundEvent ENTITY_CAT_HURT { get; private set; }

    [Signature("field_14741")]
    public static SoundEvent ENTITY_CAT_PURR { get; private set; }

    [Signature("field_14589")]
    public static SoundEvent ENTITY_CAT_PURREOW { get; private set; }

    [Signature("field_28576")]
    public static SoundEvent BLOCK_CAVE_VINES_BREAK { get; private set; }

    [Signature("field_28577")]
    public static SoundEvent BLOCK_CAVE_VINES_FALL { get; private set; }

    [Signature("field_28578")]
    public static SoundEvent BLOCK_CAVE_VINES_HIT { get; private set; }

    [Signature("field_28573")]
    public static SoundEvent BLOCK_CAVE_VINES_PLACE { get; private set; }

    [Signature("field_28574")]
    public static SoundEvent BLOCK_CAVE_VINES_STEP { get; private set; }

    [Signature("field_28575")]
    public static SoundEvent BLOCK_CAVE_VINES_PICK_BERRIES { get; private set; }

    [Signature("field_24065")]
    public static SoundEvent BLOCK_CHAIN_BREAK { get; private set; }

    [Signature("field_24061")]
    public static SoundEvent BLOCK_CHAIN_FALL { get; private set; }

    [Signature("field_24062")]
    public static SoundEvent BLOCK_CHAIN_HIT { get; private set; }

    [Signature("field_24063")]
    public static SoundEvent BLOCK_CHAIN_PLACE { get; private set; }

    [Signature("field_24064")]
    public static SoundEvent BLOCK_CHAIN_STEP { get; private set; }

    [Signature("field_42573")]
    public static SoundEvent BLOCK_CHERRY_WOOD_BREAK { get; private set; }

    [Signature("field_42547")]
    public static SoundEvent BLOCK_CHERRY_WOOD_FALL { get; private set; }

    [Signature("field_42548")]
    public static SoundEvent BLOCK_CHERRY_WOOD_HIT { get; private set; }

    [Signature("field_42549")]
    public static SoundEvent BLOCK_CHERRY_WOOD_PLACE { get; private set; }

    [Signature("field_42550")]
    public static SoundEvent BLOCK_CHERRY_WOOD_STEP { get; private set; }

    [Signature("field_42551")]
    public static SoundEvent BLOCK_CHERRY_SAPLING_BREAK { get; private set; }

    [Signature("field_42552")]
    public static SoundEvent BLOCK_CHERRY_SAPLING_FALL { get; private set; }

    [Signature("field_42553")]
    public static SoundEvent BLOCK_CHERRY_SAPLING_HIT { get; private set; }

    [Signature("field_42554")]
    public static SoundEvent BLOCK_CHERRY_SAPLING_PLACE { get; private set; }

    [Signature("field_42555")]
    public static SoundEvent BLOCK_CHERRY_SAPLING_STEP { get; private set; }

    [Signature("field_42556")]
    public static SoundEvent BLOCK_CHERRY_LEAVES_BREAK { get; private set; }

    [Signature("field_42557")]
    public static SoundEvent BLOCK_CHERRY_LEAVES_FALL { get; private set; }

    [Signature("field_42558")]
    public static SoundEvent BLOCK_CHERRY_LEAVES_HIT { get; private set; }

    [Signature("field_42559")]
    public static SoundEvent BLOCK_CHERRY_LEAVES_PLACE { get; private set; }

    [Signature("field_42560")]
    public static SoundEvent BLOCK_CHERRY_LEAVES_STEP { get; private set; }

    [Signature("field_42561")]
    public static SoundEvent BLOCK_CHERRY_WOOD_HANGING_SIGN_STEP { get; private set; }

    [Signature("field_42562")]
    public static SoundEvent BLOCK_CHERRY_WOOD_HANGING_SIGN_BREAK { get; private set; }

    [Signature("field_42563")]
    public static SoundEvent BLOCK_CHERRY_WOOD_HANGING_SIGN_FALL { get; private set; }

    [Signature("field_42564")]
    public static SoundEvent BLOCK_CHERRY_WOOD_HANGING_SIGN_HIT { get; private set; }

    [Signature("field_42565")]
    public static SoundEvent BLOCK_CHERRY_WOOD_HANGING_SIGN_PLACE { get; private set; }

    [Signature("field_42566")]
    public static SoundEvent BLOCK_CHERRY_WOOD_DOOR_CLOSE { get; private set; }

    [Signature("field_42567")]
    public static SoundEvent BLOCK_CHERRY_WOOD_DOOR_OPEN { get; private set; }

    [Signature("field_42568")]
    public static SoundEvent BLOCK_CHERRY_WOOD_TRAPDOOR_CLOSE { get; private set; }

    [Signature("field_42569")]
    public static SoundEvent BLOCK_CHERRY_WOOD_TRAPDOOR_OPEN { get; private set; }

    [Signature("field_42570")]
    public static SoundEvent BLOCK_CHERRY_WOOD_BUTTON_CLICK_OFF { get; private set; }

    [Signature("field_42571")]
    public static SoundEvent BLOCK_CHERRY_WOOD_BUTTON_CLICK_ON { get; private set; }

    [Signature("field_42572")]
    public static SoundEvent BLOCK_CHERRY_WOOD_PRESSURE_PLATE_CLICK_OFF { get; private set; }

    [Signature("field_42574")]
    public static SoundEvent BLOCK_CHERRY_WOOD_PRESSURE_PLATE_CLICK_ON { get; private set; }

    [Signature("field_42575")]
    public static SoundEvent BLOCK_CHERRY_WOOD_FENCE_GATE_CLOSE { get; private set; }

    [Signature("field_42576")]
    public static SoundEvent BLOCK_CHERRY_WOOD_FENCE_GATE_OPEN { get; private set; }

    [Signature("field_14823")]
    public static SoundEvent BLOCK_CHEST_CLOSE { get; private set; }

    [Signature("field_14731")]
    public static SoundEvent BLOCK_CHEST_LOCKED { get; private set; }

    [Signature("field_14982")]
    public static SoundEvent BLOCK_CHEST_OPEN { get; private set; }

    [Signature("field_14871")]
    public static SoundEvent ENTITY_CHICKEN_AMBIENT { get; private set; }

    [Signature("field_15140")]
    public static SoundEvent ENTITY_CHICKEN_DEATH { get; private set; }

    [Signature("field_15219")]
    public static SoundEvent ENTITY_CHICKEN_EGG { get; private set; }

    [Signature("field_14601")]
    public static SoundEvent ENTITY_CHICKEN_HURT { get; private set; }

    [Signature("field_14685")]
    public static SoundEvent ENTITY_CHICKEN_STEP { get; private set; }

    [Signature("field_40967")]
    public static SoundEvent BLOCK_CHISELED_BOOKSHELF_BREAK { get; private set; }

    [Signature("field_40968")]
    public static SoundEvent BLOCK_CHISELED_BOOKSHELF_FALL { get; private set; }

    [Signature("field_40969")]
    public static SoundEvent BLOCK_CHISELED_BOOKSHELF_HIT { get; private set; }

    [Signature("field_40970")]
    public static SoundEvent BLOCK_CHISELED_BOOKSHELF_INSERT { get; private set; }

    [Signature("field_40971")]
    public static SoundEvent BLOCK_CHISELED_BOOKSHELF_INSERT_ENCHANTED { get; private set; }

    [Signature("field_40972")]
    public static SoundEvent BLOCK_CHISELED_BOOKSHELF_STEP { get; private set; }

    [Signature("field_40973")]
    public static SoundEvent BLOCK_CHISELED_BOOKSHELF_PICKUP { get; private set; }

    [Signature("field_40974")]
    public static SoundEvent BLOCK_CHISELED_BOOKSHELF_PICKUP_ENCHANTED { get; private set; }

    [Signature("field_40975")]
    public static SoundEvent BLOCK_CHISELED_BOOKSHELF_PLACE { get; private set; }

    [Signature("field_14739")]
    public static SoundEvent BLOCK_CHORUS_FLOWER_DEATH { get; private set; }

    [Signature("field_14817")]
    public static SoundEvent BLOCK_CHORUS_FLOWER_GROW { get; private set; }

    [Signature("field_14890")]
    public static SoundEvent ITEM_CHORUS_FRUIT_TELEPORT { get; private set; }

    [Signature("field_15083")]
    public static SoundEvent ENTITY_COD_AMBIENT { get; private set; }

    [Signature("field_15003")]
    public static SoundEvent ENTITY_COD_DEATH { get; private set; }

    [Signature("field_14918")]
    public static SoundEvent ENTITY_COD_FLOP { get; private set; }

    [Signature("field_14851")]
    public static SoundEvent ENTITY_COD_HURT { get; private set; }

    [Signature("field_14762")]
    public static SoundEvent BLOCK_COMPARATOR_CLICK { get; private set; }

    [Signature("field_17606")]
    public static SoundEvent BLOCK_COMPOSTER_EMPTY { get; private set; }

    [Signature("field_17607")]
    public static SoundEvent BLOCK_COMPOSTER_FILL { get; private set; }

    [Signature("field_17608")]
    public static SoundEvent BLOCK_COMPOSTER_FILL_SUCCESS { get; private set; }

    [Signature("field_17609")]
    public static SoundEvent BLOCK_COMPOSTER_READY { get; private set; }

    [Signature("field_14700")]
    public static SoundEvent BLOCK_CONDUIT_ACTIVATE { get; private set; }

    [Signature("field_14632")]
    public static SoundEvent BLOCK_CONDUIT_AMBIENT { get; private set; }

    [Signature("field_15071")]
    public static SoundEvent BLOCK_CONDUIT_AMBIENT_SHORT { get; private set; }

    [Signature("field_15177")]
    public static SoundEvent BLOCK_CONDUIT_ATTACK_TARGET { get; private set; }

    [Signature("field_14979")]
    public static SoundEvent BLOCK_CONDUIT_DEACTIVATE { get; private set; }

    [Signature("field_46929")]
    public static SoundEvent BLOCK_COPPER_BULB_BREAK { get; private set; }

    [Signature("field_46930")]
    public static SoundEvent BLOCK_COPPER_BULB_STEP { get; private set; }

    [Signature("field_46931")]
    public static SoundEvent BLOCK_COPPER_BULB_PLACE { get; private set; }

    [Signature("field_46932")]
    public static SoundEvent BLOCK_COPPER_BULB_HIT { get; private set; }

    [Signature("field_46933")]
    public static SoundEvent BLOCK_COPPER_BULB_FALL { get; private set; }

    [Signature("field_46934")]
    public static SoundEvent BLOCK_COPPER_BULB_TURN_ON { get; private set; }

    [Signature("field_46935")]
    public static SoundEvent BLOCK_COPPER_BULB_TURN_OFF { get; private set; }

    [Signature("field_26960")]
    public static SoundEvent BLOCK_COPPER_BREAK { get; private set; }

    [Signature("field_26961")]
    public static SoundEvent BLOCK_COPPER_STEP { get; private set; }

    [Signature("field_26962")]
    public static SoundEvent BLOCK_COPPER_PLACE { get; private set; }

    [Signature("field_26963")]
    public static SoundEvent BLOCK_COPPER_HIT { get; private set; }

    [Signature("field_26964")]
    public static SoundEvent BLOCK_COPPER_FALL { get; private set; }

    [Signature("field_46936")]
    public static SoundEvent BLOCK_COPPER_DOOR_CLOSE { get; private set; }

    [Signature("field_46937")]
    public static SoundEvent BLOCK_COPPER_DOOR_OPEN { get; private set; }

    [Signature("field_46938")]
    public static SoundEvent BLOCK_COPPER_GRATE_BREAK { get; private set; }

    [Signature("field_46939")]
    public static SoundEvent BLOCK_COPPER_GRATE_STEP { get; private set; }

    [Signature("field_46940")]
    public static SoundEvent BLOCK_COPPER_GRATE_PLACE { get; private set; }

    [Signature("field_46941")]
    public static SoundEvent BLOCK_COPPER_GRATE_HIT { get; private set; }

    [Signature("field_46942")]
    public static SoundEvent BLOCK_COPPER_GRATE_FALL { get; private set; }

    [Signature("field_46943")]
    public static SoundEvent BLOCK_COPPER_TRAPDOOR_CLOSE { get; private set; }

    [Signature("field_46944")]
    public static SoundEvent BLOCK_COPPER_TRAPDOOR_OPEN { get; private set; }

    [Signature("field_14804")]
    public static SoundEvent BLOCK_CORAL_BLOCK_BREAK { get; private set; }

    [Signature("field_14551")]
    public static SoundEvent BLOCK_CORAL_BLOCK_FALL { get; private set; }

    [Signature("field_14672")]
    public static SoundEvent BLOCK_CORAL_BLOCK_HIT { get; private set; }

    [Signature("field_15087")]
    public static SoundEvent BLOCK_CORAL_BLOCK_PLACE { get; private set; }

    [Signature("field_14935")]
    public static SoundEvent BLOCK_CORAL_BLOCK_STEP { get; private set; }

    [Signature("field_14780")]
    public static SoundEvent ENTITY_COW_AMBIENT { get; private set; }

    [Signature("field_14857")]
    public static SoundEvent ENTITY_COW_DEATH { get; private set; }

    [Signature("field_14597")]
    public static SoundEvent ENTITY_COW_HURT { get; private set; }

    [Signature("field_14691")]
    public static SoundEvent ENTITY_COW_MILK { get; private set; }

    [Signature("field_15110")]
    public static SoundEvent ENTITY_COW_STEP { get; private set; }

    [Signature("field_46765")]
    public static SoundEvent BLOCK_CRAFTER_CRAFT { get; private set; }

    [Signature("field_46766")]
    public static SoundEvent BLOCK_CRAFTER_FAIL { get; private set; }

    [Signature("field_14907")]
    public static SoundEvent ENTITY_CREEPER_DEATH { get; private set; }

    [Signature("field_15192")]
    public static SoundEvent ENTITY_CREEPER_HURT { get; private set; }

    [Signature("field_15057")]
    public static SoundEvent ENTITY_CREEPER_PRIMED { get; private set; }

    [Signature("field_17610")]
    public static SoundEvent BLOCK_CROP_BREAK { get; private set; }

    [Signature("field_17611")]
    public static SoundEvent ITEM_CROP_PLANT { get; private set; }

    [Signature("field_14636")]
    public static SoundEvent ITEM_CROSSBOW_HIT { get; private set; }

    [Signature("field_14626")]
    public static SoundEvent ITEM_CROSSBOW_LOADING_END { get; private set; }

    [Signature("field_14860")]
    public static SoundEvent ITEM_CROSSBOW_LOADING_MIDDLE { get; private set; }

    [Signature("field_14765")]
    public static SoundEvent ITEM_CROSSBOW_LOADING_START { get; private set; }

    [Signature("field_15011")]
    public static SoundEvent ITEM_CROSSBOW_QUICK_CHARGE_1 { get; private set; }

    [Signature("field_14916")]
    public static SoundEvent ITEM_CROSSBOW_QUICK_CHARGE_2 { get; private set; }

    [Signature("field_15089")]
    public static SoundEvent ITEM_CROSSBOW_QUICK_CHARGE_3 { get; private set; }

    [Signature("field_15187")]
    public static SoundEvent ITEM_CROSSBOW_SHOOT { get; private set; }

    [Signature("field_42577")]
    public static SoundEvent BLOCK_DECORATED_POT_BREAK { get; private set; }

    [Signature("field_42578")]
    public static SoundEvent BLOCK_DECORATED_POT_FALL { get; private set; }

    [Signature("field_42579")]
    public static SoundEvent BLOCK_DECORATED_POT_HIT { get; private set; }

    [Signature("field_46649")]
    public static SoundEvent BLOCK_DECORATED_POT_INSERT { get; private set; }

    [Signature("field_46650")]
    public static SoundEvent BLOCK_DECORATED_POT_INSERT_FAIL { get; private set; }

    [Signature("field_42580")]
    public static SoundEvent BLOCK_DECORATED_POT_STEP { get; private set; }

    [Signature("field_42581")]
    public static SoundEvent BLOCK_DECORATED_POT_PLACE { get; private set; }

    [Signature("field_42582")]
    public static SoundEvent BLOCK_DECORATED_POT_SHATTER { get; private set; }

    [Signature("field_28968")]
    public static SoundEvent BLOCK_DEEPSLATE_BRICKS_BREAK { get; private set; }

    [Signature("field_28969")]
    public static SoundEvent BLOCK_DEEPSLATE_BRICKS_FALL { get; private set; }

    [Signature("field_28970")]
    public static SoundEvent BLOCK_DEEPSLATE_BRICKS_HIT { get; private set; }

    [Signature("field_28971")]
    public static SoundEvent BLOCK_DEEPSLATE_BRICKS_PLACE { get; private set; }

    [Signature("field_28972")]
    public static SoundEvent BLOCK_DEEPSLATE_BRICKS_STEP { get; private set; }

    [Signature("field_28973")]
    public static SoundEvent BLOCK_DEEPSLATE_BREAK { get; private set; }

    [Signature("field_28974")]
    public static SoundEvent BLOCK_DEEPSLATE_FALL { get; private set; }

    [Signature("field_28975")]
    public static SoundEvent BLOCK_DEEPSLATE_HIT { get; private set; }

    [Signature("field_28976")]
    public static SoundEvent BLOCK_DEEPSLATE_PLACE { get; private set; }

    [Signature("field_28977")]
    public static SoundEvent BLOCK_DEEPSLATE_STEP { get; private set; }

    [Signature("field_28978")]
    public static SoundEvent BLOCK_DEEPSLATE_TILES_BREAK { get; private set; }

    [Signature("field_28979")]
    public static SoundEvent BLOCK_DEEPSLATE_TILES_FALL { get; private set; }

    [Signature("field_28980")]
    public static SoundEvent BLOCK_DEEPSLATE_TILES_HIT { get; private set; }

    [Signature("field_28981")]
    public static SoundEvent BLOCK_DEEPSLATE_TILES_PLACE { get; private set; }

    [Signature("field_28982")]
    public static SoundEvent BLOCK_DEEPSLATE_TILES_STEP { get; private set; }

    [Signature("field_14611")]
    public static SoundEvent BLOCK_DISPENSER_DISPENSE { get; private set; }

    [Signature("field_14701")]
    public static SoundEvent BLOCK_DISPENSER_FAIL { get; private set; }

    [Signature("field_14711")]
    public static SoundEvent BLOCK_DISPENSER_LAUNCH { get; private set; }

    [Signature("field_14799")]
    public static SoundEvent ENTITY_DOLPHIN_AMBIENT { get; private set; }

    [Signature("field_14881")]
    public static SoundEvent ENTITY_DOLPHIN_AMBIENT_WATER { get; private set; }

    [Signature("field_14992")]
    public static SoundEvent ENTITY_DOLPHIN_ATTACK { get; private set; }

    [Signature("field_15101")]
    public static SoundEvent ENTITY_DOLPHIN_DEATH { get; private set; }

    [Signature("field_14590")]
    public static SoundEvent ENTITY_DOLPHIN_EAT { get; private set; }

    [Signature("field_15216")]
    public static SoundEvent ENTITY_DOLPHIN_HURT { get; private set; }

    [Signature("field_14707")]
    public static SoundEvent ENTITY_DOLPHIN_JUMP { get; private set; }

    [Signature("field_14972")]
    public static SoundEvent ENTITY_DOLPHIN_PLAY { get; private set; }

    [Signature("field_14887")]
    public static SoundEvent ENTITY_DOLPHIN_SPLASH { get; private set; }

    [Signature("field_15172")]
    public static SoundEvent ENTITY_DOLPHIN_SWIM { get; private set; }

    [Signature("field_15094")]
    public static SoundEvent ENTITY_DONKEY_AMBIENT { get; private set; }

    [Signature("field_14661")]
    public static SoundEvent ENTITY_DONKEY_ANGRY { get; private set; }

    [Signature("field_14598")]
    public static SoundEvent ENTITY_DONKEY_CHEST { get; private set; }

    [Signature("field_14827")]
    public static SoundEvent ENTITY_DONKEY_DEATH { get; private set; }

    [Signature("field_24629")]
    public static SoundEvent ENTITY_DONKEY_EAT { get; private set; }

    [Signature("field_14781")]
    public static SoundEvent ENTITY_DONKEY_HURT { get; private set; }

    [Signature("field_28038")]
    public static SoundEvent BLOCK_DRIPSTONE_BLOCK_BREAK { get; private set; }

    [Signature("field_28039")]
    public static SoundEvent BLOCK_DRIPSTONE_BLOCK_STEP { get; private set; }

    [Signature("field_28025")]
    public static SoundEvent BLOCK_DRIPSTONE_BLOCK_PLACE { get; private set; }

    [Signature("field_28026")]
    public static SoundEvent BLOCK_DRIPSTONE_BLOCK_HIT { get; private set; }

    [Signature("field_28027")]
    public static SoundEvent BLOCK_DRIPSTONE_BLOCK_FALL { get; private set; }

    [Signature("field_28028")]
    public static SoundEvent BLOCK_POINTED_DRIPSTONE_BREAK { get; private set; }

    [Signature("field_28029")]
    public static SoundEvent BLOCK_POINTED_DRIPSTONE_STEP { get; private set; }

    [Signature("field_28030")]
    public static SoundEvent BLOCK_POINTED_DRIPSTONE_PLACE { get; private set; }

    [Signature("field_28031")]
    public static SoundEvent BLOCK_POINTED_DRIPSTONE_HIT { get; private set; }

    [Signature("field_28032")]
    public static SoundEvent BLOCK_POINTED_DRIPSTONE_FALL { get; private set; }

    [Signature("field_28033")]
    public static SoundEvent BLOCK_POINTED_DRIPSTONE_LAND { get; private set; }

    [Signature("field_28034")]
    public static SoundEvent BLOCK_POINTED_DRIPSTONE_DRIP_LAVA { get; private set; }

    [Signature("field_28035")]
    public static SoundEvent BLOCK_POINTED_DRIPSTONE_DRIP_WATER { get; private set; }

    [Signature("field_28036")]
    public static SoundEvent BLOCK_POINTED_DRIPSTONE_DRIP_LAVA_INTO_CAULDRON { get; private set; }

    [Signature("field_28037")]
    public static SoundEvent BLOCK_POINTED_DRIPSTONE_DRIP_WATER_INTO_CAULDRON { get; private set; }

    [Signature("field_28579")]
    public static SoundEvent BLOCK_BIG_DRIPLEAF_TILT_DOWN { get; private set; }

    [Signature("field_28580")]
    public static SoundEvent BLOCK_BIG_DRIPLEAF_TILT_UP { get; private set; }

    [Signature("field_15030")]
    public static SoundEvent ENTITY_DROWNED_AMBIENT { get; private set; }

    [Signature("field_14980")]
    public static SoundEvent ENTITY_DROWNED_AMBIENT_WATER { get; private set; }

    [Signature("field_15066")]
    public static SoundEvent ENTITY_DROWNED_DEATH { get; private set; }

    [Signature("field_15162")]
    public static SoundEvent ENTITY_DROWNED_DEATH_WATER { get; private set; }

    [Signature("field_14571")]
    public static SoundEvent ENTITY_DROWNED_HURT { get; private set; }

    [Signature("field_14651")]
    public static SoundEvent ENTITY_DROWNED_HURT_WATER { get; private set; }

    [Signature("field_14753")]
    public static SoundEvent ENTITY_DROWNED_SHOOT { get; private set; }

    [Signature("field_14835")]
    public static SoundEvent ENTITY_DROWNED_STEP { get; private set; }

    [Signature("field_14913")]
    public static SoundEvent ENTITY_DROWNED_SWIM { get; private set; }

    [Signature("field_28391")]
    public static SoundEvent ITEM_DYE_USE { get; private set; }

    [Signature("field_15012")]
    public static SoundEvent ENTITY_EGG_THROW { get; private set; }

    [Signature("field_15127")]
    public static SoundEvent ENTITY_ELDER_GUARDIAN_AMBIENT { get; private set; }

    [Signature("field_14569")]
    public static SoundEvent ENTITY_ELDER_GUARDIAN_AMBIENT_LAND { get; private set; }

    [Signature("field_15203")]
    public static SoundEvent ENTITY_ELDER_GUARDIAN_CURSE { get; private set; }

    [Signature("field_15052")]
    public static SoundEvent ENTITY_ELDER_GUARDIAN_DEATH { get; private set; }

    [Signature("field_14973")]
    public static SoundEvent ENTITY_ELDER_GUARDIAN_DEATH_LAND { get; private set; }

    [Signature("field_14939")]
    public static SoundEvent ENTITY_ELDER_GUARDIAN_FLOP { get; private set; }

    [Signature("field_14868")]
    public static SoundEvent ENTITY_ELDER_GUARDIAN_HURT { get; private set; }

    [Signature("field_14652")]
    public static SoundEvent ENTITY_ELDER_GUARDIAN_HURT_LAND { get; private set; }

    [Signature("field_14572")]
    public static SoundEvent ITEM_ELYTRA_FLYING { get; private set; }

    [Signature("field_15119")]
    public static SoundEvent BLOCK_ENCHANTMENT_TABLE_USE { get; private set; }

    [Signature("field_15206")]
    public static SoundEvent BLOCK_ENDER_CHEST_CLOSE { get; private set; }

    [Signature("field_14952")]
    public static SoundEvent BLOCK_ENDER_CHEST_OPEN { get; private set; }

    [Signature("field_15024")]
    public static SoundEvent ENTITY_ENDER_DRAGON_AMBIENT { get; private set; }

    [Signature("field_14773")]
    public static SoundEvent ENTITY_ENDER_DRAGON_DEATH { get; private set; }

    [Signature("field_14803")]
    public static SoundEvent ENTITY_DRAGON_FIREBALL_EXPLODE { get; private set; }

    [Signature("field_14550")]
    public static SoundEvent ENTITY_ENDER_DRAGON_FLAP { get; private set; }

    [Signature("field_14671")]
    public static SoundEvent ENTITY_ENDER_DRAGON_GROWL { get; private set; }

    [Signature("field_15086")]
    public static SoundEvent ENTITY_ENDER_DRAGON_HURT { get; private set; }

    [Signature("field_14934")]
    public static SoundEvent ENTITY_ENDER_DRAGON_SHOOT { get; private set; }

    [Signature("field_15210")]
    public static SoundEvent ENTITY_ENDER_EYE_DEATH { get; private set; }

    [Signature("field_15155")]
    public static SoundEvent ENTITY_ENDER_EYE_LAUNCH { get; private set; }

    [Signature("field_14696")]
    public static SoundEvent ENTITY_ENDERMAN_AMBIENT { get; private set; }

    [Signature("field_14608")]
    public static SoundEvent ENTITY_ENDERMAN_DEATH { get; private set; }

    [Signature("field_14797")]
    public static SoundEvent ENTITY_ENDERMAN_HURT { get; private set; }

    [Signature("field_14713")]
    public static SoundEvent ENTITY_ENDERMAN_SCREAM { get; private set; }

    [Signature("field_14967")]
    public static SoundEvent ENTITY_ENDERMAN_STARE { get; private set; }

    [Signature("field_14879")]
    public static SoundEvent ENTITY_ENDERMAN_TELEPORT { get; private set; }

    [Signature("field_15137")]
    public static SoundEvent ENTITY_ENDERMITE_AMBIENT { get; private set; }

    [Signature("field_15230")]
    public static SoundEvent ENTITY_ENDERMITE_DEATH { get; private set; }

    [Signature("field_14582")]
    public static SoundEvent ENTITY_ENDERMITE_HURT { get; private set; }

    [Signature("field_14678")]
    public static SoundEvent ENTITY_ENDERMITE_STEP { get; private set; }

    [Signature("field_14757")]
    public static SoundEvent ENTITY_ENDER_PEARL_THROW { get; private set; }

    [Signature("field_14816")]
    public static SoundEvent BLOCK_END_GATEWAY_SPAWN { get; private set; }

    [Signature("field_19197")]
    public static SoundEvent BLOCK_END_PORTAL_FRAME_FILL { get; private set; }

    [Signature("field_14981")]
    public static SoundEvent BLOCK_END_PORTAL_SPAWN { get; private set; }

    [Signature("field_14782")]
    public static SoundEvent ENTITY_EVOKER_AMBIENT { get; private set; }

    [Signature("field_14858")]
    public static SoundEvent ENTITY_EVOKER_CAST_SPELL { get; private set; }

    [Signature("field_19147")]
    public static SoundEvent ENTITY_EVOKER_CELEBRATE { get; private set; }

    [Signature("field_14599")]
    public static SoundEvent ENTITY_EVOKER_DEATH { get; private set; }

    [Signature("field_14692")]
    public static SoundEvent ENTITY_EVOKER_FANGS_ATTACK { get; private set; }

    [Signature("field_15111")]
    public static SoundEvent ENTITY_EVOKER_HURT { get; private set; }

    [Signature("field_14908")]
    public static SoundEvent ENTITY_EVOKER_PREPARE_ATTACK { get; private set; }

    [Signature("field_15193")]
    public static SoundEvent ENTITY_EVOKER_PREPARE_SUMMON { get; private set; }

    [Signature("field_15058")]
    public static SoundEvent ENTITY_EVOKER_PREPARE_WOLOLO { get; private set; }

    [Signature("field_14637")]
    public static SoundEvent ENTITY_EXPERIENCE_BOTTLE_THROW { get; private set; }

    [Signature("field_14627")]
    public static SoundEvent ENTITY_EXPERIENCE_ORB_PICKUP { get; private set; }

    [Signature("field_14861")]
    public static SoundEvent BLOCK_FENCE_GATE_CLOSE { get; private set; }

    [Signature("field_14766")]
    public static SoundEvent BLOCK_FENCE_GATE_OPEN { get; private set; }

    [Signature("field_15013")]
    public static SoundEvent ITEM_FIRECHARGE_USE { get; private set; }

    [Signature("field_14917")]
    public static SoundEvent ENTITY_FIREWORK_ROCKET_BLAST { get; private set; }

    [Signature("field_15090")]
    public static SoundEvent ENTITY_FIREWORK_ROCKET_BLAST_FAR { get; private set; }

    [Signature("field_15188")]
    public static SoundEvent ENTITY_FIREWORK_ROCKET_LARGE_BLAST { get; private set; }

    [Signature("field_14612")]
    public static SoundEvent ENTITY_FIREWORK_ROCKET_LARGE_BLAST_FAR { get; private set; }

    [Signature("field_14702")]
    public static SoundEvent ENTITY_FIREWORK_ROCKET_LAUNCH { get; private set; }

    [Signature("field_14712")]
    public static SoundEvent ENTITY_FIREWORK_ROCKET_SHOOT { get; private set; }

    [Signature("field_14800")]
    public static SoundEvent ENTITY_FIREWORK_ROCKET_TWINKLE { get; private set; }

    [Signature("field_14882")]
    public static SoundEvent ENTITY_FIREWORK_ROCKET_TWINKLE_FAR { get; private set; }

    [Signature("field_14993")]
    public static SoundEvent BLOCK_FIRE_AMBIENT { get; private set; }

    [Signature("field_15102")]
    public static SoundEvent BLOCK_FIRE_EXTINGUISH { get; private set; }

    [Signature("field_14591")]
    public static SoundEvent ENTITY_FISH_SWIM { get; private set; }

    [Signature("field_15093")]
    public static SoundEvent ENTITY_FISHING_BOBBER_RETRIEVE { get; private set; }

    [Signature("field_14660")]
    public static SoundEvent ENTITY_FISHING_BOBBER_SPLASH { get; private set; }

    [Signature("field_14596")]
    public static SoundEvent ENTITY_FISHING_BOBBER_THROW { get; private set; }

    [Signature("field_15145")]
    public static SoundEvent ITEM_FLINTANDSTEEL_USE { get; private set; }

    [Signature("field_28581")]
    public static SoundEvent BLOCK_FLOWERING_AZALEA_BREAK { get; private set; }

    [Signature("field_28582")]
    public static SoundEvent BLOCK_FLOWERING_AZALEA_FALL { get; private set; }

    [Signature("field_28583")]
    public static SoundEvent BLOCK_FLOWERING_AZALEA_HIT { get; private set; }

    [Signature("field_28584")]
    public static SoundEvent BLOCK_FLOWERING_AZALEA_PLACE { get; private set; }

    [Signature("field_28585")]
    public static SoundEvent BLOCK_FLOWERING_AZALEA_STEP { get; private set; }

    [Signature("field_18055")]
    public static SoundEvent ENTITY_FOX_AGGRO { get; private set; }

    [Signature("field_18056")]
    public static SoundEvent ENTITY_FOX_AMBIENT { get; private set; }

    [Signature("field_18058")]
    public static SoundEvent ENTITY_FOX_BITE { get; private set; }

    [Signature("field_18059")]
    public static SoundEvent ENTITY_FOX_DEATH { get; private set; }

    [Signature("field_18060")]
    public static SoundEvent ENTITY_FOX_EAT { get; private set; }

    [Signature("field_18061")]
    public static SoundEvent ENTITY_FOX_HURT { get; private set; }

    [Signature("field_18265")]
    public static SoundEvent ENTITY_FOX_SCREECH { get; private set; }

    [Signature("field_18062")]
    public static SoundEvent ENTITY_FOX_SLEEP { get; private set; }

    [Signature("field_18063")]
    public static SoundEvent ENTITY_FOX_SNIFF { get; private set; }

    [Signature("field_18054")]
    public static SoundEvent ENTITY_FOX_SPIT { get; private set; }

    [Signature("field_24630")]
    public static SoundEvent ENTITY_FOX_TELEPORT { get; private set; }

    [Signature("field_42583")]
    public static SoundEvent BLOCK_SUSPICIOUS_SAND_BREAK { get; private set; }

    [Signature("field_42584")]
    public static SoundEvent BLOCK_SUSPICIOUS_SAND_STEP { get; private set; }

    [Signature("field_42585")]
    public static SoundEvent BLOCK_SUSPICIOUS_SAND_PLACE { get; private set; }

    [Signature("field_42586")]
    public static SoundEvent BLOCK_SUSPICIOUS_SAND_HIT { get; private set; }

    [Signature("field_42587")]
    public static SoundEvent BLOCK_SUSPICIOUS_SAND_FALL { get; private set; }

    [Signature("field_43160")]
    public static SoundEvent BLOCK_SUSPICIOUS_GRAVEL_BREAK { get; private set; }

    [Signature("field_43161")]
    public static SoundEvent BLOCK_SUSPICIOUS_GRAVEL_STEP { get; private set; }

    [Signature("field_43162")]
    public static SoundEvent BLOCK_SUSPICIOUS_GRAVEL_PLACE { get; private set; }

    [Signature("field_43163")]
    public static SoundEvent BLOCK_SUSPICIOUS_GRAVEL_HIT { get; private set; }

    [Signature("field_43164")]
    public static SoundEvent BLOCK_SUSPICIOUS_GRAVEL_FALL { get; private set; }

    [Signature("field_37302")]
    public static SoundEvent BLOCK_FROGLIGHT_BREAK { get; private set; }

    [Signature("field_37303")]
    public static SoundEvent BLOCK_FROGLIGHT_FALL { get; private set; }

    [Signature("field_37304")]
    public static SoundEvent BLOCK_FROGLIGHT_HIT { get; private set; }

    [Signature("field_37305")]
    public static SoundEvent BLOCK_FROGLIGHT_PLACE { get; private set; }

    [Signature("field_37306")]
    public static SoundEvent BLOCK_FROGLIGHT_STEP { get; private set; }

    [Signature("field_37307")]
    public static SoundEvent BLOCK_FROGSPAWN_STEP { get; private set; }

    [Signature("field_37308")]
    public static SoundEvent BLOCK_FROGSPAWN_BREAK { get; private set; }

    [Signature("field_37309")]
    public static SoundEvent BLOCK_FROGSPAWN_FALL { get; private set; }

    [Signature("field_37310")]
    public static SoundEvent BLOCK_FROGSPAWN_HATCH { get; private set; }

    [Signature("field_37311")]
    public static SoundEvent BLOCK_FROGSPAWN_HIT { get; private set; }

    [Signature("field_37312")]
    public static SoundEvent BLOCK_FROGSPAWN_PLACE { get; private set; }

    [Signature("field_37313")]
    public static SoundEvent ENTITY_FROG_AMBIENT { get; private set; }

    [Signature("field_37314")]
    public static SoundEvent ENTITY_FROG_DEATH { get; private set; }

    [Signature("field_37315")]
    public static SoundEvent ENTITY_FROG_EAT { get; private set; }

    [Signature("field_37316")]
    public static SoundEvent ENTITY_FROG_HURT { get; private set; }

    [Signature("field_37317")]
    public static SoundEvent ENTITY_FROG_LAY_SPAWN { get; private set; }

    [Signature("field_37318")]
    public static SoundEvent ENTITY_FROG_LONG_JUMP { get; private set; }

    [Signature("field_37319")]
    public static SoundEvent ENTITY_FROG_STEP { get; private set; }

    [Signature("field_37320")]
    public static SoundEvent ENTITY_FROG_TONGUE { get; private set; }

    [Signature("field_21877")]
    public static SoundEvent BLOCK_ROOTS_BREAK { get; private set; }

    [Signature("field_21878")]
    public static SoundEvent BLOCK_ROOTS_STEP { get; private set; }

    [Signature("field_21879")]
    public static SoundEvent BLOCK_ROOTS_PLACE { get; private set; }

    [Signature("field_21880")]
    public static SoundEvent BLOCK_ROOTS_HIT { get; private set; }

    [Signature("field_21881")]
    public static SoundEvent BLOCK_ROOTS_FALL { get; private set; }

    [Signature("field_15006")]
    public static SoundEvent BLOCK_FURNACE_FIRE_CRACKLE { get; private set; }

    [Signature("field_14928")]
    public static SoundEvent ENTITY_GENERIC_BIG_FALL { get; private set; }

    [Signature("field_14821")]
    public static SoundEvent ENTITY_GENERIC_BURN { get; private set; }

    [Signature("field_14732")]
    public static SoundEvent ENTITY_GENERIC_DEATH { get; private set; }

    [Signature("field_20613")]
    public static SoundEvent ENTITY_GENERIC_DRINK { get; private set; }

    [Signature("field_20614")]
    public static SoundEvent ENTITY_GENERIC_EAT { get; private set; }

    [Signature("field_15152")]
    public static SoundEvent ENTITY_GENERIC_EXPLODE { get; private set; }

    [Signature("field_15222")]
    public static SoundEvent ENTITY_GENERIC_EXTINGUISH_FIRE { get; private set; }

    [Signature("field_14940")]
    public static SoundEvent ENTITY_GENERIC_HURT { get; private set; }

    [Signature("field_15018")]
    public static SoundEvent ENTITY_GENERIC_SMALL_FALL { get; private set; }

    [Signature("field_14737")]
    public static SoundEvent ENTITY_GENERIC_SPLASH { get; private set; }

    [Signature("field_14818")]
    public static SoundEvent ENTITY_GENERIC_SWIM { get; private set; }

    [Signature("field_14566")]
    public static SoundEvent ENTITY_GHAST_AMBIENT { get; private set; }

    [Signature("field_14648")]
    public static SoundEvent ENTITY_GHAST_DEATH { get; private set; }

    [Signature("field_15054")]
    public static SoundEvent ENTITY_GHAST_HURT { get; private set; }

    [Signature("field_14958")]
    public static SoundEvent ENTITY_GHAST_SCREAM { get; private set; }

    [Signature("field_15231")]
    public static SoundEvent ENTITY_GHAST_SHOOT { get; private set; }

    [Signature("field_15130")]
    public static SoundEvent ENTITY_GHAST_WARN { get; private set; }

    [Signature("field_24066")]
    public static SoundEvent BLOCK_GILDED_BLACKSTONE_BREAK { get; private set; }

    [Signature("field_24067")]
    public static SoundEvent BLOCK_GILDED_BLACKSTONE_FALL { get; private set; }

    [Signature("field_24068")]
    public static SoundEvent BLOCK_GILDED_BLACKSTONE_HIT { get; private set; }

    [Signature("field_24069")]
    public static SoundEvent BLOCK_GILDED_BLACKSTONE_PLACE { get; private set; }

    [Signature("field_24070")]
    public static SoundEvent BLOCK_GILDED_BLACKSTONE_STEP { get; private set; }

    [Signature("field_15081")]
    public static SoundEvent BLOCK_GLASS_BREAK { get; private set; }

    [Signature("field_14666")]
    public static SoundEvent BLOCK_GLASS_FALL { get; private set; }

    [Signature("field_14583")]
    public static SoundEvent BLOCK_GLASS_HIT { get; private set; }

    [Signature("field_14843")]
    public static SoundEvent BLOCK_GLASS_PLACE { get; private set; }

    [Signature("field_14769")]
    public static SoundEvent BLOCK_GLASS_STEP { get; private set; }

    [Signature("field_28392")]
    public static SoundEvent ITEM_GLOW_INK_SAC_USE { get; private set; }

    [Signature("field_29188")]
    public static SoundEvent ENTITY_GLOW_ITEM_FRAME_ADD_ITEM { get; private set; }

    [Signature("field_29189")]
    public static SoundEvent ENTITY_GLOW_ITEM_FRAME_BREAK { get; private set; }

    [Signature("field_29190")]
    public static SoundEvent ENTITY_GLOW_ITEM_FRAME_PLACE { get; private set; }

    [Signature("field_29191")]
    public static SoundEvent ENTITY_GLOW_ITEM_FRAME_REMOVE_ITEM { get; private set; }

    [Signature("field_29192")]
    public static SoundEvent ENTITY_GLOW_ITEM_FRAME_ROTATE_ITEM { get; private set; }

    [Signature("field_28393")]
    public static SoundEvent ENTITY_GLOW_SQUID_AMBIENT { get; private set; }

    [Signature("field_28394")]
    public static SoundEvent ENTITY_GLOW_SQUID_DEATH { get; private set; }

    [Signature("field_28395")]
    public static SoundEvent ENTITY_GLOW_SQUID_HURT { get; private set; }

    [Signature("field_28396")]
    public static SoundEvent ENTITY_GLOW_SQUID_SQUIRT { get; private set; }

    [Signature("field_29809")]
    public static SoundEvent ENTITY_GOAT_AMBIENT { get; private set; }

    [Signature("field_29810")]
    public static SoundEvent ENTITY_GOAT_DEATH { get; private set; }

    [Signature("field_33437")]
    public static SoundEvent ENTITY_GOAT_EAT { get; private set; }

    [Signature("field_29811")]
    public static SoundEvent ENTITY_GOAT_HURT { get; private set; }

    [Signature("field_33438")]
    public static SoundEvent ENTITY_GOAT_LONG_JUMP { get; private set; }

    [Signature("field_29812")]
    public static SoundEvent ENTITY_GOAT_MILK { get; private set; }

    [Signature("field_29813")]
    public static SoundEvent ENTITY_GOAT_PREPARE_RAM { get; private set; }

    [Signature("field_33439")]
    public static SoundEvent ENTITY_GOAT_RAM_IMPACT { get; private set; }

    [Signature("field_39024")]
    public static SoundEvent ENTITY_GOAT_HORN_BREAK { get; private set; }

    [Signature("field_39025")]
    public static SoundEvent ITEM_GOAT_HORN_PLAY { get; private set; }

    [Signature("field_29814")]
    public static SoundEvent ENTITY_GOAT_SCREAMING_AMBIENT { get; private set; }

    [Signature("field_29815")]
    public static SoundEvent ENTITY_GOAT_SCREAMING_DEATH { get; private set; }

    [Signature("field_33440")]
    public static SoundEvent ENTITY_GOAT_SCREAMING_EAT { get; private set; }

    [Signature("field_29816")]
    public static SoundEvent ENTITY_GOAT_SCREAMING_HURT { get; private set; }

    [Signature("field_33434")]
    public static SoundEvent ENTITY_GOAT_SCREAMING_LONG_JUMP { get; private set; }

    [Signature("field_29817")]
    public static SoundEvent ENTITY_GOAT_SCREAMING_MILK { get; private set; }

    [Signature("field_33435")]
    public static SoundEvent ENTITY_GOAT_SCREAMING_PREPARE_RAM { get; private set; }

    [Signature("field_33436")]
    public static SoundEvent ENTITY_GOAT_SCREAMING_RAM_IMPACT { get; private set; }

    [Signature("field_39026")]
    public static SoundEvent ENTITY_GOAT_SCREAMING_HORN_BREAK { get; private set; }

    [Signature("field_29819")]
    public static SoundEvent ENTITY_GOAT_STEP { get; private set; }

    [Signature("field_15037")]
    public static SoundEvent BLOCK_GRASS_BREAK { get; private set; }

    [Signature("field_14965")]
    public static SoundEvent BLOCK_GRASS_FALL { get; private set; }

    [Signature("field_14720")]
    public static SoundEvent BLOCK_GRASS_HIT { get; private set; }

    [Signature("field_14653")]
    public static SoundEvent BLOCK_GRASS_PLACE { get; private set; }

    [Signature("field_14573")]
    public static SoundEvent BLOCK_GRASS_STEP { get; private set; }

    [Signature("field_15211")]
    public static SoundEvent BLOCK_GRAVEL_BREAK { get; private set; }

    [Signature("field_15156")]
    public static SoundEvent BLOCK_GRAVEL_FALL { get; private set; }

    [Signature("field_14697")]
    public static SoundEvent BLOCK_GRAVEL_HIT { get; private set; }

    [Signature("field_14609")]
    public static SoundEvent BLOCK_GRAVEL_PLACE { get; private set; }

    [Signature("field_14798")]
    public static SoundEvent BLOCK_GRAVEL_STEP { get; private set; }

    [Signature("field_16865")]
    public static SoundEvent BLOCK_GRINDSTONE_USE { get; private set; }

    [Signature("field_34896")]
    public static SoundEvent BLOCK_GROWING_PLANT_CROP { get; private set; }

    [Signature("field_14714")]
    public static SoundEvent ENTITY_GUARDIAN_AMBIENT { get; private set; }

    [Signature("field_14968")]
    public static SoundEvent ENTITY_GUARDIAN_AMBIENT_LAND { get; private set; }

    [Signature("field_14880")]
    public static SoundEvent ENTITY_GUARDIAN_ATTACK { get; private set; }

    [Signature("field_15138")]
    public static SoundEvent ENTITY_GUARDIAN_DEATH { get; private set; }

    [Signature("field_15232")]
    public static SoundEvent ENTITY_GUARDIAN_DEATH_LAND { get; private set; }

    [Signature("field_14584")]
    public static SoundEvent ENTITY_GUARDIAN_FLOP { get; private set; }

    [Signature("field_14679")]
    public static SoundEvent ENTITY_GUARDIAN_HURT { get; private set; }

    [Signature("field_14758")]
    public static SoundEvent ENTITY_GUARDIAN_HURT_LAND { get; private set; }

    [Signature("field_28586")]
    public static SoundEvent BLOCK_HANGING_ROOTS_BREAK { get; private set; }

    [Signature("field_28587")]
    public static SoundEvent BLOCK_HANGING_ROOTS_FALL { get; private set; }

    [Signature("field_28588")]
    public static SoundEvent BLOCK_HANGING_ROOTS_HIT { get; private set; }

    [Signature("field_28589")]
    public static SoundEvent BLOCK_HANGING_ROOTS_PLACE { get; private set; }

    [Signature("field_28590")]
    public static SoundEvent BLOCK_HANGING_ROOTS_STEP { get; private set; }

    [Signature("field_40083")]
    public static SoundEvent BLOCK_HANGING_SIGN_STEP { get; private set; }

    [Signature("field_40084")]
    public static SoundEvent BLOCK_HANGING_SIGN_BREAK { get; private set; }

    [Signature("field_40085")]
    public static SoundEvent BLOCK_HANGING_SIGN_FALL { get; private set; }

    [Signature("field_40086")]
    public static SoundEvent BLOCK_HANGING_SIGN_HIT { get; private set; }

    [Signature("field_40087")]
    public static SoundEvent BLOCK_HANGING_SIGN_PLACE { get; private set; }

    [Signature("field_40976")]
    public static SoundEvent BLOCK_NETHER_WOOD_HANGING_SIGN_STEP { get; private set; }

    [Signature("field_40977")]
    public static SoundEvent BLOCK_NETHER_WOOD_HANGING_SIGN_BREAK { get; private set; }

    [Signature("field_40978")]
    public static SoundEvent BLOCK_NETHER_WOOD_HANGING_SIGN_FALL { get; private set; }

    [Signature("field_40979")]
    public static SoundEvent BLOCK_NETHER_WOOD_HANGING_SIGN_HIT { get; private set; }

    [Signature("field_40980")]
    public static SoundEvent BLOCK_NETHER_WOOD_HANGING_SIGN_PLACE { get; private set; }

    [Signature("field_40981")]
    public static SoundEvent BLOCK_BAMBOO_WOOD_HANGING_SIGN_STEP { get; private set; }

    [Signature("field_40982")]
    public static SoundEvent BLOCK_BAMBOO_WOOD_HANGING_SIGN_BREAK { get; private set; }

    [Signature("field_40983")]
    public static SoundEvent BLOCK_BAMBOO_WOOD_HANGING_SIGN_FALL { get; private set; }

    [Signature("field_40984")]
    public static SoundEvent BLOCK_BAMBOO_WOOD_HANGING_SIGN_HIT { get; private set; }

    [Signature("field_40985")]
    public static SoundEvent BLOCK_BAMBOO_WOOD_HANGING_SIGN_PLACE { get; private set; }

    [Signature("field_47201")]
    public static SoundEvent BLOCK_TRIAL_SPAWNER_BREAK { get; private set; }

    [Signature("field_47202")]
    public static SoundEvent BLOCK_TRIAL_SPAWNER_STEP { get; private set; }

    [Signature("field_47203")]
    public static SoundEvent BLOCK_TRIAL_SPAWNER_PLACE { get; private set; }

    [Signature("field_47204")]
    public static SoundEvent BLOCK_TRIAL_SPAWNER_HIT { get; private set; }

    [Signature("field_47205")]
    public static SoundEvent BLOCK_TRIAL_SPAWNER_FALL { get; private set; }

    [Signature("field_47206")]
    public static SoundEvent BLOCK_TRIAL_SPAWNER_SPAWN_MOB { get; private set; }

    [Signature("field_47207")]
    public static SoundEvent BLOCK_TRIAL_SPAWNER_DETECT_PLAYER { get; private set; }

    [Signature("field_47208")]
    public static SoundEvent BLOCK_TRIAL_SPAWNER_AMBIENT { get; private set; }

    [Signature("field_47209")]
    public static SoundEvent BLOCK_TRIAL_SPAWNER_OPEN_SHUTTER { get; private set; }

    [Signature("field_47210")]
    public static SoundEvent BLOCK_TRIAL_SPAWNER_CLOSE_SHUTTER { get; private set; }

    [Signature("field_47211")]
    public static SoundEvent BLOCK_TRIAL_SPAWNER_EJECT_ITEM { get; private set; }

    [Signature("field_14846")]
    public static SoundEvent ITEM_HOE_TILL { get; private set; }

    [Signature("field_22256")]
    public static SoundEvent ENTITY_HOGLIN_AMBIENT { get; private set; }

    [Signature("field_22257")]
    public static SoundEvent ENTITY_HOGLIN_ANGRY { get; private set; }

    [Signature("field_22258")]
    public static SoundEvent ENTITY_HOGLIN_ATTACK { get; private set; }

    [Signature("field_23671")]
    public static SoundEvent ENTITY_HOGLIN_CONVERTED_TO_ZOMBIFIED { get; private set; }

    [Signature("field_22259")]
    public static SoundEvent ENTITY_HOGLIN_DEATH { get; private set; }

    [Signature("field_22260")]
    public static SoundEvent ENTITY_HOGLIN_HURT { get; private set; }

    [Signature("field_22261")]
    public static SoundEvent ENTITY_HOGLIN_RETREAT { get; private set; }

    [Signature("field_22262")]
    public static SoundEvent ENTITY_HOGLIN_STEP { get; private set; }

    [Signature("field_21070")]
    public static SoundEvent BLOCK_HONEY_BLOCK_BREAK { get; private set; }

    [Signature("field_21071")]
    public static SoundEvent BLOCK_HONEY_BLOCK_FALL { get; private set; }

    [Signature("field_21072")]
    public static SoundEvent BLOCK_HONEY_BLOCK_HIT { get; private set; }

    [Signature("field_21073")]
    public static SoundEvent BLOCK_HONEY_BLOCK_PLACE { get; private set; }

    [Signature("field_21074")]
    public static SoundEvent BLOCK_HONEY_BLOCK_SLIDE { get; private set; }

    [Signature("field_21075")]
    public static SoundEvent BLOCK_HONEY_BLOCK_STEP { get; private set; }

    [Signature("field_29543")]
    public static SoundEvent ITEM_HONEYCOMB_WAX_ON { get; private set; }

    [Signature("field_20615")]
    public static SoundEvent ITEM_HONEY_BOTTLE_DRINK { get; private set; }

    [Signature("field_39027")]
    public static int GOAT_HORN_SOUND_COUNT { get; private set; }

    // [Signature("field_39028")]
    // public static ImmutableList<RegistryEntry.Reference<SoundEvent>> GOAT_HORN_SOUNDS { get; private set; }

    [Signature("field_14947")]
    public static SoundEvent ENTITY_HORSE_AMBIENT { get; private set; }

    [Signature("field_15043")]
    public static SoundEvent ENTITY_HORSE_ANGRY { get; private set; }

    [Signature("field_15141")]
    public static SoundEvent ENTITY_HORSE_ARMOR { get; private set; }

    [Signature("field_14556")]
    public static SoundEvent ENTITY_HORSE_BREATHE { get; private set; }

    [Signature("field_15166")]
    public static SoundEvent ENTITY_HORSE_DEATH { get; private set; }

    [Signature("field_15099")]
    public static SoundEvent ENTITY_HORSE_EAT { get; private set; }

    [Signature("field_14987")]
    public static SoundEvent ENTITY_HORSE_GALLOP { get; private set; }

    [Signature("field_14923")]
    public static SoundEvent ENTITY_HORSE_HURT { get; private set; }

    [Signature("field_14831")]
    public static SoundEvent ENTITY_HORSE_JUMP { get; private set; }

    [Signature("field_14783")]
    public static SoundEvent ENTITY_HORSE_LAND { get; private set; }

    [Signature("field_14704")]
    public static SoundEvent ENTITY_HORSE_SADDLE { get; private set; }

    [Signature("field_14613")]
    public static SoundEvent ENTITY_HORSE_STEP { get; private set; }

    [Signature("field_15061")]
    public static SoundEvent ENTITY_HORSE_STEP_WOOD { get; private set; }

    [Signature("field_15157")]
    public static SoundEvent ENTITY_HOSTILE_BIG_FALL { get; private set; }

    [Signature("field_14899")]
    public static SoundEvent ENTITY_HOSTILE_DEATH { get; private set; }

    [Signature("field_14994")]
    public static SoundEvent ENTITY_HOSTILE_HURT { get; private set; }

    [Signature("field_14754")]
    public static SoundEvent ENTITY_HOSTILE_SMALL_FALL { get; private set; }

    [Signature("field_14836")]
    public static SoundEvent ENTITY_HOSTILE_SPLASH { get; private set; }

    [Signature("field_14630")]
    public static SoundEvent ENTITY_HOSTILE_SWIM { get; private set; }

    [Signature("field_14680")]
    public static SoundEvent ENTITY_HUSK_AMBIENT { get; private set; }

    [Signature("field_15128")]
    public static SoundEvent ENTITY_HUSK_CONVERTED_TO_ZOMBIE { get; private set; }

    [Signature("field_14892")]
    public static SoundEvent ENTITY_HUSK_DEATH { get; private set; }

    [Signature("field_15196")]
    public static SoundEvent ENTITY_HUSK_HURT { get; private set; }

    [Signature("field_15046")]
    public static SoundEvent ENTITY_HUSK_STEP { get; private set; }

    [Signature("field_14644")]
    public static SoundEvent ENTITY_ILLUSIONER_AMBIENT { get; private set; }

    [Signature("field_14545")]
    public static SoundEvent ENTITY_ILLUSIONER_CAST_SPELL { get; private set; }

    [Signature("field_15153")]
    public static SoundEvent ENTITY_ILLUSIONER_DEATH { get; private set; }

    [Signature("field_15223")]
    public static SoundEvent ENTITY_ILLUSIONER_HURT { get; private set; }

    [Signature("field_14941")]
    public static SoundEvent ENTITY_ILLUSIONER_MIRROR_MOVE { get; private set; }

    [Signature("field_15019")]
    public static SoundEvent ENTITY_ILLUSIONER_PREPARE_BLINDNESS { get; private set; }

    [Signature("field_14738")]
    public static SoundEvent ENTITY_ILLUSIONER_PREPARE_MIRROR { get; private set; }

    [Signature("field_28397")]
    public static SoundEvent ITEM_INK_SAC_USE { get; private set; }

    [Signature("field_14819")]
    public static SoundEvent BLOCK_IRON_DOOR_CLOSE { get; private set; }

    [Signature("field_14567")]
    public static SoundEvent BLOCK_IRON_DOOR_OPEN { get; private set; }

    [Signature("field_14649")]
    public static SoundEvent ENTITY_IRON_GOLEM_ATTACK { get; private set; }

    [Signature("field_21076")]
    public static SoundEvent ENTITY_IRON_GOLEM_DAMAGE { get; private set; }

    [Signature("field_15055")]
    public static SoundEvent ENTITY_IRON_GOLEM_DEATH { get; private set; }

    [Signature("field_14959")]
    public static SoundEvent ENTITY_IRON_GOLEM_HURT { get; private set; }

    [Signature("field_21077")]
    public static SoundEvent ENTITY_IRON_GOLEM_REPAIR { get; private set; }

    [Signature("field_15233")]
    public static SoundEvent ENTITY_IRON_GOLEM_STEP { get; private set; }

    [Signature("field_15131")]
    public static SoundEvent BLOCK_IRON_TRAPDOOR_CLOSE { get; private set; }

    [Signature("field_15082")]
    public static SoundEvent BLOCK_IRON_TRAPDOOR_OPEN { get; private set; }

    [Signature("field_14667")]
    public static SoundEvent ENTITY_ITEM_FRAME_ADD_ITEM { get; private set; }

    [Signature("field_14585")]
    public static SoundEvent ENTITY_ITEM_FRAME_BREAK { get; private set; }

    [Signature("field_14844")]
    public static SoundEvent ENTITY_ITEM_FRAME_PLACE { get; private set; }

    [Signature("field_14770")]
    public static SoundEvent ENTITY_ITEM_FRAME_REMOVE_ITEM { get; private set; }

    [Signature("field_15038")]
    public static SoundEvent ENTITY_ITEM_FRAME_ROTATE_ITEM { get; private set; }

    [Signature("field_15075")]
    public static SoundEvent ENTITY_ITEM_BREAK { get; private set; }

    [Signature("field_15197")]
    public static SoundEvent ENTITY_ITEM_PICKUP { get; private set; }

    [Signature("field_14546")]
    public static SoundEvent BLOCK_LADDER_BREAK { get; private set; }

    [Signature("field_14646")]
    public static SoundEvent BLOCK_LADDER_FALL { get; private set; }

    [Signature("field_14775")]
    public static SoundEvent BLOCK_LADDER_HIT { get; private set; }

    [Signature("field_14853")]
    public static SoundEvent BLOCK_LADDER_PLACE { get; private set; }

    [Signature("field_14948")]
    public static SoundEvent BLOCK_LADDER_STEP { get; private set; }

    [Signature("field_17745")]
    public static SoundEvent BLOCK_LANTERN_BREAK { get; private set; }

    [Signature("field_17746")]
    public static SoundEvent BLOCK_LANTERN_FALL { get; private set; }

    [Signature("field_17742")]
    public static SoundEvent BLOCK_LANTERN_HIT { get; private set; }

    [Signature("field_17743")]
    public static SoundEvent BLOCK_LANTERN_PLACE { get; private set; }

    [Signature("field_17744")]
    public static SoundEvent BLOCK_LANTERN_STEP { get; private set; }

    [Signature("field_26966")]
    public static SoundEvent BLOCK_LARGE_AMETHYST_BUD_BREAK { get; private set; }

    [Signature("field_26965")]
    public static SoundEvent BLOCK_LARGE_AMETHYST_BUD_PLACE { get; private set; }

    [Signature("field_15021")]
    public static SoundEvent BLOCK_LAVA_AMBIENT { get; private set; }

    [Signature("field_19198")]
    public static SoundEvent BLOCK_LAVA_EXTINGUISH { get; private set; }

    [Signature("field_14576")]
    public static SoundEvent BLOCK_LAVA_POP { get; private set; }

    [Signature("field_15184")]
    public static SoundEvent ENTITY_LEASH_KNOT_BREAK { get; private set; }

    [Signature("field_15062")]
    public static SoundEvent ENTITY_LEASH_KNOT_PLACE { get; private set; }

    [Signature("field_14962")]
    public static SoundEvent BLOCK_LEVER_CLICK { get; private set; }

    [Signature("field_14956")]
    public static SoundEvent ENTITY_LIGHTNING_BOLT_IMPACT { get; private set; }

    [Signature("field_14865")]
    public static SoundEvent ENTITY_LIGHTNING_BOLT_THUNDER { get; private set; }

    [Signature("field_14767")]
    public static SoundEvent ENTITY_LINGERING_POTION_THROW { get; private set; }

    [Signature("field_14682")]
    public static SoundEvent ENTITY_LLAMA_AMBIENT { get; private set; }

    [Signature("field_14586")]
    public static SoundEvent ENTITY_LLAMA_ANGRY { get; private set; }

    [Signature("field_15097")]
    public static SoundEvent ENTITY_LLAMA_CHEST { get; private set; }

    [Signature("field_15189")]
    public static SoundEvent ENTITY_LLAMA_DEATH { get; private set; }

    [Signature("field_14884")]
    public static SoundEvent ENTITY_LLAMA_EAT { get; private set; }

    [Signature("field_15031")]
    public static SoundEvent ENTITY_LLAMA_HURT { get; private set; }

    [Signature("field_14789")]
    public static SoundEvent ENTITY_LLAMA_SPIT { get; private set; }

    [Signature("field_14795")]
    public static SoundEvent ENTITY_LLAMA_STEP { get; private set; }

    [Signature("field_14554")]
    public static SoundEvent ENTITY_LLAMA_SWAG { get; private set; }

    [Signature("field_14889")]
    public static SoundEvent ENTITY_MAGMA_CUBE_DEATH_SMALL { get; private set; }

    [Signature("field_23194")]
    public static SoundEvent BLOCK_LODESTONE_BREAK { get; private set; }

    [Signature("field_23195")]
    public static SoundEvent BLOCK_LODESTONE_STEP { get; private set; }

    [Signature("field_23196")]
    public static SoundEvent BLOCK_LODESTONE_PLACE { get; private set; }

    [Signature("field_23197")]
    public static SoundEvent BLOCK_LODESTONE_HIT { get; private set; }

    [Signature("field_23198")]
    public static SoundEvent BLOCK_LODESTONE_FALL { get; private set; }

    [Signature("field_23199")]
    public static SoundEvent ITEM_LODESTONE_COMPASS_LOCK { get; private set; }

    [Signature("field_14662")]
    public static SoundEvent ENTITY_MAGMA_CUBE_DEATH { get; private set; }

    [Signature("field_14747")]
    public static SoundEvent ENTITY_MAGMA_CUBE_HURT { get; private set; }

    [Signature("field_15005")]
    public static SoundEvent ENTITY_MAGMA_CUBE_HURT_SMALL { get; private set; }

    [Signature("field_14847")]
    public static SoundEvent ENTITY_MAGMA_CUBE_JUMP { get; private set; }

    [Signature("field_14949")]
    public static SoundEvent ENTITY_MAGMA_CUBE_SQUISH { get; private set; }

    [Signature("field_14749")]
    public static SoundEvent ENTITY_MAGMA_CUBE_SQUISH_SMALL { get; private set; }

    [Signature("field_37321")]
    public static SoundEvent BLOCK_MANGROVE_ROOTS_BREAK { get; private set; }

    [Signature("field_37322")]
    public static SoundEvent BLOCK_MANGROVE_ROOTS_FALL { get; private set; }

    [Signature("field_37323")]
    public static SoundEvent BLOCK_MANGROVE_ROOTS_HIT { get; private set; }

    [Signature("field_37324")]
    public static SoundEvent BLOCK_MANGROVE_ROOTS_PLACE { get; private set; }

    [Signature("field_37325")]
    public static SoundEvent BLOCK_MANGROVE_ROOTS_STEP { get; private set; }

    [Signature("field_26967")]
    public static SoundEvent BLOCK_MEDIUM_AMETHYST_BUD_BREAK { get; private set; }

    [Signature("field_26968")]
    public static SoundEvent BLOCK_MEDIUM_AMETHYST_BUD_PLACE { get; private set; }

    [Signature("field_15044")]
    public static SoundEvent BLOCK_METAL_BREAK { get; private set; }

    [Signature("field_15142")]
    public static SoundEvent BLOCK_METAL_FALL { get; private set; }

    [Signature("field_14557")]
    public static SoundEvent BLOCK_METAL_HIT { get; private set; }

    [Signature("field_15167")]
    public static SoundEvent BLOCK_METAL_PLACE { get; private set; }

    [Signature("field_15100")]
    public static SoundEvent BLOCK_METAL_PRESSURE_PLATE_CLICK_OFF { get; private set; }

    [Signature("field_14988")]
    public static SoundEvent BLOCK_METAL_PRESSURE_PLATE_CLICK_ON { get; private set; }

    [Signature("field_14924")]
    public static SoundEvent BLOCK_METAL_STEP { get; private set; }

    [Signature("field_26969")]
    public static SoundEvent ENTITY_MINECART_INSIDE_UNDERWATER { get; private set; }

    [Signature("field_14832")]
    public static SoundEvent ENTITY_MINECART_INSIDE { get; private set; }

    [Signature("field_14784")]
    public static SoundEvent ENTITY_MINECART_RIDING { get; private set; }

    [Signature("field_18266")]
    public static SoundEvent ENTITY_MOOSHROOM_CONVERT { get; private set; }

    [Signature("field_18267")]
    public static SoundEvent ENTITY_MOOSHROOM_EAT { get; private set; }

    [Signature("field_18268")]
    public static SoundEvent ENTITY_MOOSHROOM_MILK { get; private set; }

    [Signature("field_18269")]
    public static SoundEvent ENTITY_MOOSHROOM_SUSPICIOUS_MILK { get; private set; }

    [Signature("field_14705")]
    public static SoundEvent ENTITY_MOOSHROOM_SHEAR { get; private set; }

    [Signature("field_28591")]
    public static SoundEvent BLOCK_MOSS_CARPET_BREAK { get; private set; }

    [Signature("field_28592")]
    public static SoundEvent BLOCK_MOSS_CARPET_FALL { get; private set; }

    [Signature("field_28593")]
    public static SoundEvent BLOCK_MOSS_CARPET_HIT { get; private set; }

    [Signature("field_28594")]
    public static SoundEvent BLOCK_MOSS_CARPET_PLACE { get; private set; }

    [Signature("field_28595")]
    public static SoundEvent BLOCK_MOSS_CARPET_STEP { get; private set; }

    [Signature("field_42588")]
    public static SoundEvent BLOCK_PINK_PETALS_BREAK { get; private set; }

    [Signature("field_42589")]
    public static SoundEvent BLOCK_PINK_PETALS_FALL { get; private set; }

    [Signature("field_42590")]
    public static SoundEvent BLOCK_PINK_PETALS_HIT { get; private set; }

    [Signature("field_42591")]
    public static SoundEvent BLOCK_PINK_PETALS_PLACE { get; private set; }

    [Signature("field_42592")]
    public static SoundEvent BLOCK_PINK_PETALS_STEP { get; private set; }

    [Signature("field_28596")]
    public static SoundEvent BLOCK_MOSS_BREAK { get; private set; }

    [Signature("field_28597")]
    public static SoundEvent BLOCK_MOSS_FALL { get; private set; }

    [Signature("field_28598")]
    public static SoundEvent BLOCK_MOSS_HIT { get; private set; }

    [Signature("field_28599")]
    public static SoundEvent BLOCK_MOSS_PLACE { get; private set; }

    [Signature("field_28600")]
    public static SoundEvent BLOCK_MOSS_STEP { get; private set; }

    [Signature("field_37329")]
    public static SoundEvent BLOCK_MUD_BREAK { get; private set; }

    [Signature("field_37330")]
    public static SoundEvent BLOCK_MUD_FALL { get; private set; }

    [Signature("field_37331")]
    public static SoundEvent BLOCK_MUD_HIT { get; private set; }

    [Signature("field_37332")]
    public static SoundEvent BLOCK_MUD_PLACE { get; private set; }

    [Signature("field_37333")]
    public static SoundEvent BLOCK_MUD_STEP { get; private set; }

    [Signature("field_37334")]
    public static SoundEvent BLOCK_MUD_BRICKS_BREAK { get; private set; }

    [Signature("field_37335")]
    public static SoundEvent BLOCK_MUD_BRICKS_FALL { get; private set; }

    [Signature("field_37336")]
    public static SoundEvent BLOCK_MUD_BRICKS_HIT { get; private set; }

    [Signature("field_37337")]
    public static SoundEvent BLOCK_MUD_BRICKS_PLACE { get; private set; }

    [Signature("field_37338")]
    public static SoundEvent BLOCK_MUD_BRICKS_STEP { get; private set; }

    [Signature("field_37339")]
    public static SoundEvent BLOCK_MUDDY_MANGROVE_ROOTS_BREAK { get; private set; }

    [Signature("field_37340")]
    public static SoundEvent BLOCK_MUDDY_MANGROVE_ROOTS_FALL { get; private set; }

    [Signature("field_37326")]
    public static SoundEvent BLOCK_MUDDY_MANGROVE_ROOTS_HIT { get; private set; }

    [Signature("field_37327")]
    public static SoundEvent BLOCK_MUDDY_MANGROVE_ROOTS_PLACE { get; private set; }

    [Signature("field_37328")]
    public static SoundEvent BLOCK_MUDDY_MANGROVE_ROOTS_STEP { get; private set; }

    [Signature("field_14614")]
    public static SoundEvent ENTITY_MULE_AMBIENT { get; private set; }

    [Signature("field_24631")]
    public static SoundEvent ENTITY_MULE_ANGRY { get; private set; }

    [Signature("field_15063")]
    public static SoundEvent ENTITY_MULE_CHEST { get; private set; }

    [Signature("field_15158")]
    public static SoundEvent ENTITY_MULE_DEATH { get; private set; }

    [Signature("field_24632")]
    public static SoundEvent ENTITY_MULE_EAT { get; private set; }

    [Signature("field_14900")]
    public static SoundEvent ENTITY_MULE_HURT { get; private set; }

    [Signature("field_14995")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_CREATIVE { get; private set; }

    [Signature("field_14755")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_CREDITS { get; private set; }

    [Signature("field_38924")]
    public static SoundEvent MUSIC_DISC_5 { get; private set; }

    [Signature("field_14654")]
    public static SoundEvent MUSIC_DISC_11 { get; private set; }

    [Signature("field_14592")]
    public static SoundEvent MUSIC_DISC_13 { get; private set; }

    [Signature("field_14829")]
    public static SoundEvent MUSIC_DISC_BLOCKS { get; private set; }

    [Signature("field_14744")]
    public static SoundEvent MUSIC_DISC_CAT { get; private set; }

    [Signature("field_15039")]
    public static SoundEvent MUSIC_DISC_CHIRP { get; private set; }

    [Signature("field_14944")]
    public static SoundEvent MUSIC_DISC_FAR { get; private set; }

    [Signature("field_15059")]
    public static SoundEvent MUSIC_DISC_MALL { get; private set; }

    [Signature("field_15169")]
    public static SoundEvent MUSIC_DISC_MELLOHI { get; private set; }

    [Signature("field_23968")]
    public static SoundEvent MUSIC_DISC_PIGSTEP { get; private set; }

    [Signature("field_14578")]
    public static SoundEvent MUSIC_DISC_STAL { get; private set; }

    [Signature("field_14656")]
    public static SoundEvent MUSIC_DISC_STRAD { get; private set; }

    [Signature("field_14759")]
    public static SoundEvent MUSIC_DISC_WAIT { get; private set; }

    [Signature("field_14838")]
    public static SoundEvent MUSIC_DISC_WARD { get; private set; }

    [Signature("field_35343")]
    public static SoundEvent MUSIC_DISC_OTHERSIDE { get; private set; }

    [Signature("field_44700")]
    public static SoundEvent MUSIC_DISC_RELIC { get; private set; }

    [Signature("field_14837")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_DRAGON { get; private set; }

    [Signature("field_14631")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_END { get; private set; }

    [Signature("field_14681")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_GAME { get; private set; }

    [Signature("field_15129")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_MENU { get; private set; }

    [Signature("field_23793")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_NETHER_BASALT_DELTAS { get; private set; }

    [Signature("field_23796")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_NETHER_CRIMSON_FOREST { get; private set; }

    [Signature("field_37345")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_OVERWORLD_DEEP_DARK { get; private set; }

    [Signature("field_35344")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_OVERWORLD_DRIPSTONE_CAVES { get; private set; }

    [Signature("field_35345")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_OVERWORLD_GROVE { get; private set; }

    [Signature("field_35346")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_OVERWORLD_JAGGED_PEAKS { get; private set; }

    [Signature("field_35347")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_OVERWORLD_LUSH_CAVES { get; private set; }

    [Signature("field_38925")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_OVERWORLD_SWAMP { get; private set; }

    [Signature("field_44693")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_OVERWORLD_FOREST { get; private set; }

    [Signature("field_38927")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_OVERWORLD_OLD_GROWTH_TAIGA { get; private set; }

    [Signature("field_35348")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_OVERWORLD_MEADOW { get; private set; }

    [Signature("field_42594")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_OVERWORLD_CHERRY_GROVE { get; private set; }

    [Signature("field_23794")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_NETHER_NETHER_WASTES { get; private set; }

    [Signature("field_35349")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_OVERWORLD_FROZEN_PEAKS { get; private set; }

    [Signature("field_35350")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_OVERWORLD_SNOWY_SLOPES { get; private set; }

    [Signature("field_23795")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_NETHER_SOUL_SAND_VALLEY { get; private set; }

    [Signature("field_35351")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_OVERWORLD_STONY_PEAKS { get; private set; }

    [Signature("field_23797")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_NETHER_WARPED_FOREST { get; private set; }

    [Signature("field_44694")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_OVERWORLD_FLOWER_FOREST { get; private set; }

    [Signature("field_44695")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_OVERWORLD_DESERT { get; private set; }

    [Signature("field_44696")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_OVERWORLD_BADLANDS { get; private set; }

    [Signature("field_44697")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_OVERWORLD_JUNGLE { get; private set; }

    [Signature("field_44698")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_OVERWORLD_SPARSE_JUNGLE { get; private set; }

    [Signature("field_44699")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_OVERWORLD_BAMBOO_JUNGLE { get; private set; }

    [Signature("field_15198")]
    public static RegistryEntry.Reference<SoundEvent> MUSIC_UNDER_WATER { get; private set; }

    [Signature("field_21882")]
    public static SoundEvent BLOCK_NETHER_BRICKS_BREAK { get; private set; }

    [Signature("field_21883")]
    public static SoundEvent BLOCK_NETHER_BRICKS_STEP { get; private set; }

    [Signature("field_21884")]
    public static SoundEvent BLOCK_NETHER_BRICKS_PLACE { get; private set; }

    [Signature("field_21885")]
    public static SoundEvent BLOCK_NETHER_BRICKS_HIT { get; private set; }

    [Signature("field_21886")]
    public static SoundEvent BLOCK_NETHER_BRICKS_FALL { get; private set; }

    [Signature("field_17612")]
    public static SoundEvent BLOCK_NETHER_WART_BREAK { get; private set; }

    [Signature("field_17613")]
    public static SoundEvent ITEM_NETHER_WART_PLANT { get; private set; }

    [Signature("field_40097")]
    public static SoundEvent BLOCK_NETHER_WOOD_BREAK { get; private set; }

    [Signature("field_40098")]
    public static SoundEvent BLOCK_NETHER_WOOD_FALL { get; private set; }

    [Signature("field_40099")]
    public static SoundEvent BLOCK_NETHER_WOOD_HIT { get; private set; }

    [Signature("field_40100")]
    public static SoundEvent BLOCK_NETHER_WOOD_PLACE { get; private set; }

    [Signature("field_40101")]
    public static SoundEvent BLOCK_NETHER_WOOD_STEP { get; private set; }

    [Signature("field_40102")]
    public static SoundEvent BLOCK_NETHER_WOOD_DOOR_CLOSE { get; private set; }

    [Signature("field_40088")]
    public static SoundEvent BLOCK_NETHER_WOOD_DOOR_OPEN { get; private set; }

    [Signature("field_40089")]
    public static SoundEvent BLOCK_NETHER_WOOD_TRAPDOOR_CLOSE { get; private set; }

    [Signature("field_40090")]
    public static SoundEvent BLOCK_NETHER_WOOD_TRAPDOOR_OPEN { get; private set; }

    [Signature("field_40091")]
    public static SoundEvent BLOCK_NETHER_WOOD_BUTTON_CLICK_OFF { get; private set; }

    [Signature("field_40092")]
    public static SoundEvent BLOCK_NETHER_WOOD_BUTTON_CLICK_ON { get; private set; }

    [Signature("field_40093")]
    public static SoundEvent BLOCK_NETHER_WOOD_PRESSURE_PLATE_CLICK_OFF { get; private set; }

    [Signature("field_40094")]
    public static SoundEvent BLOCK_NETHER_WOOD_PRESSURE_PLATE_CLICK_ON { get; private set; }

    [Signature("field_40095")]
    public static SoundEvent BLOCK_NETHER_WOOD_FENCE_GATE_CLOSE { get; private set; }

    [Signature("field_40096")]
    public static SoundEvent BLOCK_NETHER_WOOD_FENCE_GATE_OPEN { get; private set; }

    [Signature("field_42593")]
    public static SoundEvent INTENTIONALLY_EMPTY { get; private set; }

    [Signature("field_37346")]
    public static SoundEvent BLOCK_PACKED_MUD_BREAK { get; private set; }

    [Signature("field_37341")]
    public static SoundEvent BLOCK_PACKED_MUD_FALL { get; private set; }

    [Signature("field_37342")]
    public static SoundEvent BLOCK_PACKED_MUD_HIT { get; private set; }

    [Signature("field_37343")]
    public static SoundEvent BLOCK_PACKED_MUD_PLACE { get; private set; }

    [Signature("field_37344")]
    public static SoundEvent BLOCK_PACKED_MUD_STEP { get; private set; }

    [Signature("field_21887")]
    public static SoundEvent BLOCK_STEM_BREAK { get; private set; }

    [Signature("field_21888")]
    public static SoundEvent BLOCK_STEM_STEP { get; private set; }

    [Signature("field_21889")]
    public static SoundEvent BLOCK_STEM_PLACE { get; private set; }

    [Signature("field_21890")]
    public static SoundEvent BLOCK_STEM_HIT { get; private set; }

    [Signature("field_21892")]
    public static SoundEvent BLOCK_STEM_FALL { get; private set; }

    [Signature("field_21893")]
    public static SoundEvent BLOCK_NYLIUM_BREAK { get; private set; }

    [Signature("field_21894")]
    public static SoundEvent BLOCK_NYLIUM_STEP { get; private set; }

    [Signature("field_21895")]
    public static SoundEvent BLOCK_NYLIUM_PLACE { get; private set; }

    [Signature("field_21896")]
    public static SoundEvent BLOCK_NYLIUM_HIT { get; private set; }

    [Signature("field_21897")]
    public static SoundEvent BLOCK_NYLIUM_FALL { get; private set; }

    [Signature("field_21898")]
    public static SoundEvent BLOCK_NETHER_SPROUTS_BREAK { get; private set; }

    [Signature("field_21899")]
    public static SoundEvent BLOCK_NETHER_SPROUTS_STEP { get; private set; }

    [Signature("field_21900")]
    public static SoundEvent BLOCK_NETHER_SPROUTS_PLACE { get; private set; }

    [Signature("field_21901")]
    public static SoundEvent BLOCK_NETHER_SPROUTS_HIT { get; private set; }

    [Signature("field_21902")]
    public static SoundEvent BLOCK_NETHER_SPROUTS_FALL { get; private set; }

    [Signature("field_21903")]
    public static SoundEvent BLOCK_FUNGUS_BREAK { get; private set; }

    [Signature("field_21904")]
    public static SoundEvent BLOCK_FUNGUS_STEP { get; private set; }

    [Signature("field_21905")]
    public static SoundEvent BLOCK_FUNGUS_PLACE { get; private set; }

    [Signature("field_21907")]
    public static SoundEvent BLOCK_FUNGUS_HIT { get; private set; }

    [Signature("field_21908")]
    public static SoundEvent BLOCK_FUNGUS_FALL { get; private set; }

    [Signature("field_21909")]
    public static SoundEvent BLOCK_WEEPING_VINES_BREAK { get; private set; }

    [Signature("field_21910")]
    public static SoundEvent BLOCK_WEEPING_VINES_STEP { get; private set; }

    [Signature("field_21911")]
    public static SoundEvent BLOCK_WEEPING_VINES_PLACE { get; private set; }

    [Signature("field_21912")]
    public static SoundEvent BLOCK_WEEPING_VINES_HIT { get; private set; }

    [Signature("field_21913")]
    public static SoundEvent BLOCK_WEEPING_VINES_FALL { get; private set; }

    [Signature("field_21914")]
    public static SoundEvent BLOCK_WART_BLOCK_BREAK { get; private set; }

    [Signature("field_21915")]
    public static SoundEvent BLOCK_WART_BLOCK_STEP { get; private set; }

    [Signature("field_21916")]
    public static SoundEvent BLOCK_WART_BLOCK_PLACE { get; private set; }

    [Signature("field_21917")]
    public static SoundEvent BLOCK_WART_BLOCK_HIT { get; private set; }

    [Signature("field_21918")]
    public static SoundEvent BLOCK_WART_BLOCK_FALL { get; private set; }

    [Signature("field_21919")]
    public static SoundEvent BLOCK_NETHERITE_BLOCK_BREAK { get; private set; }

    [Signature("field_21920")]
    public static SoundEvent BLOCK_NETHERITE_BLOCK_STEP { get; private set; }

    [Signature("field_21921")]
    public static SoundEvent BLOCK_NETHERITE_BLOCK_PLACE { get; private set; }

    [Signature("field_21922")]
    public static SoundEvent BLOCK_NETHERITE_BLOCK_HIT { get; private set; }

    [Signature("field_21923")]
    public static SoundEvent BLOCK_NETHERITE_BLOCK_FALL { get; private set; }

    [Signature("field_21924")]
    public static SoundEvent BLOCK_NETHERRACK_BREAK { get; private set; }

    [Signature("field_21925")]
    public static SoundEvent BLOCK_NETHERRACK_STEP { get; private set; }

    [Signature("field_21926")]
    public static SoundEvent BLOCK_NETHERRACK_PLACE { get; private set; }

    [Signature("field_21927")]
    public static SoundEvent BLOCK_NETHERRACK_HIT { get; private set; }

    [Signature("field_21928")]
    public static SoundEvent BLOCK_NETHERRACK_FALL { get; private set; }

    [Signature("field_15047")]
    public static RegistryEntry.Reference<SoundEvent> BLOCK_NOTE_BLOCK_BASEDRUM { get; private set; }

    [Signature("field_14624")]
    public static RegistryEntry.Reference<SoundEvent> BLOCK_NOTE_BLOCK_BASS { get; private set; }

    [Signature("field_14793")]
    public static RegistryEntry.Reference<SoundEvent> BLOCK_NOTE_BLOCK_BELL { get; private set; }

    [Signature("field_14725")]
    public static RegistryEntry.Reference<SoundEvent> BLOCK_NOTE_BLOCK_CHIME { get; private set; }

    [Signature("field_14989")]
    public static RegistryEntry.Reference<SoundEvent> BLOCK_NOTE_BLOCK_FLUTE { get; private set; }

    [Signature("field_14903")]
    public static RegistryEntry.Reference<SoundEvent> BLOCK_NOTE_BLOCK_GUITAR { get; private set; }

    [Signature("field_15114")]
    public static RegistryEntry.Reference<SoundEvent> BLOCK_NOTE_BLOCK_HARP { get; private set; }

    [Signature("field_15204")]
    public static RegistryEntry.Reference<SoundEvent> BLOCK_NOTE_BLOCK_HAT { get; private set; }

    [Signature("field_14622")]
    public static RegistryEntry.Reference<SoundEvent> BLOCK_NOTE_BLOCK_PLING { get; private set; }

    [Signature("field_14708")]
    public static RegistryEntry.Reference<SoundEvent> BLOCK_NOTE_BLOCK_SNARE { get; private set; }

    [Signature("field_14776")]
    public static RegistryEntry.Reference<SoundEvent> BLOCK_NOTE_BLOCK_XYLOPHONE { get; private set; }

    [Signature("field_18308")]
    public static RegistryEntry.Reference<SoundEvent> BLOCK_NOTE_BLOCK_IRON_XYLOPHONE { get; private set; }

    [Signature("field_18309")]
    public static RegistryEntry.Reference<SoundEvent> BLOCK_NOTE_BLOCK_COW_BELL { get; private set; }

    [Signature("field_18310")]
    public static RegistryEntry.Reference<SoundEvent> BLOCK_NOTE_BLOCK_DIDGERIDOO { get; private set; }

    [Signature("field_18311")]
    public static RegistryEntry.Reference<SoundEvent> BLOCK_NOTE_BLOCK_BIT { get; private set; }

    [Signature("field_18312")]
    public static RegistryEntry.Reference<SoundEvent> BLOCK_NOTE_BLOCK_BANJO { get; private set; }

    [Signature("field_41700")]
    public static RegistryEntry.Reference<SoundEvent> BLOCK_NOTE_BLOCK_IMITATE_ZOMBIE { get; private set; }

    [Signature("field_41701")]
    public static RegistryEntry.Reference<SoundEvent> BLOCK_NOTE_BLOCK_IMITATE_SKELETON { get; private set; }

    [Signature("field_41702")]
    public static RegistryEntry.Reference<SoundEvent> BLOCK_NOTE_BLOCK_IMITATE_CREEPER { get; private set; }

    [Signature("field_41703")]
    public static RegistryEntry.Reference<SoundEvent> BLOCK_NOTE_BLOCK_IMITATE_ENDER_DRAGON { get; private set; }

    [Signature("field_41704")]
    public static RegistryEntry.Reference<SoundEvent> BLOCK_NOTE_BLOCK_IMITATE_WITHER_SKELETON { get; private set; }

    [Signature("field_41705")]
    public static RegistryEntry.Reference<SoundEvent> BLOCK_NOTE_BLOCK_IMITATE_PIGLIN { get; private set; }

    [Signature("field_16441")]
    public static SoundEvent ENTITY_OCELOT_HURT { get; private set; }

    [Signature("field_16437")]
    public static SoundEvent ENTITY_OCELOT_AMBIENT { get; private set; }

    [Signature("field_16442")]
    public static SoundEvent ENTITY_OCELOT_DEATH { get; private set; }

    [Signature("field_14809")]
    public static SoundEvent ENTITY_PAINTING_BREAK { get; private set; }

    [Signature("field_14875")]
    public static SoundEvent ENTITY_PAINTING_PLACE { get; private set; }

    [Signature("field_14997")]
    public static SoundEvent ENTITY_PANDA_PRE_SNEEZE { get; private set; }

    [Signature("field_15076")]
    public static SoundEvent ENTITY_PANDA_SNEEZE { get; private set; }

    [Signature("field_14604")]
    public static SoundEvent ENTITY_PANDA_AMBIENT { get; private set; }

    [Signature("field_15208")]
    public static SoundEvent ENTITY_PANDA_DEATH { get; private set; }

    [Signature("field_15106")]
    public static SoundEvent ENTITY_PANDA_EAT { get; private set; }

    [Signature("field_15035")]
    public static SoundEvent ENTITY_PANDA_STEP { get; private set; }

    [Signature("field_14936")]
    public static SoundEvent ENTITY_PANDA_CANT_BREED { get; private set; }

    [Signature("field_14801")]
    public static SoundEvent ENTITY_PANDA_AGGRESSIVE_AMBIENT { get; private set; }

    [Signature("field_14715")]
    public static SoundEvent ENTITY_PANDA_WORRIED_AMBIENT { get; private set; }

    [Signature("field_14668")]
    public static SoundEvent ENTITY_PANDA_HURT { get; private set; }

    [Signature("field_14552")]
    public static SoundEvent ENTITY_PANDA_BITE { get; private set; }

    [Signature("field_15132")]
    public static SoundEvent ENTITY_PARROT_AMBIENT { get; private set; }

    [Signature("field_15234")]
    public static SoundEvent ENTITY_PARROT_DEATH { get; private set; }

    [Signature("field_14960")]
    public static SoundEvent ENTITY_PARROT_EAT { get; private set; }

    [Signature("field_14925")]
    public static SoundEvent ENTITY_PARROT_FLY { get; private set; }

    [Signature("field_15077")]
    public static SoundEvent ENTITY_PARROT_HURT { get; private set; }

    [Signature("field_15199")]
    public static SoundEvent ENTITY_PARROT_IMITATE_BLAZE { get; private set; }

    [Signature("field_47212")]
    public static SoundEvent ENTITY_PARROT_IMITATE_BREEZE { get; private set; }

    [Signature("field_14547")]
    public static SoundEvent ENTITY_PARROT_IMITATE_CREEPER { get; private set; }

    [Signature("field_14647")]
    public static SoundEvent ENTITY_PARROT_IMITATE_DROWNED { get; private set; }

    [Signature("field_14777")]
    public static SoundEvent ENTITY_PARROT_IMITATE_ELDER_GUARDIAN { get; private set; }

    [Signature("field_14854")]
    public static SoundEvent ENTITY_PARROT_IMITATE_ENDER_DRAGON { get; private set; }

    [Signature("field_15022")]
    public static SoundEvent ENTITY_PARROT_IMITATE_ENDERMITE { get; private set; }

    [Signature("field_15113")]
    public static SoundEvent ENTITY_PARROT_IMITATE_EVOKER { get; private set; }

    [Signature("field_14577")]
    public static SoundEvent ENTITY_PARROT_IMITATE_GHAST { get; private set; }

    [Signature("field_18813")]
    public static SoundEvent ENTITY_PARROT_IMITATE_GUARDIAN { get; private set; }

    [Signature("field_24634")]
    public static SoundEvent ENTITY_PARROT_IMITATE_HOGLIN { get; private set; }

    [Signature("field_15185")]
    public static SoundEvent ENTITY_PARROT_IMITATE_HUSK { get; private set; }

    [Signature("field_15064")]
    public static SoundEvent ENTITY_PARROT_IMITATE_ILLUSIONER { get; private set; }

    [Signature("field_14963")]
    public static SoundEvent ENTITY_PARROT_IMITATE_MAGMA_CUBE { get; private set; }

    [Signature("field_14957")]
    public static SoundEvent ENTITY_PARROT_IMITATE_PHANTOM { get; private set; }

    [Signature("field_24635")]
    public static SoundEvent ENTITY_PARROT_IMITATE_PIGLIN { get; private set; }

    [Signature("field_25727")]
    public static SoundEvent ENTITY_PARROT_IMITATE_PIGLIN_BRUTE { get; private set; }

    [Signature("field_18815")]
    public static SoundEvent ENTITY_PARROT_IMITATE_PILLAGER { get; private set; }

    [Signature("field_18816")]
    public static SoundEvent ENTITY_PARROT_IMITATE_RAVAGER { get; private set; }

    [Signature("field_14768")]
    public static SoundEvent ENTITY_PARROT_IMITATE_SHULKER { get; private set; }

    [Signature("field_14683")]
    public static SoundEvent ENTITY_PARROT_IMITATE_SILVERFISH { get; private set; }

    [Signature("field_14587")]
    public static SoundEvent ENTITY_PARROT_IMITATE_SKELETON { get; private set; }

    [Signature("field_15098")]
    public static SoundEvent ENTITY_PARROT_IMITATE_SLIME { get; private set; }

    [Signature("field_15190")]
    public static SoundEvent ENTITY_PARROT_IMITATE_SPIDER { get; private set; }

    [Signature("field_14885")]
    public static SoundEvent ENTITY_PARROT_IMITATE_STRAY { get; private set; }

    [Signature("field_15032")]
    public static SoundEvent ENTITY_PARROT_IMITATE_VEX { get; private set; }

    [Signature("field_14790")]
    public static SoundEvent ENTITY_PARROT_IMITATE_VINDICATOR { get; private set; }

    [Signature("field_38059")]
    public static SoundEvent ENTITY_PARROT_IMITATE_WARDEN { get; private set; }

    [Signature("field_14796")]
    public static SoundEvent ENTITY_PARROT_IMITATE_WITCH { get; private set; }

    [Signature("field_14555")]
    public static SoundEvent ENTITY_PARROT_IMITATE_WITHER { get; private set; }

    [Signature("field_15073")]
    public static SoundEvent ENTITY_PARROT_IMITATE_WITHER_SKELETON { get; private set; }

    [Signature("field_24633")]
    public static SoundEvent ENTITY_PARROT_IMITATE_ZOGLIN { get; private set; }

    [Signature("field_15220")]
    public static SoundEvent ENTITY_PARROT_IMITATE_ZOMBIE { get; private set; }

    [Signature("field_14676")]
    public static SoundEvent ENTITY_PARROT_IMITATE_ZOMBIE_VILLAGER { get; private set; }

    [Signature("field_14602")]
    public static SoundEvent ENTITY_PARROT_STEP { get; private set; }

    [Signature("field_14813")]
    public static SoundEvent ENTITY_PHANTOM_AMBIENT { get; private set; }

    [Signature("field_14729")]
    public static SoundEvent ENTITY_PHANTOM_BITE { get; private set; }

    [Signature("field_14974")]
    public static SoundEvent ENTITY_PHANTOM_DEATH { get; private set; }

    [Signature("field_14869")]
    public static SoundEvent ENTITY_PHANTOM_FLAP { get; private set; }

    [Signature("field_15149")]
    public static SoundEvent ENTITY_PHANTOM_HURT { get; private set; }

    [Signature("field_15238")]
    public static SoundEvent ENTITY_PHANTOM_SWOOP { get; private set; }

    [Signature("field_14615")]
    public static SoundEvent ENTITY_PIG_AMBIENT { get; private set; }

    [Signature("field_14689")]
    public static SoundEvent ENTITY_PIG_DEATH { get; private set; }

    [Signature("field_14750")]
    public static SoundEvent ENTITY_PIG_HURT { get; private set; }

    [Signature("field_14824")]
    public static SoundEvent ENTITY_PIG_SADDLE { get; private set; }

    [Signature("field_14894")]
    public static SoundEvent ENTITY_PIG_STEP { get; private set; }

    [Signature("field_22263")]
    public static SoundEvent ENTITY_PIGLIN_ADMIRING_ITEM { get; private set; }

    [Signature("field_22264")]
    public static SoundEvent ENTITY_PIGLIN_AMBIENT { get; private set; }

    [Signature("field_22265")]
    public static SoundEvent ENTITY_PIGLIN_ANGRY { get; private set; }

    [Signature("field_22266")]
    public static SoundEvent ENTITY_PIGLIN_CELEBRATE { get; private set; }

    [Signature("field_22267")]
    public static SoundEvent ENTITY_PIGLIN_DEATH { get; private set; }

    [Signature("field_22268")]
    public static SoundEvent ENTITY_PIGLIN_JEALOUS { get; private set; }

    [Signature("field_22269")]
    public static SoundEvent ENTITY_PIGLIN_HURT { get; private set; }

    [Signature("field_22270")]
    public static SoundEvent ENTITY_PIGLIN_RETREAT { get; private set; }

    [Signature("field_22271")]
    public static SoundEvent ENTITY_PIGLIN_STEP { get; private set; }

    [Signature("field_22272")]
    public static SoundEvent ENTITY_PIGLIN_CONVERTED_TO_ZOMBIFIED { get; private set; }

    [Signature("field_25728")]
    public static SoundEvent ENTITY_PIGLIN_BRUTE_AMBIENT { get; private set; }

    [Signature("field_25729")]
    public static SoundEvent ENTITY_PIGLIN_BRUTE_ANGRY { get; private set; }

    [Signature("field_25730")]
    public static SoundEvent ENTITY_PIGLIN_BRUTE_DEATH { get; private set; }

    [Signature("field_25731")]
    public static SoundEvent ENTITY_PIGLIN_BRUTE_HURT { get; private set; }

    [Signature("field_25732")]
    public static SoundEvent ENTITY_PIGLIN_BRUTE_STEP { get; private set; }

    [Signature("field_25733")]
    public static SoundEvent ENTITY_PIGLIN_BRUTE_CONVERTED_TO_ZOMBIFIED { get; private set; }

    [Signature("field_14976")]
    public static SoundEvent ENTITY_PILLAGER_AMBIENT { get; private set; }

    [Signature("field_19150")]
    public static SoundEvent ENTITY_PILLAGER_CELEBRATE { get; private set; }

    [Signature("field_15049")]
    public static SoundEvent ENTITY_PILLAGER_DEATH { get; private set; }

    [Signature("field_15159")]
    public static SoundEvent ENTITY_PILLAGER_HURT { get; private set; }

    [Signature("field_15228")]
    public static SoundEvent BLOCK_PISTON_CONTRACT { get; private set; }

    [Signature("field_15134")]
    public static SoundEvent BLOCK_PISTON_EXTEND { get; private set; }

    [Signature("field_15016")]
    public static SoundEvent ENTITY_PLAYER_ATTACK_CRIT { get; private set; }

    [Signature("field_14999")]
    public static SoundEvent ENTITY_PLAYER_ATTACK_KNOCKBACK { get; private set; }

    [Signature("field_14914")]
    public static SoundEvent ENTITY_PLAYER_ATTACK_NODAMAGE { get; private set; }

    [Signature("field_14840")]
    public static SoundEvent ENTITY_PLAYER_ATTACK_STRONG { get; private set; }

    [Signature("field_14706")]
    public static SoundEvent ENTITY_PLAYER_ATTACK_SWEEP { get; private set; }

    [Signature("field_14625")]
    public static SoundEvent ENTITY_PLAYER_ATTACK_WEAK { get; private set; }

    [Signature("field_14794")]
    public static SoundEvent ENTITY_PLAYER_BIG_FALL { get; private set; }

    [Signature("field_14726")]
    public static SoundEvent ENTITY_PLAYER_BREATH { get; private set; }

    [Signature("field_19149")]
    public static SoundEvent ENTITY_PLAYER_BURP { get; private set; }

    [Signature("field_14904")]
    public static SoundEvent ENTITY_PLAYER_DEATH { get; private set; }

    [Signature("field_15115")]
    public static SoundEvent ENTITY_PLAYER_HURT { get; private set; }

    [Signature("field_15205")]
    public static SoundEvent ENTITY_PLAYER_HURT_DROWN { get; private set; }

    [Signature("field_27853")]
    public static SoundEvent ENTITY_PLAYER_HURT_FREEZE { get; private set; }

    [Signature("field_14623")]
    public static SoundEvent ENTITY_PLAYER_HURT_ON_FIRE { get; private set; }

    [Signature("field_17614")]
    public static SoundEvent ENTITY_PLAYER_HURT_SWEET_BERRY_BUSH { get; private set; }

    [Signature("field_14709")]
    public static SoundEvent ENTITY_PLAYER_LEVELUP { get; private set; }

    [Signature("field_14778")]
    public static SoundEvent ENTITY_PLAYER_SMALL_FALL { get; private set; }

    [Signature("field_14810")]
    public static SoundEvent ENTITY_PLAYER_SPLASH { get; private set; }

    [Signature("field_14876")]
    public static SoundEvent ENTITY_PLAYER_SPLASH_HIGH_SPEED { get; private set; }

    [Signature("field_14998")]
    public static SoundEvent ENTITY_PLAYER_SWIM { get; private set; }

    [Signature("field_46945")]
    public static SoundEvent ENTITY_PLAYER_TELEPORT { get; private set; }

    [Signature("field_15078")]
    public static SoundEvent ENTITY_POLAR_BEAR_AMBIENT { get; private set; }

    [Signature("field_14605")]
    public static SoundEvent ENTITY_POLAR_BEAR_AMBIENT_BABY { get; private set; }

    [Signature("field_15209")]
    public static SoundEvent ENTITY_POLAR_BEAR_DEATH { get; private set; }

    [Signature("field_15107")]
    public static SoundEvent ENTITY_POLAR_BEAR_HURT { get; private set; }

    [Signature("field_15036")]
    public static SoundEvent ENTITY_POLAR_BEAR_STEP { get; private set; }

    [Signature("field_14937")]
    public static SoundEvent ENTITY_POLAR_BEAR_WARNING { get; private set; }

    [Signature("field_28983")]
    public static SoundEvent BLOCK_POLISHED_DEEPSLATE_BREAK { get; private set; }

    [Signature("field_28984")]
    public static SoundEvent BLOCK_POLISHED_DEEPSLATE_FALL { get; private set; }

    [Signature("field_28985")]
    public static SoundEvent BLOCK_POLISHED_DEEPSLATE_HIT { get; private set; }

    [Signature("field_28986")]
    public static SoundEvent BLOCK_POLISHED_DEEPSLATE_PLACE { get; private set; }

    [Signature("field_28987")]
    public static SoundEvent BLOCK_POLISHED_DEEPSLATE_STEP { get; private set; }

    [Signature("field_14802")]
    public static SoundEvent BLOCK_PORTAL_AMBIENT { get; private set; }

    [Signature("field_14716")]
    public static SoundEvent BLOCK_PORTAL_TRAVEL { get; private set; }

    [Signature("field_14669")]
    public static SoundEvent BLOCK_PORTAL_TRIGGER { get; private set; }

    [Signature("field_27848")]
    public static SoundEvent BLOCK_POWDER_SNOW_BREAK { get; private set; }

    [Signature("field_27849")]
    public static SoundEvent BLOCK_POWDER_SNOW_FALL { get; private set; }

    [Signature("field_27850")]
    public static SoundEvent BLOCK_POWDER_SNOW_HIT { get; private set; }

    [Signature("field_27851")]
    public static SoundEvent BLOCK_POWDER_SNOW_PLACE { get; private set; }

    [Signature("field_27852")]
    public static SoundEvent BLOCK_POWDER_SNOW_STEP { get; private set; }

    [Signature("field_14553")]
    public static SoundEvent ENTITY_PUFFER_FISH_AMBIENT { get; private set; }

    [Signature("field_15133")]
    public static SoundEvent ENTITY_PUFFER_FISH_BLOW_OUT { get; private set; }

    [Signature("field_15235")]
    public static SoundEvent ENTITY_PUFFER_FISH_BLOW_UP { get; private set; }

    [Signature("field_14888")]
    public static SoundEvent ENTITY_PUFFER_FISH_DEATH { get; private set; }

    [Signature("field_15004")]
    public static SoundEvent ENTITY_PUFFER_FISH_FLOP { get; private set; }

    [Signature("field_14748")]
    public static SoundEvent ENTITY_PUFFER_FISH_HURT { get; private set; }

    [Signature("field_14848")]
    public static SoundEvent ENTITY_PUFFER_FISH_STING { get; private set; }

    [Signature("field_14619")]
    public static SoundEvent BLOCK_PUMPKIN_CARVE { get; private set; }

    [Signature("field_14693")]
    public static SoundEvent ENTITY_RABBIT_AMBIENT { get; private set; }

    [Signature("field_15147")]
    public static SoundEvent ENTITY_RABBIT_ATTACK { get; private set; }

    [Signature("field_14872")]
    public static SoundEvent ENTITY_RABBIT_DEATH { get; private set; }

    [Signature("field_15164")]
    public static SoundEvent ENTITY_RABBIT_HURT { get; private set; }

    [Signature("field_15091")]
    public static SoundEvent ENTITY_RABBIT_JUMP { get; private set; }

    [Signature("field_17266")]
    public static RegistryEntry.Reference<SoundEvent> EVENT_RAID_HORN { get; private set; }

    [Signature("field_14639")]
    public static SoundEvent ENTITY_RAVAGER_AMBIENT { get; private set; }

    [Signature("field_15240")]
    public static SoundEvent ENTITY_RAVAGER_ATTACK { get; private set; }

    [Signature("field_19148")]
    public static SoundEvent ENTITY_RAVAGER_CELEBRATE { get; private set; }

    [Signature("field_15146")]
    public static SoundEvent ENTITY_RAVAGER_DEATH { get; private set; }

    [Signature("field_15007")]
    public static SoundEvent ENTITY_RAVAGER_HURT { get; private set; }

    [Signature("field_14929")]
    public static SoundEvent ENTITY_RAVAGER_STEP { get; private set; }

    [Signature("field_14822")]
    public static SoundEvent ENTITY_RAVAGER_STUNNED { get; private set; }

    [Signature("field_14733")]
    public static SoundEvent ENTITY_RAVAGER_ROAR { get; private set; }

    [Signature("field_24071")]
    public static SoundEvent BLOCK_NETHER_GOLD_ORE_BREAK { get; private set; }

    [Signature("field_24072")]
    public static SoundEvent BLOCK_NETHER_GOLD_ORE_FALL { get; private set; }

    [Signature("field_24073")]
    public static SoundEvent BLOCK_NETHER_GOLD_ORE_HIT { get; private set; }

    [Signature("field_24074")]
    public static SoundEvent BLOCK_NETHER_GOLD_ORE_PLACE { get; private set; }

    [Signature("field_24075")]
    public static SoundEvent BLOCK_NETHER_GOLD_ORE_STEP { get; private set; }

    [Signature("field_21937")]
    public static SoundEvent BLOCK_NETHER_ORE_BREAK { get; private set; }

    [Signature("field_21938")]
    public static SoundEvent BLOCK_NETHER_ORE_FALL { get; private set; }

    [Signature("field_21939")]
    public static SoundEvent BLOCK_NETHER_ORE_HIT { get; private set; }

    [Signature("field_21940")]
    public static SoundEvent BLOCK_NETHER_ORE_PLACE { get; private set; }

    [Signature("field_21941")]
    public static SoundEvent BLOCK_NETHER_ORE_STEP { get; private set; }

    [Signature("field_19199")]
    public static SoundEvent BLOCK_REDSTONE_TORCH_BURNOUT { get; private set; }

    [Signature("field_23115")]
    public static SoundEvent BLOCK_RESPAWN_ANCHOR_AMBIENT { get; private set; }

    [Signature("field_23116")]
    public static SoundEvent BLOCK_RESPAWN_ANCHOR_CHARGE { get; private set; }

    [Signature("field_23117")]
    public static RegistryEntry.Reference<SoundEvent> BLOCK_RESPAWN_ANCHOR_DEPLETE { get; private set; }

    [Signature("field_23118")]
    public static SoundEvent BLOCK_RESPAWN_ANCHOR_SET_SPAWN { get; private set; }

    [Signature("field_28601")]
    public static SoundEvent BLOCK_ROOTED_DIRT_BREAK { get; private set; }

    [Signature("field_28602")]
    public static SoundEvent BLOCK_ROOTED_DIRT_FALL { get; private set; }

    [Signature("field_28603")]
    public static SoundEvent BLOCK_ROOTED_DIRT_HIT { get; private set; }

    [Signature("field_28604")]
    public static SoundEvent BLOCK_ROOTED_DIRT_PLACE { get; private set; }

    [Signature("field_28605")]
    public static SoundEvent BLOCK_ROOTED_DIRT_STEP { get; private set; }

    [Signature("field_15033")]
    public static SoundEvent ENTITY_SALMON_AMBIENT { get; private set; }

    [Signature("field_15123")]
    public static SoundEvent ENTITY_SALMON_DEATH { get; private set; }

    [Signature("field_14563")]
    public static SoundEvent ENTITY_SALMON_FLOP { get; private set; }

    [Signature("field_14638")]
    public static SoundEvent ENTITY_SALMON_HURT { get; private set; }

    [Signature("field_15074")]
    public static SoundEvent BLOCK_SAND_BREAK { get; private set; }

    [Signature("field_14943")]
    public static SoundEvent BLOCK_SAND_FALL { get; private set; }

    [Signature("field_15221")]
    public static SoundEvent BLOCK_SAND_HIT { get; private set; }

    [Signature("field_15144")]
    public static SoundEvent BLOCK_SAND_PLACE { get; private set; }

    [Signature("field_14677")]
    public static SoundEvent BLOCK_SAND_STEP { get; private set; }

    [Signature("field_16509")]
    public static SoundEvent BLOCK_SCAFFOLDING_BREAK { get; private set; }

    [Signature("field_16510")]
    public static SoundEvent BLOCK_SCAFFOLDING_FALL { get; private set; }

    [Signature("field_16506")]
    public static SoundEvent BLOCK_SCAFFOLDING_HIT { get; private set; }

    [Signature("field_16507")]
    public static SoundEvent BLOCK_SCAFFOLDING_PLACE { get; private set; }

    [Signature("field_16508")]
    public static SoundEvent BLOCK_SCAFFOLDING_STEP { get; private set; }

    [Signature("field_37357")]
    public static SoundEvent BLOCK_SCULK_SPREAD { get; private set; }

    [Signature("field_37358")]
    public static SoundEvent BLOCK_SCULK_CHARGE { get; private set; }

    [Signature("field_37359")]
    public static SoundEvent BLOCK_SCULK_BREAK { get; private set; }

    [Signature("field_37360")]
    public static SoundEvent BLOCK_SCULK_FALL { get; private set; }

    [Signature("field_37361")]
    public static SoundEvent BLOCK_SCULK_HIT { get; private set; }

    [Signature("field_37362")]
    public static SoundEvent BLOCK_SCULK_PLACE { get; private set; }

    [Signature("field_37363")]
    public static SoundEvent BLOCK_SCULK_STEP { get; private set; }

    [Signature("field_37364")]
    public static SoundEvent BLOCK_SCULK_CATALYST_BLOOM { get; private set; }

    [Signature("field_37365")]
    public static SoundEvent BLOCK_SCULK_CATALYST_BREAK { get; private set; }

    [Signature("field_37366")]
    public static SoundEvent BLOCK_SCULK_CATALYST_FALL { get; private set; }

    [Signature("field_37367")]
    public static SoundEvent BLOCK_SCULK_CATALYST_HIT { get; private set; }

    [Signature("field_37368")]
    public static SoundEvent BLOCK_SCULK_CATALYST_PLACE { get; private set; }

    [Signature("field_37369")]
    public static SoundEvent BLOCK_SCULK_CATALYST_STEP { get; private set; }

    [Signature("field_28081")]
    public static SoundEvent BLOCK_SCULK_SENSOR_CLICKING { get; private set; }

    [Signature("field_28082")]
    public static SoundEvent BLOCK_SCULK_SENSOR_CLICKING_STOP { get; private set; }

    [Signature("field_28083")]
    public static SoundEvent BLOCK_SCULK_SENSOR_BREAK { get; private set; }

    [Signature("field_28084")]
    public static SoundEvent BLOCK_SCULK_SENSOR_FALL { get; private set; }

    [Signature("field_28085")]
    public static SoundEvent BLOCK_SCULK_SENSOR_HIT { get; private set; }

    [Signature("field_28086")]
    public static SoundEvent BLOCK_SCULK_SENSOR_PLACE { get; private set; }

    [Signature("field_28087")]
    public static SoundEvent BLOCK_SCULK_SENSOR_STEP { get; private set; }

    [Signature("field_37347")]
    public static SoundEvent BLOCK_SCULK_SHRIEKER_BREAK { get; private set; }

    [Signature("field_37348")]
    public static SoundEvent BLOCK_SCULK_SHRIEKER_FALL { get; private set; }

    [Signature("field_37349")]
    public static SoundEvent BLOCK_SCULK_SHRIEKER_HIT { get; private set; }

    [Signature("field_37350")]
    public static SoundEvent BLOCK_SCULK_SHRIEKER_PLACE { get; private set; }

    [Signature("field_38060")]
    public static SoundEvent BLOCK_SCULK_SHRIEKER_SHRIEK { get; private set; }

    [Signature("field_37351")]
    public static SoundEvent BLOCK_SCULK_SHRIEKER_STEP { get; private set; }

    [Signature("field_37352")]
    public static SoundEvent BLOCK_SCULK_VEIN_BREAK { get; private set; }

    [Signature("field_37353")]
    public static SoundEvent BLOCK_SCULK_VEIN_FALL { get; private set; }

    [Signature("field_37354")]
    public static SoundEvent BLOCK_SCULK_VEIN_HIT { get; private set; }

    [Signature("field_37355")]
    public static SoundEvent BLOCK_SCULK_VEIN_PLACE { get; private set; }

    [Signature("field_37356")]
    public static SoundEvent BLOCK_SCULK_VEIN_STEP { get; private set; }

    [Signature("field_14603")]
    public static SoundEvent ENTITY_SHEEP_AMBIENT { get; private set; }

    [Signature("field_14814")]
    public static SoundEvent ENTITY_SHEEP_DEATH { get; private set; }

    [Signature("field_14730")]
    public static SoundEvent ENTITY_SHEEP_HURT { get; private set; }

    [Signature("field_14975")]
    public static SoundEvent ENTITY_SHEEP_SHEAR { get; private set; }

    [Signature("field_14870")]
    public static SoundEvent ENTITY_SHEEP_STEP { get; private set; }

    [Signature("field_15150")]
    public static SoundEvent ITEM_SHIELD_BLOCK { get; private set; }

    [Signature("field_15239")]
    public static SoundEvent ITEM_SHIELD_BREAK { get; private set; }

    [Signature("field_21931")]
    public static SoundEvent BLOCK_SHROOMLIGHT_BREAK { get; private set; }

    [Signature("field_21932")]
    public static SoundEvent BLOCK_SHROOMLIGHT_STEP { get; private set; }

    [Signature("field_21933")]
    public static SoundEvent BLOCK_SHROOMLIGHT_PLACE { get; private set; }

    [Signature("field_21934")]
    public static SoundEvent BLOCK_SHROOMLIGHT_HIT { get; private set; }

    [Signature("field_21935")]
    public static SoundEvent BLOCK_SHROOMLIGHT_FALL { get; private set; }

    [Signature("field_14616")]
    public static SoundEvent ITEM_SHOVEL_FLATTEN { get; private set; }

    [Signature("field_14690")]
    public static SoundEvent ENTITY_SHULKER_AMBIENT { get; private set; }

    [Signature("field_14751")]
    public static SoundEvent BLOCK_SHULKER_BOX_CLOSE { get; private set; }

    [Signature("field_14825")]
    public static SoundEvent BLOCK_SHULKER_BOX_OPEN { get; private set; }

    [Signature("field_14895")]
    public static SoundEvent ENTITY_SHULKER_BULLET_HIT { get; private set; }

    [Signature("field_14977")]
    public static SoundEvent ENTITY_SHULKER_BULLET_HURT { get; private set; }

    [Signature("field_15050")]
    public static SoundEvent ENTITY_SHULKER_CLOSE { get; private set; }

    [Signature("field_15160")]
    public static SoundEvent ENTITY_SHULKER_DEATH { get; private set; }

    [Signature("field_15229")]
    public static SoundEvent ENTITY_SHULKER_HURT { get; private set; }

    [Signature("field_15135")]
    public static SoundEvent ENTITY_SHULKER_HURT_CLOSED { get; private set; }

    [Signature("field_15017")]
    public static SoundEvent ENTITY_SHULKER_OPEN { get; private set; }

    [Signature("field_15000")]
    public static SoundEvent ENTITY_SHULKER_SHOOT { get; private set; }

    [Signature("field_14915")]
    public static SoundEvent ENTITY_SHULKER_TELEPORT { get; private set; }

    [Signature("field_14786")]
    public static SoundEvent ENTITY_SILVERFISH_AMBIENT { get; private set; }

    [Signature("field_14673")]
    public static SoundEvent ENTITY_SILVERFISH_DEATH { get; private set; }

    [Signature("field_14593")]
    public static SoundEvent ENTITY_SILVERFISH_HURT { get; private set; }

    [Signature("field_15084")]
    public static SoundEvent ENTITY_SILVERFISH_STEP { get; private set; }

    [Signature("field_15200")]
    public static SoundEvent ENTITY_SKELETON_AMBIENT { get; private set; }

    [Signature("field_28606")]
    public static SoundEvent ENTITY_SKELETON_CONVERTED_TO_STRAY { get; private set; }

    [Signature("field_14877")]
    public static SoundEvent ENTITY_SKELETON_DEATH { get; private set; }

    [Signature("field_14984")]
    public static SoundEvent ENTITY_SKELETON_HORSE_AMBIENT { get; private set; }

    [Signature("field_14721")]
    public static SoundEvent ENTITY_SKELETON_HORSE_DEATH { get; private set; }

    [Signature("field_14855")]
    public static SoundEvent ENTITY_SKELETON_HORSE_HURT { get; private set; }

    [Signature("field_14617")]
    public static SoundEvent ENTITY_SKELETON_HORSE_SWIM { get; private set; }

    [Signature("field_14686")]
    public static SoundEvent ENTITY_SKELETON_HORSE_AMBIENT_WATER { get; private set; }

    [Signature("field_15108")]
    public static SoundEvent ENTITY_SKELETON_HORSE_GALLOP_WATER { get; private set; }

    [Signature("field_14901")]
    public static SoundEvent ENTITY_SKELETON_HORSE_JUMP_WATER { get; private set; }

    [Signature("field_15182")]
    public static SoundEvent ENTITY_SKELETON_HORSE_STEP_WATER { get; private set; }

    [Signature("field_15069")]
    public static SoundEvent ENTITY_SKELETON_HURT { get; private set; }

    [Signature("field_14633")]
    public static SoundEvent ENTITY_SKELETON_SHOOT { get; private set; }

    [Signature("field_14548")]
    public static SoundEvent ENTITY_SKELETON_STEP { get; private set; }

    [Signature("field_14863")]
    public static SoundEvent ENTITY_SLIME_ATTACK { get; private set; }

    [Signature("field_14763")]
    public static SoundEvent ENTITY_SLIME_DEATH { get; private set; }

    [Signature("field_15014")]
    public static SoundEvent ENTITY_SLIME_HURT { get; private set; }

    [Signature("field_14919")]
    public static SoundEvent ENTITY_SLIME_JUMP { get; private set; }

    [Signature("field_15095")]
    public static SoundEvent ENTITY_SLIME_SQUISH { get; private set; }

    [Signature("field_15194")]
    public static SoundEvent BLOCK_SLIME_BLOCK_BREAK { get; private set; }

    [Signature("field_14560")]
    public static SoundEvent BLOCK_SLIME_BLOCK_FALL { get; private set; }

    [Signature("field_14640")]
    public static SoundEvent BLOCK_SLIME_BLOCK_HIT { get; private set; }

    [Signature("field_14788")]
    public static SoundEvent BLOCK_SLIME_BLOCK_PLACE { get; private set; }

    [Signature("field_15180")]
    public static SoundEvent BLOCK_SLIME_BLOCK_STEP { get; private set; }

    [Signature("field_26970")]
    public static SoundEvent BLOCK_SMALL_AMETHYST_BUD_BREAK { get; private set; }

    [Signature("field_26971")]
    public static SoundEvent BLOCK_SMALL_AMETHYST_BUD_PLACE { get; private set; }

    [Signature("field_28612")]
    public static SoundEvent BLOCK_SMALL_DRIPLEAF_BREAK { get; private set; }

    [Signature("field_28613")]
    public static SoundEvent BLOCK_SMALL_DRIPLEAF_FALL { get; private set; }

    [Signature("field_28614")]
    public static SoundEvent BLOCK_SMALL_DRIPLEAF_HIT { get; private set; }

    [Signature("field_28615")]
    public static SoundEvent BLOCK_SMALL_DRIPLEAF_PLACE { get; private set; }

    [Signature("field_28616")]
    public static SoundEvent BLOCK_SMALL_DRIPLEAF_STEP { get; private set; }

    [Signature("field_21949")]
    public static SoundEvent BLOCK_SOUL_SAND_BREAK { get; private set; }

    [Signature("field_21950")]
    public static SoundEvent BLOCK_SOUL_SAND_STEP { get; private set; }

    [Signature("field_21951")]
    public static SoundEvent BLOCK_SOUL_SAND_PLACE { get; private set; }

    [Signature("field_21942")]
    public static SoundEvent BLOCK_SOUL_SAND_HIT { get; private set; }

    [Signature("field_21943")]
    public static SoundEvent BLOCK_SOUL_SAND_FALL { get; private set; }

    [Signature("field_21944")]
    public static SoundEvent BLOCK_SOUL_SOIL_BREAK { get; private set; }

    [Signature("field_21945")]
    public static SoundEvent BLOCK_SOUL_SOIL_STEP { get; private set; }

    [Signature("field_21946")]
    public static SoundEvent BLOCK_SOUL_SOIL_PLACE { get; private set; }

    [Signature("field_21947")]
    public static SoundEvent BLOCK_SOUL_SOIL_HIT { get; private set; }

    [Signature("field_21948")]
    public static SoundEvent BLOCK_SOUL_SOIL_FALL { get; private set; }

    [Signature("field_23060")]
    public static SoundEvent PARTICLE_SOUL_ESCAPE { get; private set; }

    [Signature("field_28607")]
    public static SoundEvent BLOCK_SPORE_BLOSSOM_BREAK { get; private set; }

    [Signature("field_28608")]
    public static SoundEvent BLOCK_SPORE_BLOSSOM_FALL { get; private set; }

    [Signature("field_28609")]
    public static SoundEvent BLOCK_SPORE_BLOSSOM_HIT { get; private set; }

    [Signature("field_28610")]
    public static SoundEvent BLOCK_SPORE_BLOSSOM_PLACE { get; private set; }

    [Signature("field_28611")]
    public static SoundEvent BLOCK_SPORE_BLOSSOM_STEP { get; private set; }

    [Signature("field_23200")]
    public static SoundEvent ENTITY_STRIDER_AMBIENT { get; private set; }

    [Signature("field_23201")]
    public static SoundEvent ENTITY_STRIDER_HAPPY { get; private set; }

    [Signature("field_23202")]
    public static SoundEvent ENTITY_STRIDER_RETREAT { get; private set; }

    [Signature("field_23203")]
    public static SoundEvent ENTITY_STRIDER_DEATH { get; private set; }

    [Signature("field_23204")]
    public static SoundEvent ENTITY_STRIDER_HURT { get; private set; }

    [Signature("field_23205")]
    public static SoundEvent ENTITY_STRIDER_STEP { get; private set; }

    [Signature("field_23206")]
    public static SoundEvent ENTITY_STRIDER_STEP_LAVA { get; private set; }

    [Signature("field_23207")]
    public static SoundEvent ENTITY_STRIDER_EAT { get; private set; }

    [Signature("field_23798")]
    public static SoundEvent ENTITY_STRIDER_SADDLE { get; private set; }

    [Signature("field_14849")]
    public static SoundEvent ENTITY_SLIME_DEATH_SMALL { get; private set; }

    [Signature("field_14620")]
    public static SoundEvent ENTITY_SLIME_HURT_SMALL { get; private set; }

    [Signature("field_14694")]
    public static SoundEvent ENTITY_SLIME_JUMP_SMALL { get; private set; }

    [Signature("field_15148")]
    public static SoundEvent ENTITY_SLIME_SQUISH_SMALL { get; private set; }

    [Signature("field_22463")]
    public static SoundEvent BLOCK_SMITHING_TABLE_USE { get; private set; }

    [Signature("field_17618")]
    public static SoundEvent BLOCK_SMOKER_SMOKE { get; private set; }

    [Signature("field_42595")]
    public static SoundEvent ENTITY_SNIFFER_STEP { get; private set; }

    [Signature("field_42596")]
    public static SoundEvent ENTITY_SNIFFER_EAT { get; private set; }

    [Signature("field_42597")]
    public static SoundEvent ENTITY_SNIFFER_IDLE { get; private set; }

    [Signature("field_42598")]
    public static SoundEvent ENTITY_SNIFFER_HURT { get; private set; }

    [Signature("field_42599")]
    public static SoundEvent ENTITY_SNIFFER_DEATH { get; private set; }

    [Signature("field_42600")]
    public static SoundEvent ENTITY_SNIFFER_DROP_SEED { get; private set; }

    [Signature("field_42601")]
    public static SoundEvent ENTITY_SNIFFER_SCENTING { get; private set; }

    [Signature("field_42602")]
    public static SoundEvent ENTITY_SNIFFER_SNIFFING { get; private set; }

    [Signature("field_42603")]
    public static SoundEvent ENTITY_SNIFFER_SEARCHING { get; private set; }

    [Signature("field_42604")]
    public static SoundEvent ENTITY_SNIFFER_DIGGING { get; private set; }

    [Signature("field_42605")]
    public static SoundEvent ENTITY_SNIFFER_DIGGING_STOP { get; private set; }

    [Signature("field_42606")]
    public static SoundEvent ENTITY_SNIFFER_HAPPY { get; private set; }

    [Signature("field_44588")]
    public static SoundEvent BLOCK_SNIFFER_EGG_PLOP { get; private set; }

    [Signature("field_43165")]
    public static SoundEvent BLOCK_SNIFFER_EGG_CRACK { get; private set; }

    [Signature("field_43166")]
    public static SoundEvent BLOCK_SNIFFER_EGG_HATCH { get; private set; }

    [Signature("field_14873")]
    public static SoundEvent ENTITY_SNOWBALL_THROW { get; private set; }

    [Signature("field_15165")]
    public static SoundEvent BLOCK_SNOW_BREAK { get; private set; }

    [Signature("field_15092")]
    public static SoundEvent BLOCK_SNOW_FALL { get; private set; }

    [Signature("field_14655")]
    public static SoundEvent ENTITY_SNOW_GOLEM_AMBIENT { get; private set; }

    [Signature("field_14594")]
    public static SoundEvent ENTITY_SNOW_GOLEM_DEATH { get; private set; }

    [Signature("field_14830")]
    public static SoundEvent ENTITY_SNOW_GOLEM_HURT { get; private set; }

    [Signature("field_14745")]
    public static SoundEvent ENTITY_SNOW_GOLEM_SHOOT { get; private set; }

    [Signature("field_22273")]
    public static SoundEvent ENTITY_SNOW_GOLEM_SHEAR { get; private set; }

    [Signature("field_15040")]
    public static SoundEvent BLOCK_SNOW_HIT { get; private set; }

    [Signature("field_14945")]
    public static SoundEvent BLOCK_SNOW_PLACE { get; private set; }

    [Signature("field_15060")]
    public static SoundEvent BLOCK_SNOW_STEP { get; private set; }

    [Signature("field_15170")]
    public static SoundEvent ENTITY_SPIDER_AMBIENT { get; private set; }

    [Signature("field_14579")]
    public static SoundEvent ENTITY_SPIDER_DEATH { get; private set; }

    [Signature("field_14657")]
    public static SoundEvent ENTITY_SPIDER_HURT { get; private set; }

    [Signature("field_14760")]
    public static SoundEvent ENTITY_SPIDER_STEP { get; private set; }

    [Signature("field_14839")]
    public static SoundEvent ENTITY_SPLASH_POTION_BREAK { get; private set; }

    [Signature("field_14910")]
    public static SoundEvent ENTITY_SPLASH_POTION_THROW { get; private set; }

    [Signature("field_45962")]
    public static SoundEvent BLOCK_SPONGE_BREAK { get; private set; }

    [Signature("field_45963")]
    public static SoundEvent BLOCK_SPONGE_FALL { get; private set; }

    [Signature("field_45964")]
    public static SoundEvent BLOCK_SPONGE_HIT { get; private set; }

    [Signature("field_45965")]
    public static SoundEvent BLOCK_SPONGE_PLACE { get; private set; }

    [Signature("field_45966")]
    public static SoundEvent BLOCK_SPONGE_STEP { get; private set; }

    [Signature("field_45062")]
    public static SoundEvent BLOCK_SPONGE_ABSORB { get; private set; }

    [Signature("field_26972")]
    public static SoundEvent ITEM_SPYGLASS_USE { get; private set; }

    [Signature("field_26973")]
    public static SoundEvent ITEM_SPYGLASS_STOP_USING { get; private set; }

    [Signature("field_15034")]
    public static SoundEvent ENTITY_SQUID_AMBIENT { get; private set; }

    [Signature("field_15124")]
    public static SoundEvent ENTITY_SQUID_DEATH { get; private set; }

    [Signature("field_15212")]
    public static SoundEvent ENTITY_SQUID_HURT { get; private set; }

    [Signature("field_15121")]
    public static SoundEvent ENTITY_SQUID_SQUIRT { get; private set; }

    [Signature("field_15026")]
    public static SoundEvent BLOCK_STONE_BREAK { get; private set; }

    [Signature("field_14954")]
    public static SoundEvent BLOCK_STONE_BUTTON_CLICK_OFF { get; private set; }

    [Signature("field_14791")]
    public static SoundEvent BLOCK_STONE_BUTTON_CLICK_ON { get; private set; }

    [Signature("field_14723")]
    public static SoundEvent BLOCK_STONE_FALL { get; private set; }

    [Signature("field_14658")]
    public static SoundEvent BLOCK_STONE_HIT { get; private set; }

    [Signature("field_14574")]
    public static SoundEvent BLOCK_STONE_PLACE { get; private set; }

    [Signature("field_15116")]
    public static SoundEvent BLOCK_STONE_PRESSURE_PLATE_CLICK_OFF { get; private set; }

    [Signature("field_15217")]
    public static SoundEvent BLOCK_STONE_PRESSURE_PLATE_CLICK_ON { get; private set; }

    [Signature("field_14921")]
    public static SoundEvent BLOCK_STONE_STEP { get; private set; }

    [Signature("field_15041")]
    public static SoundEvent ENTITY_STRAY_AMBIENT { get; private set; }

    [Signature("field_14771")]
    public static SoundEvent ENTITY_STRAY_DEATH { get; private set; }

    [Signature("field_14805")]
    public static SoundEvent ENTITY_STRAY_HURT { get; private set; }

    [Signature("field_14540")]
    public static SoundEvent ENTITY_STRAY_STEP { get; private set; }

    [Signature("field_17615")]
    public static SoundEvent BLOCK_SWEET_BERRY_BUSH_BREAK { get; private set; }

    [Signature("field_17616")]
    public static SoundEvent BLOCK_SWEET_BERRY_BUSH_PLACE { get; private set; }

    [Signature("field_17617")]
    public static SoundEvent BLOCK_SWEET_BERRY_BUSH_PICK_BERRIES { get; private set; }

    [Signature("field_37370")]
    public static SoundEvent ENTITY_TADPOLE_DEATH { get; private set; }

    [Signature("field_37372")]
    public static SoundEvent ENTITY_TADPOLE_FLOP { get; private set; }

    [Signature("field_37373")]
    public static SoundEvent ENTITY_TADPOLE_GROW_UP { get; private set; }

    [Signature("field_37374")]
    public static SoundEvent ENTITY_TADPOLE_HURT { get; private set; }

    [Signature("field_14663")]
    public static SoundEvent ENCHANT_THORNS_HIT { get; private set; }

    [Signature("field_15079")]
    public static SoundEvent ENTITY_TNT_PRIMED { get; private set; }

    [Signature("field_14931")]
    public static SoundEvent ITEM_TOTEM_USE { get; private set; }

    [Signature("field_15213")]
    public static SoundEvent ITEM_TRIDENT_HIT { get; private set; }

    [Signature("field_15104")]
    public static SoundEvent ITEM_TRIDENT_HIT_GROUND { get; private set; }

    [Signature("field_14698")]
    public static SoundEvent ITEM_TRIDENT_RETURN { get; private set; }

    [Signature("field_14606")]
    public static SoundEvent ITEM_TRIDENT_RIPTIDE_1 { get; private set; }

    [Signature("field_14806")]
    public static SoundEvent ITEM_TRIDENT_RIPTIDE_2 { get; private set; }

    [Signature("field_14717")]
    public static SoundEvent ITEM_TRIDENT_RIPTIDE_3 { get; private set; }

    [Signature("field_15001")]
    public static SoundEvent ITEM_TRIDENT_THROW { get; private set; }

    [Signature("field_14896")]
    public static SoundEvent ITEM_TRIDENT_THUNDER { get; private set; }

    [Signature("field_14859")]
    public static SoundEvent BLOCK_TRIPWIRE_ATTACH { get; private set; }

    [Signature("field_14787")]
    public static SoundEvent BLOCK_TRIPWIRE_CLICK_OFF { get; private set; }

    [Signature("field_14674")]
    public static SoundEvent BLOCK_TRIPWIRE_CLICK_ON { get; private set; }

    [Signature("field_14595")]
    public static SoundEvent BLOCK_TRIPWIRE_DETACH { get; private set; }

    [Signature("field_15085")]
    public static SoundEvent ENTITY_TROPICAL_FISH_AMBIENT { get; private set; }

    [Signature("field_15201")]
    public static SoundEvent ENTITY_TROPICAL_FISH_DEATH { get; private set; }

    [Signature("field_14878")]
    public static SoundEvent ENTITY_TROPICAL_FISH_FLOP { get; private set; }

    [Signature("field_14985")]
    public static SoundEvent ENTITY_TROPICAL_FISH_HURT { get; private set; }

    [Signature("field_26974")]
    public static SoundEvent BLOCK_TUFF_BREAK { get; private set; }

    [Signature("field_26975")]
    public static SoundEvent BLOCK_TUFF_STEP { get; private set; }

    [Signature("field_26976")]
    public static SoundEvent BLOCK_TUFF_PLACE { get; private set; }

    [Signature("field_26977")]
    public static SoundEvent BLOCK_TUFF_HIT { get; private set; }

    [Signature("field_26978")]
    public static SoundEvent BLOCK_TUFF_FALL { get; private set; }

    [Signature("field_46946")]
    public static SoundEvent BLOCK_TUFF_BRICKS_BREAK { get; private set; }

    [Signature("field_46947")]
    public static SoundEvent BLOCK_TUFF_BRICKS_FALL { get; private set; }

    [Signature("field_46948")]
    public static SoundEvent BLOCK_TUFF_BRICKS_HIT { get; private set; }

    [Signature("field_46949")]
    public static SoundEvent BLOCK_TUFF_BRICKS_PLACE { get; private set; }

    [Signature("field_46950")]
    public static SoundEvent BLOCK_TUFF_BRICKS_STEP { get; private set; }

    [Signature("field_46951")]
    public static SoundEvent BLOCK_POLISHED_TUFF_BREAK { get; private set; }

    [Signature("field_46952")]
    public static SoundEvent BLOCK_POLISHED_TUFF_FALL { get; private set; }

    [Signature("field_46953")]
    public static SoundEvent BLOCK_POLISHED_TUFF_HIT { get; private set; }

    [Signature("field_46954")]
    public static SoundEvent BLOCK_POLISHED_TUFF_PLACE { get; private set; }

    [Signature("field_46955")]
    public static SoundEvent BLOCK_POLISHED_TUFF_STEP { get; private set; }

    [Signature("field_14722")]
    public static SoundEvent ENTITY_TURTLE_AMBIENT_LAND { get; private set; }

    [Signature("field_14856")]
    public static SoundEvent ENTITY_TURTLE_DEATH { get; private set; }

    [Signature("field_14618")]
    public static SoundEvent ENTITY_TURTLE_DEATH_BABY { get; private set; }

    [Signature("field_14687")]
    public static SoundEvent ENTITY_TURTLE_EGG_BREAK { get; private set; }

    [Signature("field_15109")]
    public static SoundEvent ENTITY_TURTLE_EGG_CRACK { get; private set; }

    [Signature("field_14902")]
    public static SoundEvent ENTITY_TURTLE_EGG_HATCH { get; private set; }

    [Signature("field_15183")]
    public static SoundEvent ENTITY_TURTLE_HURT { get; private set; }

    [Signature("field_15070")]
    public static SoundEvent ENTITY_TURTLE_HURT_BABY { get; private set; }

    [Signature("field_14634")]
    public static SoundEvent ENTITY_TURTLE_LAY_EGG { get; private set; }

    [Signature("field_14549")]
    public static SoundEvent ENTITY_TURTLE_SHAMBLE { get; private set; }

    [Signature("field_14864")]
    public static SoundEvent ENTITY_TURTLE_SHAMBLE_BABY { get; private set; }

    [Signature("field_14764")]
    public static SoundEvent ENTITY_TURTLE_SWIM { get; private set; }

    [Signature("field_15015")]
    public static RegistryEntry.Reference<SoundEvent> UI_BUTTON_CLICK { get; private set; }

    [Signature("field_14920")]
    public static SoundEvent UI_LOOM_SELECT_PATTERN { get; private set; }

    [Signature("field_15096")]
    public static SoundEvent UI_LOOM_TAKE_RESULT { get; private set; }

    [Signature("field_17484")]
    public static SoundEvent UI_CARTOGRAPHY_TABLE_TAKE_RESULT { get; private set; }

    [Signature("field_17710")]
    public static SoundEvent UI_STONECUTTER_TAKE_RESULT { get; private set; }

    [Signature("field_17711")]
    public static SoundEvent UI_STONECUTTER_SELECT_RECIPE { get; private set; }

    [Signature("field_15195")]
    public static SoundEvent UI_TOAST_CHALLENGE_COMPLETE { get; private set; }

    [Signature("field_14561")]
    public static SoundEvent UI_TOAST_IN { get; private set; }

    [Signature("field_14641")]
    public static SoundEvent UI_TOAST_OUT { get; private set; }

    [Signature("field_14812")]
    public static SoundEvent ENTITY_VEX_AMBIENT { get; private set; }

    [Signature("field_14898")]
    public static SoundEvent ENTITY_VEX_CHARGE { get; private set; }

    [Signature("field_14964")]
    public static SoundEvent ENTITY_VEX_DEATH { get; private set; }

    [Signature("field_15072")]
    public static SoundEvent ENTITY_VEX_HURT { get; private set; }

    [Signature("field_15175")]
    public static SoundEvent ENTITY_VILLAGER_AMBIENT { get; private set; }

    [Signature("field_19152")]
    public static SoundEvent ENTITY_VILLAGER_CELEBRATE { get; private set; }

    [Signature("field_15225")]
    public static SoundEvent ENTITY_VILLAGER_DEATH { get; private set; }

    [Signature("field_15139")]
    public static SoundEvent ENTITY_VILLAGER_HURT { get; private set; }

    [Signature("field_15008")]
    public static SoundEvent ENTITY_VILLAGER_NO { get; private set; }

    [Signature("field_14933")]
    public static SoundEvent ENTITY_VILLAGER_TRADE { get; private set; }

    [Signature("field_14815")]
    public static SoundEvent ENTITY_VILLAGER_YES { get; private set; }

    [Signature("field_20669")]
    public static SoundEvent ENTITY_VILLAGER_WORK_ARMORER { get; private set; }

    [Signature("field_20670")]
    public static SoundEvent ENTITY_VILLAGER_WORK_BUTCHER { get; private set; }

    [Signature("field_20671")]
    public static SoundEvent ENTITY_VILLAGER_WORK_CARTOGRAPHER { get; private set; }

    [Signature("field_20672")]
    public static SoundEvent ENTITY_VILLAGER_WORK_CLERIC { get; private set; }

    [Signature("field_20673")]
    public static SoundEvent ENTITY_VILLAGER_WORK_FARMER { get; private set; }

    [Signature("field_20674")]
    public static SoundEvent ENTITY_VILLAGER_WORK_FISHERMAN { get; private set; }

    [Signature("field_20675")]
    public static SoundEvent ENTITY_VILLAGER_WORK_FLETCHER { get; private set; }

    [Signature("field_20676")]
    public static SoundEvent ENTITY_VILLAGER_WORK_LEATHERWORKER { get; private set; }

    [Signature("field_20677")]
    public static SoundEvent ENTITY_VILLAGER_WORK_LIBRARIAN { get; private set; }

    [Signature("field_20678")]
    public static SoundEvent ENTITY_VILLAGER_WORK_MASON { get; private set; }

    [Signature("field_20679")]
    public static SoundEvent ENTITY_VILLAGER_WORK_SHEPHERD { get; private set; }

    [Signature("field_20680")]
    public static SoundEvent ENTITY_VILLAGER_WORK_TOOLSMITH { get; private set; }

    [Signature("field_20681")]
    public static SoundEvent ENTITY_VILLAGER_WORK_WEAPONSMITH { get; private set; }

    [Signature("field_14735")]
    public static SoundEvent ENTITY_VINDICATOR_AMBIENT { get; private set; }

    [Signature("field_19151")]
    public static SoundEvent ENTITY_VINDICATOR_CELEBRATE { get; private set; }

    [Signature("field_14642")]
    public static SoundEvent ENTITY_VINDICATOR_DEATH { get; private set; }

    [Signature("field_14558")]
    public static SoundEvent ENTITY_VINDICATOR_HURT { get; private set; }

    [Signature("field_28617")]
    public static SoundEvent BLOCK_VINE_BREAK { get; private set; }

    [Signature("field_28618")]
    public static SoundEvent BLOCK_VINE_FALL { get; private set; }

    [Signature("field_28619")]
    public static SoundEvent BLOCK_VINE_HIT { get; private set; }

    [Signature("field_28620")]
    public static SoundEvent BLOCK_VINE_PLACE { get; private set; }

    [Signature("field_23061")]
    public static SoundEvent BLOCK_VINE_STEP { get; private set; }

    [Signature("field_15173")]
    public static SoundEvent BLOCK_LILY_PAD_PLACE { get; private set; }

    [Signature("field_17747")]
    public static SoundEvent ENTITY_WANDERING_TRADER_AMBIENT { get; private set; }

    [Signature("field_17748")]
    public static SoundEvent ENTITY_WANDERING_TRADER_DEATH { get; private set; }

    [Signature("field_18315")]
    public static SoundEvent ENTITY_WANDERING_TRADER_DISAPPEARED { get; private set; }

    [Signature("field_18316")]
    public static SoundEvent ENTITY_WANDERING_TRADER_DRINK_MILK { get; private set; }

    [Signature("field_18313")]
    public static SoundEvent ENTITY_WANDERING_TRADER_DRINK_POTION { get; private set; }

    [Signature("field_17749")]
    public static SoundEvent ENTITY_WANDERING_TRADER_HURT { get; private set; }

    [Signature("field_17750")]
    public static SoundEvent ENTITY_WANDERING_TRADER_NO { get; private set; }

    [Signature("field_18314")]
    public static SoundEvent ENTITY_WANDERING_TRADER_REAPPEARED { get; private set; }

    [Signature("field_17751")]
    public static SoundEvent ENTITY_WANDERING_TRADER_TRADE { get; private set; }

    [Signature("field_17752")]
    public static SoundEvent ENTITY_WANDERING_TRADER_YES { get; private set; }

    [Signature("field_38061")]
    public static SoundEvent ENTITY_WARDEN_AGITATED { get; private set; }

    [Signature("field_38062")]
    public static SoundEvent ENTITY_WARDEN_AMBIENT { get; private set; }

    [Signature("field_38063")]
    public static SoundEvent ENTITY_WARDEN_ANGRY { get; private set; }

    [Signature("field_38064")]
    public static SoundEvent ENTITY_WARDEN_ATTACK_IMPACT { get; private set; }

    [Signature("field_38065")]
    public static SoundEvent ENTITY_WARDEN_DEATH { get; private set; }

    [Signature("field_38066")]
    public static SoundEvent ENTITY_WARDEN_DIG { get; private set; }

    [Signature("field_38067")]
    public static SoundEvent ENTITY_WARDEN_EMERGE { get; private set; }

    [Signature("field_38068")]
    public static SoundEvent ENTITY_WARDEN_HEARTBEAT { get; private set; }

    [Signature("field_38069")]
    public static SoundEvent ENTITY_WARDEN_HURT { get; private set; }

    [Signature("field_38070")]
    public static SoundEvent ENTITY_WARDEN_LISTENING { get; private set; }

    [Signature("field_38071")]
    public static SoundEvent ENTITY_WARDEN_LISTENING_ANGRY { get; private set; }

    [Signature("field_38072")]
    public static SoundEvent ENTITY_WARDEN_NEARBY_CLOSE { get; private set; }

    [Signature("field_38073")]
    public static SoundEvent ENTITY_WARDEN_NEARBY_CLOSER { get; private set; }

    [Signature("field_38074")]
    public static SoundEvent ENTITY_WARDEN_NEARBY_CLOSEST { get; private set; }

    [Signature("field_38075")]
    public static SoundEvent ENTITY_WARDEN_ROAR { get; private set; }

    [Signature("field_38076")]
    public static SoundEvent ENTITY_WARDEN_SNIFF { get; private set; }

    [Signature("field_38830")]
    public static SoundEvent ENTITY_WARDEN_SONIC_BOOM { get; private set; }

    [Signature("field_38831")]
    public static SoundEvent ENTITY_WARDEN_SONIC_CHARGE { get; private set; }

    [Signature("field_38077")]
    public static SoundEvent ENTITY_WARDEN_STEP { get; private set; }

    [Signature("field_38078")]
    public static SoundEvent ENTITY_WARDEN_TENDRIL_CLICKS { get; private set; }

    [Signature("field_46651")]
    public static SoundEvent BLOCK_HANGING_SIGN_WAXED_INTERACT_FAIL { get; private set; }

    [Signature("field_43167")]
    public static SoundEvent BLOCK_SIGN_WAXED_INTERACT_FAIL { get; private set; }

    [Signature("field_15237")]
    public static SoundEvent BLOCK_WATER_AMBIENT { get; private set; }

    [Signature("field_14946")]
    public static SoundEvent WEATHER_RAIN { get; private set; }

    [Signature("field_15020")]
    public static SoundEvent WEATHER_RAIN_ABOVE { get; private set; }

    [Signature("field_15120")]
    public static SoundEvent BLOCK_WET_GRASS_BREAK { get; private set; }

    [Signature("field_15207")]
    public static SoundEvent BLOCK_WET_GRASS_FALL { get; private set; }

    [Signature("field_14953")]
    public static SoundEvent BLOCK_WET_GRASS_HIT { get; private set; }

    [Signature("field_15025")]
    public static SoundEvent BLOCK_WET_GRASS_PLACE { get; private set; }

    [Signature("field_14774")]
    public static SoundEvent BLOCK_WET_GRASS_STEP { get; private set; }

    [Signature("field_45967")]
    public static SoundEvent BLOCK_WET_SPONGE_BREAK { get; private set; }

    [Signature("field_45968")]
    public static SoundEvent BLOCK_WET_SPONGE_FALL { get; private set; }

    [Signature("field_45959")]
    public static SoundEvent BLOCK_WET_SPONGE_HIT { get; private set; }

    [Signature("field_45960")]
    public static SoundEvent BLOCK_WET_SPONGE_PLACE { get; private set; }

    [Signature("field_45961")]
    public static SoundEvent BLOCK_WET_SPONGE_STEP { get; private set; }

    [Signature("field_47191")]
    public static SoundEvent ENTITY_GENERIC_WIND_BURST { get; private set; }

    [Signature("field_14736")]
    public static SoundEvent ENTITY_WITCH_AMBIENT { get; private set; }

    [Signature("field_19153")]
    public static SoundEvent ENTITY_WITCH_CELEBRATE { get; private set; }

    [Signature("field_14820")]
    public static SoundEvent ENTITY_WITCH_DEATH { get; private set; }

    [Signature("field_14565")]
    public static SoundEvent ENTITY_WITCH_DRINK { get; private set; }

    [Signature("field_14645")]
    public static SoundEvent ENTITY_WITCH_HURT { get; private set; }

    [Signature("field_15067")]
    public static SoundEvent ENTITY_WITCH_THROW { get; private set; }

    [Signature("field_15163")]
    public static SoundEvent ENTITY_WITHER_AMBIENT { get; private set; }

    [Signature("field_15236")]
    public static SoundEvent ENTITY_WITHER_BREAK_BLOCK { get; private set; }

    [Signature("field_15136")]
    public static SoundEvent ENTITY_WITHER_DEATH { get; private set; }

    [Signature("field_14688")]
    public static SoundEvent ENTITY_WITHER_HURT { get; private set; }

    [Signature("field_14588")]
    public static SoundEvent ENTITY_WITHER_SHOOT { get; private set; }

    [Signature("field_15214")]
    public static SoundEvent ENTITY_WITHER_SKELETON_AMBIENT { get; private set; }

    [Signature("field_15122")]
    public static SoundEvent ENTITY_WITHER_SKELETON_DEATH { get; private set; }

    [Signature("field_15027")]
    public static SoundEvent ENTITY_WITHER_SKELETON_HURT { get; private set; }

    [Signature("field_14955")]
    public static SoundEvent ENTITY_WITHER_SKELETON_STEP { get; private set; }

    [Signature("field_14792")]
    public static SoundEvent ENTITY_WITHER_SPAWN { get; private set; }

    [Signature("field_14724")]
    public static SoundEvent ENTITY_WOLF_AMBIENT { get; private set; }

    [Signature("field_14659")]
    public static SoundEvent ENTITY_WOLF_DEATH { get; private set; }

    [Signature("field_14575")]
    public static SoundEvent ENTITY_WOLF_GROWL { get; private set; }

    [Signature("field_15117")]
    public static SoundEvent ENTITY_WOLF_HOWL { get; private set; }

    [Signature("field_15218")]
    public static SoundEvent ENTITY_WOLF_HURT { get; private set; }

    [Signature("field_14922")]
    public static SoundEvent ENTITY_WOLF_PANT { get; private set; }

    [Signature("field_15042")]
    public static SoundEvent ENTITY_WOLF_SHAKE { get; private set; }

    [Signature("field_14772")]
    public static SoundEvent ENTITY_WOLF_STEP { get; private set; }

    [Signature("field_14807")]
    public static SoundEvent ENTITY_WOLF_WHINE { get; private set; }

    [Signature("field_14541")]
    public static SoundEvent BLOCK_WOODEN_DOOR_CLOSE { get; private set; }

    [Signature("field_14664")]
    public static SoundEvent BLOCK_WOODEN_DOOR_OPEN { get; private set; }

    [Signature("field_15080")]
    public static SoundEvent BLOCK_WOODEN_TRAPDOOR_CLOSE { get; private set; }

    [Signature("field_14932")]
    public static SoundEvent BLOCK_WOODEN_TRAPDOOR_OPEN { get; private set; }

    [Signature("field_15105")]
    public static SoundEvent BLOCK_WOODEN_BUTTON_CLICK_OFF { get; private set; }

    [Signature("field_14699")]
    public static SoundEvent BLOCK_WOODEN_BUTTON_CLICK_ON { get; private set; }

    [Signature("field_15002")]
    public static SoundEvent BLOCK_WOODEN_PRESSURE_PLATE_CLICK_OFF { get; private set; }

    [Signature("field_14961")]
    public static SoundEvent BLOCK_WOODEN_PRESSURE_PLATE_CLICK_ON { get; private set; }

    [Signature("field_15215")]
    public static SoundEvent BLOCK_WOOD_BREAK { get; private set; }

    [Signature("field_14607")]
    public static SoundEvent BLOCK_WOOD_FALL { get; private set; }

    [Signature("field_14808")]
    public static SoundEvent BLOCK_WOOD_HIT { get; private set; }

    [Signature("field_14718")]
    public static SoundEvent BLOCK_WOOD_PLACE { get; private set; }

    [Signature("field_15053")]
    public static SoundEvent BLOCK_WOOD_STEP { get; private set; }

    [Signature("field_14983")]
    public static SoundEvent BLOCK_WOOL_BREAK { get; private set; }

    [Signature("field_15048")]
    public static SoundEvent BLOCK_WOOL_FALL { get; private set; }

    [Signature("field_14628")]
    public static SoundEvent BLOCK_WOOL_HIT { get; private set; }

    [Signature("field_15226")]
    public static SoundEvent BLOCK_WOOL_PLACE { get; private set; }

    [Signature("field_15181")]
    public static SoundEvent BLOCK_WOOL_STEP { get; private set; }

    [Signature("field_23672")]
    public static SoundEvent ENTITY_ZOGLIN_AMBIENT { get; private set; }

    [Signature("field_23673")]
    public static SoundEvent ENTITY_ZOGLIN_ANGRY { get; private set; }

    [Signature("field_23674")]
    public static SoundEvent ENTITY_ZOGLIN_ATTACK { get; private set; }

    [Signature("field_23675")]
    public static SoundEvent ENTITY_ZOGLIN_DEATH { get; private set; }

    [Signature("field_23676")]
    public static SoundEvent ENTITY_ZOGLIN_HURT { get; private set; }

    [Signature("field_23677")]
    public static SoundEvent ENTITY_ZOGLIN_STEP { get; private set; }

    [Signature("field_15174")]
    public static SoundEvent ENTITY_ZOMBIE_AMBIENT { get; private set; }

    [Signature("field_14562")]
    public static SoundEvent ENTITY_ZOMBIE_ATTACK_WOODEN_DOOR { get; private set; }

    [Signature("field_14670")]
    public static SoundEvent ENTITY_ZOMBIE_ATTACK_IRON_DOOR { get; private set; }

    [Signature("field_14742")]
    public static SoundEvent ENTITY_ZOMBIE_BREAK_WOODEN_DOOR { get; private set; }

    [Signature("field_14850")]
    public static SoundEvent ENTITY_ZOMBIE_CONVERTED_TO_DROWNED { get; private set; }

    [Signature("field_14930")]
    public static SoundEvent ENTITY_ZOMBIE_DEATH { get; private set; }

    [Signature("field_15023")]
    public static SoundEvent ENTITY_ZOMBIE_DESTROY_EGG { get; private set; }

    [Signature("field_15154")]
    public static SoundEvent ENTITY_ZOMBIE_HORSE_AMBIENT { get; private set; }

    [Signature("field_14543")]
    public static SoundEvent ENTITY_ZOMBIE_HORSE_DEATH { get; private set; }

    [Signature("field_15179")]
    public static SoundEvent ENTITY_ZOMBIE_HORSE_HURT { get; private set; }

    [Signature("field_15088")]
    public static SoundEvent ENTITY_ZOMBIE_HURT { get; private set; }

    [Signature("field_14986")]
    public static SoundEvent ENTITY_ZOMBIE_INFECT { get; private set; }

    [Signature("field_14926")]
    public static SoundEvent ENTITY_ZOMBIFIED_PIGLIN_AMBIENT { get; private set; }

    [Signature("field_14852")]
    public static SoundEvent ENTITY_ZOMBIFIED_PIGLIN_ANGRY { get; private set; }

    [Signature("field_14743")]
    public static SoundEvent ENTITY_ZOMBIFIED_PIGLIN_DEATH { get; private set; }

    [Signature("field_14710")]
    public static SoundEvent ENTITY_ZOMBIFIED_PIGLIN_HURT { get; private set; }

    [Signature("field_14621")]
    public static SoundEvent ENTITY_ZOMBIE_STEP { get; private set; }

    [Signature("field_15056")]
    public static SoundEvent ENTITY_ZOMBIE_VILLAGER_AMBIENT { get; private set; }

    [Signature("field_15168")]
    public static SoundEvent ENTITY_ZOMBIE_VILLAGER_CONVERTED { get; private set; }

    [Signature("field_14905")]
    public static SoundEvent ENTITY_ZOMBIE_VILLAGER_CURE { get; private set; }

    [Signature("field_14996")]
    public static SoundEvent ENTITY_ZOMBIE_VILLAGER_DEATH { get; private set; }

    [Signature("field_14728")]
    public static SoundEvent ENTITY_ZOMBIE_VILLAGER_HURT { get; private set; }

    [Signature("field_14841")]
    public static SoundEvent ENTITY_ZOMBIE_VILLAGER_STEP { get; private set; }
}
