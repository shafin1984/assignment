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
            string name, contact, address, order;
            int quantity, totalPrice=0;
            name = nameTextBox.Text;
            contact = contactTextBox.Text;
            address = addressTextBox.Text;
            order = orderComboBox.Text;

            if (quantityTextBox.Text == "")

            { outputRichTextBox.Text = "You have to select an order and quantity"; }

            else if (orderComboBox.Text == "")
            { outputRichTextBox.Text = "You have to select an order and quantity"; }
            else

            {
                if (typeof(quantityTextBox.Text) !=Int32)

                quantity = Convert.ToInt32(quantityTextBox.Text);

                if (order == "Black")
                { totalPrice = 120 * quantity; }

                else if (order == "Cold")
                { totalPrice = 100 * quantity; }

                else if (order == "Hot")
                { totalPrice = 90 * quantity; }

                else if (order == "Regular")
                { totalPrice = 80 * quantity; }

             outputRichTextBox.Text = "Name: " + nameTextBox.Text + Environment.NewLine +
                                      "Contact No.: " + contactTextBox.Text + Environment.NewLine +
                                      "Address: " + addressTextBox.Text + Environment.NewLine +
                                      "Total Price: " + totalPrice + " Taka";
            }
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
