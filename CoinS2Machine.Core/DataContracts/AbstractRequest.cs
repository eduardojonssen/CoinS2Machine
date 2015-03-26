using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core.DataContracts {
    
    public abstract class AbstractRequest {

        public AbstractRequest() {
            this.ValidationErrorList = new List<string>();
        }

        public bool IsValid {
            get {
                this.ValidationErrorList.Clear();
                this.Validate();
                return (this.ValidationErrorList.Any() == false);
            }
        }

        public List<string> ValidationErrorList { get; set; }

        protected abstract void Validate();
    }
}
