using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

using log4net;

using NUnit.Framework;

namespace Meerkat.Test
{
    [SetUpFixture]
    public class TestInitialize
    {
        [OneTimeSetUp]
        public void Initialize()
        {
            //var dir = Path.GetDirectoryName(typeof(LoggingTest).Assembly.Location);
            //Environment.CurrentDirectory = dir;

            //// or
            //Directory.SetCurrentDirectory(dir);


#if NETCOREAPP2_1
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            log4net.Config.XmlConfigurator.Configure(logRepository, new FileInfo("logger.config"));
            if (logRepository.Configured)
            {
                Debug.WriteLine("configured");
            }
#else
            log4net.Config.XmlConfigurator.Configure();
            if (LogManager.GetRepository().Configured)
            {
                Debug.WriteLine("configured");
            }
#endif
        }
    }
}