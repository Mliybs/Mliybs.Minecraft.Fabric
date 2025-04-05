using Net.Minecraft.Server.World;

namespace Net.Minecraft.World;

[MapName("net/minecraft/class_5425"), JavaInterface(typeof(IServerWorldAccess))]
public partial class ServerWorldAccess : WorldAccess, IServerWorldAccess, IClassRef<ServerWorldAccess>, IFromHandle<ServerWorldAccess>
{
    [Signature("method_8410")]
    public partial ServerWorld ToServerWorld();

    [Signature("method_30771")]
    public partial void SpawnEntityAndPassengers(Minecraft.Entity.Entity entity);
}

[JavaInterface(typeof(ServerWorldAccess))]
public partial interface IServerWorldAccess : IWorldAccess
{
    ServerWorld ToServerWorld();

    public void SpawnEntityAndPassengers(Minecraft.Entity.Entity entity) => ServerWorldAccess.SpawnEntityAndPassengersProxy(ObjectRef, entity);
}