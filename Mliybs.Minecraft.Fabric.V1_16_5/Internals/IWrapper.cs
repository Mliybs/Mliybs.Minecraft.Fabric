namespace Mliybs.Minecraft.Fabric.V1_16_5.Internals;

public interface IWrapper : IConstructor
{
    internal static abstract IntPtr WrapperClassRef { get;}

    internal static abstract IntPtr[] WrapperConstructors { get; }
}