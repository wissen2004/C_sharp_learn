using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13L
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void выходToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?", 
            "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Функция находится в доработке.", 
            "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void добавитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Menu fm = new Menu();
            fm.Show();
        }

        private void посмотретьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MenuS fms = new MenuS();
            fms.Show();
        }

        private void добавитьToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SotrudnikAdd fs = new SotrudnikAdd();
            fs.Show();
        }

        private void посмотретьToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SotrudnikS fss = new SotrudnikS();
            fss.Show();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales fsl = new Sales();
            fsl.Show();
        }

        private void посмотретьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesS fsls = new SalesS();
            fsls.Show();
        }

        private void добавитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Order fo = new Order();
            fo.Show();
        }

        private void посмотретьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OrderS fos = new OrderS();
            fos.Show();
        }
    }
}
