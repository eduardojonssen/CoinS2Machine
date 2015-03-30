using CoinS2Machine.Core.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core.Processors {

    public abstract class AbstractProcessor {

        public CashType CashType { get; set; }
      
        public abstract string GetName();

        public abstract long[] GetAvailableValues();

        public abstract Dictionary<long, long> Calculate(long changeAmount);
    }
}
