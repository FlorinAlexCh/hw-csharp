using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopLoggingSystem.Library.Loggers
{
    public interface IWriteLogger
    {
        public void Write(LogEntry entry);
    }
}
