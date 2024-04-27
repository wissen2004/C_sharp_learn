using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace L9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < listBox1.Items.Count)
            {
                string str = (string)listBox1.Items[listBox1.SelectedIndex];
                int len = str.Length;
                int count = 0;
                int i = 0;
                while (i < len)
                {
                    if (str[i] == ' ')
                    {
                        count++;
                    }
                    i++;
                }
                label1.Text = "Количество пробелов = " + count.ToString();
            }
            else
            {
                MessageBox.Show("Выберите элемент из списка.");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
           int index = listBox2.SelectedIndex;
           string str = (String)listBox2.Items[index];
            int len = str.Length;
            int count = 0;
            for(int i=0; i < str.Length; i++) {
                if ((str[i]=='1') || (str[i]=='0'))
                        count++;
            }
            label2.Text = "Количество 0 и 1 = "+count.ToString();
        }
    }
}
