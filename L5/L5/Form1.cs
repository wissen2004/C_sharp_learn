using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* double x = Convert.ToDouble(textBox2.Text);
             double y = Convert.ToDouble(textBox1.Text);
             double z = Convert.ToDouble(textBox3.Text);

             textBox4.Text += "результаты работы программы ст. петрова И.И." + Environment.NewLine;
             textBox4.Text +="При x = "+textBox2.Text+Environment.NewLine;
             textBox4.Text += "При y = " + textBox1.Text + Environment.NewLine;
             textBox4.Text += "При z = " + textBox3.Text + Environment.NewLine;

             double u;
             if ((z - x) == 0)
                 u = y * Math.Sin(x) * Math.Sin(x) + z;
             else
                 if ((z - x) < 0)
                 u = y * Math.Exp(Math.Sin(x) - z);
             else
                 u = y * Math.Sin(Math.Sin(x)) + z;
             textBox4.Text += "U = " + u.ToString() + Environment.NewLine;
         */



            double x = Convert.ToDouble(textBox2.Text);
            double y = Convert.ToDouble(textBox1.Text);
            double z = Convert.ToDouble(textBox3.Text);

            textBox4.Text += "результаты работы программы ст. петрова И.И." + Environment.NewLine;
            textBox4.Text += "При x = " + textBox2.Text + Environment.NewLine;
            textBox4.Text += "При y = " + textBox1.Text + Environment.NewLine;
            textBox4.Text += "При z = " + textBox3.Text + Environment.NewLine;

            double u;

            double fx = Math.Pow(x, 2); // f(x) = x^2

            if (x - y == 0)
                u = Math.Pow(fx, 2) + Math.Pow(y, 2) + Math.Sin(y);
            else if (x - y > 0)
                u = Math.Pow((fx - y), 2) + Math.Cos(y);
            else
                u = Math.Pow((y - fx), 2) + Math.Tan(y);

            textBox4.Text += "U = " + u.ToString() + Environment.NewLine;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }
    }
}
