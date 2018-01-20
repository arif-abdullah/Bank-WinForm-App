namespace SQLExamples
{
    partial class Transaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtTransAccNo = new System.Windows.Forms.TextBox();
            this.btnTransDeposit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTransAmount = new System.Windows.Forms.TextBox();
            this.btnTransWithdraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number";
            // 
            // txtTransAccNo
            // 
            this.txtTransAccNo.Location = new System.Drawing.Point(193, 59);
            this.txtTransAccNo.Name = "txtTransAccNo";
            this.txtTransAccNo.Size = new System.Drawing.Size(130, 26);
            this.txtTransAccNo.TabIndex = 1;
            // 
            // btnTransDeposit
            // 
            this.btnTransDeposit.Location = new System.Drawing.Point(167, 141);
            this.btnTransDeposit.Name = "btnTransDeposit";
            this.btnTransDeposit.Size = new System.Drawing.Size(75, 31);
            this.btnTransDeposit.TabIndex = 2;
            this.btnTransDeposit.Text = "Deposit";
            this.btnTransDeposit.UseVisualStyleBackColor = true;
            this.btnTransDeposit.Click += new System.EventHandler(this.btnTransDeposit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Amount";
            // 
            // txtTransAmount
            // 
            this.txtTransAmount.Location = new System.Drawing.Point(193, 98);
            this.txtTransAmount.Name = "txtTransAmount";
            this.txtTransAmount.Size = new System.Drawing.Size(130, 26);
            this.txtTransAmount.TabIndex = 1;
            // 
            // btnTransWithdraw
            // 
            this.btnTransWithdraw.Location = new System.Drawing.Point(248, 141);
            this.btnTransWithdraw.Name = "btnTransWithdraw";
            this.btnTransWithdraw.Size = new System.Drawing.Size(88, 31);
            this.btnTransWithdraw.TabIndex = 2;
            this.btnTransWithdraw.Text = "Withdraw";
            this.btnTransWithdraw.UseVisualStyleBackColor = true;
            this.btnTransWithdraw.Click += new System.EventHandler(this.btnTransWithdraw_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 218);
            this.Controls.Add(this.btnTransWithdraw);
            this.Controls.Add(this.btnTransDeposit);
            this.Controls.Add(this.txtTransAmount);
            this.Controls.Add(this.txtTransAccNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Transaction";
            this.Text = "Transaction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTransAccNo;
        private System.Windows.Forms.Button btnTransDeposit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTransAmount;
        private System.Windows.Forms.Button btnTransWithdraw;
    }
}