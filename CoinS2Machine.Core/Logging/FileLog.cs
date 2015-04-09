using CoinS2Machine.Core.Utility;
using Dlp.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core.Logging {
    public class FileLog: AbstractLog, ILog {
       
        public FileLog (IConfigurationUtility configurationUtility = null):base (configurationUtility) {   }

        public void WriteLog(Log log) {
            try {
                // Obtém o objeto serializado em uma string.
                string serializedData = Serializer.JsonSerialize(log.LogData);

                string date = DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss");

                string logLine = String.Format("[{0}] [{1}] [{2}] [{3}]{4}", date, log.MethodName, log.LogType, serializedData, Environment.NewLine);
                
                string directoryName = Path.GetDirectoryName(base.ConfigurationUtility.LogPath);

                if (Directory.Exists(directoryName) == false) {
                    Directory.CreateDirectory(directoryName);
                }

                File.AppendAllText(base.ConfigurationUtility.LogPath, logLine);
            }
            catch  { }
        
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
