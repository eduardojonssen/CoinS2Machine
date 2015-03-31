using CoinS2Machine.Core.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core.Processors {

    public class CoinProcessor : AbstractProcessor {

        public CoinProcessor() { }

        public override string GetName() {
            return "Coin Processor";
        }

        public override long[] GetAvailableValues() {
            return new long[] { 100, 50, 25, 10, 5 };
        }

        public override CashType CashType {
            get { return DataContracts.CashType.Coin; }
        }
    }
}
