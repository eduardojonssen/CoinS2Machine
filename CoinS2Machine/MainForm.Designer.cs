namespace CoinS2Machine {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.UxTxbProductAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UxTxbPaidAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UxTxbResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.UxBtnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UxTxbProductAmount
            // 
            this.UxTxbProductAmount.Location = new System.Drawing.Point(146, 12);
            this.UxTxbProductAmount.Name = "UxTxbProductAmount";
            this.UxTxbProductAmount.Size = new System.Drawing.Size(100, 26);
            this.UxTxbProductAmount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product Price";
            // 
            // UxTxbPaidAmount
            // 
            this.UxTxbPaidAmount.Location = new System.Drawing.Point(146, 62);
            this.UxTxbPaidAmount.Name = "UxTxbPaidAmount";
            this.UxTxbPaidAmount.Size = new System.Drawing.Size(100, 26);
            this.UxTxbPaidAmount.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Paid Amount";
            // 
            // UxTxbResult
            // 
            this.UxTxbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UxTxbResult.Location = new System.Drawing.Point(146, 117);
            this.UxTxbResult.Multiline = true;
            this.UxTxbResult.Name = "UxTxbResult";
            this.UxTxbResult.Size = new System.Drawing.Size(348, 113);
            this.UxTxbResult.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Change Result";
            // 
            // UxBtnCalculate
            // 
            this.UxBtnCalculate.Location = new System.Drawing.Point(307, 12);
            this.UxBtnCalculate.Name = "UxBtnCalculate";
            this.UxBtnCalculate.Size = new System.Drawing.Size(187, 81);
            this.UxBtnCalculate.TabIndex = 0;
            this.UxBtnCalculate.Text = "Calculate S2";
            this.UxBtnCalculate.UseVisualStyleBackColor = true;
            this.UxBtnCalculate.Click += new System.EventHandler(this.UxBtnCalculate_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.UxBtnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 247);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UxTxbResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UxTxbPaidAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UxTxbProductAmount);
            this.Controls.Add(this.UxBtnCalculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "CoinS2Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UxTxbProductAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UxTxbPaidAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UxTxbResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UxBtnCalculate;
    }
}

