using OopLoggingSystem.Library.Loggers;

namespace OopLoggingSystem.Library.Factories
{
    public class ConsoleLoggerFactory : ILoggerFactory
    {
        public IWriteLogger Create()
        {
            return new ConsoleLogger();
        }
    }
}
