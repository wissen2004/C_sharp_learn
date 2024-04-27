using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace L7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int[] Mas = new int[15];
        /*private int[] array = new int[20];//1*/
        private int[] array = new int[50];
        private Random rand = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            //Из лабы
            /*
            listBox1.Items.Clear();
            Random rand = new Random();
            for (int i=0; i<15; i++)
            {
                Mas[i]=rand.Next(-50,50);
                listBox1.Items.Add("Mas[" + i.ToString() + "]=" + Mas[i].ToString());

            }*/

            /*Задагте 1*/
            /*
            listBox1.Items.Clear();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-50, 51);
                listBox1.Items.Add($"array[{i}] = {array[i]}");
            }*/


            /*Задание 2*/
            listBox1.Items.Clear();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-20, 61);
                listBox1.Items.Add($"array[{i}] = {array[i]}");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //из лабы
            /*
            listBox2.Items.Clear();
            for(int  i=0; i < 15; i++)
            {
                if (Mas[i]<0)
                    Mas[i]=0;
                listBox2.Items.Add("Mas["+Convert.ToString(i)+"]="+Mas[i].ToString());
            }*/

            /*Задание 1*/
            /*
            listBox2.Items.Clear();
            foreach (int num in array)
            {
                listBox2.Items.Add($"array[{Array.IndexOf(array, num)}] = {num}");
            }*/

            /*Задание 2*/

            listBox2.Items.Clear();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Math.Max(0, array[i]);
                listBox2.Items.Add($"array[{i}] = {array[i]}");
            }

        }
    }
}
