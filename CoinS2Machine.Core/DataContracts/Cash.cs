using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core.DataContracts {

    public class Cash {

        public CashType CashType { get; set; }

        public string Name { get; set; }

        public long Value { get; set; }

        public Cash() { }

        public Cash(long coinValue, string coinName, CashType cashType) {

            this.Value = coinValue;
            this.Name = coinName;
            this.CashType = cashType;
        }
    }
}
