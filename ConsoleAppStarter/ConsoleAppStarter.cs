using System;
using Microsoft.Extensions.Logging;

namespace TestConsoleApp
{
    public interface IConsoleApp
    {
        void Run();
    }

    public class ConsoleAppStarter : IConsoleApp
    {
        private readonly ILogger _logger;

        public ConsoleAppStarter(ILogger logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}