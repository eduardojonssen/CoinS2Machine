using CoinS2Machine.Core;
using CoinS2Machine.Core.DataContracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinS2Machine {
    public partial class MainForm : Form {


        public MainForm() {
            InitializeComponent();
        }

        private void UxBtnCalculate_Click(object sender, EventArgs e) {

            this.CalculateChange();
        }

        private void CalculateChange() {

            this.UxTxbResult.Clear();

            long paidAmount = Convert.ToInt64(this.UxTxbPaidAmount.Text);
            long productAmount = Convert.ToInt64(this.UxTxbProductAmount.Text);

            CoinS2MachineManager coinS2MachineManager = new CoinS2MachineManager();

            CalculateChangeRequest request = new CalculateChangeRequest();

            request.PaidAmount = paidAmount;
            request.ProductAmount = productAmount;

            CalculateChangeResponse response = coinS2MachineManager.CalculateChange(request);

            if (response.OperationReportList.Any() == true) {

                foreach (OperationReport operationReport in response.OperationReportList) {
                    this.UxTxbResult.Text += string.Concat(Environment.NewLine, "FieldName: ", operationReport.FieldName, " - ", operationReport.Message);
                }
            }
            else {

                this.UxTxbResult.Text = String.Format("Troco total: {0}",response.ChangeAmount);

                foreach (KeyValuePair<Cash, long> item in response.CoinDictionary) {
                    string cashType = item.Key.CashType.ToString();
                    this.UxTxbResult.Text += String.Concat(Environment.NewLine, cashType, " ", item.Key.Name, ": " , item.Value);                  
                }
            }
        }
    }
}
