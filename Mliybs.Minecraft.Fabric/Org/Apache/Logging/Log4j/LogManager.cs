using System;

namespace Org.Apache.Logging.Log4j;

[MapName("org/apache/logging/log4j/LogManager", false)]
public partial class LogManager : JavaObject, IClassRef<LogManager>, IFromHandle<LogManager>
{
    [Signature("getLogger", false)]
    public static partial Logger GetLogger(string name);
}
