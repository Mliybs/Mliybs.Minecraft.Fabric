using System.Reflection;

namespace Net.Minecraft.Item;

public partial class Item
{
    private static readonly Lazy<List<Item>> Instances = new(() => []);

    public static IntPtr WrapperClassRef { get; } = FindClass("com/mlinetles/nativeloader/wrappers/ItemWrapper");

    public static IntPtr[] WrapperConstructors { get; } = [GetConstructorID(WrapperClassRef, $"(L{Settings.Names.MapSignature};J)V")];

    protected unsafe Item(Settings settings, bool isWrapper)
    {
        if (isWrapper)
        {
            Instances.Value.Add(this);

            var type = GetType();
            
            var wrapper = new ItemWrapper()
            {
                GetTranslationKey = type
                    .GetMethod(nameof(GetTranslationKey), BindingFlags.Instance | BindingFlags.NonPublic)
                    .IsOverride() ? &GetTranslationKeyStatic : null
            };

            ObjectRef = ((Method4Ptr)Env->Functions->NewObject)(Env, WrapperClassRef, WrapperConstructors[0], settings.ObjectRef, (nint)(&wrapper));
        }
        
        else
        {
            ObjectRef = ((Method3Ptr)Env->Functions->NewObject)(Env, ClassRef, Constructors[0], settings.ObjectRef);
        }
    }

    private static IntPtr GetTranslationKeyStatic(IntPtr obj)
    {
        var instance = Instances.Value.Find(x => IsSameObject(x.ObjectRef, obj)) ?? throw new ArgumentException($"调用的方法没有被注册！");
        return NewString(instance.GetTranslationKey());
    }

    protected internal virtual string GetTranslationKey() => "item.mlinetles.dnmd";

    ~Item()
    {
        Instances.Value.Remove(this);
    }
    
    [StructLayout(LayoutKind.Sequential)]
    private unsafe struct ItemWrapper
    {
        public required delegate*<IntPtr, IntPtr> GetTranslationKey;
    }
}