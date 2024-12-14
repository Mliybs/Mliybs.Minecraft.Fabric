using System.Collections.Concurrent;
using Com.Google.Common.Collect;
using Net.Minecraft.Resource.Featuretoggle;
using Net.Minecraft.Util;
using Net.Minecraft.Util.Hit;
using Net.Minecraft.Util.Math;
using Net.Minecraft.Block;
using Net.Minecraft.Entity;
using Net.Minecraft.Entity.Player;
using Net.Minecraft.Entity.Damage;
using Net.Minecraft.Nbt;
using Net.Minecraft.World;
using Net.Minecraft.Registry;
using Net.Minecraft.Screen.Slot;
using Net.Minecraft.Text;
using Net.Minecraft.Sound;
using Net.Minecraft.Entity.Attribute;
using Net.Minecraft.Client.Item;
using Net.Minecraft.Inventory;

namespace Net.Minecraft.Item;

[MapName("net/minecraft/class_1792")]
public partial class Item : Java.Lang.Object, IClassRef<Item>, IFromHandle<Item>, IWrapper<Item>, IItemConvertible, IToggleableFeature
{
    protected readonly static ConcurrentBag<Delegate> KeepAlive = new();

    [JavaConstructor]
    public Item(Settings settings) : base(nint.Zero)
    {
        ObjectRef = Item_SettingsInvoke(settings);
    }

    [Signature("method_7880")]
    public static partial int GetRawId(Item item);

    [Signature("method_7875")]
    public static partial Item ByRawId(int id);

    [Signature("method_7867"), Obsolete("请使用Block.AsItem()")]
    public static partial Item FromBlock(Block.Block block);

    public virtual Item AsItem() => ItemConvertible.AsItemProxy(ObjectRef);

    protected virtual nint AsItemHandler() => AsItem().ObjectRef;

    protected delegate nint AsItemDelegate();

    public virtual FeatureSet GetRequiredFeatures() => ToggleableFeature.GetRequiredFeaturesProxy(ObjectRef);

    protected virtual nint GetRequiredFeaturesHandler() => GetRequiredFeatures().ObjectRef;

    protected delegate nint GetRequiredFeaturesDelegate();

    [Signature("method_7852")]
    public virtual partial void UsageTick(World.World world, LivingEntity user, ItemStack stack, int remainingUseTicks);

    [Signature("method_33261")]
    public virtual partial void OnItemEntityDestroyed(ItemEntity entity);

    [Signature("method_7860")]
    public virtual partial void PostProcessNbt(NbtCompound nbt);

    [Signature("method_7885")]
    public virtual partial bool CanMine(BlockState state, World.World world, BlockPos pos, PlayerEntity miner);

    [Signature("method_7884")]
    public virtual partial ActionResult UseOnBlock(ItemUsageContext context);

    [Signature("method_7865")]
    public virtual partial float GetMiningSpeedMultiplier(ItemStack stack, BlockState state);

    [Signature("method_7836")]
    public virtual partial TypedActionResult<ItemStack> Use(World.World world, PlayerEntity user, Hand hand);

    [Signature("method_7861")]
    public virtual partial ItemStack FinishUsing(ItemStack stack, World.World world, LivingEntity user);

    [Signature("method_7882")]
    public partial int GetMaxCount();

    [Signature("method_7841")]
    public partial int GetMaxDamage();

    [Signature("method_7846")]
    public virtual partial bool IsDamageable();

    [Signature("method_31567")]
    public virtual partial bool IsItemBarVisible(ItemStack stack);

    [Signature("method_31569")]
    public virtual partial int GetItemBarStep(ItemStack stack);

    [Signature("method_31571")]
    public virtual partial int GetItemBarColor(ItemStack stack);

    [Signature("method_31565")]
    public virtual partial bool OnStackClicked(ItemStack stack, Slot slot, ClickType clickType, PlayerEntity player);

    [Signature("method_31566")]
    public virtual partial bool OnClicked(ItemStack stack, ItemStack otherStack, Slot slot, ClickType clickType, PlayerEntity player, StackReference cursorStackReference);

    [Signature("method_7873")]
    public virtual partial bool PostHit(ItemStack stack, LivingEntity target, LivingEntity attacker);

    [Signature("method_7879")]
    public virtual partial bool PostMine(ItemStack stack, World.World world, BlockState state, BlockPos pos, LivingEntity miner);

    [Signature("method_7856")]
    public virtual partial bool IsSuitableFor(BlockState state);

    [Signature("method_7847")]
    public virtual partial ActionResult UseOnEntity(ItemStack stack, PlayerEntity user, LivingEntity entity, Hand hand);

    [Signature("method_7848")]
    public virtual partial Text.Text GetName();

    [Signature("method_7869")]
    protected virtual partial string GetOrCreateTranslationKey();

    [Signature("method_7876")]
    public virtual partial string GetTranslationKey();

    [Signature("method_7866")]
    public virtual partial string GetTranslationKey(ItemStack stack);

    [Signature("method_7887")]
    public virtual partial bool IsNbtSynced();

    [Signature("method_7858")]
    public partial Item? GetRecipeRemainder();

    [Signature("method_7857")]
    public virtual partial bool HasRecipeRemainder();

    [Signature("method_7888")]
    public virtual partial void InventoryTick(ItemStack stack, World.World world, Entity.Entity entity, int slot, bool selected);

    [Signature("method_54465")]
    public virtual partial void OnCraftByPlayer(ItemStack stack, World.World world, PlayerEntity player);

    [Signature("method_7843")]
    public virtual partial void OnCraft(ItemStack stack, World.World world);

    [Signature("method_16698")]
    public virtual partial bool IsNetworkSynced();

    [Signature("method_7853")]
    public virtual partial UseAction GetUseAction(ItemStack stack);

    [Signature("method_7881")]
    public virtual partial int GetMaxUseTime(ItemStack stack);

    [Signature("method_7840")]
    public virtual partial void OnStoppedUsing(ItemStack stack, World.World world, LivingEntity user, int remainingUseTicks);

    [Signature("method_7851")]
    public virtual partial void AppendTooltip(ItemStack stack, World.World? world, Java.Util.List<Text.Text> tooltip, TooltipContext context);

    [Signature("method_32346")]
    public virtual partial Optional<TooltipData> GetTooltipData(ItemStack stack);

    [Signature("method_7864")]
    public virtual partial Text.Text GetName(ItemStack stack);

    [Signature("method_7886")]
    public virtual partial bool HasGlint(ItemStack stack);

    [Signature("method_7862")]
    public virtual partial Rarity GetRarity(ItemStack stack);

    [Signature("method_7870")]
    public virtual partial bool IsEnchantable(ItemStack stack);

    [Signature("method_7872")]
    protected static partial BlockHitResult Raycast(World.World world, PlayerEntity player, RaycastContext.FluidHandling fluidHandling);

    [Signature("method_7837")]
    public virtual partial int GetEnchantability();

    [Signature("method_7878")]
    public virtual partial bool CanRepair(ItemStack stack, ItemStack ingredient);

    [Signature("method_7844")]
    public virtual partial Multimap<EntityAttribute, EntityAttributeModifier> GetAttributeModifiers(EquipmentSlot slot);

    [Signature("method_7838")]
    public virtual partial bool IsUsedOnRelease(ItemStack stack);

    [Signature("method_7854")]
    public virtual partial ItemStack GetDefaultStack();

    [Signature("method_19263")]
    public virtual partial bool IsFood();

    [Signature("method_19264")]
    public virtual partial FoodComponent? GetFoodComponent();

    [Signature("method_21831")]
    public virtual partial SoundEvent GetDrinkSound();

    [Signature("method_21830")]
    public virtual partial SoundEvent GetEatSound();

    [Signature("method_24358")]
    public virtual partial bool IsFireproof();

    [Signature("method_24357")]
    public virtual partial bool Damage(DamageSource source);

    [Signature("method_31568")]
    public virtual partial bool CanBeNested();

    protected virtual bool TryGetWrapper(out Wrapper wrapper)
    {
        wrapper = default;
        return false;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Wrapper
    {
        
    }

    [MapName("class_1793")]
    public partial class Settings : Java.Lang.Object, IClassRef<Settings>, IFromHandle<Settings>
    {
        [JavaConstructor]
        public Settings() : base(Settings_Invoke())
        {}

        [Signature("method_19265")]
        public partial Settings Food(FoodComponent foodComponent);

        [Signature("method_7889")]
        public partial Settings MaxCount(int maxCount);

        [Signature("method_7898")]
        public partial Settings MaxDamageIfAbsent(int maxDamage);

        [Signature("method_7895")]
        public partial Settings MaxDamage(int maxDamage);

        [Signature("method_7896")]
        public partial Settings RecipeRemainder(Item recipeRemainder);

        [Signature("method_7894")]
        public partial Settings Rarity(Rarity rarity);

        [Signature("method_24359")]
        public partial Settings Fireproof();

        [Signature("method_45434")]
        public partial Settings Requires(JavaArray<FeatureFlag> features);
    }
}
