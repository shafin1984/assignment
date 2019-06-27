using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class indexForm : Form
    {
        public indexForm()
        {
            InitializeComponent();
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            Customer_Account_Info_Entry customer_Account_Info_Entry = new Customer_Account_Info_Entry();
            customer_Account_Info_Entry.Show();
        }

        private void SecondButton_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            transaction.Show();
        }

        private void ThirdButton_Click(object sender, EventArgs e)
        {
            bu search_Customer_Account_Info = new bu();
            search_Customer_Account_Info.Show();
        }
    }
}
