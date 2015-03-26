using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core {
   public  class OperationResult<T> {

        public OperationResult(T value) {

            this.Failed = false;
            this.ErrorMessageList = null;
            this.Value = value;
        }

        public OperationResult(List<string> errorMessageList) {

            this.ErrorMessageList = errorMessageList;
            this.Failed = true;
            this.Value = default(T);
        }
        
        public bool Failed { get; private set; }

        public List<string> ErrorMessageList { get; private set; }

        public T Value { get; private set; }
    }
}
