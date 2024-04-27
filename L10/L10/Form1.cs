using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L10
{
    public partial class Form1 : Form
    {
        double kr = 0;
        public Form1()
        {
            InitializeComponent();

//            dataGridView1.Rows.Add(3);
            dataGridView1.Rows.Add(8);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Rows[0].Cells[0].Value = "Доллар США";
            dataGridView1.Rows[1].Cells[0].Value = "Евро";
            dataGridView1.Rows[2].Cells[0].Value = "Фунт UK";
            dataGridView1.Rows[3].Cells[0].Value = "Евро";
            dataGridView1.Rows[4].Cells[0].Value = "Японский йен";
            dataGridView1.Rows[5].Cells[0].Value = "Фунт стерлинга";
            dataGridView1.Rows[6].Cells[0].Value = "Гривна Украины";
            dataGridView1.Rows[7].Cells[0].Value = "Рубль Беларуси";


            dataGridView1.Rows[0].Cells[1].Value = "30";
            double vd = System.Convert.ToDouble(dataGridView1.Rows[0].Cells[1].Value);
            dataGridView1.Rows[1].Cells[1].Value = "45";
            double ve = System.Convert.ToDouble(dataGridView1.Rows[1].Cells[1].Value);
            dataGridView1.Rows[2].Cells[1].Value = "50";
            double vf = System.Convert.ToDouble(dataGridView1.Rows[2].Cells[1].Value);
            dataGridView1.Rows[3].Cells[1].Value = "90";
            double qf = System.Convert.ToDouble(dataGridView1.Rows[3].Cells[1].Value);
            dataGridView1.Rows[4].Cells[1].Value = "70";
            double wf = System.Convert.ToDouble(dataGridView1.Rows[4].Cells[1].Value);
            dataGridView1.Rows[5].Cells[1].Value = "100";
            double ef = System.Convert.ToDouble(dataGridView1.Rows[5].Cells[1].Value);
            dataGridView1.Rows[6].Cells[1].Value = "25";
            double rf = System.Convert.ToDouble(dataGridView1.Rows[6].Cells[1].Value);
            dataGridView1.Rows[7].Cells[1].Value = "60";
            double tf = System.Convert.ToDouble(dataGridView1.Rows[7].Cells[1].Value);


            string s = textBox1.Text;
            double k = System.Convert.ToDouble(s);

            s = textBox2.Text;
            double r = System.Convert.ToDouble(s);
            double commission = k / 100 * r;
            



            dataGridView1.Rows[0].Cells[2].Value = s;
            dataGridView1.Rows[1].Cells[2].Value = s;
            dataGridView1.Rows[2].Cells[2].Value = s;

            dataGridView1.Rows[3].Cells[2].Value = s;
            dataGridView1.Rows[4].Cells[2].Value = s;
            dataGridView1.Rows[5].Cells[2].Value = s;
            dataGridView1.Rows[6].Cells[2].Value = s;
            dataGridView1.Rows[7].Cells[2].Value = s;


            dataGridView1.Rows[0].Cells[3].Value = s;
            double v = (r - commission) / vd;
            dataGridView1.Rows[0].Cells[4].Value = v.ToString();

            v = (r - commission) / ve;
            dataGridView1.Rows[1].Cells[4].Value = v.ToString();

            v = (r - commission) / vf;
            dataGridView1.Rows[2].Cells[4].Value = v.ToString();

            v = (r - commission) / qf;
            dataGridView1.Rows[3].Cells[4].Value = v.ToString();

            v = (r - commission) / wf;
            dataGridView1.Rows[4].Cells[4].Value = v.ToString();

            v = (r - commission) / ef;
            dataGridView1.Rows[5].Cells[4].Value = v.ToString();

            v = (r - commission) / rf;
            dataGridView1.Rows[6].Cells[4].Value = v.ToString();

            v = (r - commission) / tf;
            dataGridView1.Rows[7].Cells[4].Value = v.ToString();






            dataGridView1.Rows[0].Cells[3].Value = commission.ToString(); 
            dataGridView1.Rows[1].Cells[3].Value = commission.ToString();
            dataGridView1.Rows[2].Cells[3].Value = commission.ToString();
            dataGridView1.Rows[3].Cells[3].Value = commission.ToString();
            dataGridView1.Rows[4].Cells[3].Value = commission.ToString();
            dataGridView1.Rows[5].Cells[3].Value = commission.ToString();
            dataGridView1.Rows[6].Cells[3].Value = commission.ToString();
            dataGridView1.Rows[7].Cells[3].Value = commission.ToString();
           


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
