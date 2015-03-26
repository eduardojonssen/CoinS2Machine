using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core.DataContracts {

    public class CalculateChangeRequest : AbstractRequest {

        public CalculateChangeRequest() { }

        public long ProductAmount { get; set; }

        public long PaidAmount { get; set; }

        protected override void Validate() {

            if (this.ProductAmount <= 0) {
                this.ValidationErrorList.Add("Product amount must be greater than zero.");
            }

            if (this.PaidAmount <= 0) {
                this.ValidationErrorList.Add("Paid amount must be greater than zero.");
            }

            if (this.PaidAmount < this.ProductAmount) {
                this.ValidationErrorList.Add("Paid amount must be greater or equals than the product amount.");
            }
        }
    }
}
