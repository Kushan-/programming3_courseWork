using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_01
{
    //Exception Handling Added To all the required methods- Try and Catch Blocks

    public partial class Ex01 : Form
    {
        public Ex01()
        {
            InitializeComponent();
        }

        private void displayInputBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inputBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double gradeInput = Convert.ToDouble(gradeBox.Text);
                displayInputBox.Items.Add(gradeInput);
                gradeBox.Text = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            try
            {
                displayInputBox.Items.Clear();
                gradeBox.Text = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }

        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (displayInputBox.Items.Count < 1)
                {
                    MessageBox.Show("Please Enter Grade", "No Grades To Remove", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else if (displayInputBox.SelectedIndex != -1)
                {
                    displayInputBox.Items.RemoveAt(displayInputBox.SelectedIndex);
                }

                else
                {
                    MessageBox.Show("Please Select a Grade", "Select a Grade", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }

        private void Calculate_Btn(object sender, EventArgs e)
        {
            try
            {
                double sum = 0;
                double avg = 0;
                if (displayInputBox.Items.Count > 0)
                {
                    foreach (double grade in displayInputBox.Items)
                        sum = sum + grade;
                    avg = sum / displayInputBox.Items.Count;
                    if (sender == sumBtn)
                    {
                        MessageBox.Show("Sum Of Grades: " + sum, "Grade", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }

                    if (sender == avgBtn)
                    {
                        MessageBox.Show("Average Of Grades: " + avg, "Grade", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }

                else
                {
                    MessageBox.Show("You need enter some Grades", "Missing Grades", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }
    }
}
