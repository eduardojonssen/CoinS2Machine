using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinS2Machine.Core.DataContracts;

namespace CoinS2Machine.Core.Processors {

    public class SilverProcessor : AbstractProcessor {

        public SilverProcessor() { }

        internal override CashType CashType {
            get { return CashType.Silver; }
        }

        internal override string GetName() {
            return "Silver Processor";
        }

        internal override long[] GetAvailableValues() {
            return new long[] { 50000, 100000 };
        }

    }
}
