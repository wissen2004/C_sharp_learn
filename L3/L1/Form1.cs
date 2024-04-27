using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace L1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {     
            PlotFunction(chart4, "cos(x)", x => Math.Cos(x), -10, 10, 0.1);
            PlotFunction(chart5, "cos(x) + sin(x)", x => Math.Cos(x) + Math.Sin(x), -10, 10, 0.1);
            PlotFunction(chart6, "cos(x) / sin(x)", x => Math.Cos(x) / Math.Sin(x), -10, 10, 0.1);
            PlotFunction(chart7, "sin(x) / cos(x)", x => Math.Sin(x) / Math.Cos(x), -10, 10, 0.1);

            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, 50);
            chart1.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = true;

            chart1.ChartAreas[0].AxisY.ScaleView.Zoom(-1, 1);
            chart1.ChartAreas[0].CursorY.IsUserEnabled = true;
            chart1.ChartAreas[0].CursorY.IsUserSelectionEnabled = true;
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisY.ScrollBar.IsPositionedInside = true;

            for (int i = 0; i < 50; i++)
            {
                chart1.Series[0].Points.AddXY(i, Math.Sin(i));
            }
        }

        int N = 49;
        private void timer1_Tick(object sender, EventArgs e)
        {
            N++;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoom(0, N);
            chart1.Series[0].Points.RemoveAt(0);
            chart1.Series[0].Points.AddXY(N, Math.Sin(N));
            chart1.ChartAreas[0].AxisX.Minimum = N - 50;
            chart1.ChartAreas[0].AxisX.Maximum = N;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
                button1.Text = "Стоп";
            }
            else
            {
                timer1.Enabled = true;
                button1.Text = "Старт";

            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            timer1.Interval = hScrollBar1.Value;
        }
        int k = 0;
        private void chart2_Click(object sender, EventArgs e)
        {

            if (k == 0)
            {
                chart2.Series[0].Points.AddXY(k, 3);
                chart2.Series[0].Points[k].LegendText = "отлично";
            }
            if (k == 1)
            {
                chart2.Series[0].Points.AddXY(k, 10);
                chart2.Series[0].Points[k].LegendText = "хорошо";
            }
            if (k == 2)
            {
                chart2.Series[0].Points.AddXY(k, 5);
                chart2.Series[0].Points[k].LegendText = "удовлетворительно";
            }
            if (k == 3)
            {
                chart2.Series[0].Points.AddXY(k, 2);
                chart2.Series[0].Points[k].LegendText = "неудов";
            }
            k++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader StreamReader = new StreamReader(openFileDialog1.FileName);
                int x = 0;
                while (!StreamReader.EndOfStream)
                {
                    int y = Convert.ToInt16(StreamReader.ReadLine());
                    chart3.Series[0].Points.AddXY(x, y);
                    x++;
                }
                StreamReader.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);
                for (int i = 0; i < chart3.Series[0].Points.Count; i++)
                    streamWriter.WriteLine(chart3.Series[0].Points[i].YValues[0]);
                streamWriter.Close();
            }

        }


        private void PlotFunction(Chart chart, string name, Func<double, double> func, double minX, double maxX, double step)
        {
            Series series = chart.Series.Add(name);
            series.ChartType = SeriesChartType.Line;

            for (double x = minX; x <= maxX; x += step)
            {
                double y = func(x);
                if (!double.IsInfinity(y) && !double.IsNaN(y))
                {
                    series.Points.AddXY(x, y);
                }
            }
        }




    }
}
