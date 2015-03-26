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

            long paidAmount = Convert.ToInt64(this.UxTxbPaidAmount.Text);
            long productAmount = Convert.ToInt64(this.UxTxbProductAmount.Text);

            CoinS2MachineManager coinS2MachineManager = new CoinS2MachineManager();

            CalculateChangeRequest request = new CalculateChangeRequest();

            request.PaidAmount = paidAmount;
            request.ProductAmount = productAmount;

            CalculateChangeResponse response = coinS2MachineManager.CalculateChange(request);

            if (response.ErrorList.Any() == true) {

                this.UxTxbResult.Text = string.Join(Environment.NewLine, response.ErrorList);
            }
            else {

                this.UxTxbResult.Text = String.Format("Troco total: {0}",response.ChangeAmount);
                foreach (KeyValuePair<Coin, long> item in response.CoinDictionary) {
                    this.UxTxbResult.Text += String.Concat(Environment.NewLine , "Moeda(s) de " , item.Key.CoinName, ": " , item.Value);                  
                }
            }
        }
    }
}
