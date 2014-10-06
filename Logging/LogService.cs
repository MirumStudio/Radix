using Radix.Service;
using Radix.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radix.Logging
{
    internal class LogService : ServiceBase
    {
        private LogFile mLogFile;

        protected override void Init()
        {
            mLogFile = new LogFile();
        }

        protected override void Dispose()
        {
            
        }

        internal void AddLogEntry(LogEntry aLogEntry)
        {
            mLogFile.AddLogEntry(aLogEntry);
            mLogFile.Save();
        }
    }
}
