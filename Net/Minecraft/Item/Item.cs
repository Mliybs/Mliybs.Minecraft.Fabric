using System.Collections.Concurrent;
using Com.Google.Common.Collect;
using Net.Minecraft.Resource.FeatureToggle;
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
public partial class Item : JavaObject, IClassRef<Item>, IFromHandle<Item>, IWrapper<Item>, IItemConvertible, IToggleableFeature
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

    protected virtual void UsageTickHandler(nint world, nint user, nint stack, int remainingUseTicks) => UsageTick(World.World.From(world), LivingEntity.From(user), ItemStack.From(stack), remainingUseTicks);

    protected delegate void UsageTickDelegate(nint world, nint user, nint stack, int remainingUseTicks);

    [Signature("method_33261")]
    public virtual partial void OnItemEntityDestroyed(ItemEntity entity);

    protected virtual void OnItemEntityDestroyedHandler(nint entity) => OnItemEntityDestroyed(ItemEntity.From(entity));

    protected delegate void OnItemEntityDestroyedDelegate(nint entity);

    [Signature("method_7860")]
    public virtual partial void PostProcessNbt(NbtCompound nbt);

    protected virtual void PostProcessNbtHandler(nint nbt) => PostProcessNbt(NbtCompound.From(nbt));

    protected delegate void PostProcessNbtDelegate(nint nbt);

    [Signature("method_7885")]
    public virtual partial bool CanMine(BlockState state, World.World world, BlockPos pos, PlayerEntity miner);

    protected virtual bool CanMineHandler(nint state, nint world, nint pos, nint miner) => CanMine(BlockState.From(state), World.World.From(world), BlockPos.From(pos), PlayerEntity.From(miner));

    protected delegate bool CanMineDelegate(nint state, nint world, nint pos, nint miner);

    [Signature("method_7884")]
    public virtual partial ActionResult UseOnBlock(ItemUsageContext context);

    protected virtual nint UseOnBlockHandler(nint context) => UseOnBlock(ItemUsageContext.From(context)).ObjectRef;

    protected delegate nint UseOnBlockDelegate(nint context);

    [Signature("method_7865")]
    public virtual partial float GetMiningSpeedMultiplier(ItemStack stack, BlockState state);

    protected virtual float GetMiningSpeedMultiplierHandler(nint stack, nint state) => GetMiningSpeedMultiplier(ItemStack.From(stack), BlockState.From(state));

    protected delegate float GetMiningSpeedMultiplierDelegate(nint stack, nint state);

    [Signature("method_7836")]
    public virtual partial TypedActionResult<ItemStack> Use(World.World world, PlayerEntity user, Hand hand);

    protected virtual nint UseHandler(nint world, nint user, nint hand) => Use(World.World.From(world), PlayerEntity.From(user), Hand.From(hand)).ObjectRef;

    protected delegate nint UseDelegate(nint world, nint user, nint hand);

    [Signature("method_7861")]
    public virtual partial ItemStack FinishUsing(ItemStack stack, World.World world, LivingEntity user);

    protected virtual nint FinishUsingHandler(nint stack, nint world, nint user) => FinishUsing(ItemStack.From(stack), World.World.From(world), LivingEntity.From(user)).ObjectRef;

    protected delegate nint FinishUsingDelegate(nint stack, nint world, nint user);

    [Signature("method_7882")]
    public partial int GetMaxCount();

    [Signature("method_7841")]
    public partial int GetMaxDamage();

    [Signature("method_7846")]
    public virtual partial bool IsDamageable();

    [Signature("method_31567")]
    public virtual partial bool IsItemBarVisible(ItemStack stack);

    protected virtual bool IsItemBarVisibleHandler(nint stack) => IsItemBarVisible(ItemStack.From(stack));

    protected delegate bool IsItemBarVisibleDelegate(nint stack);

    [Signature("method_31569")]
    public virtual partial int GetItemBarStep(ItemStack stack);

    protected virtual int GetItemBarStepHandler(nint stack) => GetItemBarStep(ItemStack.From(stack));

    protected delegate int GetItemBarStepDelegate(nint stack);

    [Signature("method_31571")]
    public virtual partial int GetItemBarColor(ItemStack stack);

    protected virtual int GetItemBarColorHandler(nint stack) => GetItemBarColor(ItemStack.From(stack));

    protected delegate int GetItemBarColorDelegate(nint stack);

    [Signature("method_31565")]
    public virtual partial bool OnStackClicked(ItemStack stack, Slot slot, ClickType clickType, PlayerEntity player);

    protected virtual bool OnStackClickedHandler(nint stack, nint slot, nint clickType, nint player) => OnStackClicked(ItemStack.From(stack), Slot.From(slot), ClickType.From(clickType), PlayerEntity.From(player));

    protected delegate bool OnStackClickedDelegate(nint stack, nint slot, nint clickType, nint player);

    [Signature("method_31566")]
    public virtual partial bool OnClicked(ItemStack stack, ItemStack otherStack, Slot slot, ClickType clickType, PlayerEntity player, StackReference cursorStackReference);

    protected virtual bool OnClickedHandler(nint stack, nint otherStack, nint slot, nint clickType, nint player, nint cursorStackReference) => OnClicked(ItemStack.From(stack), ItemStack.From(otherStack), Slot.From(slot), ClickType.From(clickType), PlayerEntity.From(player), StackReference.From(cursorStackReference));

    protected delegate bool OnClickedDelegate(nint stack, nint otherStack, nint slot, nint clickType, nint player, nint cursorStackReference);

    [Signature("method_7873")]
    public virtual partial bool PostHit(ItemStack stack, LivingEntity target, LivingEntity attacker);

    protected virtual bool PostHitHandler(nint stack, nint target, nint attacker) => PostHit(ItemStack.From(stack), LivingEntity.From(target), LivingEntity.From(attacker));

    protected delegate bool PostHitDelegate(nint stack, nint target, nint attacker);

    [Signature("method_7879")]
    public virtual partial bool PostMine(ItemStack stack, World.World world, BlockState state, BlockPos pos, LivingEntity miner);

    protected virtual bool PostMineHandler(nint stack, nint world, nint state, nint pos, nint miner) => PostMine(ItemStack.From(stack), World.World.From(world), BlockState.From(state), BlockPos.From(pos), LivingEntity.From(miner));

    protected delegate bool PostMineDelegate(nint stack, nint world, nint state, nint pos, nint miner);

    [Signature("method_7856")]
    public virtual partial bool IsSuitableFor(BlockState state);

    protected virtual bool IsSuitableForHandler(nint state) => IsSuitableFor(BlockState.From(state));

    protected delegate bool IsSuitableForDelegate(nint state);

    [Signature("method_7847")]
    public virtual partial ActionResult UseOnEntity(ItemStack stack, PlayerEntity user, LivingEntity entity, Hand hand);

    protected virtual nint UseOnEntityHandler(nint stack, nint user, nint entity, nint hand) => UseOnEntity(ItemStack.From(stack), PlayerEntity.From(user), LivingEntity.From(entity), Hand.From(hand)).ObjectRef;

    protected delegate nint UseOnEntityDelegate(nint stack, nint user, nint entity, nint hand);

    [Signature("method_7848")]
    public virtual partial Text.Text GetName();

    protected virtual nint GetNameHandler() => GetName().ObjectRef;

    protected delegate nint GetNameDelegate();

    [Signature("method_7869")]
    protected virtual partial string GetOrCreateTranslationKey();

    protected virtual nint GetOrCreateTranslationKeyHandler() => NewString(GetOrCreateTranslationKey());

    protected delegate nint GetOrCreateTranslationKeyDelegate();

    [Signature("method_7876")]
    public virtual partial string GetTranslationKey();

    protected virtual nint GetTranslationKeyHandler() => NewString(GetTranslationKey());

    protected delegate nint GetTranslationKeyDelegate();

    [Signature("method_7866"), AlterDelegate(nameof(GetTranslationKeyDelegate_ItemStack))]
    public virtual partial string GetTranslationKey(ItemStack stack);

    protected virtual nint GetTranslationKeyHandler(nint stack) => NewString(GetTranslationKey(ItemStack.From(stack)));

    protected delegate nint GetTranslationKeyDelegate_ItemStack(nint stack);

    [Signature("method_7887")]
    public virtual partial bool IsNbtSynced();

    protected virtual bool IsNbtSyncedHandler() => IsNbtSynced();

    protected delegate bool IsNbtSyncedDelegate();

    [Signature("method_7858")]
    public partial Item? GetRecipeRemainder();

    [Signature("method_7857")]
    public virtual partial bool HasRecipeRemainder();

    protected virtual bool HasRecipeRemainderHandler() => HasRecipeRemainder();

    protected delegate bool HasRecipeRemainderDelegate();

    [Signature("method_7888")]
    public virtual partial void InventoryTick(ItemStack stack, World.World world, Entity.Entity entity, int slot, bool selected);

    protected virtual void InventoryTickHandler(nint stack, nint world, nint entity, int slot, bool selected) => InventoryTick(ItemStack.From(stack), World.World.From(world), Entity.Entity.From(entity), slot, selected);

    protected delegate void InventoryTickDelegate(nint stack, nint world, nint entity, int slot, bool selected);

    [Signature("method_54465")]
    public virtual partial void OnCraftByPlayer(ItemStack stack, World.World world, PlayerEntity player);

    protected virtual void OnCraftByPlayerHandler(nint stack, nint world, nint player) => OnCraftByPlayer(ItemStack.From(stack), World.World.From(world), PlayerEntity.From(player));

    protected delegate void OnCraftByPlayerDelegate(nint stack, nint world, nint player);

    [Signature("method_7843")]
    public virtual partial void OnCraft(ItemStack stack, World.World world);

    protected virtual void OnCraftHandler(nint stack, nint world) => OnCraft(ItemStack.From(stack), World.World.From(world));

    protected delegate void OnCraftDelegate(nint stack, nint world);

    [Signature("method_16698")]
    public virtual partial bool IsNetworkSynced();

    protected virtual bool IsNetworkSyncedHandler() => IsNetworkSynced();

    protected delegate bool IsNetworkSyncedDelegate();

    [Signature("method_7853")]
    public virtual partial UseAction GetUseAction(ItemStack stack);

    protected virtual nint GetUseActionHandler(nint stack) => GetUseAction(ItemStack.From(stack)).ObjectRef;

    protected delegate nint GetUseActionDelegate(nint stack);

    [Signature("method_7881")]
    public virtual partial int GetMaxUseTime(ItemStack stack);

    protected virtual int GetMaxUseTimeHandler(nint stack) => GetMaxUseTime(ItemStack.From(stack));

    protected delegate int GetMaxUseTimeDelegate(nint stack);

    [Signature("method_7840")]
    public virtual partial void OnStoppedUsing(ItemStack stack, World.World world, LivingEntity user, int remainingUseTicks);

    protected virtual void OnStoppedUsingHandler(nint stack, nint world, nint user, int remainingUseTicks) => OnStoppedUsing(ItemStack.From(stack), World.World.From(world), LivingEntity.From(user), remainingUseTicks);

    protected delegate void OnStoppedUsingDelegate(nint stack, nint world, nint user, int remainingUseTicks);

    [Signature("method_7851")]
    public virtual partial void AppendTooltip(ItemStack stack, World.World? world, Java.Util.List<Text.Text> tooltip, TooltipContext context);

    protected virtual void AppendTooltipHandler(nint stack, nint world, nint tooltip, nint context) => AppendTooltip(ItemStack.From(stack), World.World.From(world), Java.Util.List<Text.Text>.From(tooltip), TooltipContext.From(context));

    protected delegate void AppendTooltipDelegate(nint stack, nint world, nint tooltip, nint context);

    [Signature("method_32346")]
    public virtual partial Optional<TooltipData> GetTooltipData(ItemStack stack);

    protected virtual nint GetTooltipDataHandler(nint stack) => GetTooltipData(ItemStack.From(stack)).ObjectRef;

    protected delegate nint GetTooltipDataDelegate(nint stack);

    [Signature("method_7864"), AlterDelegate(nameof(GetNameDelegate_ItemStack))]
    public virtual partial Text.Text GetName(ItemStack stack);

    protected virtual nint GetNameHandler(nint stack) => GetName(ItemStack.From(stack)).ObjectRef;

    protected delegate nint GetNameDelegate_ItemStack(nint stack);

    [Signature("method_7886")]
    public virtual partial bool HasGlint(ItemStack stack);

    protected virtual bool HasGlintHandler(nint stack) => HasGlint(ItemStack.From(stack));

    protected delegate bool HasGlintDelegate(nint stack);

    [Signature("method_7862")]
    public virtual partial Rarity GetRarity(ItemStack stack);

    protected virtual nint GetRarityHandler(nint stack) => GetRarity(ItemStack.From(stack)).ObjectRef;

    protected delegate nint GetRarityDelegate(nint stack);

    [Signature("method_7870")]
    public virtual partial bool IsEnchantable(ItemStack stack);

    protected virtual bool IsEnchantableHandler(nint stack) => IsEnchantable(ItemStack.From(stack));

    protected delegate bool IsEnchantableDelegate(nint stack);

    [Signature("method_7872")]
    protected static partial BlockHitResult Raycast(World.World world, PlayerEntity player, RaycastContext.FluidHandling fluidHandling);

    [Signature("method_7837")]
    public virtual partial int GetEnchantability();

    [Signature("method_7878")]
    public virtual partial bool CanRepair(ItemStack stack, ItemStack ingredient);

    protected virtual bool CanRepairHandler(nint stack, nint ingredient) => CanRepair(ItemStack.From(stack), ItemStack.From(ingredient));

    protected delegate bool CanRepairDelegate(nint stack, nint ingredient);

    [Signature("method_7844")]
    public virtual partial Multimap<EntityAttribute, EntityAttributeModifier> GetAttributeModifiers(EquipmentSlot slot);

    protected virtual nint GetAttributeModifiersHandler(nint slot) => GetAttributeModifiers(EquipmentSlot.From(slot)).ObjectRef;

    protected delegate nint GetAttributeModifiersDelegate(nint slot);

    [Signature("method_7838")]
    public virtual partial bool IsUsedOnRelease(ItemStack stack);

    protected virtual bool IsUsedOnReleaseHandler(nint stack) => IsUsedOnRelease(ItemStack.From(stack));

    protected delegate bool IsUsedOnReleaseDelegate(nint stack);

    [Signature("method_7854")]
    public virtual partial ItemStack GetDefaultStack();

    protected virtual nint GetDefaultStackHandler() => GetDefaultStack().ObjectRef;

    protected delegate nint GetDefaultStackDelegate();

    [Signature("method_19263")]
    public virtual partial bool IsFood();

    protected virtual bool IsFoodHandler() => IsFood();

    protected delegate bool IsFoodDelegate();

    [Signature("method_19264")]
    public virtual partial FoodComponent? GetFoodComponent();

    protected virtual nint GetFoodComponentHandler() => GetFoodComponent()?.ObjectRef ?? nint.Zero;

    protected delegate nint GetFoodComponentDelegate();

    [Signature("method_21831")]
    public virtual partial SoundEvent GetDrinkSound();

    protected virtual nint GetDrinkSoundHandler() => GetDrinkSound().ObjectRef;

    protected delegate nint GetDrinkSoundDelegate();

    [Signature("method_21830")]
    public virtual partial SoundEvent GetEatSound();

    protected virtual nint GetEatSoundHandler() => GetEatSound().ObjectRef;

    protected delegate nint GetEatSoundDelegate();

    [Signature("method_24358")]
    public virtual partial bool IsFireproof();

    protected virtual bool IsFireproofHandler() => IsFireproof();

    protected delegate bool IsFireproofDelegate();

    [Signature("method_24357")]
    public virtual partial bool Damage(DamageSource source);

    protected virtual bool DamageHandler(nint source) => Damage(DamageSource.From(source));

    protected delegate bool DamageDelegate(nint source);

    [Signature("method_31568")]
    public virtual partial bool CanBeNested();

    protected virtual bool CanBeNestedHandler() => CanBeNested();

    protected delegate bool CanBeNestedDelegate();

    protected virtual bool TryGetWrapper(out Wrapper wrapper)
    {
        wrapper = default;
        return false;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct Wrapper
    {
        public nint AsItem;
        public nint GetRequiredFeatures;
        public nint UsageTick;
        public nint OnItemEntityDestroyed;
        public nint PostProcessNbt;
        public nint CanMine;
        public nint UseOnBlock;
        public nint GetMiningSpeedMultiplier;
        public nint Use;
        public nint FinishUsing;
        public nint IsItemBarVisible;
        public nint GetItemBarStep;
        public nint GetItemBarColor;
        public nint OnStackClicked;
        public nint OnClicked;
        public nint PostHit;
        public nint PostMine;
        public nint IsSuitableFor;
        public nint UseOnEntity;
        public nint GetName;
        public nint GetOrCreateTranslationKey;
        public nint GetTranslationKey;
        public nint GetTranslationKey_ItemStack;
        public nint IsNbtSynced;
        public nint HasRecipeRemainder;
        public nint InventoryTick;
        public nint OnCraftByPlayer;
        public nint OnCraft;
        public nint IsNetworkSynced;
        public nint GetUseAction;
        public nint GetMaxUseTime;
        public nint OnStoppedUsing;
        public nint AppendTooltip;
        public nint GetTooltipData;
        public nint GetName_ItemStack;
        public nint HasGlint;
        public nint GetRarity;
        public nint IsEnchantable;
        public nint CanRepair;
        public nint GetAttributeModifiers;
        public nint GetDefaultStack;
        public nint IsFood;
        public nint GetFoodComponent;
        public nint GetDrinkSound;
        public nint GetEatSound;
        public nint IsFireproof;
        public nint Damage;
        public nint CanBeNested;
    }

    [MapName("class_1793")]
    public partial class Settings : JavaObject, IClassRef<Settings>, IFromHandle<Settings>
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
