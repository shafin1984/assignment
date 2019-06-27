using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using BankApp.BusinessLogicLayer;

namespace WindowsFormsApp1
{
    public partial class bu : Form
    {
        Customer customer;
        CustomerManager _customerManager = new CustomerManager();
        public bu()
        {
            InitializeComponent();
            customer = new Customer();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isExist;
                if (IsBlank(accountNumberTextBox.Text)) { return; };
                if (accountNumberTextBox.Text.Length == 8)
                {
                    customer.accountNumber = accountNumberTextBox.Text;
                    isExist = _customerManager.isExist(customer);
                    if (isExist)
                    {
                        MessageBox.Show("Account number doesn't exist");
                    }
                    else
                    {
                        displayDataGridView.DataSource = _customerManager.Display(customer);
                    }
                }
                else
                {
                    MessageBox.Show("Account number must be 8 digits");
                    return;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private bool IsBlank(String input)
        {
                bool isNull = false;
                if (string.IsNullOrEmpty(input))
                {
                    MessageBox.Show("Please fill out all fields!!!");
                    isNull = true;
                }
                return isNull;
        }
    }
}
