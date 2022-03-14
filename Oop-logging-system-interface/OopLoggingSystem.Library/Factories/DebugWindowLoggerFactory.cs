using OopLoggingSystem.Library.Loggers;

namespace OopLoggingSystem.Library.Factories
{
    public class DebugWindowLoggerFactory : ILoggerFactory
    {
        public IWriteLogger Create()
        {
            return new DebugWindowLogger();
        }
    }
}
