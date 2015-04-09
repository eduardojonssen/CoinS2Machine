using CoinS2Machine.Core.Utility;
using Dlp.Framework;
using System;
using System.Diagnostics;

namespace CoinS2Machine.Core.Logging {
    public class EventViewerLog : AbstractLog, ILog {

        private const string source = "CoinS2Machine";

        public EventViewerLog(IConfigurationUtility configurationUtility = null):base (configurationUtility) {
        }
        
        public void WriteLog(Log log) {
            this.WriteLog(log.MethodName, log.LogType, log.LogData);
        }

        public void WriteLog(string methodName, LogType logType, object logData) {
            string serializedData = Serializer.JsonSerialize(logData);

            EventLogEntryType eventLogEntryType = EventLogEntryType.Information;

            switch (logType) {
                case LogType.Request:
                case LogType.Response:
                case LogType.Information:
                    eventLogEntryType = EventLogEntryType.Information;
                    break;
                case LogType.Error:
                    eventLogEntryType = EventLogEntryType.Error;
                    break;                  
                default:
                    break;
            }

            string eventDetails = logType.ToString();
            string logMessage = String.Format("[{0}] [{1}] [{2}]", eventDetails, methodName, serializedData);

            EventLog.WriteEntry(source, logMessage, eventLogEntryType);
        }
    }
}
