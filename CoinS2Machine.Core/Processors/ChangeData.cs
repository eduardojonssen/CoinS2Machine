using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core.Processors {

    public class ChangeData {

        public ChangeData() { }

        public ChangeData(long unitAmount, long unitCount) {

            this.UnitAmount = unitAmount;
            this.UnitCount = unitCount;
        }

        public long UnitAmount { get; set; }

        public long UnitCount { get; set; }
    }
}
