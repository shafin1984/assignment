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
        List<int> targetOneScores = new List<int>();
        List<int> targetTwoScores = new List<int>();
        List<int> targetThreeScores = new List<int>();
        List<int> targetFourScores = new List<int>();
        List<int> averageScores = new List<int>();
        List<int> totalScores = new List<int>();

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
                int targetScoreOne = 0;
                int targetScoreTwo = 0;
                int targetScoreThree = 0;
                int targetScoreFour = 0;
                if (chkSoldier(soldierNoTextBox.Text))
                {
                    MessageBox.Show("Soldier already exist");
                    return;
                }
                soldierNo = soldierNoTextBox.Text;
                soldierName = soldierNameTextBox.Text;
                targetScoreOne = Convert.ToInt32(scoreOneTextBox.Text);
                targetScoreTwo = Convert.ToInt32(scoreTwoTextBox.Text);
                targetScoreThree = Convert.ToInt32(scoreThreeTextBox.Text);
                targetScoreFour = Convert.ToInt32(scoreFourTextBox.Text);
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
               string soldierNo = "";
                string soldierName = "";
                soldierName = serchTextBox.Text;
               soldierName = soldierNameTextBox.Text;
                int index = 0;
                string message = "Sl\t\tSoldier No\tSoldier Name\tAverage Score\tTotal Score\n";

                foreach (string soldier in soldierNos)
           
                {
                    
                    message = message + (index + 1) + "\t\t" + soldier + "\t\t" + soldierNames[index]
                    +"\t\t"+averageScores[index]+"\t\t"+totalScores[index]+"\n";
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
                if (chkSoldier(serchTextBox.Text))
                {
                    int index = 0;
                    string message = "Sl\t\tSoldier No\tSoldier Name\tAverage Score\tTotal Score\n";

                    foreach (string soldierNo in soldierNos)
                    {
                        message = message + (index + 1) + "\t\t" + soldierNo + "\t\t" + soldierNames[index] + "\t\t" + averageScores[index] + "\t\t" + totalScores[index] + "\n";
                        index++;
                    }

                    outputRichTextBox.Text = message;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
            
        }
    }
}
