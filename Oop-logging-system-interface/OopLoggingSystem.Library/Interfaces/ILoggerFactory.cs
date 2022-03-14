using OopLoggingSystem.Library.Loggers;

namespace OopLoggingSystem.Library.Factories
{
    public interface ILoggerFactory
    {
        public IWriteLogger Create();
    }
}
