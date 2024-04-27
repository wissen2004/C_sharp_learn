using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g=Graphics.FromHwnd(this.Handle);
            Pen pen = new Pen(Color.Black);
            Brush brush = Brushes.White;
            Brush brush1=Brushes.Blue;
            HatchBrush brush2 = new HatchBrush(HatchStyle.Cross, ForeColor, BackColor);
            HatchBrush brush3 = new HatchBrush(HatchStyle.DiagonalCross, ForeColor, BackColor);
            HatchBrush brush4 = new HatchBrush(HatchStyle.ForwardDiagonal, ForeColor, BackColor);
            HatchBrush brush5 = new HatchBrush(HatchStyle.BackwardDiagonal, ForeColor, BackColor);

            Point[] p =
            {
                new Point(10,0),
                new Point(80,70),
                new Point(90,50),
                new Point(50,200),
            };

            Point[] p1 =
           {
                new Point(10,0),
                new Point(80,70),
                new Point(90,50),
                new Point(50,200),
            };


            Rectangle rect = new Rectangle(0, 0, 110, 220);
            Rectangle rect1 = new Rectangle(10, 0, 100, 100);
            Rectangle rect2 = new Rectangle(10, 110, 100, 100);
            g.FillRectangle(brush, rect);
            if (comboBox2.SelectedItem == "Dash")
            {
                pen.DashStyle=DashStyle.Dash;
            }
            if (comboBox2.SelectedItem == "DashDot")
            {
                pen.DashStyle = DashStyle.DashDot;
            }
            if (comboBox2.SelectedItem == "DashDotDot")
            {
                pen.DashStyle = DashStyle.DashDotDot;
            }
            if (comboBox2.SelectedItem == "Dot")
            {
                pen.DashStyle = DashStyle.Dot;
            }
            if (comboBox4.SelectedItem == "Cross")
            {
                brush1 = brush2;
            }
            if (comboBox4.SelectedItem == "DioganalCross")
            {
                brush1= brush3;
            }
            if (comboBox4.SelectedItem == "ForwardDioganal")
            {
                brush1=brush4;
            }
            if (comboBox4.SelectedItem == "BackwardDiagonal")
            {
                brush1 = brush5;
            }
            if (comboBox1.SelectedItem == "DrawRectangle")
            {
                g.DrawRectangle(pen, rect1);
            }
            if (comboBox3.SelectedItem == "FillRectangle")
            {
                g.FillRectangle(brush1,10,110,100,100);
            }
            if (comboBox1.SelectedItem == "DrawPolygon")
            {
                g.DrawPolygon(pen, p);
            }
            if (comboBox3.SelectedItem == "FillPolygon")
            {
                g.FillPolygon(brush1, p1);
            }
            if (comboBox1.SelectedItem == "DrawElipse")
            {
                g.DrawEllipse(pen, rect1);
            }
            if (comboBox3.SelectedItem == "FillElipse")
            {
                g.FillEllipse(brush1, 10, 110, 100, 100);
            }
            if (comboBox1.SelectedItem == "DrawPie")
            {
                g.DrawPie(pen, rect1, 50,250);
            }
            if (comboBox3.SelectedItem == "FillPie")
            {
                g.FillPie(brush1, rect2,50,250);
            }
            if (comboBox1.SelectedItem == "DrawCurve")
            {
                g.DrawCurve(pen,p);
            }
            if (comboBox1.SelectedItem == "DrawClosedCurve")
            {
                g.DrawClosedCurve(pen,p);
            }
            if (comboBox3.SelectedItem == "FillClosedCurve")
            {
                g.FillClosedCurve(brush1,p1);
            }
            if (comboBox1.SelectedItem == "DrawArc")
            {
                g.DrawArc(pen, rect1, 50,250);
            }
            if (comboBox2.SelectedItem == "DrawBezier")
            {
                g.DrawBezier(pen, p[0], p[1], p[2], p[3]);            
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
