using CoinS2Machine.Core.DataContracts;
using CoinS2Machine.Core.Logging;
using CoinS2Machine.Core.Utility;
using CoinS2Machine.Test.CoinS2Machine.Core.Test.Mocks;
using Dlp.Framework.Container;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Test.CoinS2Machine.Core.Test {

    [TestClass]
    public class LoggerTest {

        [TestMethod]
        public void WriteLog_SaveData() {

            CalculateChangeRequest calculateChangeRequest = new CalculateChangeRequest();
            calculateChangeRequest.PaidAmount = 500;
            calculateChangeRequest.ProductAmount = 300;

            Log log = new Log();
            log.MethodName = "WriteLog_SaveData";
            log.LogType = LogType.Request;
            log.LogData = calculateChangeRequest;

            ConfigurationUtilityMock mock = new ConfigurationUtilityMock();
            mock.LogTypeName = @"EventViewerLog";

            IocFactory.Register(
                    Component.For<IConfigurationUtility>()
                    .Instance(mock)
                );

            ILog logImplementation = new LogFactory().Create();
            Logger logger = new Logger(logImplementation);
            logger.WriteLog(log);
        }
    }
}
