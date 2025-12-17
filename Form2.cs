using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Winform.userDefineFunction
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height = 0.0;
            double weight = 0.0;
            double triangleArea = 0.0;

            if (!double.TryParse(textBox1.Text, out height)
                && double.TryParse(textBox2.Text, out weight))
            {
                triangleArea = calculateTriangleArea(height, weight);
                label6.Text = triangleArea.ToString("F2");

            }
        }

        private double calculateTriangleArea(double height, double weight)
        {
            double Area = 0.5 * height * weight;
            return Area;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double radius = 0.0;
            double circleArea = 0.0;
            double circumference = 0.0;

            if (double.TryParse(textBox4.Text, out radius))
            {
                circleArea = calculateCircleArea(radius);
                circumference = calculateCircumference(radius);
                label15.Text = circumference.ToString("F2");
                label9.Text = circleArea.ToString("F2");
            }
        }
        private double calculateCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }
        private double calculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (int.TryParse(textBox3.Text, out i))
            {
                label19.Text = i.ToString();
                label20.Text = RandomNextNumber(ref i).ToString();
                textBox3.Text = i.ToString();

            }
        }
        private int RandomNextNumber(ref int x)
        {
            Random rand = new Random();
            x = rand.Next(1, 100);
            return x;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double sumary = 0.0;
            string[] inputs = textBox5.Lines;
            double[] numbers = new double[inputs.Length];
            for (int i = 0; i < inputs.Length; i++)
            {
                if (!double.TryParse(inputs[i], out  numbers[i]))
                {
                    numbers[i] = 0.0;
                }
            }
            sumary = CalculateSumary(numbers);
            MessageBox.Show("ผลรวม = " + sumary.ToString("F2"));

        }
        private double CalculateSumary(double[] numbers)
        {
          
            return numbers.Sum();
        }
    }
}
