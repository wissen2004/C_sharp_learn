using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L4
{
    public partial class Form1 : Form
    {
        private double a;
        private double b;
        private double x;

        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "2,56";
            textBox2.Text = "7,18";
            textBox3.Text = "6,37";

            CalculateFunctions();
        }

        private void CalculateFunctions()
        {
            if (!double.TryParse(textBox1.Text, out a) ||
               !double.TryParse(textBox2.Text, out b) ||
               !double.TryParse(textBox3.Text, out x))
            {
                MessageBox.Show("Неверный формат ввода. Пожалуйста, введите числовые значения.");
                return;
            }

            double result1 = (Math.Cos(x - a)) / (Math.Exp(x - a) + (Math.Sqrt(Math.Abs(b * x))));
            double result2 = (Math.Exp(Math.Abs(x - a))) / (Math.Pow(Math.Cos(b * x), 2) + Math.Sin(a * x));
            double result3 = (a * x + b) / (Math.Pow(Math.Log(b * x), 2) + Math.Sqrt(a));
            double result4 = (3.1 * b - Math.Exp(a * x)) / (0.8 * Math.Pow(Math.Log(a * x), 3));
            double result5 = (Math.Atan(Math.Sqrt(b + x))) / (0.3 * Math.Exp(-a * x) - Math.Cos(b * x));
            double result6 = (0.8 * Math.Cos(x + b)) / (Math.Sqrt(5) * (0.2 * x + a));

            textBox4.Text = $"Y1={result1+Environment.NewLine}\nY2={result2 + Environment.NewLine}\nY3={result3 + Environment.NewLine}\nY4={result4 + Environment.NewLine}\nY5={result5 + Environment.NewLine}\nY6={result6 + Environment.NewLine}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateFunctions();
        }
    }
}
