using CoinS2Machine.Core.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core.Processors {

    public class CoinProcessor : AbstractProcessor {

        public CoinProcessor() {
            this.CashType = DataContracts.CashType.Coin;
        }
        public override string GetName() {
            return "Coin Processor";
        }

        public override long[] GetAvailableValues() {
            return new long[] { 100, 50, 25, 10, 5, 1 };
        }

        public override Dictionary<long, long> Calculate(long changeAmount) {

            Dictionary<long, long> amountDictionary = new Dictionary<long,long>();

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
