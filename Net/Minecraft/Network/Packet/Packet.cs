using Net.Minecraft.Network.Listener;

namespace Net.Minecraft.Network.Packet;

[JavaInterface(typeof(IPacket<>))]
public partial class Packet<T> : JavaObject, IPacket<T>, IClassRef<Packet<T>>, IFromHandle<Packet<T>> where T : JavaObject, IPacketListener, IClassRef<T>, IFromHandle<T>
{
    internal static Names Names => Packet.Names;

    public static Class<Packet<PacketListener>> ClassRef => Packet.ClassRef;
    
    static Class<Packet<T>> IClassRef<Packet<T>>.ClassRef => Class.Proxy<Packet<T>>(ClassRef.ObjectRef);
}

[MapName("net/minecraft/class_2596"), StaticGeneric(typeof(Packet<>))]
public static partial class Packet
{
    public static Class<Packet<PacketListener>> ClassRef => _classRef;
}

[JavaInterface(typeof(Packet<>))]
public partial interface IPacket<T> where T : JavaObject, IPacketListener, IClassRef<T>, IFromHandle<T>
{
    public static Class<Packet<PacketListener>> ClassRef => Packet.ClassRef;
}