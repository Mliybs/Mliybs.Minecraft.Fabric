namespace Mliybs.Minecraft.Fabric;

public class JavaException : Exception
{
    public JavaObject InnerObject { get; }

    public JavaException(JavaObject obj) : base(obj.ToString())
    {
        InnerObject = obj;
    }
}