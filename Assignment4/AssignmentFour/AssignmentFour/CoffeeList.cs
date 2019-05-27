using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentFour
{
    public partial class CoffeeList : Form
    {
        List<string> names = new List<string>();
        List<string> contacts = new List<string>();
        List<string> addresses = new List<string>();
        List<string> orders = new List<string>();
        List<int> quantities = new List<int>();
        List<int> totalPrices = new List<int>();

        public CoffeeList()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string message = "";
            names.Add(nameTextBox.Text);
            contacts.Add(contactTextBox.Text);
            addresses.Add(addressTextBox.Text);
            orders.Add(orderComboBox.Text);
            quantities.Add(Convert.ToInt32(quantityTextBox.Text));
            int index = 0;
            
            foreach (string name in names)
            {
                if (orders[index] == "Black")
                { totalPrices.Insert(index, (120 * quantities[index])); }

                else if (orders[index] == "Cold")
                { totalPrices.Insert(index, (100 * quantities[index])); }

                else if (orders[index] == "Hot")
                { totalPrices.Insert(index, (90 * quantities[index])); }

                else if (orders[index] == "Regular")
                { totalPrices.Insert(index, (80 * quantities[index])); }
                message = message + "Name: " + name + Environment.NewLine +
                                   "Contact No.: " + contacts[index] + Environment.NewLine +
                                   "Address: " + addresses[index] + Environment.NewLine +
                                   "Total Price: " + totalPrices[index] + " Taka" + Environment.NewLine + "\n";
                index++;
            }
            outputRichTextBox.Text = message;

        }
    }
}
