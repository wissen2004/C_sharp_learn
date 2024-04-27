using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.TextChanged += TextBox_TextChanged;
            textBox2.TextChanged += TextBox_TextChanged;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double radius))
            {
                label8.Text = "";
                label10.Text = "";
                label9.Text = "";
                return;
            }

            double baseArea = Math.PI * radius * radius;
            double totalSurfaceArea = 2 * Math.PI * radius * (radius + (string.IsNullOrWhiteSpace(textBox2.Text) ? 0 : double.Parse(textBox2.Text)));

            label8.Text = baseArea.ToString("#0.000");
            label10.Text = totalSurfaceArea.ToString("#0.000");
            if (string.IsNullOrWhiteSpace(textBox2.Text) || double.Parse(textBox2.Text) == 0)
            {
                label9.Text = "";
                return;
            }

            double height = double.Parse(textBox2.Text);
            double volume = baseArea * height;
            label9.Text = volume.ToString("#0.000");
        }
    }
}