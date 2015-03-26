using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core.DataContracts {

    public class CalculateChangeResponse {

        public CalculateChangeResponse() {

            this.CoinDictionary = new Dictionary<Coin, long>();
            this.ErrorList = new List<string>();
        }

        public List<string> ErrorList { get; set; }

        public Nullable<long> ChangeAmount { get; set; }

        public Dictionary<Coin, long> CoinDictionary { get; set; }
    }
}
