namespace Net.Minecraft.Item;

public partial class Item : JavaClass, IWrapper
{
    internal static readonly Names Names = MapClassName("net.minecraft.class_1792");

    public static IntPtr ClassRef { get; } = FindClass(Names.MapSignature);

    public static IntPtr[] Constructors { get; } = [GetConstructorID(ClassRef, $"(L{Settings.Names.MapSignature};)V")];

    public Item(Settings settings) : this(settings, false) {}

    public Item(IntPtr handle) : base(handle) {}

    public partial class Settings : JavaClass, IConstructor
    {
        internal static readonly Names Names = MapClassName("net.minecraft.class_1792$class_1793");

        public static IntPtr ClassRef { get; } = FindClass(Names.MapSignature);

        public static IntPtr[] Constructors { get; } = [GetConstructorID(ClassRef, "()V")];

        public unsafe Settings()
        {
            ObjectRef = ((Method2Ptr)Env->Functions->NewObject)(Env, ClassRef, Constructors[0]);
        }

        public Settings(IntPtr handle) : base(handle) {}

        public unsafe Settings Food(FoodComponent foodComponent) => this.ReturnCheck(null, ((Method3Ptr)Env->Functions->CallObjectMethod)(Env, ObjectRef, Food_, foodComponent.ObjectRef));

        public unsafe Settings Fireproof() => this.ReturnCheck(null, ((Method2Ptr)Env->Functions->CallObjectMethod)(Env, ObjectRef, Fireproof_));

        public unsafe Settings MaxCount(int maxCount) => this.ReturnCheck(null, ((delegate* unmanaged[Stdcall]<JNIEnv*, IntPtr, IntPtr, int, IntPtr>)Env->Functions->CallObjectMethod)(Env, ObjectRef, MaxCount_Int, maxCount));
    }
}