using System;

namespace Mliybs.Minecraft.Fabric.Debugging;

public static class DebugExtensions
{
    public static nint GetObjectRef(this IJavaClass obj) => obj.ObjectRef;
}