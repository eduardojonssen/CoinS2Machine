using CoinS2Machine.Core.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core.Processors {

    public abstract class AbstractProcessor {

        internal abstract CashType CashType { get; }

        internal abstract string GetName();

        internal abstract long[] GetAvailableValues();

        internal virtual List<ChangeData> Calculate(long changeAmount) {

            List<ChangeData> changeDataList = new List<ChangeData>();

            IEnumerable<long> orderedAmountList = this.GetAvailableValues().OrderByDescending(c => c);

            long actualChangeAmount = changeAmount;

            foreach (long amount in orderedAmountList) {

                long unitCount = actualChangeAmount / amount;
                actualChangeAmount = actualChangeAmount % amount;

                if (unitCount > 0) {
                    changeDataList.Add(new ChangeData(amount, unitCount));
                }
            }

            return changeDataList;
        }
    }
}
