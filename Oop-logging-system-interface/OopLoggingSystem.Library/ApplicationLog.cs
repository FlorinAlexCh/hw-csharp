﻿using OopLoggingSystem.Library.Factories;
using OopLoggingSystem.Library.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLoggingSystem.Library
{
    public static class ApplicationLog
    {
        private static IWriteLogger logger;

        public static void Initialize(ILoggerFactory factory)
        {
            ApplicationLog.logger = factory.Create();
        }

        public static void Write(LogEntry logEntry)
        {
            if (logEntry is not null)
            {
                ApplicationLog.logger.Write(logEntry);
            }
        }
    }
}
