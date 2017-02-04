using System.Reflection;

namespace Meerkat.Logging.Test
{
    public class SampleService
    {
        private static readonly ILog Logger = LogProvider.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public void Debug()
        {
            Logger.Debug("Debug");
        }

        public void Info()
        {
            Logger.Info("Info");
        }

        public void Warning()
        {
            Logger.Info("Info");
        }

        public void Errorl()
        {
            Logger.Error("Info");
        }

        public void Fatal()
        {
            Logger.Fatal("Info");
        }
    }
}