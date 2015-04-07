using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core.Logging {
    public class Log {

        public string MethodName { get; set; }
        public LogType LogType { get; set; }
        public object LogData { get; set; }

        public Log() { }

        public Log(string methodName, LogType logType, object logData) {
            this.MethodName = methodName;
            this.LogType = logType;
            this.LogData = logData;
        }

    }
}
