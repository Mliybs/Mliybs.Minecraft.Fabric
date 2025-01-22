namespace Mliybs.Minecraft.Fabric;

public class JavaException : Exception
{
    public Throwable InnerObject { get; }

    public JavaException(Throwable obj) : base(obj.ToString())
    {
        InnerObject = obj;
    }
}