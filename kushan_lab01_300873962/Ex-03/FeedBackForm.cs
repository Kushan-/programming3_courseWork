using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_03
{
    public partial class FeedBackForm : Form
    {
        public FeedBackForm()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
               // displayInputBox.Items.Clear();
                txtName.Text = "";
                txtcomm.Text = "Enter Comments here:";
                textBox1.Text = "";
                comboBox1.Text = "";
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;

                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
                radioButton4.Checked = false;
                radioButton5.Checked = false;

                comboBox1.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcomm_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            string chain = txtName.Text + "\t\t" + txtcomm.Text + "\t\t" + textBox1.Text + "\t\t";
            if (checkBox1.Checked == true) {
                chain = chain + "Links" + "\t\t";
            }
            if (checkBox2.Checked)
            {
                chain = chain + "Site Design" + "\t\t";
            }

            if (checkBox3.Checked)
            {
                chain = chain + "Ease Of Use" + "\t\t";
            }

            if (checkBox4.Checked)
            {
                chain = chain + "Images" + "\t\t";
            }

            if (checkBox5.Checked)
            {
                chain = chain + "Source Code" + "\t\t";
            }

            if (radioButton1.Checked)
            {
                chain = chain + "SearchEngines" + "\t\t";
            }

            if (radioButton2.Checked)
            {
                chain = chain + "Links From Another Site" + "\t\t";
            }

            if (radioButton3.Checked)
            {
                chain = chain + "Dietel.com Website" + "\t\t";
            }

            if (radioButton4.Checked)
            {
                chain = chain + "Reference from a book" + "\t\t";
            }

            if (radioButton5.Checked)
            {
                chain = chain + "Others" + "\t\t";
            }

            chain = chain + comboBox1.Text;
            MessageBox.Show(chain);
        }
        
    }
}
