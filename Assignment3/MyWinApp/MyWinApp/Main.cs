using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApp
{
    public partial class CustomerInformation : Form
    {
        const int size = 10;
        string[] name = new string[size];
        string[] contact = new string[size];
        string[] address = new string[size];
        string[] order = new string[size];
        int[] quantity = new int[size];
        int[] totalPrice = new int[size];
        string message = "";
        int index = 0;

        public CustomerInformation()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
                name[index] = nameTextBox.Text;
                contact[index] = contactTextBox.Text;
                address[index] = addressTextBox.Text;
                order[index] = orderComboBox.Text;
                quantity[index] = Convert.ToInt32(quantityTextBox.Text);

                if (order[index] == "Black")
                { totalPrice[index] = 120 * quantity[index]; }

                else if (order[index] == "Cold")
                { totalPrice[index] = 100 * quantity[index]; }

                else if (order[index] == "Hot")
                { totalPrice[index] = 90 * quantity[index]; }

                else if (order[index] == "Regular")
                { totalPrice[index] = 80 * quantity[index]; }

                    message = message + "Name: " + name[index] + Environment.NewLine +
                                       "Contact No.: " + contact[index] + Environment.NewLine +
                                       "Address: " + address[index] + Environment.NewLine +
                                       "Total Price: " + totalPrice[index] + " Taka" + Environment.NewLine+ "\n";

            outputRichTextBox.Text = message;
            index++;
        }

            private void CustomerInformation_Load(object sender, EventArgs e)
            {

            }

            private void groupBox1_Enter(object sender, EventArgs e)
            {

            }

            private void contactTextBox_TextChanged(object sender, EventArgs e)
            {

            }

            private void groupBox1_Enter_1(object sender, EventArgs e)
            {

            }

            private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
            {

            }
        }
    } 
