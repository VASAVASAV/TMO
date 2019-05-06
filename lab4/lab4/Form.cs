using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    class MyProg : Form
    {
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private GroupBox LogOutput;
        private TextBox textBox5;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private CheckedListBox checkedListBox1;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private TextBox textBox6;
        private Label label5;
        private TextBox textBox7;
        private Label label6;
        private TabPage tabPage3;
        private DataGridView dataGridView1;
        private TextBox textBox8;
        private Label label7;
        private Label label4;
        private TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private TabPage tabPage5;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        int Accuracy = 5;

        public MyProg()
        {
            InitializeComponent();
            dataGridView1.Rows.Add("Ймовірність відмови","","","");
            dataGridView1.Rows.Add("Пропускна властивість", "", "", "");
            dataGridView1.Rows.Add("Абсолютна пропускна властивість", "", "", "");
            dataGridView1.Rows.Add("Середня кількість вимог, що знаходиться у черзі", "", "", "");
            dataGridView1.Rows.Add("Середня кількість вимог, що обслуговується", "", "", "");
            dataGridView1.Rows.Add("Середня кількість вимог, що знаходиться у СМО", "", "", "");
            dataGridView1.Rows.Add("Середній час очікування", "", "", "");
            dataGridView1.Rows.Add("Середній час обслуговування", "", "", "");
            dataGridView1.Rows.Add("Середній час перебування вимоги у СМО", "", "", "");
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogOutput = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.LogOutput.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Моделювати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "інтенсивність надходження вимог, λ(par1) = ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(262, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(80, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0,45";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(262, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "0,55";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "інтенсивність обслуговування вимог, μ(par1) = ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(541, 43);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "2";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "довжина черги";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(541, 17);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.Text = "1000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Час роботи";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(15, 115);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(815, 498);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(807, 472);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ймовірності станів";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.AxisY.Maximum = 1D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(7, 7);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(790, 450);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chart2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(807, 472);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Графіки характеристик";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(6, 3);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Legend = "Legend1";
            series1.Name = "Кількість обслугованих вимог";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series2.Legend = "Legend1";
            series2.Name = "Кількість відмов";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series3.Legend = "Legend1";
            series3.Name = "Кількість вимог, що надійшли у СМО";
            this.chart2.Series.Add(series1);
            this.chart2.Series.Add(series2);
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(607, 463);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.chart3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(807, 472);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Додаткові графіки характеристик";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // chart3
            // 
            chartArea3.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(3, 3);
            this.chart3.Name = "chart3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Середній час обслуговування";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Середній час очікування у черзі";
            this.chart3.Series.Add(series4);
            this.chart3.Series.Add(series5);
            this.chart3.Size = new System.Drawing.Size(607, 463);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "chart3";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(807, 472);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Значення характеристик";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(695, 465);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Назва характеристики";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Теоретичне значення";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Статистичне значення(1)";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Статистичне значення(2)";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(807, 472);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Значення ймовірностей";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(695, 465);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер стану";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Теоретичная ймовірність перебування";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 175;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Статистичне ймовірність перебування";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 175;
            // 
            // LogOutput
            // 
            this.LogOutput.Controls.Add(this.textBox5);
            this.LogOutput.Location = new System.Drawing.Point(860, 115);
            this.LogOutput.Name = "LogOutput";
            this.LogOutput.Size = new System.Drawing.Size(258, 246);
            this.LogOutput.TabIndex = 10;
            this.LogOutput.TabStop = false;
            this.LogOutput.Text = "Журнал";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(6, 19);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(246, 221);
            this.textBox5.TabIndex = 11;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 17);
            this.radioButton1.TabIndex = 11;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Черга";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 41);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(49, 17);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.Text = "Стек";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(860, 367);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(258, 274);
            this.checkedListBox1.TabIndex = 14;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Location = new System.Drawing.Point(11, 19);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(165, 17);
            this.radioButton5.TabIndex = 15;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Експоненціальний розподіл";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(11, 42);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(136, 17);
            this.radioButton6.TabIndex = 16;
            this.radioButton6.Text = "Нормальний розподіл";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(11, 65);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(133, 17);
            this.radioButton7.TabIndex = 17;
            this.radioButton7.Text = "Рівномірний розподіл";
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton7);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Location = new System.Drawing.Point(647, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип розподілу інтервалів";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Location = new System.Drawing.Point(853, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(102, 100);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тип очікування";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Location = new System.Drawing.Point(961, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 96);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Варіант роботи";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 42);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(72, 17);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.Text = "Варіант 2";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(72, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Варіант 1";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(392, 17);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(55, 20);
            this.textBox6.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "par2 = ";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(392, 43);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(55, 20);
            this.textBox7.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(346, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "par2 = ";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(319, 80);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(67, 20);
            this.textBox8.TabIndex = 26;
            this.textBox8.Text = "5";
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Точність";
            // 
            // MyProg
            // 
            this.ClientSize = new System.Drawing.Size(1130, 652);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.LogOutput);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "MyProg";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.LogOutput.ResumeLayout(false);
            this.LogOutput.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j, k;
            string tmp;
            double lambda;
            double mi;
            double TimeOfWork;
            int QueueLength;
            try
            {
                lambda = Convert.ToDouble(textBox1.Text);
                mi = Convert.ToDouble(textBox2.Text);
                if (lambda <= 0 || mi <= 0)
                {
                    throw new Exception();
                }
                TimeOfWork = Convert.ToDouble(textBox4.Text);
                QueueLength = Convert.ToInt32(textBox3.Text);
                if (TimeOfWork <= 0 || QueueLength < 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                textBox5.Text += "Wrong input" + Environment.NewLine;
                return;
            }
            double CurrentT = 0;
            List<Need> Queue = new List<Need>();
            List<Need> Done = new List<Need>();

            List<double> TimeInNode = new List<double>();
            for (i = 0; i < QueueLength + 2; i++)
            {
                TimeInNode.Add(0);
            }

            double[] Param1 = new double[2]; // parameters for random generator
            double[] Param2 = new double[2]; // parameters for random generator

            double AverageWait=0;
            double AverageWork=0;

            Param1[0] = lambda;
            Param2[0] = mi;
            if (!radioButton5.Checked)
            {
                try
                {
                    Param1[1] = Convert.ToDouble(textBox6.Text);
                    Param2[1] = Convert.ToDouble(textBox7.Text);
                }
                catch
                {
                    textBox5.Text += " Параметри для генератору інтервалів задані невірно" + Environment.NewLine;
                    return;
                }
            }

            IRandom Generator = null;

            if (radioButton5.Checked)
            {
                Generator = new ExpRand();
            }
            if (radioButton6.Checked)
            {
                Generator = new NormRand();
            }
            if (radioButton7.Checked)
            {
                Generator = new UniformRand();
            }

            List<Need> NewNeeds = new List<Need>();

            int NumberOfDenies = 0;

            double temp;
            double tau1, tau2;

            int AllIncome = 0;

            dataGridView2.Rows.Clear();
            chart1.Series.Clear();
            chart2.Series[0].Points.Clear();
            chart2.Series[1].Points.Clear();
            chart2.Series[2].Points.Clear();
            chart3.Series[0].Points.Clear();
            chart3.Series[1].Points.Clear();
            for (i = 0; i < QueueLength + 2; i++)
            {
                var Tempser = new System.Windows.Forms.DataVisualization.Charting.Series();
                Tempser.ChartArea = "ChartArea1";
                Tempser.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                Tempser.Legend = "Legend1";
                Tempser.Name = "Series"+i;
                this.chart1.Series.Add(Tempser);
            }

            int Iterations = 0;
            double TempSum1 = 0;
            double TempSum2 = 0;
            if (radioButton3.Checked)
            {
                int CurrentState = 0;
                Need Current = null;
                while (CurrentT < TimeOfWork)
                {
                    Iterations++;
                    TempSum1 = ((TempSum1 * (Iterations - 1)) + ((CurrentState > 1) ? (CurrentState - 1) : (0))) / Iterations;
                    TempSum2 += (CurrentState > 0) ? (CurrentState) : (0);
                    tau1 = Generator.NextRand(Param1);
                    if (CurrentState == 0)
                    {
                        tau2 = double.PositiveInfinity;
                    }
                    else
                    {
                        tau2 = Generator.NextRand(Param2);
                    }
                    if (CurrentT + ((tau1 < tau2) ? (tau1) : (tau2)) > TimeOfWork)
                    {
                        TimeInNode[CurrentState] += TimeOfWork - CurrentT;
                        CurrentT = TimeOfWork;
                    }
                    else
                    {
                        if (tau1 < tau2)//new need
                        {
                            AllIncome++;
                            if (CurrentState == QueueLength + 1)
                            {
                                NumberOfDenies++;
                                TimeInNode[CurrentState] += tau1;
                            }
                            else
                            {
                                if (CurrentState == 0)
                                {
                                    Current = new Need(CurrentT + tau1);
                                    Current.WorkStartTime = Current.IncomeTime;
                                }
                                else
                                {
                                    Queue.Add(new Need(CurrentT + tau1));
                                }
                                TimeInNode[CurrentState] += tau1;
                                CurrentState++;
                            }
                            CurrentT += tau1;
                        }
                        else//need processed
                        {
                            Current.WorkEndTime = CurrentT + tau2;
                            Done.Add(Current);
                            AverageWait = (AverageWait * (Done.Count - 1) + Done[Done.Count - 1].WorkStartTime - Done[Done.Count - 1].IncomeTime) / Done.Count;
                            AverageWork = (AverageWork * (Done.Count - 1) + Done[Done.Count - 1].WorkEndTime - Done[Done.Count - 1].WorkStartTime) / Done.Count;
                            if (CurrentState == 1)
                            {
                                Current = null;
                            }
                            else
                            {
                                if (radioButton1.Checked)
                                {
                                    Current = Queue[0];
                                    Queue.RemoveAt(0);
                                }
                                else
                                {
                                    Current = Queue[Queue.Count - 1];
                                    Queue.RemoveAt(Queue.Count-1);
                                }
                                Current.WorkStartTime = CurrentT + tau2;
                            }
                            CurrentT += tau2;
                            TimeInNode[CurrentState] += tau2;
                            CurrentState--;
                        }
                        for (i = 0; i < checkedListBox1.Items.Count; i++)
                        {
                            if (checkedListBox1.CheckedItems.Contains(checkedListBox1.Items[i]))
                            {
                                chart1.Series[i].Points.AddXY(CurrentT,TimeInNode[i]/CurrentT);
                            }
                        }
                        chart2.Series[0].Points.AddXY(CurrentT,Done.Count);
                        chart2.Series[1].Points.AddXY(CurrentT, NumberOfDenies);
                        chart2.Series[2].Points.AddXY(CurrentT, AllIncome);
                        chart3.Series[0].Points.AddXY(CurrentT, AverageWork);
                        chart3.Series[1].Points.AddXY(CurrentT, AverageWait);
                    }
                }
            }
            else
            {

            }
            double ro = lambda / mi;
            double p0 = 1;
            for (i = 1; i < QueueLength + 2; i++)
            {
                p0 += Math.Pow(ro, i);
            }
            p0 = 1 / p0;
            dataGridView2.Rows.Add("0", Math.Round(p0,Accuracy), Math.Round(TimeInNode[0]/TimeOfWork, Accuracy));
            for (i = 1; i < QueueLength + 2; i++)
            {
                dataGridView2.Rows.Add("0", Math.Round(p0*Math.Pow(ro,i), Accuracy), Math.Round(TimeInNode[i] / TimeOfWork, Accuracy));
            }
            dataGridView1.Rows[0].Cells[1].Value = "" + Math.Round(p0 * Math.Pow(ro, QueueLength + 1), Accuracy);
            dataGridView1.Rows[0].Cells[2].Value = "" + Math.Round(TimeInNode[QueueLength + 1] / TimeOfWork, Accuracy);
            dataGridView1.Rows[0].Cells[3].Value = "" + Math.Round((double)NumberOfDenies/AllIncome, Accuracy);

            dataGridView1.Rows[1].Cells[1].Value =  1 - Math.Round(p0 *  Math.Pow(ro, QueueLength + 1), Accuracy);
            dataGridView1.Rows[1].Cells[2].Value =  1 - Math.Round(TimeInNode[QueueLength + 1] / TimeOfWork, Accuracy);
            dataGridView1.Rows[1].Cells[3].Value = (Done.Count / TimeOfWork)/lambda;

            dataGridView1.Rows[2].Cells[1].Value = lambda*(1 - Math.Round(p0 * Math.Pow(ro, QueueLength + 1), Accuracy));
            dataGridView1.Rows[2].Cells[2].Value = lambda*(1 - Math.Round(TimeInNode[QueueLength + 1] / TimeOfWork, Accuracy));
            dataGridView1.Rows[2].Cells[3].Value = Done.Count / TimeOfWork;

            temp = 0;

            for (i = 2; i < QueueLength+2; i++)
            {
                temp += (i - 1) * (TimeInNode[i] / TimeOfWork);
            }

            dataGridView1.Rows[3].Cells[1].Value = Math.Round((ro*ro*(1-Math.Pow(ro,QueueLength)*(QueueLength+1- QueueLength * ro)))/((1-Math.Pow(ro,QueueLength+2))*(1-ro)),Accuracy);
            dataGridView1.Rows[3].Cells[2].Value = Math.Round(TempSum1, Accuracy);
            dataGridView1.Rows[3].Cells[3].Value = Math.Round(temp, Accuracy);

            dataGridView1.Rows[4].Cells[1].Value = Math.Round(ro*(1-p0*(Math.Pow(ro,QueueLength+1))/(1)), Accuracy);//Math.Round((ro+Math.Pow(ro,QueueLength+2))/(1- Math.Pow(ro, QueueLength + 2)), Accuracy);
            dataGridView1.Rows[4].Cells[3].Value = Math.Round(1-TimeInNode[0]/TimeOfWork, Accuracy);

            temp = 0;

            for (i = 1; i < QueueLength+2; i++)
            {
                temp += (i) * (TimeInNode[i] / TimeOfWork);
            }

            dataGridView1.Rows[5].Cells[1].Value = Math.Round((ro * ro * (1 - Math.Pow(ro, QueueLength) * (QueueLength + 1 - QueueLength * ro))) / ((1 - Math.Pow(ro, QueueLength + 2)) * (1 - ro)), Accuracy) + Math.Round(ro * (1 - p0 * (Math.Pow(ro, QueueLength + 1)) / (1)), Accuracy);
            dataGridView1.Rows[5].Cells[2].Value = Math.Round((double)TempSum2 / Iterations, Accuracy);
            dataGridView1.Rows[5].Cells[3].Value = Math.Round(temp, Accuracy);

            dataGridView1.Rows[6].Cells[1].Value = Math.Round(((ro * ro * (1 - Math.Pow(ro, QueueLength) * (QueueLength + 1 - QueueLength * ro))) / ((1 - Math.Pow(ro, QueueLength + 2)) * (1 - ro)))/lambda, Accuracy);
            dataGridView1.Rows[6].Cells[3].Value = Math.Round(AverageWait, Accuracy);
            
            dataGridView1.Rows[7].Cells[1].Value = Math.Round(1d/mi, Accuracy);
            dataGridView1.Rows[7].Cells[3].Value = Math.Round(AverageWork, Accuracy);

            dataGridView1.Rows[8].Cells[1].Value = Math.Round(((ro * ro * (1 - Math.Pow(ro, QueueLength) * (QueueLength + 1 - QueueLength * ro))) / ((1 - Math.Pow(ro, QueueLength + 2)) * (1 - ro))) / lambda, Accuracy) - Math.Round(1 - Math.Round(p0 * Math.Pow(ro, QueueLength + 1), Accuracy) / mi, Accuracy);
            dataGridView1.Rows[8].Cells[3].Value = Math.Round(AverageWait+AverageWork, Accuracy);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int temp;
            try
            {
                temp = Convert.ToInt32(textBox3.Text);
            }
            catch
            {
                textBox3.Text = "";
                return;
            }
            checkedListBox1.Items.Clear();
            for (int i = 0; i < temp+2; i++)
            {
                checkedListBox1.Items.Add("p" + i);
            }

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            int temp;
            try
            {
                temp = Convert.ToInt32(textBox8.Text);
                Accuracy = temp;
            }
            catch
            {
                textBox8.Text = "5";
                Accuracy = 5;
                return;
            }
        }
    }
}
