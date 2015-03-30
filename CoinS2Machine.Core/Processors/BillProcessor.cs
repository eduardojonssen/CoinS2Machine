using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core.Processors {

    public class BillProcessor : AbstractProcessor {

        public BillProcessor() {
            this.CashType = DataContracts.CashType.Bill;
        }
        public override string GetName() {
            return "Bill Processor";
        }

        public override long[] GetAvailableValues() {
            return new long[] { 10000, 5000, 2000, 1000, 500, 200 };
        }

        public override Dictionary<long, long> Calculate(long changeAmount) {

            Dictionary<long, long> amountDictionary = new Dictionary<long, long>();

            IEnumerable<long> orderedAmountList = this.GetAvailableValues().OrderByDescending(c => c);

            long actualChangeAmount = changeAmount;

            foreach (long amount in orderedAmountList) {

                long unityCount = actualChangeAmount / amount;
                actualChangeAmount = actualChangeAmount % amount;

                amountDictionary.Add(amount, unityCount);
            }

            return amountDictionary;
        }
    }
}
