using CoinS2Machine.Core.DataContracts;
using CoinS2Machine.Core.Logging;
using CoinS2Machine.Test.CoinS2Machine.Core.Test.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Test.CoinS2Machine.Core.Test {
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClass]
    public class LoggerTest {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void WriteLog_SaveData() {
            CalculateChangeRequest calculateChangeRequest = new CalculateChangeRequest();
            calculateChangeRequest.PaidAmount = 500;
            calculateChangeRequest.ProductAmount = 300;

            Log log = new Log();
            log.MethodName = "WriteLog_SaveData";
            log.LogType = LogType.Request;
            log.LogData = calculateChangeRequest;

            ConfigurationUtilityMock configurationUtilityMock = new ConfigurationUtilityMock();

            ILog LOG = new LogFactory().Create(configurationUtilityMock);
            Logger logger = new Logger(LOG);
            logger.WriteLog(log);
        }
    }
}
 