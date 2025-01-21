namespace Net.FabricMC.Loader.Api;

[MapName("net/fabricmc/loader/api/MappingResolver", false)]
public partial class MappingResolver : JavaObject, IClassRef<MappingResolver>, IFromHandle<MappingResolver>
{
    [Signature("getNamespaces", false)]
    public partial Java.Util.Collection<JavaString> GetNamespaces();

    [Signature("getCurrentRuntimeNamespace", false)]
    public partial string GetCurrentRuntimeNamespace();

    [Signature("mapClassName", false)]
    public partial string MapClassName(string @namespace, string className);

    [Signature("unmapClassName", false)]
    public partial string UnmapClassName(string targetNamespace, string className);

    [Signature("mapFieldName", false)]
    public partial string MapFieldName(string @namespace, string owner, string name, string descriptor);

    [Signature("mapMethodName", false)]
    public partial string MapMethodName(string @namespace, string owner, string name, string descriptor);
}
