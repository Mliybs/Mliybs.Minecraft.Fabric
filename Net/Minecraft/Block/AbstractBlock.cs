namespace Net.Minecraft.Block;

[MapName("net/minecraft/class_4970")]
public partial class AbstractBlock : JavaObject, IClassRef<AbstractBlock>, IFromHandle<AbstractBlock>
{
    [MapName("class_4971")]
    public partial class AbstractBlockState : JavaObject, IClassRef<AbstractBlockState>, IFromHandle<AbstractBlockState>
    {
        [Signature("method_26204")]
        public partial Block GetBlock();

        [Signature("method_26215")]
        public partial bool IsAir();
    }
}
