using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibApp.Models.Models;
using LibApp.BLL.BLL;

namespace LibApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        StudentManager _studentManager;
        private void AddButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            _studentManager = new StudentManager();
            student.ID = idTextBox.Text;
            student.Name = nameTextBox.Text;
            student.Roll = rollTextBox.Text;
            student.Address = addressTextBox.Text;
            student.Contact = Convert.ToInt32(contactTextBox.Text);
            int added=_studentManager.AddStudent(student);
            if (added > 0)
            {
                MessageBox.Show("Student Added Successfully");
            }
            else
            {
                MessageBox.Show("Student Not Added!!!");
            }
        }

        private void displayDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            displayDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _studentManager = new StudentManager();
            displayDataGridView.DataSource = _studentManager.Display();
        }
    }
}
