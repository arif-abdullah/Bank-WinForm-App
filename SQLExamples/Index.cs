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
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        

        private void lbCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Customer customer = new Customer();
            customer.Show();
        }

        private void lbTransaction_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Transaction transaction = new Transaction();
            transaction.Show();
        }

        private void lbSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Search search = new Search();
            search.Show();
        }
    }
}
