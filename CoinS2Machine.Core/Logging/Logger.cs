using Dlp.Framework;
using System;
using System.Configuration;
using System.IO;

namespace CoinS2Machine.Core.Logging {

    public enum LogType {
        Request = 0
        ,
        Response = 1
            ,
        Error = 2
            , Information = 3
    }

    public class Logger {
        public ILog Log { get; private set; }

        public string LogPath { get; set; }
        public Logger()
            : this(new LogFactory().Create()) {

        }

        public Logger(ILog log) {
            if (log == null) {
                throw new ArgumentNullException("log");
            }
            this.Log = log;
        }


        public void WriteLog(Log log) {
            this.Log.WriteLog(log);
        }

        public void WriteLog(string methodName, LogType logType, object logData) {

            Log log = new Log();
            log.MethodName = methodName;
            log.LogType = logType;
            log.LogData = logData;

            this.WriteLog(log);
        }
    }
}
