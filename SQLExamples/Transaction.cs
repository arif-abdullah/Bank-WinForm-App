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
    public partial class Transaction : Form
    {
        string con = @"server='.\SQLEXPRESS'; database='myDB'; Integrated security='true'";
        public Transaction()
        {
            InitializeComponent();
        }

        private void btnTransDeposit_Click(object sender, EventArgs e)
        {
            double amount = 0, totalAmount = 0;
            string accNo;
            accNo = txtTransAccNo.Text;
            try
            {
                if (txtTransAccNo.Text == null || txtTransAmount.Text == null)
                {
                    MessageBox.Show("fill all field");
                    return;
                }

                if (!AccountCheck(accNo))
                {
                    MessageBox.Show("Invalid Account");
                    return;
                }

                if (!double.TryParse(txtTransAmount.Text,out amount) || amount <= 0)
                {
                    MessageBox.Show("Please enter the Correct value or greater than zero");
                    txtTransAmount.Focus();
                    return;
                }

                totalAmount = BalanceCheck(accNo);
                totalAmount += amount;

                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Customer SET Balance = '" + totalAmount + "' WHERE AccountNo = '" + accNo + "'", sqlCon);

                 int exe = cmd.ExecuteNonQuery();

                if (exe > 0)
                {
                    MessageBox.Show("Deposited");
                    this.Hide();
                }
                else
                    MessageBox.Show("Not Deposited");



                sqlCon.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnTransWithdraw_Click(object sender, EventArgs e)
        {
            try
            {

                double amount = 0, totalAmount = 0;
                string accNo;
                accNo = txtTransAccNo.Text;
                try
                {
                    if (txtTransAccNo.Text == null || txtTransAmount.Text == null)
                    {
                        MessageBox.Show("fill all field");
                        return;
                    }

                    if (!AccountCheck(accNo))
                    {
                        MessageBox.Show("Invalid Account");
                        return;
                    }

                    if (!double.TryParse(txtTransAmount.Text, out amount) || amount <= 0)
                    {
                        MessageBox.Show("Please enter the Correct value or greater than zero");
                        txtTransAmount.Focus();
                        return;
                    }

                    if (BalanceCheck(accNo) <= 0 || amount > BalanceCheck(accNo))
                    {
                        MessageBox.Show("No suficient Balance");
                        return;
                    }

                    totalAmount = BalanceCheck(accNo);
                    totalAmount -= amount;

                    SqlConnection sqlCon = new SqlConnection(con);
                    sqlCon.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Customer SET Balance = '" + totalAmount + "' WHERE AccountNo = '" + accNo + "'", sqlCon);

                    int exe = cmd.ExecuteNonQuery();

                    if (exe > 0)
                    {
                        MessageBox.Show("Withdrawn");
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Not Withdrawn");



                    sqlCon.Close();


                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public double BalanceCheck(string accNo)
        {
            double amount = 0;
            try
            {
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT Balance FROM Customer WHERE AccountNo = '" + accNo + "'", sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {

                        amount = Convert.ToDouble(dr.GetValue(0));
                    }
                }
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return amount;
        }

        public bool AccountCheck(string accNo)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(con);
                sqlCon.Open();
                SqlCommand cmd =
                    new SqlCommand("SELECT * FROM Customer WHERE AccountNo = '"+ accNo +"'", sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
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
