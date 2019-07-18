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
            try
            {
                bool isExist;
                int updated;
                bool isIntegar;

                if (isBlank(accountNumberTextBox.Text)) { return; };
                if (isBlank(amountTextBox.Text)) { return; };
                isIntegar = int.TryParse(amountTextBox.Text, out int i);
                if (!isIntegar)
                {
                    MessageBox.Show("Please input integar number");
                    return;
                }

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
                        if (Convert.ToInt32(amountTextBox.Text) > -1)
                        {
                            customer.balance = Convert.ToInt32(amountTextBox.Text);
                            updated = _customerManager.DepositBalance(customer);
                            if (updated > 0)
                            {
                                MessageBox.Show("Deposited");
                            }
                            else
                            {
                                MessageBox.Show("Not Deposited");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please input positive number");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Account number must be 8 digits");
                    return;
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private bool isBlank(String input)
        {
            bool isNull = false;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Please fill out all fields!!!");
                isNull = true;
            }
            return isNull;
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool isExist;
                bool isIntegar;

                if (isBlank(accountNumberTextBox.Text)) { return; };
                if (isBlank(amountTextBox.Text)) { return; };
                isIntegar = int.TryParse(amountTextBox.Text, out int i);
                if (!isIntegar)
                {
                    MessageBox.Show("Please input integar number");
                    return;
                }
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
                        if (Convert.ToInt32(amountTextBox.Text) > -1)
                        {
                            int bal = _customerManager.CheckBalance(customer);
                            customer.balance = Convert.ToInt32(amountTextBox.Text);
                            if (bal >= customer.balance)
                            {
                                if (_customerManager.WithdrawBalance(customer) > 0)
                                {
                                    MessageBox.Show("Withdrawed");
                                }
                                else
                                {
                                    MessageBox.Show("Not Withdrawed");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Insufficient balance");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please input positive number");
                        }
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
    }
}
