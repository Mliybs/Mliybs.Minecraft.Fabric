using System;
using System.Collections.Generic;

namespace Org.Apache.Logging.Log4j
{
    [JavaInterface]
    public partial class Logger : JavaClass, IClassRef, IFromHandle<Logger>
    {
        public static nint ClassRef { get; } = FindClass("org/apache/logging/log4j/Logger");

        [Signature("info", false)]
        public partial void Info(string message);
    }
}
