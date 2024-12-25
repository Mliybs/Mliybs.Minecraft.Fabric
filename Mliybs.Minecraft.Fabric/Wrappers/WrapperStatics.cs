using System;

namespace Mliybs.Minecraft.Fabric.Wrappers;

internal static class WrapperStatics
{
    public delegate nint ObjectDelegate();

    public delegate int IntDelegate();

    public delegate bool BoolDelegate();

    public delegate void ObjectVoidDelegate(nint param1);

    public delegate void IntVoidDelegate(int param1);

    public delegate void LongVoidDelegate(long param1);
}