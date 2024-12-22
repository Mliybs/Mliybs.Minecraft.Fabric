namespace Java.Lang;

[MapName("java.lang.Runnable")]
public partial class Runnable : JavaObject, IClassRef<Runnable>, IFromHandle<Runnable>
{
    [Signature("run", false)]
    public partial void Run();

    public delegate void RunnableDelegate();

    internal static RunnableDelegate Handle(RunnableDelegate @delegate) => @delegate;
}