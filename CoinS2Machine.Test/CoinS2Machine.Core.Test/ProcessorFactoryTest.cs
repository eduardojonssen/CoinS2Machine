using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinS2Machine.Core.Processors;
using System.Diagnostics.CodeAnalysis;

namespace CoinS2Machine.Test.CoinS2Machine.Core.Test {

    [TestClass]
    [ExcludeFromCodeCoverage]
    public class ProcessorFactoryTest {

        [TestMethod]
        public void Create_GetCoinProcessorByMinValue_Test() {

            AbstractProcessor processor = ProcessorFactory.Create(5);

            Assert.IsNotNull(processor);
            Assert.IsInstanceOfType(processor, typeof(CoinProcessor));
        }

        [TestMethod]
        public void Create_GetCoinProcessorByMaxValue_Test() {

            AbstractProcessor processor = ProcessorFactory.Create(100);

            Assert.IsNotNull(processor);
            Assert.IsInstanceOfType(processor, typeof(CoinProcessor));
        }

        [TestMethod]
        public void Create_GetBillProcessorByMinValue_Test() {

            AbstractProcessor processor = ProcessorFactory.Create(200);

            Assert.IsNotNull(processor);
            Assert.IsInstanceOfType(processor, typeof(BillProcessor));
        }

        [TestMethod]
        public void Create_GetBillProcessorByMaxValue_Test() {

            AbstractProcessor processor = ProcessorFactory.Create(10000);

            Assert.IsNotNull(processor);
            Assert.IsInstanceOfType(processor, typeof(BillProcessor));
        }

        [TestMethod]
        public void Create_GetSilverProcessorByMinValue_Test() {

            AbstractProcessor processor = ProcessorFactory.Create(50000);

            Assert.IsNotNull(processor);
            Assert.IsInstanceOfType(processor, typeof(SilverProcessor));
        }

        [TestMethod]
        public void Create_GetSilverProcessorByMaxValue_Test() {

            AbstractProcessor processor = ProcessorFactory.Create(100000);

            Assert.IsNotNull(processor);
            Assert.IsInstanceOfType(processor, typeof(SilverProcessor));
        }

        [TestMethod]
        public void Create_GetCandyProcessorByMinValue_Test() {

            AbstractProcessor processor = ProcessorFactory.Create(1);

            Assert.IsNotNull(processor);
            Assert.IsInstanceOfType(processor, typeof(CandyProcessor));
        }

        [TestMethod]
        public void Create_GetCandyProcessorByMaxValue_Test() {

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
