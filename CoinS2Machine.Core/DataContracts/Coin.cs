using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core.DataContracts {

    public class Coin {

        public string CoinName { get; set; }

        public long CoinValue { get; set; }

        public Coin() { }

        public Coin(long coinValue, string coinName) {

            this.CoinValue = coinValue;
            this.CoinName = coinName;
        }
    }
}
