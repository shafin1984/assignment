using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BankCustomer
{
    public partial class BankCustomer : Form
    {
        List<string> userNames = new List<string>();
        List<string> firstNames = new List<string>();
        List<string> lastNames = new List<string>();
        List<int> contactNos = new List<int>();
        List<string> emails = new List<string>();
        List<string> addresses = new List<string>();
        List<int> accountNos = new List<int>();
        List<int> amounts = new List<int>();

        public BankCustomer()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BankCustomer_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = "";
                string firstName = "";
                string lastName = "";
                string email = "";
                string address = "";
                int contactNo = 0;
                int accountNo = 0;
                int amount = 0;
                userNameLabel.Text = "";
                contactNoLabel.Text = "";
                emailLabel.Text = "";
                accountNoLabel.Text = "";

                if (string.IsNullOrEmpty(userNameTextBox.Text) || string.IsNullOrEmpty(firstNameTextBox.Text)||
                    string.IsNullOrEmpty(lastNameTextBox.Text)|| string.IsNullOrEmpty(contactNoTextBox.Text)||
                    string.IsNullOrEmpty(emailTextBox.Text)||string.IsNullOrEmpty(addressTextBox.Text)||
                    string.IsNullOrEmpty(accountNoTextBox.Text))
                {
                    MessageBox.Show("Please fill out all fields!!!");
                    return;
                }
                if (chkUserName(userNameTextBox.Text))
                {
                    userNameLabel.Text = "User name already exist";
                    return;
                }
                
                if (chkEmail(emailTextBox.Text))
                {
                    emailLabel.Text = "Email already exist";
                    return;
                }
                if (chkIntegar(contactNoTextBox.Text))
                {
                    MessageBox.Show("Please insert integar number in Contact field");
                    return;
                }
                if (chkIntegar(accountNoTextBox.Text))
                {
                    MessageBox.Show("Please insert integar number in Account field");
                    return;
                }
                if (chkContactNo(Convert.ToInt32(contactNoTextBox.Text)))
                {
                    contactNoLabel.Text = "Contact No already exist";
                    return;
                }
                
                if (chkAccountNo(Convert.ToInt32(accountNoTextBox.Text)))
                {
                    accountNoLabel.Text = "Account No already exist";
                    return;
                }
                if (!Regex.IsMatch(emailTextBox.Text, "@"))
                {
                    MessageBox.Show("Please enter valid email address");
                    return;
                }
                userName = userNameTextBox.Text;
                userNames.Add(userName);
                firstName = firstNameTextBox.Text;
                firstNames.Add(firstName);
                lastName = lastNameTextBox.Text;
                lastNames.Add(lastName);
                accountNo = Convert.ToInt32(accountNoTextBox.Text);
                accountNos.Add(accountNo);
                contactNo = Convert.ToInt32(contactNoTextBox.Text);
                contactNos.Add(contactNo);
                email = emailTextBox.Text;
                emails.Add(email);
                address = addressTextBox.Text;
                addresses.Add(address);
                amounts.Add(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private bool chkUserName(string user)
        {
            bool isExist = false;
            foreach (string userChk in userNames)
            {
                if (userChk == user)
                    isExist = true;
            }
            return isExist;
        }
        private bool chkContactNo(int contact)
        {
            bool isExist = false;
            foreach (int contactChk in contactNos)
            {
                if (contactChk == contact)
                    isExist = true;
            }
            return isExist;
        }
        private bool chkEmail(string email)
        {
            bool isExist = false;
            foreach (string emailChk in emails)
            {
                if (emailChk == email)
                    isExist = true;
            }
            return isExist;
        }
        private bool chkAccountNo(int account)
        {
            bool isExist = false;
            foreach (int accountChk in accountNos)
            {
                if (accountChk == account)
                    isExist = true;
            }
            return isExist;
        }
        private bool chkIntegar(string account)
        {
            bool isIntegar = true;
            int number;
            if (int.TryParse(account, out number))
            {
                    isIntegar = false;
            }
            return isIntegar;
        }
        private void ShowButton_Click(object sender, EventArgs e)
        {
            try
            {
                int index = 0;
                string message = "Sl\t\tUser Name\tFisrt Name\tLast Name\tContact No\tEmail\tAddress\tAccount No\n";

                foreach (string userName in userNames)
                {
                    message = message + (index + 1) + "\t\t" + userName + "\t\t" + firstNames[index] + "\t\t" + lastNames[index] + "\t\t" + contactNos[index] + "\t\t" + emails[index] + "\t\t" + addresses[index] + "\t\t" + accountNos[index] + "\n";
                    index++;
                }

                outputRichTextBox.Text = message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            try
            {
                int amount = 0;
                int index = 0;
                if (string.IsNullOrEmpty(accountNoBalanceTextBox.Text) || string.IsNullOrEmpty(amountTextBox.Text))
                {
                    MessageBox.Show("Please fill out all fields!!!");
                    return;
                }
                if (!chkAccountNo(Convert.ToInt32(accountNoBalanceTextBox.Text)))
                {
                    MessageBox.Show("Please enter valid account no!!!");
                    return;
                }
                if (Convert.ToInt32(amountTextBox.Text) < 0)
                {
                    MessageBox.Show("Please enter positive value");
                    return;
                }

                int acCount = 0;
                foreach (int account in accountNos)
                {
                   
                        int amt = 0;
                        if (account == (Convert.ToInt32(accountNoBalanceTextBox.Text)))
                        {
                            amt = amt + Convert.ToInt32(amountTextBox.Text);
                            amounts[acCount] =amt;
                        }

                    acCount++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {

        }

        private void balanceButton_Click(object sender, EventArgs e)
        {
            try
            {
                balanceLabel.Text = "";
                if (string.IsNullOrEmpty(accountNoBalanceTextBox.Text))
                {
                    MessageBox.Show("Please fill out account field!!!");
                    return;
                }
                if (!chkAccountNo(Convert.ToInt32(accountNoBalanceTextBox.Text)))
                {
                    MessageBox.Show("Please enter valid account no!!!");
                    return;
                }
                
                foreach (int account in accountNos)
                {

                    if (account == (Convert.ToInt32(accountNoBalanceTextBox.Text)))
                    {
                        balanceLabel.Text = amounts[account].ToString();
                        }
                    

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
