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

namespace LabExam
{
    

    public partial class FRAS : Form
    {
        List<string> soldierNos = new List<string>();
        List<string> soldierNames = new List<string>();
        List<double> targetOneScores = new List<double>();
        List<double> targetTwoScores = new List<double>();
        List<double> targetThreeScores = new List<double>();
        List<double> targetFourScores = new List<double>();
        List<double> averageScores = new List<double>();
        List<double> totalScores = new List<double>();

        public FRAS()
        {
            InitializeComponent();
        }
        

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                string soldierNo = "";
                string soldierName = "";
                double targetScoreOne = 0;
                double targetScoreTwo = 0;
                double targetScoreThree = 0;
                double targetScoreFour = 0;
                if (chkSoldier(soldierNoTextBox.Text))
                {
                    MessageBox.Show("Soldier already exist");
                    return;
                }
                soldierNo = soldierNoTextBox.Text;
                soldierName = soldierNameTextBox.Text;
                targetScoreOne = Convert.ToDouble(scoreOneTextBox.Text);
                targetScoreTwo = Convert.ToDouble(scoreTwoTextBox.Text);
                targetScoreThree = Convert.ToDouble(scoreThreeTextBox.Text);
                targetScoreFour = Convert.ToDouble(scoreFourTextBox.Text);
                soldierNos.Add(soldierNo);
                soldierNames.Add(soldierName);
                targetOneScores.Add(targetScoreOne);
                targetTwoScores.Add(targetScoreTwo);
                targetThreeScores.Add(targetScoreThree);
                targetFourScores.Add(targetScoreFour);
                averageScores.Add((targetScoreOne + targetScoreTwo + targetScoreThree + targetScoreFour) / 4);
                totalScores.Add((targetScoreOne + targetScoreTwo + targetScoreThree + targetScoreFour));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool chkSoldier(string user)
        {
            
                bool isExist = false;
                foreach (string soldierChk in soldierNos)
                {
                    if (soldierChk == user)
                        isExist = true;
                }
                return isExist;
                
        }

        private void FRAS_Load(object sender, EventArgs e)
        {

        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            try
            {
                string soldierName = "";
               soldierName = soldierNameTextBox.Text;
                int index = 0;
                string message = "Sl\t\tSoldier No\tSoldier Name\tAverage Score\tTotal Score\n";

                foreach (string soldier in soldierNos)
                {
                    message = message + (index + 1) + "\t\t" + soldier + "\t\t" + soldierNames[index]
                    + "\t\t" + averageScores[index] + "\t\t" + totalScores[index] + "\n";

                    if (averageScores[index] == averageScores.Max())
                        outputAvgTextBox.Text = soldierNames[index];
                    if (totalScores[index] == totalScores.Max())
                        outputTotalTextBox.Text = soldierNames[index];
                    index++;
                }
                outputRichTextBox.Text = message;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (soldierNoRadioButton.Checked)
                {
                    int index = 0;
                    string message = "Sl\t\tSoldier No\tSoldier Name\tAverage Score\tTotal Score\n";
                    string soldierNO = "";
                    string soldierName = "";
                    soldierNO = searchTextBox.Text;
                    foreach (string soldier in soldierNos)
                    {
                        if (soldier == soldierNO)
                        {
                            message = message + (index + 1) + "\t\t" + soldier + "\t\t" + soldierNames[index]
                            + "\t\t" + averageScores[index] + "\t\t" + totalScores[index] + "\n";
                            soldierName = soldierNames[index];
                        }
                        index++;
                    }
                    outputRichTextBox.Text = message;
                    outputAvgTextBox.Text = soldierName;
                    outputTotalTextBox.Text = soldierName;
                }
                else if (soldierNameRadioButton.Checked)
                {
                    int index = 0;
                    string message = "Sl\t\tSoldier No\tSoldier Name\tAverage Score\tTotal Score\n";
                    string soldierName = "";
                    soldierName = searchTextBox.Text;
                    foreach (string soldier in soldierNames)
                    {
                        if (soldier == soldierName)
                        {
                            message = message + (index + 1) + "\t\t" + soldierNos[index] + "\t\t" + soldier
                            + "\t\t" + averageScores[index] + "\t\t" + totalScores[index] + "\n";
                        }
                        index++;
                    }
                    outputRichTextBox.Text = message;
                    outputAvgTextBox.Text = searchTextBox.Text;
                    outputTotalTextBox.Text = searchTextBox.Text;
                }
                else
                {
                    int index = 0;
                    string message = "Sl\t\tSoldier No\tSoldier Name\tAverage Score\tTotal Score\n";
                    foreach (string soldier in soldierNos)
                    {
                        message = message + (index + 1) + "\t\t" + soldier + "\t\t" + soldierNames[index]
                        + "\t\t" + averageScores[index] + "\t\t" + totalScores[index] + "\n";
                        index++;
                    }
                    outputRichTextBox.Text = message;
                }
                soldierNameRadioButton.Checked = false;
                soldierNoRadioButton.Checked = false;
                searchTextBox.Text = "";
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
