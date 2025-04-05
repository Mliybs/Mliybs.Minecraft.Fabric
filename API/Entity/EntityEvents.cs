using Net.Minecraft.Block;

namespace Mliybs.Minecraft.Fabric.API.Entity;

[MapName("com.mlinetles.nativeloader.api.entity.EntityEvents", false)]
public partial class EntityEvents : JavaObject, IClassRef<EntityEvents>, IFromHandle<EntityEvents>
{
    [MapName("BlockCollisionEvent", false)]
    public partial class BlockCollisionEvent : JavaObject, IClassRef<BlockCollisionEvent>, IFromHandle<BlockCollisionEvent>, IFunctionalInterface<BlockCollisionEvent, BlockCollisionEvent.BlockCollisionEventDelegate>
    {
        [Signature("invoke", false)]
        public partial void Invoke(MCEntity entity, BlockState state, int id);

        public delegate void BlockCollisionEventDelegate(MCEntity entity, BlockState state, int id);

        internal delegate void BlockCollisionEventDelegateHandler(nint entity, nint state, int id);

        internal static BlockCollisionEventDelegateHandler? Handle(BlockCollisionEventDelegate? @delegate) => @delegate is null ? null : (entity, state, id) => @delegate.Invoke(MCEntity.From(entity), BlockState.From(state), id);

        static BlockCollisionEvent IFunctionalInterface<BlockCollisionEvent, BlockCollisionEventDelegate>.ToObject(BlockCollisionEventDelegate @delegate) =>
            new(InvocationHandlerWrapper.GetProxyOf(ClassRef, Handle(@delegate)));
    }
}