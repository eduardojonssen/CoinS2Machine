using CoinS2Machine.Core.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core {
    public class CoinS2MachineManager {

        public List<Coin> CoinList { get; set; }

        public CoinS2MachineManager() {
            this.CoinList = new List<Coin>();

            this.CoinList.Add(new Coin(100, "1 real"));
            this.CoinList.Add(new Coin(50, "50 centavos"));
            this.CoinList.Add(new Coin(25, "25 centavos"));
            this.CoinList.Add(new Coin(10, "10 centavos"));
            this.CoinList.Add(new Coin(5, "5 centavos"));
            this.CoinList.Add(new Coin(1, "1 centavo"));
        }

        public CalculateChangeResponse CalculateChange(CalculateChangeRequest calculateChangeRequest) {

            CalculateChangeResponse calculateChangeResponse = new CalculateChangeResponse();

            if (calculateChangeRequest.IsValid == false) {

                calculateChangeResponse.ErrorList = calculateChangeRequest.ValidationErrorList;
                return calculateChangeResponse;
            }

            long result = calculateChangeRequest.PaidAmount - calculateChangeRequest.ProductAmount;

            calculateChangeResponse.ChangeAmount = result;

            this.CoinList.OrderByDescending(c => c.CoinValue);

            foreach (Coin item in this.CoinList) {

                long change = result / item.CoinValue;
                long rest = result % item.CoinValue;

                if (change > 0) { calculateChangeResponse.CoinDictionary.Add(item, change); }

                if (rest == 0) { break; }
                else { result = rest; }
            }

            return calculateChangeResponse;
        }

    }
}
