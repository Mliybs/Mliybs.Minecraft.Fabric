#if USE_SLF4J
using System;

namespace Org.Slf4j;


[MapName("org.slf4j.Logger", false), JavaInterface(typeof(ILogger))]
public partial class Logger : Java.Lang.Object, IClassRef, IFromHandle<Logger>, ILogger
{
    [Signature("info", false)]
    public partial void Info(string msg);
}

[JavaInterface(typeof(Logger))]
public partial interface ILogger : IJavaClass
{
    void Info(string msg);
}
#endif