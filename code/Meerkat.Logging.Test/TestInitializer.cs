using System.Diagnostics;
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
            log4net.Config.XmlConfigurator.Configure();
            if (LogManager.GetRepository().Configured)
            {
                Debug.WriteLine("configured");
            }
        }
    }
}

