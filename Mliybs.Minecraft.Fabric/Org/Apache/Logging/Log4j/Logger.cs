using System;
using System.Collections.Generic;

namespace Org.Apache.Logging.Log4j
{
    [MapName("org.apache.logging.log4j.Logger", false), JavaInterface(typeof(ILogger))]
    public partial class Logger : JavaObject, IClassRef<Logger>, IFromHandle<Logger>, ILogger
    {
        [Signature("info", false)]
        public partial void Info(string message);
    }

    [JavaInterface(typeof(Logger))]
    public partial interface ILogger : IJavaClass
    {
        void Info(string message);
    }
}
