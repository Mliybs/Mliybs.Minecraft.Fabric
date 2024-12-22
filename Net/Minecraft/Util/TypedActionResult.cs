namespace Net.Minecraft.Util;

public partial class TypedActionResult<T> : JavaObject, IClassRef<TypedActionResult<T>>, IFromHandle<TypedActionResult<T>> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => TypedActionResult.Names;

    public static Class<TypedActionResult<JavaObject>> ClassRef => TypedActionResult.ClassRef;

    static Class<TypedActionResult<T>> IClassRef<TypedActionResult<T>>.ClassRef => new(ClassRef.ObjectRef);
}

[MapName("net/minecraft/class_1271"), StaticGeneric(typeof(TypedActionResult<>))]
public static partial class TypedActionResult
{}
