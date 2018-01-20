namespace SQLExamples
{
    partial class Search
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
            this.txtSearchAccNo = new System.Windows.Forms.TextBox();
            this.btnSearchAcc = new System.Windows.Forms.Button();
            this.gvCustomerDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomerDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Account Number";
            // 
            // txtSearchAccNo
            // 
            this.txtSearchAccNo.Location = new System.Drawing.Point(190, 46);
            this.txtSearchAccNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchAccNo.Name = "txtSearchAccNo";
            this.txtSearchAccNo.Size = new System.Drawing.Size(148, 26);
            this.txtSearchAccNo.TabIndex = 1;
            // 
            // btnSearchAcc
            // 
            this.btnSearchAcc.Location = new System.Drawing.Point(360, 46);
            this.btnSearchAcc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchAcc.Name = "btnSearchAcc";
            this.btnSearchAcc.Size = new System.Drawing.Size(112, 26);
            this.btnSearchAcc.TabIndex = 2;
            this.btnSearchAcc.Text = "Search";
            this.btnSearchAcc.UseVisualStyleBackColor = true;
            this.btnSearchAcc.Click += new System.EventHandler(this.btnSearchAcc_Click);
            // 
            // gvCustomerDetails
            // 
            this.gvCustomerDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvCustomerDetails.Location = new System.Drawing.Point(58, 108);
            this.gvCustomerDetails.Name = "gvCustomerDetails";
            this.gvCustomerDetails.Size = new System.Drawing.Size(414, 150);
            this.gvCustomerDetails.TabIndex = 3;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 293);
            this.Controls.Add(this.gvCustomerDetails);
            this.Controls.Add(this.btnSearchAcc);
            this.Controls.Add(this.txtSearchAccNo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Search";
            this.Text = "Search";
            ((System.ComponentModel.ISupportInitialize)(this.gvCustomerDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchAccNo;
        private System.Windows.Forms.Button btnSearchAcc;
        private System.Windows.Forms.DataGridView gvCustomerDetails;
    }
}