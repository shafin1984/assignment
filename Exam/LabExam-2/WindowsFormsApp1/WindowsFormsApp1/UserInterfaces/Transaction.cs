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
    public partial class Transaction : Form
    {
        Customer customer;
        CustomerManager _customerManager = new CustomerManager();
        
        public Transaction()
        {
            InitializeComponent();
            customer = new Customer();
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            bool isExist;
           
            if (isBlank(accountNumberTextBox.Text)) { return; };
          
            if (accountNumberTextBox.Text.Length == 8)
            {
                customer.accountNumber = accountNumberTextBox.Text;
                isExist=_customerManager.isExist(customer);
                if (isExist)
                {
                    MessageBox.Show("Account number doesn't exist");
                    
                }
                else
                {
                    customer.balance = customer.balance + Convert.ToInt32(amountTextBox.Text);
                }
            }
            else
            {
                MessageBox.Show("Account number must be 8 digits");
                return;
            }
        }
        private bool isBlank(String input)
        {
            bool isNull = false;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please fill out account number!!!");
                isNull = true;
            }
            return isNull;
        }
    }
}
