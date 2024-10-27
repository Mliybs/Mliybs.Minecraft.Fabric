namespace Mliybs.Minecraft.Fabric.Internals
{
    public partial interface IJavaEnum<T> where T : JavaClass, IJavaEnum<T>, IClassRef, IFromHandle<T>
    {
        static abstract T ValueOf(string name);
    }
}
