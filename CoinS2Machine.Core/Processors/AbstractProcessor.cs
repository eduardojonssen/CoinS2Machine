using CoinS2Machine.Core.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core.Processors {

    public abstract class AbstractProcessor {

        public abstract CashType CashType { get; }
      
        public abstract string GetName();

        public abstract long[] GetAvailableValues();

        public virtual List<ChangeData> Calculate(long changeAmount) {

            List<ChangeData> changeDataList = new List<ChangeData>();

            IEnumerable<long> orderedAmountList = this.GetAvailableValues().OrderByDescending(c => c);

            long actualChangeAmount = changeAmount;

            foreach (long amount in orderedAmountList) {

                long unityCount = actualChangeAmount / amount;
                actualChangeAmount = actualChangeAmount % amount;

                changeDataList.Add(new ChangeData(amount, unityCount));
            }

            return changeDataList;
        }

    }
}
