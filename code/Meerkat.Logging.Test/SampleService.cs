using System.Reflection;
using Meerkat.Logging;

namespace Meerkat.Test
{
    public class SampleService
    {
        private static readonly ILog Logger = LogProvider.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

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