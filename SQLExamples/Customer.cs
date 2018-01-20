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
    public partial class Customer : Form
    {
        string con = @"server='.\SQLEXPRESS'; database='myDB'; Integrated security='true'";
        public Customer()
        {
            InitializeComponent();
            dtpDate.Value = DateTime.Now;
        }

        private void btnCustSave_Click(object sender, EventArgs e)
        {
            string name, email, accNo;
            DateTime date = dtpDate.Value;
            double amount = 0;
            try
            {
                if (txtCustEmail.Text == null || txtCustEmail.Text == null || txtCustAccNo.Text == null)
                {
                    MessageBox.Show("Please fill the all field");
                }
                else
                {
                    name = txtCustName.Text;
                    email = txtCustEmail.Text;
                    accNo = txtCustAccNo.Text;

                    if (accNo.Length < 8)
                    {
                        MessageBox.Show("fill at least 8 char");
                        txtCustAccNo.Focus();
                        return;
                    }

                    if(AccountCheck(accNo) == true)
                        return;

                    SqlConnection sqlCon = new SqlConnection(con);
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Customer VALUES ('" + name + "','" + email + "','" + accNo + "','" + 
                            amount + "','" + date + "')", sqlCon);

                    int exe = cmd.ExecuteNonQuery();

                    if (exe > 0)
                    {
                        MessageBox.Show("save success");
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Not save");


                    sqlCon.Close();
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        public bool AccountCheck(string accNo)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();
                SqlCommand cmd =
                    new SqlCommand("SELECT * FROM Customer WHERE AccountNo = '" + accNo + "'", sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    MessageBox.Show("This Acc No already Exists...");
                    return true;
                }
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }
    }
}
