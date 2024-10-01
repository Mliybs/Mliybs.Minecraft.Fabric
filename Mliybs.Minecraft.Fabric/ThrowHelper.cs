using System.Diagnostics.CodeAnalysis;

namespace Mliybs.Minecraft.Fabric;

internal static class ThrowHelper
{
    
    public static void ThrowIfNull<T>([NotNull] T? obj, string message = "")
    {
        if (obj is null) throw new NullReferenceException($"{nameof(obj)}为空！\n附加消息：${message}");
    }

    public unsafe static void ThrowIfPtrIsNull<T>([NotNull] T* ptr) where T : unmanaged
    {
        if (ptr is null) throw new NullReferenceException($"{nameof(ptr)}为空指针！");
    }
    public unsafe static void ThrowIfPtrIsZero(nint ptr)
    {
        if (ptr == nint.Zero) throw new NullReferenceException($"{nameof(ptr)}为空指针！");
    }
}