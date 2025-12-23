using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Winform.userDefineFunction
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string letter = textBox1.Text;
            int size = int.Parse(textBox2.Text);

            if (radioButton1.Checked)
            {
                textBox3.Text = Triangle1(letter, size);
            }
            else if (radioButton2.Checked)
            {
                textBox3.Text = Triangle2(letter, size);
            }
            else if (radioButton3.Checked)
            {
                string result;
                Triangle3(letter, size, out result);
                textBox3.Text = result;
            }
        }


        
        
        private string Triangle1(string letter, int size)
        {
            string result = "";

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    result += letter;
                }
                result += Environment.NewLine;
            }

            return result;
        }
        private void Triangle3(string letter, int size, out string result)
        {
            result = "";

            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    result += letter;
                }
                result += Environment.NewLine;
            }
        }
        private string Triangle2(string letter, int size)
        {
            string result = "";

            for (int i = size; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    result += letter;
                }
                result += Environment.NewLine;
            }

            return result;
        }




    }
}
