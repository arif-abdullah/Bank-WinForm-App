namespace SQLExamples
{
    partial class Index
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
            this.lbCustomer = new System.Windows.Forms.LinkLabel();
            this.lbTransaction = new System.Windows.Forms.LinkLabel();
            this.lbSearch = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbCustomer
            // 
            this.lbCustomer.AutoSize = true;
            this.lbCustomer.Location = new System.Drawing.Point(57, 46);
            this.lbCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCustomer.Name = "lbCustomer";
            this.lbCustomer.Size = new System.Drawing.Size(244, 20);
            this.lbCustomer.TabIndex = 0;
            this.lbCustomer.TabStop = true;
            this.lbCustomer.Text = "Save Customer and Account Info";
            this.lbCustomer.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbCustomer_LinkClicked);
            // 
            // lbTransaction
            // 
            this.lbTransaction.AutoSize = true;
            this.lbTransaction.Location = new System.Drawing.Point(57, 80);
            this.lbTransaction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTransaction.Name = "lbTransaction";
            this.lbTransaction.Size = new System.Drawing.Size(92, 20);
            this.lbTransaction.TabIndex = 0;
            this.lbTransaction.TabStop = true;
            this.lbTransaction.Text = "Transaction";
            this.lbTransaction.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbTransaction_LinkClicked);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(57, 117);
            this.lbSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(259, 20);
            this.lbSearch.TabIndex = 0;
            this.lbSearch.TabStop = true;
            this.lbSearch.Text = "Search Customer and Account Info";
            this.lbSearch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbSearch_LinkClicked);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 208);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.lbTransaction);
            this.Controls.Add(this.lbCustomer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Index";
            this.Text = "Index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lbCustomer;
        private System.Windows.Forms.LinkLabel lbTransaction;
        private System.Windows.Forms.LinkLabel lbSearch;
    }
}

