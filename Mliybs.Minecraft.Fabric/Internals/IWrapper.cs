namespace Mliybs.Minecraft.Fabric.Internals;

public interface IWrapper<T> : IConstructor where T : JavaClass, IWrapper<T>
{
    internal static abstract Class WrapperClassRef { get; }
}