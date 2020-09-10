using Meerkat.Logging;

using NUnit.Framework;

namespace Meerkat.Test
{
    [TestFixture]
    public class LoggingTest
    {
        [Test]
        public void Debug()
        {
            var service = new SampleService();
            service.LogDebug();
        }

        [Test]
        public void Info()
        {
            var service = new SampleService();
            service.LogInfo();
        }

        [Test]
        public void Trace()
        {
            var service = new SampleService();
            service.LogTrace();
        }

        [Test]
        public void Warning()
        {
            var service = new SampleService();
            service.LogWarning();
        }

        [Test]
        public void Error()
        {
            var service = new SampleService();
            service.LogError();
        }

        [Test]
        public void Fatal()
        {
            var service = new SampleService();
            service.LogFatal();
        }

#if NETCOREAPP
        [SetUp]
        public void Setup()
        {
            var factory = new Microsoft.Extensions.Logging.LoggerFactory();
            LibraryLogger.Factory = factory;
        }
#endif
    }
}
