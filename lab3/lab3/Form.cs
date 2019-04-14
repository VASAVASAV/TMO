using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    class MyProg : Form
    {
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox groupBox1;
        private Label label9;
        private TextBox textBox9;
        private Label label13;
        private TextBox textBox14;
        private Label label12;
        private TextBox textBox12;
        private Label label11;
        private TextBox textBox11;
        private Button button1;
        private TextBox textBox13;
        private Button button2;
        private Button button3;
        private GroupBox groupBox3;
        private RadioButton radioButton4;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private GroupBox groupBox2;
        private IRandomGenerator CurrentGen;
        private uint Accuracy;
        private Label label1;
        private TextBox textBox1;
        private int key = 1;

        private void InitializeComponent()
        {
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(71, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Моменти";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(100, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Аперіодичність";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 66);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(78, 17);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Коваріація";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(277, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 122);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Оцінки якості випадкових чисел";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Параметр";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(70, 89);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBox14);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBox11);
            this.groupBox2.Location = new System.Drawing.Point(13, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 74);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметри";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "α";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(334, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Точність виводу";
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(100, 45);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(83, 20);
            this.textBox14.TabIndex = 23;
            this.textBox14.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(240, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Зерно";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(334, 19);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "N";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(100, 19);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(83, 20);
            this.textBox11.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 40);
            this.button1.TabIndex = 20;
            this.button1.Text = "Згенерувати нове ВЧ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(13, 267);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(476, 165);
            this.textBox13.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 221);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 40);
            this.button2.TabIndex = 21;
            this.button2.Text = "Оновити генератор";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(335, 221);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 40);
            this.button3.TabIndex = 22;
            this.button3.Text = "Провести оцінку якості";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton6);
            this.groupBox3.Controls.Add(this.radioButton5);
            this.groupBox3.Controls.Add(this.radioButton4);
            this.groupBox3.Location = new System.Drawing.Point(12, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(259, 122);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Виберіть тип генератора";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(6, 65);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(81, 17);
            this.radioButton6.TabIndex = 21;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Системний";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(6, 42);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(96, 17);
            this.radioButton5.TabIndex = 20;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Уічмана-Хілла";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(179, 17);
            this.radioButton4.TabIndex = 19;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Звичайний мультиплікативний";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // MyProg
            // 
            this.ClientSize = new System.Drawing.Size(501, 444);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MyProg";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public MyProg()
        {
            bool KeyDefined;
            int CurrentKey;
            Accuracy = 5;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint N;
            if (CurrentGen == null)
            {
                textBox13.Text += "Спочатку створіть генератор" + Environment.NewLine;
                return;
            }
            if (textBox11.Text == "")
            {
                N = 1;
            }
            else
            {
                try
                {
                    N = Convert.ToUInt32(textBox11.Text);
                }
                catch
                {
                    textBox13.Text += "Невірно введено число нових ВЧ" + Environment.NewLine;
                    return;
                }
            }
            double newVal;
            for (int i = 0; i < N; i++)
            {
                newVal = CurrentGen.GetNext();
                textBox13.Text += Math.Round(newVal, (int)Accuracy) + Environment.NewLine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uint NewKey;
            if (CurrentGen == null)
            {
                return;
            }
            if (textBox12.Text == "")
            {
                CurrentGen.ChangeKey(1);
                return;
            }
            try
            {
                NewKey = Convert.ToUInt32(textBox12.Text);
                if (NewKey == 0)
                {
                    textBox13.Text += "Неможливо задати зерно, що дорвнює 0" + Environment.NewLine;
                    return;
                }
            }
            catch
            {
                textBox13.Text += "Нове значення зерна введено невірно" + Environment.NewLine;
                return;
            }
            CurrentGen.ChangeKey(NewKey);
           // CurrentGen.ChangeKey();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int par = 1;
            double alfa;
            if (!radioButton1.Checked)
            {
                try
                {
                    par = Convert.ToInt32(textBox9.Text);
                }
                catch
                {
                    textBox13.Text += "Параметр задан невірно" + Environment.NewLine;
                    return;
                }
            }
            try
            {
                alfa = Convert.ToDouble(textBox1.Text);
                if (alfa <= 0 || alfa >= 1)
                    throw new Exception();
            }
            catch
            {
                alfa = 0.05;
                textBox1.Text = ""+0.05;
                textBox13.Text += "Ймовірність похибки першого роду задана невірно" + Environment.NewLine;
            }
            double Xexp = 0;
            double sigm = 0;
            int N = 10000;
            double[] Vals = new double[N];
            for (int i = 0; i < N; i++)
            {
                Vals[i] = CurrentGen.GetNext();
            }
            for (int i = 0; i < N; i++)
            {
                Xexp += Vals[i];
            }
            Xexp /= N;
            for (int i = 0; i < N; i++)
            {
                sigm += Math.Pow(Vals[i] - Xexp, 2);
            }
            sigm /= N;
            sigm = Math.Sqrt(sigm);
            if (radioButton2.Checked)
            {
                int i;
                if (par < 1 || par > 10)
                {
                    textBox13.Text += "Безсенсно" + Environment.NewLine;
                    return;
                }
                bool End = false;
                bool Temp;
                int Counter = 0;
                double[] Target = new double[par];
                List<double> ToCheck = new List<double>();
                for (i = 0; i < par; i++)
                {
                    Target[i] = CurrentGen.GetNext();
                }
                for (i = 1; i < par; i++)
                {
                    ToCheck.Add(Target[i]);
                }
                ToCheck.Add(CurrentGen.GetNext());
                while (!End && Counter < 20000000)
                {
                    Temp = true;
                    for (i = 0; i < par && Temp; i++)
                    {
                        if (!(Math.Round(ToCheck[i], (int)Accuracy) == Math.Round(Target[i], (int)Accuracy)))
                        {
                            Temp = false;
                        }
                    }
                    if (!Temp)
                    {
                        ToCheck.RemoveAt(0);
                        ToCheck.Add(CurrentGen.GetNext());
                    }
                    else
                    {
                        break;
                    }
                    Counter++;
                }
                if (Counter == 20000000)
                {
                    textBox13.Text += "У перших 20 міліонах чисел циклу знайдено не було" + Environment.NewLine;
                }
                else
                {
                    textBox13.Text += "Було зайдено цикл довжиною " + Counter + Environment.NewLine;
                }
            }
            if (radioButton3.Checked)
            {
                if (par < 0 || par > N - 2)
                {
                    textBox13.Text += "Параметр введено невірно" + Environment.NewLine;
                    return;
                }
                double cov = 0;
                for (int i = 0; i < N-par; i++)
                {
                    cov += Vals[i] * Vals[i + par];
                }
                cov = cov / (N - par - 1) - (double)N / (N - 1) * Xexp * Xexp;
                double covneeded = (par != 0) ? (0) : (1d / 12);
                double c = (par == 0) ? (Math.Sqrt(2)) : (1);
                double quan = c / (12 * Math.Sqrt(N - 1));
                double st = -1*Quantile.StudQuan(1-alfa/2, N);
                textBox13.Text += "Коваріація = " + Math.Round(cov,(int)Accuracy) + ", довірчі інтервали - від " + Math.Round(covneeded - quan * st, (int)Accuracy) + " до " + Math.Round(covneeded + quan * st, (int)Accuracy) + Environment.NewLine;

            }
            if (radioButton1.Checked)
            {             
                double quan = (Math.Abs(Xexp - 0.5) * Math.Sqrt(N)) / sigm;
                double st = Quantile.StudQuan(alfa, N);
                if (quan < st)
                {
                    textBox13.Text += "Оціночне значення среденього збігаєтсья з теоретичним. Значення середнього - " + Math.Round(Xexp,(int)Accuracy) + ", значення критерію - " + quan + Environment.NewLine;
                }
                else
                {
                    textBox13.Text += "Оціночне значення среденього не збігаєтсья з теоретичним. Значення середнього - " + Math.Round(Xexp, (int)Accuracy) + ", значення критерію - " + quan + Environment.NewLine;
                }
                quan = (Math.Abs(sigm - 1d/(Math.Sqrt(12))) * Math.Sqrt(2*N)) / sigm;
                if (quan < st)
                {
                    textBox13.Text += "Оціночне значення σ збігаєтсья з теоретичним. Значення σ - " + Math.Round(sigm, (int)Accuracy) + ", значення критерію - " + quan + Environment.NewLine;
                }
                else
                {
                    textBox13.Text += "Оціночне значення σ не збігаєтсья з теоретичним. Значення σ - " + Math.Round(sigm, (int)Accuracy) + ", значення критерію - " + quan + Environment.NewLine;
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton4.Checked)
            {
                CurrentGen = new MultiplicativeGen();
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Accuracy = Convert.ToUInt32(textBox14.Text);
            }
            catch
            {
                Accuracy = 5;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                CurrentGen = new SystemGen();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                CurrentGen = new HillGen();
            }
        }
    }
}
