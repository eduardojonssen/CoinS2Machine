using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core.DataContracts {

    public class CalculateChangeResponse {

        public CalculateChangeResponse() {

            this.ChangeDictionary = new Dictionary<Cash, long>();
            this.OperationReportList = new List<OperationReport>();
        }

        public List<OperationReport> OperationReportList { get; set; }

        public Nullable<long> ChangeAmount { get; set; }

        public Dictionary<Cash, long> ChangeDictionary { get; set; }
    }
}
