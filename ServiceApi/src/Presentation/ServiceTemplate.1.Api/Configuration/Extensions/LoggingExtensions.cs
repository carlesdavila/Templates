﻿using Serilog;

namespace ServiceTemplate._1.Api.Configuration.Extensions;

public static class LoggingExtensions
{
    public static void SetupSerilog(this ILoggingBuilder logging, IConfiguration configuration)
    {
        var logger = new LoggerConfiguration()
            .ReadFrom.Configuration(configuration)
            .CreateLogger();
        logging.AddSerilog(logger);
    }
}