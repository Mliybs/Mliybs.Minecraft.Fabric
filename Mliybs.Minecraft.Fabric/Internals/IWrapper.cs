namespace Mliybs.Minecraft.Fabric.Internals;

internal interface IWrapper<T> where T : JavaObject, IWrapper<T>
{
}