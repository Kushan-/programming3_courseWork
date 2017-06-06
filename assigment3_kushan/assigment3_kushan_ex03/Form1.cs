using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment3_kushan_ex03
{
    public partial class Form1 : Form
    {
        bool isNumeric = false;
        Random rnd = new Random();
        List<int> intList = new List<int>();
        List<double> dList = new List<double>();
        int number;
        double dnumber;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number = rnd.Next(1, 20);
            intList.Add(number);
            
            textBox1.Text = number.ToString();
            isNumeric = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dnumber = rnd.NextDouble();
            dnumber = System.Math.Round(dnumber, 2);
            dList.Add(dnumber);
            textBox2.Text = dnumber.ToString("0.00");
            isNumeric = false;
        }

       


        private void button4_Click(object sender, EventArgs e)
        {
            //double[] doubleArray = { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7 };
            if (isNumeric == false && dList.Count == 0)
            {
                throw new ArgumentException("List is empty");
            }
            else {
                Console.Write("Array intArray contains: ");

                String value = textBox3.Text;

                




                if (isNumeric == true)
                {
                    int val = Int32.Parse(value);


                    var q = DisplayArray(intList, val); // pass an int array argument

                    if (q == 0)
                    {
                        q = -1;
                    }
                    else
                    {
                        q = q - 1;
                    }
                    textBox4.Text = q.ToString();

                }
                else
                {
                    //Debug.WriteLine(dList);
                    double dval = Convert.ToDouble(value);
                    var t = DisplayArray(dList, dval); // pass a double array argument
                    Console.Write("Array charArray contains: ");
                    if (t == 0)
                    {
                        t = -1;
                    }
                    else
                    {
                        t = t - 1;
                    }
                    textBox4.Text = t.ToString();
                }
            }
        }


        private static T DisplayArray<T>(List<T> inputArray, T value) where T : IComparable<T>
        {
            int y = 0;
            foreach (var element in inputArray)
            {
                y++;
                if (element.CompareTo(value) == 0)
                {
                    
                    return (T)Convert.ChangeType(y, typeof(T));
                }

            }

            return default(T);
            Console.WriteLine();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isNumeric == true)
            {
                //listBox1.DataSource = null;
                listBox1.DataSource = intList;
            }
            else {
                listBox1.DataSource = null;
                listBox1.DataSource = dList;

            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {


            if (checkBox1.Checked == true)
            {
                isNumeric = true;
            }
            else {
                isNumeric = false;
            }
            


        }

        
    }
}
