using System.Reflection;

using Meerkat.Logging;

#if NETCOREAPP
using Microsoft.Extensions.Logging;
#endif

namespace Meerkat.Test
{
    public class SampleService
    {
#if NETCOREAPP
        private static readonly ILogger Logger = LibraryLogger.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
#else
        private static readonly ILog Logger = LogProvider.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
#endif

        public void LogDebug()
        {
            Logger.Debug("Debug");
        }

        public void LogInfo()
        {
            Logger.Info("Info");
        }

        public void LogTrace()
        {
            Logger.Trace("Trace");
        }

        public void LogWarning()
        {
            Logger.Warn("Warning");
        }

        public void LogError()
        {
            Logger.Error("Error");
        }

        public void LogFatal()
        {
            Logger.Fatal("Fatal");
        }
    }
}