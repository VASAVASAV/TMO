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
        private TextBox textBox6;
        private Label label6;
        private Label label10;
        private Label label7;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label9;
        private TextBox textBox9;
        private GroupBox groupBox2;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox groupBox3;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private GroupBox groupBox4;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private CheckBox checkBox11;
        private CheckBox checkBox12;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label8;
        private TextBox textBox10;
        private Label label11;
        private TextBox textBox11;
        private TabPage tabPage3;
        private Label label12;
        private Label label13;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private Label label14;
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
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(357, 12);
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
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series10.Legend = "Legend1";
            series10.Name = "Series10";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series11.Legend = "Legend1";
            series11.Name = "Series11";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series12.Legend = "Legend1";
            series12.Name = "Series12";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(977, 656);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Вхід у стац. режим для p2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Вхід у стац. режим для p1";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(243, 13);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(75, 20);
            this.textBox7.TabIndex = 17;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(243, 39);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(75, 20);
            this.textBox8.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Вхід у стац. режим для p0";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(243, 65);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(75, 20);
            this.textBox9.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(237, 146);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(75, 20);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Маштабування імітації";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(237, 120);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(75, 20);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Кількість кроків для чисельного розв\'язку";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Кількість кроків для точного розв\'язку";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(237, 94);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(75, 20);
            this.textBox4.TabIndex = 6;
            this.textBox4.Text = "1000";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(237, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(75, 20);
            this.textBox3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Значення Τ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(237, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "0,1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Значення μ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Значення λ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(237, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0,025";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 609);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(341, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Розв\'язати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogOutputTextBox
            // 
            this.LogOutputTextBox.Location = new System.Drawing.Point(13, 428);
            this.LogOutputTextBox.Multiline = true;
            this.LogOutputTextBox.Name = "LogOutputTextBox";
            this.LogOutputTextBox.Size = new System.Drawing.Size(340, 175);
            this.LogOutputTextBox.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 68);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "p0";
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Checked = true;
            this.checkBox4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox4.Location = new System.Drawing.Point(96, 42);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(90, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Стац. режим";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(9, 43);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(64, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Імітація";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(96, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(76, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Чисельне";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(9, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Аналітичне";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox5);
            this.groupBox3.Controls.Add(this.checkBox6);
            this.groupBox3.Controls.Add(this.checkBox7);
            this.groupBox3.Controls.Add(this.checkBox8);
            this.groupBox3.Location = new System.Drawing.Point(4, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(320, 68);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "p1";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Checked = true;
            this.checkBox5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox5.Location = new System.Drawing.Point(88, 42);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(90, 17);
            this.checkBox5.TabIndex = 3;
            this.checkBox5.Text = "Стац. режим";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Checked = true;
            this.checkBox6.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox6.Location = new System.Drawing.Point(9, 43);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(64, 17);
            this.checkBox6.TabIndex = 2;
            this.checkBox6.Text = "Імітація";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Checked = true;
            this.checkBox7.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox7.Location = new System.Drawing.Point(88, 19);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(76, 17);
            this.checkBox7.TabIndex = 1;
            this.checkBox7.Text = "Чисельне";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Checked = true;
            this.checkBox8.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox8.Location = new System.Drawing.Point(9, 20);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(81, 17);
            this.checkBox8.TabIndex = 0;
            this.checkBox8.Text = "Аналітичне";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBox9);
            this.groupBox4.Controls.Add(this.checkBox10);
            this.groupBox4.Controls.Add(this.checkBox11);
            this.groupBox4.Controls.Add(this.checkBox12);
            this.groupBox4.Location = new System.Drawing.Point(6, 154);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(318, 81);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "p2";
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Checked = true;
            this.checkBox9.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox9.Location = new System.Drawing.Point(88, 42);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(90, 17);
            this.checkBox9.TabIndex = 3;
            this.checkBox9.Text = "Стац. режим";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Checked = true;
            this.checkBox10.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox10.Location = new System.Drawing.Point(9, 43);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(64, 17);
            this.checkBox10.TabIndex = 2;
            this.checkBox10.Text = "Імітація";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Checked = true;
            this.checkBox11.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox11.Location = new System.Drawing.Point(88, 19);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(76, 17);
            this.checkBox11.TabIndex = 1;
            this.checkBox11.Text = "Чисельне";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Checked = true;
            this.checkBox12.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox12.Location = new System.Drawing.Point(9, 20);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(81, 17);
            this.checkBox12.TabIndex = 0;
            this.checkBox12.Text = "Аналітичне";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(338, 280);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textBox10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.textBox11);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(330, 254);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Загальні характеристики";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Точність виводу, знаків";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(237, 172);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(75, 20);
            this.textBox10.TabIndex = 12;
            this.textBox10.Text = "5";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Точність входу у стаціонарний режим";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(237, 198);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(75, 20);
            this.textBox11.TabIndex = 15;
            this.textBox11.Text = "0,001";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(330, 254);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Вивід графіків";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.textBox12);
            this.tabPage3.Controls.Add(this.textBox13);
            this.tabPage3.Controls.Add(this.textBox14);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.textBox8);
            this.tabPage3.Controls.Add(this.textBox9);
            this.tabPage3.Controls.Add(this.textBox7);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(330, 254);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Додаткові характеристики";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Час, проведений у стані p2";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Час, проведений у стані p0";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(243, 91);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(75, 20);
            this.textBox12.TabIndex = 22;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(243, 117);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(75, 20);
            this.textBox13.TabIndex = 20;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(243, 143);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(75, 20);
            this.textBox14.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Час, проведений у стані p1";
            // 
            // MyProg
            // 
            this.ClientSize = new System.Drawing.Size(1354, 681);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.LogOutputTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "MyProg";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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
            chart1.Series[9].Points.Clear();
            chart1.Series[10].Points.Clear();
            chart1.Series[11].Points.Clear();
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

            int AccNums;
            try
            {
                AccNums = Convert.ToInt32(textBox10.Text);
                if (AccNums < 0)
                    throw new Exception();
            }
            catch
            {
                textBox10.Text = "5";
                AccNums = 5;
            }

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

            double Accuracy;
            try
            {
                Accuracy = Convert.ToDouble(textBox11.Text);
                if (Accuracy < 0)
                    throw new Exception();
            }
            catch
            {
                Accuracy = 0.001;
                textBox11.Text = "0,001";
            }

            double time = 0;
            if (checkBox1.Checked)
            {
                for (i = 0; time < T; i++, time = i * (T / AnStep))
                {
                    chart1.Series[0].Points.AddXY(time, p0(time));
                }
            }
            time = 0;
            if (checkBox8.Checked)
            {
                for (i = 0; time < T; i++, time = i * (T / AnStep))
                {
                    chart1.Series[1].Points.AddXY(time, p1(time));
                }
            }
            time = 0;
            if (checkBox12.Checked)
            {
                for (i = 0; time < T; i++, time = i * (T / AnStep))
                {
                    chart1.Series[2].Points.AddXY(time, p2(time));
                }
            }
            double temp;
            time = 0;
            for (i = 0; time < T; i++, time = i * (T / AnStep))
            {
                temp = k1 * c1 * Math.Exp(k1 * time) + k2 * c2 * Math.Exp(k2 * time);
                if (Math.Abs(k1 * c1 * Math.Exp(k1 * time) + k2 * c2 * Math.Exp(k2 * time)) < Accuracy)
                {
                    temp = p0(time);
                    time = 0;
                    if (checkBox4.Checked)
                        for (i = 0; time < T; i += 20, time = i * (T / AnStep))
                        {
                            chart1.Series[9].Points.AddXY(time, temp);
                        }
                    textBox7.Text = "" + Math.Round(temp,AccNums);
                    break;
                }
            }
            time = 0;
            for (i = 0; time < T; i++, time = i * (T / AnStep))
            {
                if (Math.Abs(Math.Exp(k1 * time) * ((k1 * k1 * c1) / m + (2 * l * k1 * c1) / m) + Math.Exp(k2 * time) * ((k2 * k2 * c2) / m + (2 * c1 * k2) / m)) < Accuracy)
                {
                    temp = p1(time);
                    time = 0;
                    if (checkBox5.Checked)
                        for (i = 0; time < T; i += 20, time = i * (T / AnStep))
                        {
                            chart1.Series[10].Points.AddXY(time, temp);
                        }
                    textBox8.Text = "" + Math.Round(temp, AccNums);
                    break;
                }
            }
            time = 0;
            for (i = 0; time < T; i++, time = i * (T / AnStep))
            {
                if (Math.Abs(-1 * (k1 * c1 * Math.Exp(k1 * time) + k2 * c2 * Math.Exp(k2 * time)) - (Math.Exp(k1 * time) * ((k1 * k1 * c1) / m + (2 * l * k1 * c1) / m) + Math.Exp(k2 * time) * ((k2 * k2 * c2) / m + (2 * c1 * k2) / m))) < Accuracy)
                {
                    temp = p2(time);
                    time = 0;
                    if (checkBox9.Checked)
                        for (i = 0; time < T; i += 20, time = i * (T / AnStep))
                        {
                            chart1.Series[11].Points.AddXY(time, temp);
                        }
                    textBox9.Text = "" + Math.Round(temp, AccNums);
                    break;
                }
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
                if (checkBox2.Checked)
                    chart1.Series[3].Points.AddXY(time, XVals[XVals.Count - 1]);
                if (checkBox7.Checked)
                    chart1.Series[4].Points.AddXY(time, YVals[XVals.Count - 1]);
                if (checkBox11.Checked)
                    chart1.Series[5].Points.AddXY(time, ZVals[XVals.Count - 1]);
                time += step;
                Error1 += Math.Pow(XVals[XVals.Count - 1] - p0(time), 2);
                Error2 += Math.Pow(YVals[XVals.Count - 1] - p1(time), 2);
                Error3 += Math.Pow(ZVals[XVals.Count - 1] - p2(time), 2);
            }
            Error1 /= i;
            Error2 /= i;
            Error3 /= i;
            LogOutputTextBox.Text += "Середньоквадратична похибка функції p0 - " + Math.Round(Error1, AccNums) + ", функції p1 -" + Math.Round(Error2, AccNums) + ", функції p2 -" + Math.Round(Error3, AccNums) + ", середня похибка - " + Math.Round((Error1 + Error2 + Error3) / 3, 5);

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

            double Multiplyier = 1;
            try
            {
                Multiplyier = Convert.ToDouble(textBox6.Text);
            }
            catch

            {
                Multiplyier = 1;
            }

            double tau1, tau2;
            double AllTime;

            while (TimePassed < T * Multiplyier)
            {
                switch (CurrentPoint)
                {
                    case 0:
                        {
                            tau1 = (1d / (2 * l)) * Math.Log(1d / (1 - a.NextDouble()));
                            NextPoint = 1;
                            if (TimePassed + tau1 > T * Multiplyier)
                                tau1 = T * Multiplyier - TimePassed;
                            TimeInFirst += tau1;
                            break;
                        }
                    case 1:
                        {
                            tau1 = (1d / (l)) * Math.Log(1d / (1 - a.NextDouble()));
                            tau2 = (1d / (m)) * Math.Log(1d / (1 - a.NextDouble()));
                            if (tau1 < tau2)
                            {
                                NextPoint = 2;
                            }
                            else
                            {
                                NextPoint = 0;
                            }
                            tau1 = (tau1 < tau2) ? (tau1) : (tau2);
                            if (TimePassed + tau1 > T * Multiplyier)
                                tau1 = T * Multiplyier - TimePassed;
                            TimeInSecond += tau1;

                            break;
                        }
                    case 2:
                        {
                            tau1 = (1d / (m)) * Math.Log(1d / (1 - a.NextDouble()));
                            NextPoint = 1;
                            if (TimePassed + tau1 > T * Multiplyier)
                                tau1 = T * Multiplyier - TimePassed;
                            TimeInThird += tau1;
                            break;
                        }
                }
                AllTime = TimeInFirst + TimeInSecond + TimeInThird;
                TimePassed = AllTime;
                CurrentPoint = NextPoint;
                if(checkBox3.Checked)
                    chart1.Series[6].Points.AddXY(AllTime / Multiplyier, TimeInFirst / AllTime);
                if (checkBox6.Checked)
                    chart1.Series[7].Points.AddXY(AllTime / Multiplyier, TimeInSecond / AllTime);
                if (checkBox10.Checked)
                    chart1.Series[8].Points.AddXY(AllTime / Multiplyier, TimeInThird / AllTime);
            }
            textBox12.Text = "" + Math.Round(TimeInFirst,AccNums);
            textBox13.Text = "" + Math.Round(TimeInSecond,AccNums);
            textBox14.Text = "" + Math.Round(TimeInThird,AccNums);
        }
    }
}
