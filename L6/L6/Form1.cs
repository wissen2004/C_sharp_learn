using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double a = Convert.ToDouble(textBox4.Text);
            textBox5.Text = "Работу выполнил ст кан В.О." + Environment.NewLine;

            double x = x0;
            //double b = 1;
            double b = 3.2;
            double d = 1.3;
            
            while (x <= (xk+dx/2)) 
            {
                /* из лабы
                double y=a*Math.Log(x);
                textBox5.Text += "x=" + Convert.ToString(x) + ";y=" + Convert.ToString(y) + Environment.NewLine;
                x = x + dx;
                */

                /*Задания */
                /*1 арг в   x0=5.3 xk=10.3 dx=0.25 a=1.35  */
                /*
                double y = a * Math.Pow(x, 3) + Math.Pow(Math.Cos(x * x * x - b), 2);
                textBox5.Text += "x=" + Convert.ToString(x) + ";y=" + Convert.ToString(y) + Environment.NewLine;
                x = x + dx;
                */

                /*2 арг d  x0=4.6 xk 5.8 dx=0.2 d=1.3*/
                /*
                double y = Math.Pow(x, 4) + Math.Cos(2 + x * x * x - d);
                textBox5.Text += "x=" + Convert.ToString(x) + ";y=" + Convert.ToString(y) + Environment.NewLine;
                x = x + dx;
                */

                /*3 арг и=3,2 ч0=1 чл=2,2 вч=0,2*/

                double y = 9 * (Math.Pow(x, 3) + Math.Pow(b, 3)) * Math.Tan(x);
                textBox5.Text += "x=" + Convert.ToString(x) + ";y=" + Convert.ToString(y) + Environment.NewLine;
                x = x + dx;

            }
        }
    }
}
