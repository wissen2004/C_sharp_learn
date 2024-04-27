using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //из лабы
            /*
            dataGridView1.RowCount= 15;
            dataGridView1.ColumnCount= 15;
            int[,] a = new int[15, 15];
            int i, j;
            Random rand = new Random();

            for (i = 0; i < 15; i++)
                for (j = 0; j < 15; j++)
                    a[i,j]= rand.Next(-100,100);


                    for (i=0; i<15;i++)
                for(j=0;j<15;j++)
                    dataGridView1.Rows[i].Cells[j].Value = a[i,j].ToString();

            int m = int.MinValue;
            for(i=0;i<15;i++)
                if (a[i,14-i]>m) m= a[i,14-i];
            textBox1.Text = Convert.ToString(m);
            */

            /*1*/
            /*
            dataGridView1.RowCount = 4;
            dataGridView1.ColumnCount = 4;
            int[,] a = new int[4, 4];
            int i, j;
            Random rand = new Random();

            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    a[i, j] = rand.Next(-100, 100);
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
                }
            }

            int m = int.MinValue;
            for (i = 0; i < 4; i++)
            {
                if (a[i, 3 - i] > m) m = a[i, 3 - i];
            }
            textBox1.Text = Convert.ToString(m);
            */


            /*2*/
            /*
            dataGridView1.RowCount = 30;
            dataGridView1.ColumnCount = 30;
            int[,] a = new int[30, 30];
            int i, j;
            Random rand = new Random();

            for (i = 0; i < 30; i++)
            {
                for (j = 0; j < 30; j++)
                {
                    a[i, j] = rand.Next(-100, 100);
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
                }
            }

            int m = int.MinValue;
            for (i = 0; i < 30; i++)
            {
                if (a[i, 29 - i] > m) m = a[i, 29 - i];
            }
            textBox1.Text = Convert.ToString(m);
            */

            /*3*/

            // Матрица А(4,4)
            dataGridView2.RowCount = 4;
            dataGridView2.ColumnCount = 4;
            int[,] a = new int[4, 4];
            Random rand = new Random();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    a[i, j] = rand.Next(-100, 100);
                    dataGridView2.Rows[i].Cells[j].Value = a[i, j].ToString();
                }
            }

            // Матрица А(30,30)
            dataGridView1.RowCount = 30;
            dataGridView1.ColumnCount = 30;
            int[,] b = new int[30, 30];

            for (int i = 0; i < 30; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    b[i, j] = rand.Next(-100, 100);
                    dataGridView1.Rows[i].Cells[j].Value = b[i, j].ToString();
                }


            }
        }
    }
}
