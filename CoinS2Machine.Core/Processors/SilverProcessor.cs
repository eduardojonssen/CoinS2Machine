using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinS2Machine.Core.DataContracts;

namespace CoinS2Machine.Core.Processors  {
    public class SilverProcessor : AbstractProcessor {
        public override CashType CashType {
            get { return CashType.Silver; }
        }

        public override string GetName() {
            return "Silver Processor";
        }

        public override long[] GetAvailableValues() {
            return new long[] { 50000, 100000 };
        }

    }
}
