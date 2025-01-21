namespace Net.Minecraft.World.Tick;

[JavaInterface(typeof(IQueryableTickScheduler<>))]
public partial class QueryableTickScheduler<T> : JavaObject, IClassRef<QueryableTickScheduler<T>>, IFromHandle<QueryableTickScheduler<T>> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => QueryableTickScheduler.Names;

    public static Class<QueryableTickScheduler<JavaObject>> ClassRef => QueryableTickScheduler.ClassRef;

    static Class<QueryableTickScheduler<T>> IClassRef<QueryableTickScheduler<T>>.ClassRef => Class.Proxy<QueryableTickScheduler<T>>(ClassRef.ObjectRef);
}

[MapName("net/minecraft/class_6756"), StaticGeneric(typeof(QueryableTickScheduler<>))]
public static partial class QueryableTickScheduler
{}

[JavaInterface(typeof(QueryableTickScheduler<>))]
public partial interface IQueryableTickScheduler<T> where T : JavaObject, IClassRef<T>, IFromHandle<T>
{}