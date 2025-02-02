using Net.Minecraft.Util;

namespace Net.FabricMC.Fabric.Api.Event;

public partial class Event<T, K> : JavaObject, IClassRef<Event<T, K>>, IFromHandle<Event<T, K>> where T : JavaObject, IFunctionalInterface<T, K>, IClassRef<T>, IFromHandle<T> where K : Delegate
{
    internal static Names Names => Event.Names;

    public static Class<Event<FunctionalInterface, Action>> ClassRef => Event.ClassRef;
    
    static Class<Event<T, K>> IClassRef<Event<T, K>>.ClassRef => Class.Proxy<Event<T, K>>(ClassRef.ObjectRef);

    [Signature("invoker", false)]
    public partial T Invoker();

    [Signature("register", false)]
    public partial void Register(T listener);

    public void Register(K listener) => Register(T.ToObject(listener));

    [Signature("register", false)]
    public partial void Register(Identifier phase, T listener);

    public void Register(Identifier phase, K listener) => Register(phase, T.ToObject(listener));

    [Signature("addPhaseOrdering", false)]
    public partial void AddPhaseOrdering(Identifier firstPhase, Identifier secondPhase);
}

[MapName("net/fabricmc/fabric/api/event/Event", false), StaticGeneric(typeof(Event<,>))]
public static partial class Event
{
    public static Class<Event<FunctionalInterface, Action>> ClassRef => _classRef;
}