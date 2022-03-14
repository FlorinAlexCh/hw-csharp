using System;

namespace OopLoggingSystem.Library.Loggers
{
    internal class ConsoleLogger : IWriteLogger
    {
        public void Write(LogEntry entry)
        {
            Console.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}] [{entry.LogLevel}] {entry.Message}");
        }
    }
}
