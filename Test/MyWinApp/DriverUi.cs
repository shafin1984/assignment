using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyWinApp.BLL;
using MyWinApp.Models;

namespace MyWinApp
{
    public partial class DriverUi : Form
    {
        DriverManager _driverManager = new DriverManager();

        private Driver driver;
        public DriverUi()
        {
            InitializeComponent();
            driver = new Driver();
        }

        private void DriverUi_Load(object sender, EventArgs e)
        {
            levelComboBox.DataSource=_driverManager.LoadLevel();
            levelComboBox.Text ="Select One";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(licenseNoTextBox.Text))
                { MessageBox.Show("Please input licenseNo");
                    return;
                }
                driver.LicenseNo = licenseNoTextBox.Text;
                driver.Name = nameTextBox.Text;
                if (ageTextBox.Text.Length == 2)
                {
                    bool isINT;
                    int i;
                    isINT = Int32.TryParse(ageTextBox.Text, out i);
                    if (isINT)
                    {
                        driver.Age = Convert.ToInt32(ageTextBox.Text);
                    }
                    else
                    {
                        MessageBox.Show("Please input integar number");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please input two digits");
                    return;
                }
                driver.Address = addressTextBox.Text;

                driver.LevelID = Convert.ToInt32(levelComboBox.SelectedValue);

                bool isExist;
                isExist = _driverManager.isExist(driver);
                if (isExist)
                {
                    int isExecuted;
                    isExecuted = _driverManager.InsertDriver(driver);
                    if (isExecuted > 0)
                    {
                        MessageBox.Show("Saved");
                    }
                    else
                    {
                        MessageBox.Show("Not Saved!!");
                    }
                }
                else
                {
                    MessageBox.Show("License Number Exist!!");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            displayDataGridView.DataSource = _driverManager.ShowDrivers();

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            driver.LicenseNo = licenseNoTextBox.Text;
            displayDataGridView.DataSource = _driverManager.SearchDrivers(driver);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            driver.LicenseNo = licenseNoTextBox.Text;
            driver.Name = nameTextBox.Text;
            driver.Age = Convert.ToInt32(ageTextBox.Text);
            driver.Address = addressTextBox.Text;
            driver.LevelID = Convert.ToInt32(levelComboBox.SelectedValue);

            int isExecuted;
            isExecuted = _driverManager.UpdateDriver(driver);
            if (isExecuted > 0)
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Not Updated!!");
            }
        }

        private void displayDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            displayDataGridView.Rows[e.RowIndex].Cells["SL"].Value = (e.RowIndex + 1).ToString();
        }
    }
}
