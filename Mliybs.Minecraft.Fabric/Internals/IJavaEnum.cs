#if false
namespace Mliybs.Minecraft.Fabric.Internals
{
    public partial interface IJavaEnum<T> where T : JavaClass, IJavaEnum<T>, IClassRef<IJavaEnum<T>>, IFromHandle<T>
    {
        static abstract T ValueOf(string name);
    }
}
#endif
