using System;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace TestConsoleApp.Tests
{
    [TestClass]
    public class ConsoleAppStarterTests
    {
        private Mock<ILogger> _logger;

        [TestInitialize]
        public void Initialize()
        {
            _logger = new Mock<ILogger>();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ConsoleAppStarter_Without_Logger_Should_ThrowArgumentException()
        {
            new ConsoleAppStarter(null);
        }
    }
}
