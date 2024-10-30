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

   

    

     
    }
}
