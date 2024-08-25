namespace Mliybs.Minecraft.Fabric.V1_16_5.Internals;

public interface IConstructor : IClassRef
{
    internal static abstract IntPtr[] Constructors { get; }
}