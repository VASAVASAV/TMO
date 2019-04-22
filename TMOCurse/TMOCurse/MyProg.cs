using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMOCurse
{
    class MyProg : Form
    {
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox3;
        private Label label3;
        private Button button1;
        private TextBox LogOutputTextBox;
        private Label label4;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox1;

        public MyProg()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LogOutputTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(365, 13);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.MarkerSize = 40;
            series1.Name = "Series1";
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.BorderWidth = 4;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.MarkerSize = 6;
            series3.Name = "Series3";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series4";
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Series5";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Series6";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.MarkerColor = System.Drawing.Color.Green;
            series7.Name = "Series7";
            series8.BorderWidth = 3;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Series8";
            series9.BorderWidth = 3;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "Series9";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Size = new System.Drawing.Size(977, 553);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 164);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальні характеристики";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(265, 123);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(75, 20);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Кількість кроків для чисельного розв\'язку";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Кількість кроків для точного розв\'язку";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(265, 97);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(75, 20);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "1000";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(265, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Значення Τ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(265, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Значення μ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Значення λ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(265, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 506);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(341, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Розв\'язати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogOutputTextBox
            // 
            this.LogOutputTextBox.Location = new System.Drawing.Point(13, 395);
            this.LogOutputTextBox.Multiline = true;
            this.LogOutputTextBox.Name = "LogOutputTextBox";
            this.LogOutputTextBox.Size = new System.Drawing.Size(340, 105);
            this.LogOutputTextBox.TabIndex = 6;
            // 
            // MyProg
            // 
            this.ClientSize = new System.Drawing.Size(1354, 578);
            this.Controls.Add(this.LogOutputTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.Name = "MyProg";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();
            chart1.Series[4].Points.Clear();
            chart1.Series[5].Points.Clear();
            chart1.Series[6].Points.Clear();
            chart1.Series[7].Points.Clear();
            chart1.Series[8].Points.Clear();
            double T, l, m;
            try
            {
                l = Convert.ToDouble(textBox1.Text);
                if (l <= 0)
                    throw new Exception();
            }
            catch
            {
                LogOutputTextBox.Text += "Значення лямбди введено невірно" + Environment.NewLine;
                return;
            }
            try
            {
                m = Convert.ToDouble(textBox2.Text);
                if (m <= 0)
                    throw new Exception();
            }
            catch
            {
                LogOutputTextBox.Text += "Значення мі введено невірно" + Environment.NewLine;
                return;
            }
            try
            {
                T = Convert.ToDouble(textBox3.Text);
                if (T <= 0)
                    throw new Exception();
            }
            catch
            {
                LogOutputTextBox.Text += "Значення часу введено невірно" + Environment.NewLine;
                return;
            }
            double k1, k2;
            k1 = (-3 * l - 2 * m + Math.Sqrt(l * l + 4 * m * l)) / 2;
            k2 = (-3 * l - 2 * m - Math.Sqrt(l * l + 4 * m * l)) / 2;
            double A = (m * m) / (2 * l * l + m * m + 2 * m * l);
            double c1, c2;
            c2 = (k1 * (1 - A) + 2 * l) / (k1 - k2);
            c1 = 1 - A - c2;

            Func<double, double> p0 = (t) => c1 * Math.Exp(k1 * t) + c2 * Math.Exp(k2 * t) + A;
            Func<double, double> p1 = (t) => (k1 * c1 * Math.Exp(k1 * t) + k2 * c2 * Math.Exp(k2 * t)) / m + ((2 * l) / m) * (p0(t));
            Func<double, double> p2 = (t) => 1 - p0(t) - p1(t);

            int AnStep;
            try
            {
                AnStep = Convert.ToInt32(textBox4.Text);
                if (AnStep <= 1)
                    throw new Exception();
            }
            catch
            {
                LogOutputTextBox.Text += "Значення кроку для аналітичного рішення введено невірно" + Environment.NewLine;
                return;
            }


            double time = 0;
            for (i = 0; time < T; i++, time = i * (T / AnStep))
            {
               chart1.Series[0].Points.AddXY(time, p0(time));
               chart1.Series[1].Points.AddXY(time, p1(time));
               chart1.Series[2].Points.AddXY(time, p2(time));
            }


            int ObchStep;
            try
            {
                ObchStep = Convert.ToInt32(textBox4.Text);
                if (ObchStep <= 1)
                    throw new Exception();
            }
            catch
            {
                LogOutputTextBox.Text += "Значення кроку для аналітичного рішення введено невірно" + Environment.NewLine;
                return;
            }
            List<double> XVals = new List<double>();
            List<double> YVals = new List<double>();
            List<double> ZVals = new List<double>();

            double step = T / ObchStep;

            Func<double, double, double, double> pd0 = (t, P0, P1) => (-2 * l * P0 + m * P1);
            Func<double, double, double, double> pd1 = (t, P0, P1) => (-1 * (l + m) * P1 + 2 * l * P0 + m * (1 - P0 - P1));

            double l1, l2, l3, l4;
            double m1, m2, m3, m4;

            time = 0;

            chart1.Series[3].Points.AddXY(time, 1);
            chart1.Series[4].Points.AddXY(time, 0);
            chart1.Series[5].Points.AddXY(time, 0);

            XVals.Add(1);
            YVals.Add(0);
            ZVals.Add(0);

            time = step;

            double Error1 = 0;
            double Error2 = 0;
            double Error3 = 0;
            for (i = 0; time < T; i++, time = i * (T / ObchStep))
            {
                l1 = step * pd0(time, XVals[XVals.Count - 1], YVals[YVals.Count - 1]);
                m1 = step * pd1(time, XVals[XVals.Count - 1], YVals[YVals.Count - 1]);
                l2 = step * pd0(time + step / 2, XVals[XVals.Count - 1] + l1 / 2, YVals[YVals.Count - 1] + m1 / 2);
                m2 = step * pd1(time + step / 2, XVals[XVals.Count - 1] + l1 / 2, YVals[YVals.Count - 1] + m1 / 2);
                l3 = step * pd0(time + step / 2, XVals[XVals.Count - 1] + l2 / 2, YVals[YVals.Count - 1] + m2 / 2);
                m3 = step * pd1(time + step / 2, XVals[XVals.Count - 1] + l2 / 2, YVals[YVals.Count - 1] + m2 / 2);
                l4 = step * pd0(time + step, XVals[XVals.Count - 1] + l3, YVals[YVals.Count - 1] + m3);
                m4 = step * pd1(time + step, XVals[XVals.Count - 1] + l3, YVals[YVals.Count - 1] + m3);
                XVals.Add(XVals[XVals.Count - 1] + (1d / 6) * (l1 + 2 * l2 + 2 * l3 + l4));
                YVals.Add(YVals[YVals.Count - 1] + (1d / 6) * (m1 + 2 * m2 + 2 * m3 + m4));
                ZVals.Add(1 - XVals[XVals.Count - 1] - YVals[YVals.Count - 1]);
                chart1.Series[3].Points.AddXY(time, XVals[XVals.Count - 1]);
                chart1.Series[4].Points.AddXY(time, YVals[XVals.Count - 1]);
                chart1.Series[5].Points.AddXY(time, ZVals[XVals.Count - 1]);
                time += step;
                Error1 += Math.Pow(XVals[XVals.Count - 1] - p0(time), 2);
                Error2 += Math.Pow(YVals[XVals.Count - 1] - p1(time), 2);
                Error3 += Math.Pow(ZVals[XVals.Count - 1] - p2(time), 2);
            }
            Error1 /= i;
            Error2 /= i;
            Error3 /= i;
            LogOutputTextBox.Text += "Середньоквадратична похибка функції p0 - " + Math.Round(Error1,5) + ", функції p1 -" + Math.Round(Error2,5) + ", функції p2 -" + Math.Round(Error3,5) + ", середня похибка - " + Math.Round((Error1+Error2 + Error3)/3,5);

            double TimePassed = 0;
            Random a = new Random();
            Random b = new Random();

            int CurrentPoint = 0;
            int NextPoint = 0;

            double TimeInFirst = 0;
            double TimeInSecond = 0;
            double TimeInThird = 0;

            chart1.Series[6].Points.AddXY(0, 1);
            chart1.Series[7].Points.AddXY(0, 0);
            chart1.Series[8].Points.AddXY(0, 0);

            double tau1, tau2;
            double AllTime;

            while (TimePassed < T)
            {
                switch (CurrentPoint)
                {
                    case 0:
                        {
                            tau1 = (1d / (2 * l)) * Math.Log(1d / (1 - a.NextDouble()));
                            NextPoint = 1;
                            TimeInFirst += tau1;
                            break;
                        }
                    case 1:
                        {
                            tau1 = (1d / ( l)) * Math.Log(1d / (1 - a.NextDouble()));
                            tau2 = (1d / (m)) * Math.Log(1d / (1 - a.NextDouble()));
                            if (tau1 < tau2)
                            {
                                NextPoint = 2 ;
                            }
                            else
                            {
                                NextPoint = 0;
                            }
                            TimeInSecond += (tau1 < tau2) ? (tau1) : (tau2);
                                break;
                        }
                    case 2:
                        {
                            tau1 = (1d / (m)) * Math.Log(1d / (1 - a.NextDouble()));
                            NextPoint = 1;
                            TimeInThird += tau1;
                            break;
                        }
                }
                AllTime = TimeInFirst + TimeInSecond + TimeInThird;
                TimePassed = AllTime;
                CurrentPoint = NextPoint;
                chart1.Series[6].Points.AddXY(AllTime, TimeInFirst / AllTime);
                chart1.Series[7].Points.AddXY(AllTime, TimeInSecond / AllTime);
                chart1.Series[8].Points.AddXY(AllTime, TimeInThird / AllTime);
            }
            
        }
    }
}
