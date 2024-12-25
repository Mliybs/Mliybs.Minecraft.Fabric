namespace Mliybs.Minecraft.Fabric.Internals;

internal interface IWrapper<T> : IDisposable where T : JavaObject, IWrapper<T>
{
}