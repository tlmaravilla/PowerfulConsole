﻿

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace PowerfulConsole.Services
{
    public class GreetingService : IGreetingService
    {
        private readonly ILogger<GreetingService> _logger;
        private readonly IConfiguration _config;

        public GreetingService(ILogger<GreetingService> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        public void Greet()
        {
            for (int i = 0; i < _config.GetValue<int>("LoopTimes"); i++)
            {
                _logger.LogInformation("Run number {runNumber}", i);
            }
        }
    }
}
