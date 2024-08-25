namespace Net.Minecraft.Item;

public partial class FoodComponent(IntPtr handle) : JavaClass(handle), IClassRef
{
    internal static readonly Names Names = MapClassName("net.minecraft.class_4174");

    public static IntPtr ClassRef { get; } = FindClass(Names.MapSignature);

    public partial class Builder : JavaClass, IConstructor
    {
        internal static readonly Names Names = MapClassName("net.minecraft.class_4174$class_4175");

        public static IntPtr ClassRef { get; } = FindClass(Names.MapSignature);

        public static IntPtr[] Constructors { get; } = [GetConstructorID(ClassRef, $"()V")];

        public unsafe Builder()
        {
            ObjectRef = ((Method2Ptr)Env->Functions->NewObject)(Env, ClassRef, Constructors[0]);
        }

        public unsafe Builder AlwaysEdible() => this.ReturnCheck(null, ((Method2Ptr)Env->Functions->CallObjectMethod)(Env, ObjectRef, AlwaysEdible_));

        public unsafe FoodComponent Build() => new(((Method2Ptr)Env->Functions->CallObjectMethod)(Env, ObjectRef, Build_));
    }
}