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
using WindowsFormsApp1.Repository;

namespace WindowsFormsApp1
{
    public partial class Customer_Account_Info_Entry : Form
    {
        Customer customer;
        CustomerManager _customerManager = new CustomerManager();
        public Customer_Account_Info_Entry()
        {
            InitializeComponent();
            customer = new Customer();
            
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int isExecuted;
            bool isExist;
            if (isBlank(customerNameTextBox.Text)) { return; };
            if (isBlank(emailTextBox.Text)) { return; };
            if (isBlank(accountNumberTextBox.Text)) { return; };
            if (isBlank(openingDateTextBox.Text)) { return; };
            if (accountNumberTextBox.Text.Length == 8)
            {
                customer.accountNumber = accountNumberTextBox.Text;
            }
            else
            {
                MessageBox.Show("Account number must be 8 digits");
                return;
            }
            customer.customerName = customerNameTextBox.Text;
            customer.email = emailTextBox.Text;
            customer.openingDate = openingDateTextBox.Text;
            isExist=_customerManager.isExist(customer);
            if (isExist)
            { isExecuted = _customerManager.InsertCustomer(customer);
                if (isExecuted > 0)
                {
                    MessageBox.Show("Saved");
                }
                else
                {
                    MessageBox.Show("Not Saved");
                }
            }
            else
            {
                MessageBox.Show("Account Number Exist!!!");
            }
            
            
        }
        private bool isBlank(String input)
        {
            bool isNull=false;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please fill out all fields!!!");
                isNull = true;
            }
            return isNull;
        }
    }
}
