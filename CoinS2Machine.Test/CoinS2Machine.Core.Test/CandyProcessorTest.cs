using CoinS2Machine.Core.DataContracts;
using CoinS2Machine.Core.Processors;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Test.CoinS2Machine.Core.Test {

    [TestClass]
    [ExcludeFromCodeCoverage]
    public class CandyProcessorTest 
    {        
        [TestMethod]
        public void CandyProcessor_GetName_Test() {

            CandyProcessor candyProcessor = new CandyProcessor();

            PrivateObject privateObject = new PrivateObject(candyProcessor);

            string name = (string)privateObject.Invoke("GetName");

            Assert.IsNotNull(candyProcessor);
            Assert.AreEqual(name, "Candy Processor");
        }

        [TestMethod]
        public void CandyProcessor_GetCashType_Test() {
            CandyProcessor candyProcessor = new CandyProcessor();

            PrivateObject privateObject = new PrivateObject(candyProcessor);

            CashType expected = CashType.Candy;
            CashType actual = (CashType)privateObject.GetProperty("CashType");

            Assert.IsNotNull(candyProcessor);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Calculate_ChangeForFour_Test() {

            CandyProcessor candyProcessor = new CandyProcessor();

            PrivateObject privateObject = new PrivateObject(candyProcessor);

            List<ChangeData> changeDataList = privateObject.Invoke("Calculate", 4) as List<ChangeData>;

            Assert.IsNotNull(changeDataList);
            Assert.AreEqual(2, changeDataList.Count);

            Assert.IsTrue(changeDataList.Any(p => p.UnitAmount == 3 && p.UnitCount == 1) == true);
            Assert.IsTrue(changeDataList.Any(p => p.UnitAmount == 1 && p.UnitCount == 1) == true);
        }

        [TestMethod]
        public void Calculate_ChangeForInvalidAmount_Test() {

            CandyProcessor candyProcessor = new CandyProcessor();

            PrivateObject privateObject = new PrivateObject(candyProcessor);

            List<ChangeData> changeDataList = privateObject.Invoke("Calculate", Convert.ToInt64(0)) as List<ChangeData>;

            Assert.IsNotNull(changeDataList);
            Assert.IsTrue(changeDataList.Any() == false);
        }
    }
}
