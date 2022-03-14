using System;
using System.IO;

namespace OopLoggingSystem.Library.Loggers
{
    internal class FileLogger : IWriteLogger
    {
        public FileLogger(string filePath)
        {
            FilePath = filePath;
        }

        public string FilePath { get; }

        public void Write(LogEntry entry)
        {
            bool fileExists = File.Exists(FilePath);

            using StreamWriter sw = fileExists
                                        ? File.AppendText(FilePath)
                                        : File.CreateText(FilePath);

            sw.WriteLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}] [{entry.LogLevel}] {entry.Message}");
        }
    }
}
