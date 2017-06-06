using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_02
{
    public partial class StudentRegistration : Form
    {
        public StudentRegistration()
        {
            InitializeComponent();
        }

        private void StudentRegistration_Load(object sender, EventArgs e)
        {

        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string tCourses = "";
                foreach (string a in lstCourses.Items)
                {
                    tCourses = tCourses + a.ToString() + "  ";
                }

                txtDisplay.Text = name.Text + "\t\t" + addr.Text + "\t\t" + city.Text +"\t\t" + postalCode.Text +"\t\t" + province.Text +"\t\t" + pNo.Text + "\t\t" + tCourses;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }

        private void Course_Click(object sender, EventArgs e)
        {
            try
            {

                comboBoxCourses.Items.Clear();
                comboBoxCourses.Text = "Select Course or Courses";
                lstCourses.Items.Clear();
                if (sender == radioBtnCPA)
                {
                    comboBoxCourses.Items.Add("Advance Programming");
                    comboBoxCourses.Items.Add("Computer Fundamentals");
                    comboBoxCourses.Items.Add("Software Engineering");
                }

                else if (sender == radioBtnCP)

                {
                    comboBoxCourses.Items.Add("CSharp");
                    comboBoxCourses.Items.Add("Java");
                    comboBoxCourses.Items.Add("Web Programming");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }

        private void radioBtn2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioBtnCPA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                {
                    if (comboBoxCourses.SelectedIndex != -1)
                    {
                        if (lstCourses.Items.Contains(comboBoxCourses.SelectedItem))
                        {
                            MessageBox.Show("This Course has been already Seleted", "This Course has been already Seleted", MessageBoxButtons.OK);
                        }
                        else
                        {
                            lstCourses.Items.Add(comboBoxCourses.SelectedItem);
                        }
                        comboBoxCourses.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
