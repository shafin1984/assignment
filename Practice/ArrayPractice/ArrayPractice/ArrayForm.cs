using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayPractice
{
    public partial class Form1 : Form
    {
        const int size = 3;
        int[] number = new int[size];
        int[] number2 = new int[size];
        int index = 0;
        //string output = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string output = "";
            number[index] = Convert.ToInt32(inputTextBox.Text);
            index++;

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                    output = output + number[index] + "\n";
            }
            richTextBox1.Text = output;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            string output = "";
            //   number[index] = Convert.ToInt32(inputTextBox.Text);
            //   index++;

            for (int index = 9; index >= 0; index--)
            {
                if (number[index] != 0)
                    output = output + number[index] + "\n";
            }
            richTextBox1.Text = output;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            int sum = 0;

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                    sum = sum + number[index];
            }
            richTextBox1.Text = sum.ToString();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            string output = "";
            number[index] = Convert.ToInt32(inputTextBox.Text);
            number2[index] = number[index];
            index++;

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                {

                    output = output + "1st Array: " + number[index] + "   " + "2nd Array: " + number2[index] + "\n";
                }
            }
            richTextBox1.Text = output;
        }

        private void DuplicateButton_Click(object sender, EventArgs e)
        {
            int count = 0;
            string output = "";
            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                {
                    for (int i = 0; i < number.Length; i++)
                    {
                        if (index != i)
                        {
                            if (number[index] == number[i])
                            {
                                count++;
                                output = number[index] + ":" + count + "\n";
                            }
                        }
                    }
                }
                richTextBox1.Text = output;
            }

        }

        private void UniqueButton_Click(object sender, EventArgs e)
        {
            string output = "";
            for (int index = 0; index < number.Length; index++)
            {
                if (number[index] != 0)
                {
                    for (int i = 0; i < number.Length; i++)
                    {
                       // if (index != i)
                        {
                            if (number[index] != number[i])
                            {
                                output = output+number[i].ToString();
                            }
                        }
                    }
                }
                richTextBox1.Text = output;
            }
        }
    }
}
