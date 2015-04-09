
namespace CoinS2Machine.Core.Logging {
    public interface ILog {
        void WriteLog(Log log);
        void WriteLog(string methodName, LogType logType, object logData);
    }
}
