using Java.Util.Stream;
using Java.Util.Function;
using Com.Google.Common.Collect;
using Net.Minecraft.Nbt;
using Net.Minecraft.Entity;
using Net.Minecraft.Entity.Player;
using Net.Minecraft.Entity.Attribute;
using Net.Minecraft.Entity.Decoration;
using Net.Minecraft.Client.Item;
using Net.Minecraft.Server.Network;
using Net.Minecraft.Registry;
using Net.Minecraft.Registry.Entry;
using Net.Minecraft.Registry.Tag;
using Net.Minecraft.Block;
using Net.Minecraft.Block.Pattern;
using Net.Minecraft.Sound;
using Net.Minecraft.Util;
using Net.Minecraft.Util.Math;
using Net.Minecraft.Text;
using Net.Minecraft.Inventory;
using Net.Minecraft.Screen.Slot;
using Net.Minecraft.Resource.FeatureToggle;

namespace Net.Minecraft.Item;

[MapName("net/minecraft/class_1799")]
public partial class ItemStack : JavaObject, IClassRef<ItemStack>, IFromHandle<ItemStack>
{
    [JavaConstructor]
    public ItemStack(IItemConvertible item) : base(ItemStack_ItemConvertibleInvoke(item))
    {}

    [JavaConstructor]
    public ItemStack(IItemConvertible item, int count) : base(ItemStack_ItemConvertibleIntInvoke(item, count))
    {}

    [Signature("method_32347")]
    public partial Optional<TooltipData> GetTooltipData();

    [Signature("method_7915")]
    public static partial ItemStack FromNbt(NbtCompound nbt);

    [Signature("method_7960")]
    public partial bool IsEmpty();

    [Signature("method_45435")]
    public partial bool IsItemEnabled(FeatureSet enabledFeatures);

    [Signature("method_7971")]
    public partial ItemStack Split(int amount);

    [Signature("method_51164")]
    public partial ItemStack CopyAndEmpty();

    [Signature("method_7909")]
    public partial Item GetItem();

    [Signature("method_41409")]
    public partial RegistryEntry<Item> GetRegistryEntry();

    [Signature("method_31573")]
    public partial bool IsIn(TagKey<Item> tag);

    [Signature("method_31574")]
    public partial bool IsOf(Item item);

    [Signature("method_41407")]
    public partial bool ItemMatches(Java.Util.Function.Predicate<RegistryEntry<Item>> predicate);

    [Signature("method_41406")]
    public partial bool ItemMatches(IRegistryEntry<Item> itemEntry);

    [Signature("method_53187")]
    public partial bool ItemMatches(IRegistryEntryList<Item> registryEntryList);

    [Signature("method_40133")]
    public partial Stream<TagKey<Item>> StreamTags();

    [Signature("method_7981")]
    public partial ActionResult UseOnBlock(ItemUsageContext context);

    [Signature("method_7924")]
    public partial float GetMiningSpeedMultiplier(BlockState state);

    [Signature("method_7913")]
    public partial TypedActionResult<ItemStack> Use(World.World world, PlayerEntity user, Hand hand);

    [Signature("method_7910")]
    public partial ItemStack FinishUsing(World.World world, LivingEntity user);

    [Signature("method_7953")]
    public partial NbtCompound WriteNbt(NbtCompound nbt);

    [Signature("method_7914")]
    public partial int GetMaxCount();

    [Signature("method_7946")]
    public partial bool IsStackable();

    [Signature("method_7963")]
    public partial bool IsDamageable();

    [Signature("method_7986")]
    public partial bool IsDamaged();

    [Signature("method_7919")]
    public partial int GetDamage();

    [Signature("method_7974")]
    public partial void SetDamage(int damage);

    [Signature("method_7936")]
    public partial int GetMaxDamage();

    [Signature("method_7970")]
    public partial bool Damage(int amount, Util.Math.Random.Random random, ServerPlayerEntity? player);

    [Signature("method_7956")]
    public partial void Damage<T>(int amount, T entity, Consumer<T> breakCallback) where T : LivingEntity, IClassRef<T>, IFromHandle<T>;

    [Signature("method_31578")]
    public partial bool IsItemBarVisible();

    [Signature("method_31579")]
    public partial int GetItemBarStep();

    [Signature("method_31580")]
    public partial int GetItemBarColor();

    [Signature("method_31575")]
    public partial bool OnStackClicked(Slot slot, ClickType clickType, PlayerEntity player);

    [Signature("method_31576")]
    public partial bool OnClicked(ItemStack stack, Slot slot, ClickType clickType, PlayerEntity player, StackReference cursorStackReference);

    [Signature("method_7979")]
    public partial void PostHit(LivingEntity target, PlayerEntity attacker);

    [Signature("method_7952")]
    public partial void PostMine(World.World world, BlockState state, BlockPos pos, PlayerEntity miner);

    [Signature("method_7951")]
    public partial bool IsSuitableFor(BlockState state);

    [Signature("method_7920")]
    public partial ActionResult UseOnEntity(PlayerEntity user, LivingEntity entity, Hand hand);

    [Signature("method_7972")]
    public partial ItemStack Copy();

    [Signature("method_46651")]
    public partial ItemStack CopyWithCount(int count);

    [Signature("method_7973")]
    public static partial bool AreEqual(ItemStack left, ItemStack right);

    [Signature("method_7984")]
    public static partial bool AreItemsEqual(ItemStack left, ItemStack right);

    [Signature("method_31577")]
    public static partial bool CanCombine(ItemStack stack, ItemStack otherStack);

    [Signature("method_7922")]
    public partial string GetTranslationKey();

    [Signature("method_7917")]
    public partial void InventoryTick(World.World world, Entity.Entity entity, int slot, bool selected);

    [Signature("method_7982")]
    public partial void OnCraftByPlayer(World.World world, PlayerEntity player, int amount);

    [Signature("method_54466")]
    public partial void OnCraftByCrafter(World.World world);

    [Signature("method_7935")]
    public partial int GetMaxUseTime();

    [Signature("method_7976")]
    public partial UseAction GetUseAction();

    [Signature("method_7930")]
    public partial void OnStoppedUsing(World.World world, LivingEntity user, int remainingUseTicks);

    [Signature("method_7967")]
    public partial bool IsUsedOnRelease();

    [Signature("method_7985")]
    public partial bool HasNbt();

    [Signature("method_7969")]
    public partial NbtCompound? GetNbt();

    [Signature("method_7948")]
    public partial NbtCompound GetOrCreateNbt();

    [Signature("method_7911")]
    public partial NbtCompound GetOrCreateSubNbt(string key);

    [Signature("method_7941")]
    public partial NbtCompound? GetSubNbt(string key);

    [Signature("method_7983")]
    public partial void RemoveSubNbt(string key);

    [Signature("method_7921")]
    public partial NbtList GetEnchantments();

    [Signature("method_7980")]
    public partial void SetNbt(NbtCompound? nbt);

    [Signature("method_7964")]
    public partial Text.Text GetName();

    [Signature("method_7977")]
    public partial ItemStack SetCustomName(IText? name);

    [Signature("method_7925")]
    public partial void RemoveCustomName();

    [Signature("method_7938")]
    public partial bool HasCustomName();

    [Signature("method_7950")]
    public partial Java.Util.List<Text.Text> GetTooltip(PlayerEntity? player, TooltipContext context);

    [Signature("method_30268")]
    public partial void AddHideFlag(ItemStack.TooltipSection tooltipSection);

    [Signature("method_17870")]
    public static partial void AppendEnchantments(Java.Util.IList<Text.Text> tooltip, NbtList enchantments);

    [Signature("method_7958")]
    public partial bool HasGlint();

    [Signature("method_7932")]
    public partial Rarity GetRarity();

    [Signature("method_7923")]
    public partial bool IsEnchantable();

    [Signature("method_7978")]
    public partial void AddEnchantment(Enchantment.Enchantment enchantment, int level);

    [Signature("method_7942")]
    public partial bool HasEnchantments();

    [Signature("method_7959")]
    public partial void SetSubNbt(string key, NbtElement element);

    [Signature("method_7961")]
    public partial bool IsInFrame();

    [Signature("method_27320")]
    public partial void SetHolder(Entity.Entity? holder);

    [Signature("method_7945")]
    public partial ItemFrameEntity? GetFrame();

    [Signature("method_27319")]
    public partial Entity.Entity? GetHolder();

    [Signature("method_7928")]
    public partial int GetRepairCost();

    [Signature("method_7927")]
    public partial void SetRepairCost(int repairCost);

    [Signature("method_7926")]
    public partial Multimap<EntityAttribute, EntityAttributeModifier> GetAttributeModifiers(EquipmentSlot slot);

    [Signature("method_7916")]
    public partial void AddAttributeModifier(EntityAttribute attribute, EntityAttributeModifier modifier, EquipmentSlot? slot);

    [Signature("method_7954")]
    public partial Text.Text ToHoverableText();

    [Signature("method_7944")]
    public partial bool CanPlaceOn(Registry<Block.Block> blockRegistry, CachedBlockPosition pos);

    [Signature("method_7940")]
    public partial bool CanDestroy(Registry<Block.Block> blockRegistry, CachedBlockPosition pos);

    [Signature("method_7965")]
    public partial int GetBobbingAnimationTime();

    [Signature("method_7912")]
    public partial void SetBobbingAnimationTime(int bobbingAnimationTime);

    [Signature("method_7947")]
    public partial int GetCount();

    [Signature("method_7939")]
    public partial void SetCount(int count);

    [Signature("method_7933")]
    public partial void Increment(int amount);

    [Signature("method_7934")]
    public partial void Decrement(int amount);

    [Signature("method_7949")]
    public partial void UsageTick(World.World world, LivingEntity user, int remainingUseTicks);

    [Signature("method_33262")]
    public partial void OnItemEntityDestroyed(ItemEntity entity);

    [Signature("method_19267")]
    public partial bool IsFood();

    [Signature("method_21832")]
    public partial SoundEvent GetDrinkSound();

    [Signature("method_21833")]
    public partial SoundEvent GetEatSound();

    [MapName("class_5422")]
    public partial class TooltipSection : Java.Lang.Enum<TooltipSection>, IClassRef<TooltipSection>, IFromHandle<TooltipSection>
    {
        [Signature("field_25768")]
        public static TooltipSection ENCHANTMENTS { get; private set; }

        [Signature("field_25769")]
        public static TooltipSection MODIFIERS { get; private set; }
        
        [Signature("field_25770")]
        public static TooltipSection UNBREAKABLE { get; private set; }
        
        [Signature("field_25771")]
        public static TooltipSection CAN_DESTROY { get; private set; }
        
        [Signature("field_25772")]
        public static TooltipSection CAN_PLACE { get; private set; }
        
        [Signature("field_25773")]
        public static TooltipSection ADDITIONAL { get; private set; }
        
        [Signature("field_25774")]
        public static TooltipSection DYE { get; private set; }
        
        [Signature("field_41945")]
        public static TooltipSection UPGRADES { get; private set; }
    }
}
