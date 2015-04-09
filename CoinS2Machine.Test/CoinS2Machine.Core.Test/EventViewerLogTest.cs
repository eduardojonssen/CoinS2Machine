using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinS2Machine.Core.Logging;
using CoinS2Machine.Test.CoinS2Machine.Core.Test.Mocks;

namespace CoinS2Machine.Test.CoinS2Machine.Core.Test {
    [TestClass]
    public class EventViewerLogTest {
        [TestMethod]
        public void WriteLog_WriteError_Test() {
            EventViewerLog eventViewerLog = new EventViewerLog();

            eventViewerLog.WriteLog("Mensagem de Erro", LogType.Error, "Mensagem de Erro");


        }

        public object calculateChangeRequest { get; set; }
    }
}
