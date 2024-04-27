namespace L1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart6 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart7 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart7)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, -1);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.LegendText = "Синус";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(994, 196);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title2.Name = "Title2";
            title2.Text = "График функции синус";
            this.chart1.Titles.Add(title1);
            this.chart1.Titles.Add(title2);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(78, 207);
            this.hScrollBar1.Maximum = 2000;
            this.hScrollBar1.Minimum = 10;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(766, 17);
            this.hScrollBar1.TabIndex = 2;
            this.hScrollBar1.Value = 10;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(0, 227);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(356, 142);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "Chart";
            title3.Name = "Title1";
            title3.Text = "Успеваемость группы";
            this.chart2.Titles.Add(title3);
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(0, 375);
            this.chart3.Name = "chart3";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.LegendText = "Файл";
            series3.Name = "Series1";
            this.chart3.Series.Add(series3);
            this.chart3.Size = new System.Drawing.Size(994, 130);
            this.chart3.TabIndex = 4;
            this.chart3.Text = "chart3";
            title4.Name = "Title1";
            title4.Text = "Файл";
            this.chart3.Titles.Add(title4);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Текстовый файл|*.txt";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 511);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Загрузить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Текстовый файл|*.txt";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(94, 511);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chart4
            // 
            chartArea4.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart4.Legends.Add(legend4);
            this.chart4.Location = new System.Drawing.Point(0, 540);
            this.chart4.Name = "chart4";
            series4.ChartArea = "ChartArea1";
            series4.Enabled = false;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart4.Series.Add(series4);
            this.chart4.Size = new System.Drawing.Size(376, 132);
            this.chart4.TabIndex = 7;
            this.chart4.Text = "chart4";
            // 
            // chart5
            // 
            chartArea5.Name = "ChartArea1";
            this.chart5.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart5.Legends.Add(legend5);
            this.chart5.Location = new System.Drawing.Point(600, 540);
            this.chart5.Name = "chart5";
            series5.ChartArea = "ChartArea1";
            series5.Enabled = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart5.Series.Add(series5);
            this.chart5.Size = new System.Drawing.Size(384, 132);
            this.chart5.TabIndex = 8;
            this.chart5.Text = "chart5";
            // 
            // chart6
            // 
            chartArea6.Name = "ChartArea1";
            this.chart6.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart6.Legends.Add(legend6);
            this.chart6.Location = new System.Drawing.Point(0, 704);
            this.chart6.Name = "chart6";
            series6.ChartArea = "ChartArea1";
            series6.Enabled = false;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart6.Series.Add(series6);
            this.chart6.Size = new System.Drawing.Size(376, 132);
            this.chart6.TabIndex = 9;
            this.chart6.Text = "chart6";
            // 
            // chart7
            // 
            chartArea7.Name = "ChartArea1";
            this.chart7.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart7.Legends.Add(legend7);
            this.chart7.Location = new System.Drawing.Point(619, 704);
            this.chart7.Name = "chart7";
            series7.ChartArea = "ChartArea1";
            series7.Enabled = false;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart7.Series.Add(series7);
            this.chart7.Size = new System.Drawing.Size(375, 132);
            this.chart7.TabIndex = 10;
            this.chart7.Text = "chart7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 848);
            this.Controls.Add(this.chart7);
            this.Controls.Add(this.chart6);
            this.Controls.Add(this.chart5);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа№3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart7;
    }
}

