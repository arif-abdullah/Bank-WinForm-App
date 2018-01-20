using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLExamples
{
    public partial class Search : Form
    {

        string con = @"server='.\SQLEXPRESS'; database='myDB'; Integrated security='true'";
        public Search()
        {
            InitializeComponent();
            DataGridViewInitialDesign();
        }

        public void DataGridViewInitialDesign()
        {
            try
            {
                gvCustomerDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                gvCustomerDetails.AutoGenerateColumns = false;

                gvCustomerDetails.ColumnCount = 4;
                gvCustomerDetails.Columns[0].Name = "AccNo";
                gvCustomerDetails.Columns[0].HeaderText = "Account Number";
                gvCustomerDetails.Columns[0].DataPropertyName = "AccountNo";

                gvCustomerDetails.Columns[1].Name = "Name";
                gvCustomerDetails.Columns[1].HeaderText = "Customer Name";
                gvCustomerDetails.Columns[1].DataPropertyName = "Name";

                gvCustomerDetails.Columns[2].Name = "OpeningDate";
                gvCustomerDetails.Columns[2].HeaderText = "Opening Date";
                gvCustomerDetails.Columns[2].DataPropertyName = "OpeningDate";

                gvCustomerDetails.Columns[3].Name = "Balance";
                gvCustomerDetails.Columns[3].HeaderText = "Balance";
                gvCustomerDetails.Columns[3].DataPropertyName = "Balance";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchAcc_Click(object sender, EventArgs e)
        {
            string accNo;
            try
            {
                if (txtSearchAccNo.Text == null)
                {
                    MessageBox.Show("fill the Acc No");
                    return;
                    
                }

                accNo = txtSearchAccNo.Text;
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Customer WHERE AccountNo = '"+ accNo +"'", sqlCon);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    gvCustomerDetails.DataSource = null;
                    gvCustomerDetails.DataSource = dt;
                    gvCustomerDetails.ClearSelection();
                }
                else
                {
                    MessageBox.Show("This Acount not exists...");
                    gvCustomerDetails.DataSource = null;
                }

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
