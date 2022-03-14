using OopLoggingSystem.Library.Loggers;

namespace OopLoggingSystem.Library.Factories
{
    public class FileLoggerFactory : ILoggerFactory
    {
        public FileLoggerFactory(string filePath)
        {
            FilePath = filePath;
        }

        public string FilePath { get; }

         public IWriteLogger Create()
        {
            return new FileLogger(FilePath);
        }

    }
}
