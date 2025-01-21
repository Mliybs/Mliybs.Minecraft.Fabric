using Net.Minecraft.Block;

namespace Net.Minecraft.World.Event;

[MapName("net/minecraft/class_5712")]
public partial class GameEvent : JavaObject, IClassRef<GameEvent>, IFromHandle<GameEvent>
{
    [MapName("class_7397")]
    public partial class Emitter : Record, IClassRef<Emitter>, IFromHandle<Emitter>
    {
        [JavaConstructor]
        public Emitter(Minecraft.Entity.Entity? sourceEntity, BlockState? affectedState) : base(Emitter_EntityBlockStateInvoke(sourceEntity, affectedState))
        {}

        [Signature("method_43285")]
        public static partial Emitter Of(Minecraft.Entity.Entity? sourceEntity);

        [Signature("method_43287")]
        public static partial Emitter Of(BlockState? affectedState);

        [Signature("method_43286")]
        public static partial Emitter Of(Minecraft.Entity.Entity? sourceEntity, BlockState? affectedState);

        [Signature("comp_713")]
        public partial Minecraft.Entity.Entity? SourceEntity();

        [Signature("comp_714")]
        public partial BlockState? AffectedState();
    }
}
