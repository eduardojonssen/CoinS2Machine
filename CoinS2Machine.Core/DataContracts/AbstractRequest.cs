using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinS2Machine.Core.DataContracts {
    
    public abstract class AbstractRequest {

        public AbstractRequest() {
            this.ActualOperationReportList = new List<OperationReport>();
        }

        internal bool IsValid {
            get {
                this.ActualOperationReportList.Clear();
                this.Validate();
                return (this.ActualOperationReportList.Any() == false);
            }
        }

        internal List<OperationReport> OperationReportList {
            get {
                return this.ActualOperationReportList.ToList();
            }
        }

        private List<OperationReport> ActualOperationReportList { get; set; }

        protected abstract void Validate();

        protected void AddOperationReport(string fieldName, string message) {
        
            OperationReport operationReport = new OperationReport();

            operationReport.FieldName = this.GetType().Name + "." + fieldName;
            operationReport.Message = message;

            this.ActualOperationReportList.Add(operationReport);
        }
    }
}
