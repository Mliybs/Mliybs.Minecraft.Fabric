using Java.Util.Function;
using Net.Minecraft.Util.Math;

namespace Net.Minecraft.World;

[MapName("net/minecraft/class_5281"), JavaInterface(typeof(IStructureWorldAccess))]
public partial class StructureWorldAccess : ServerWorldAccess, IStructureWorldAccess, IClassRef<StructureWorldAccess>, IFromHandle<StructureWorldAccess>
{
    [Signature("method_8412")]
    public partial long GetSeed();

    [Signature("method_37368")]
    public partial bool IsValidForSetBlock(BlockPos pos);

    [Signature("method_36972")]
    public partial void SetCurrentlyGeneratingStructureName(Supplier.SupplierDelegate<JavaString>? structureName);
}

[JavaInterface(typeof(StructureWorldAccess))]
public partial interface IStructureWorldAccess : IServerWorldAccess
{
    long GetSeed();

    public bool IsValidForSetBlock(BlockPos pos) => StructureWorldAccess.IsValidForSetBlockProxy(ObjectRef, pos);

    public void SetCurrentlyGeneratingStructureName(Supplier.SupplierDelegate<JavaString>? structureName) => StructureWorldAccess.SetCurrentlyGeneratingStructureNameProxy(ObjectRef, structureName);
}