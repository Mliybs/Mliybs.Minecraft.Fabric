using Net.Minecraft.World.Event;

namespace Net.Minecraft.Registry;

[MapName("net/minecraft/class_7923")]
public partial class Registries : Java.Lang.Object, IClassRef<Registries>, IFromHandle<Registries>
{
    [Signature("field_41171")]
    public static DefaultedRegistry<GameEvent> GAME_EVENT { get; private set; }
}