using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinS2Machine.Core.Processors;

namespace CoinS2Machine.Test.CoinS2Machine.Core.Test {

    [TestClass]
    public class ProcessorFactoryTest {

        [TestMethod]
        public void Create_GetCoinProcessor_Test() {

            AbstractProcessor processor = ProcessorFactory.Create(150);

            Assert.IsNotNull(processor);
            Assert.IsInstanceOfType(processor, typeof(CoinProcessor));
        }
        [TestMethod]
        public void Create_GetBillProcessor_Test() {

            AbstractProcessor processor = ProcessorFactory.Create(500);

            Assert.IsNotNull(processor);
            Assert.IsInstanceOfType(processor, typeof(BillProcessor));
        }
        [TestMethod]
        public void Create_GetSilverProcessor_Test() {

            AbstractProcessor processor = ProcessorFactory.Create(500000);

            Assert.IsNotNull(processor);
            Assert.IsInstanceOfType(processor, typeof(SilverProcessor));
        }
        [TestMethod]
        public void Create_GetCandyProcessor_Test() {

            AbstractProcessor processor = ProcessorFactory.Create(3);

            Assert.IsNotNull(processor);
            Assert.IsInstanceOfType(processor, typeof(CandyProcessor));
        }
        [TestMethod]
        public void Create_GetNullProcessor_Test() {
            AbstractProcessor processor = ProcessorFactory.Create(0);

            Assert.IsNull(processor);
        }
    }
}
