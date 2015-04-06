using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinS2Machine.Core.DataContracts;

namespace CoinS2Machine.Core.Processors {

    public class CandyProcessor : AbstractProcessor {

        public CandyProcessor() { }
        internal override DataContracts.CashType CashType {
            get { return CashType.Candy; }
        }

        internal override string GetName() {
            return "Candy Processor";
        }

        internal override long[] GetAvailableValues() {
            return new long[] { 3, 1 };
        }
    }
}
