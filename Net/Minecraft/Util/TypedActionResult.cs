namespace Net.Minecraft.Util;

public partial class TypedActionResult<T> : JavaObject, IClassRef<TypedActionResult<T>>, IFromHandle<TypedActionResult<T>> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => TypedActionResult.Names;

    public static Class<TypedActionResult<JavaObject>> ClassRef => TypedActionResult.ClassRef;

    static Class<TypedActionResult<T>> IClassRef<TypedActionResult<T>>.ClassRef => Class.Proxy<TypedActionResult<T>>(ClassRef.ObjectRef);

    [JavaConstructor]
    public TypedActionResult(ActionResult result, T value) : base(TypedActionResult_ActionResultObjectInvoke(result, value))
    {}

    [Signature("method_5467")]
    public partial ActionResult GetResult();

    [Signature("method_5466")]
    public partial T GetValue();
}

[MapName("net/minecraft/class_1271"), StaticGeneric(typeof(TypedActionResult<>))]
public static partial class TypedActionResult
{
    [Signature("method_22427")]
    public static partial TypedActionResult<T> Success<T>(T data) where T : JavaObject, IClassRef<T>, IFromHandle<T>;

    [Signature("method_22428")]
    public static partial TypedActionResult<T> Consume<T>(T data) where T : JavaObject, IClassRef<T>, IFromHandle<T>;

    [Signature("method_22430")]
    public static partial TypedActionResult<T> Pass<T>(T data) where T : JavaObject, IClassRef<T>, IFromHandle<T>;

    [Signature("method_22431")]
    public static partial TypedActionResult<T> Fail<T>(T data) where T : JavaObject, IClassRef<T>, IFromHandle<T>;

    [Signature("method_29237")]
    public static partial TypedActionResult<T> Success<T>(T data, bool swingHand) where T : JavaObject, IClassRef<T>, IFromHandle<T>;
}
