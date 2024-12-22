using Net.Minecraft.Item;
using Net.Minecraft.World.Event;

namespace Net.Minecraft.Registry;

[MapName("net/minecraft/class_7923")]
public partial class Registries : JavaObject, IClassRef<Registries>, IFromHandle<Registries>
{
    [Signature("field_41171")]
    public static DefaultedRegistry<GameEvent> GAME_EVENT { get; private set; }

    [Signature("field_41178")]
    public static DefaultedRegistry<Item.Item> ITEM { get; private set; }
}