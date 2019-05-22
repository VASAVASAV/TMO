using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    partial class MainForm
    {
        public static Controller MyCont;


        private void сталуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<double> temp = MyCont.GetDataFromModel();
            temp.Sort();
            double Lambda = 0;
            Lambda = 1 / temp.Average();
            chart3.Series.Clear();
            System.Windows.Forms.DataVisualization.Charting.Series TempSer = new System.Windows.Forms.DataVisualization.Charting.Series();
            TempSer.BorderWidth = 5;
            TempSer.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            TempSer.Name = "Ser";
            TempSer.Points.AddXY(temp[0],Lambda);
            TempSer.Points.AddXY(temp[temp.Count-1], Lambda);
            chart3.ChartAreas[0].AxisX.Minimum = temp[0];
            chart3.ChartAreas[0].AxisX.Maximum = temp[temp.Count-1];
            chart3.Series.Add(TempSer);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double alfa = 0.05;
            MyCont.CheckData(radioButton1.Checked,alfa);
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void ВийтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void кусковоЛінійнуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<double> temp = MyCont.GetDataFromModel();
            temp.Sort();
            double Lambda = 0;
            Lambda = 1 / temp.Average();
            chart3.Series.Clear();
            int Num = ToolsForWork.CompNumOfClasses(temp.Count);
            int[] Intenc = new int[Num];
            int Nj = 0;
            int Ni;
            for(int i = 0; i < Num; i++)
            {
                Ni = 0;
                var lol = temp.FindAll(x=> )
            }
        }

        private void ВідкритичасовийРядToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpeningDialog = new OpenFileDialog
            {
                InitialDirectory = Application.StartupPath.ToString(),
                Filter = "txt files (*.txt)|*.txt| dat files (*.dat)|*.dat",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (OpeningDialog.ShowDialog() == DialogResult.OK)
            {
                MyCont.ReadFile(OpeningDialog, true);
            }
        }

        private void ВідкритирозподілΤToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpeningDialog = new OpenFileDialog
            {
                InitialDirectory = Application.StartupPath.ToString(),
                Filter = "txt files (*.txt)|*.txt| dat files (*.dat)|*.dat",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (OpeningDialog.ShowDialog() == DialogResult.OK)
            {
                MyCont.ReadFile(OpeningDialog,false);
            }
            //this.ProgressBar.Value = 1;

        }

        public void ShowMessage(string Message)
        {
            textBox1.Text += Message + Environment.NewLine;
        }

        public void DrawTable(List<double> Input)
        {
            dataGridView1.Rows.Clear();
            List<double> Data = Input.Select(x => x).ToList();
            Data.Sort();
            for (int i = 0; i < Data.Count; i++)
            {
                dataGridView1.Rows.Add(Math.Round(Data[i],5),Data[i]);
            }
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
             MyCont.RemoveVal(Convert.ToDouble(e.Row.Cells[1].Value));
        }


        public void PaintDistFuncs(List<double> Input)
        {
            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();
            chart2.Series[1].Points.Clear();
            List<double> Data = Input.Select(x => x).ToList();
            Data.Sort();
            if ((Data.Count == 0))
            {
                ShowMessage("Theres nothing to do");
                return;
            }
            /////
            int NumbOfClasses = ToolsForWork.CompNumOfClasses(Data.Count);
            int[] DataByClasses = new int[NumbOfClasses];
            for (int i = 0; i < DataByClasses.Length; i++)
            {
                DataByClasses[i] = 0;
            }
            ////////////////
            double MinLimit = Data[0] - 0.00001;
            double MaxLimit = Data[Data.Count - 1] + 0.00001;
            int IndOfRang = 0;
            for (int i = 0; i < Data.Count; i++)
            {
                while (Data[i] > (MinLimit + (IndOfRang + 1) * ((MaxLimit - MinLimit) / NumbOfClasses)))
                {
                    IndOfRang++;
                }
                if (IndOfRang == NumbOfClasses)
                {
                    DataByClasses[IndOfRang - 1]++;
                }
                else
                {
                    DataByClasses[IndOfRang]++;
                }
            }
            chart1.Series[0].CustomProperties = "PointWidth=1";
            double Step = (MaxLimit - MinLimit) / NumbOfClasses;
            chart1.ChartAreas[0].AxisX.Interval = Step;
            chart1.ChartAreas[0].AxisX.Minimum = MinLimit;
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "{0:0.0000}";
            chart1.ChartAreas[0].AxisY.Title = "P(x)";
            chart1.ChartAreas[0].AxisX.Title = "X";
            chart1.Series[0].Points.Clear();
            chart1.Series[0].MarkerSize = ToolsForWork.ComputeSizeOfPoint(NumbOfClasses);/////<----change it 
            double LocalCenter;
            double yVal;
            double LocalMin = 0;
            double LocalMax = 0;
            for (int i = 0; i < NumbOfClasses; i++)
            {
                yVal = (double)DataByClasses[i] / (double)Data.Count;
                LocalMin = (MinLimit + Step * i);
                LocalMax = (MinLimit + Step * (i + 1));
                LocalCenter = ((LocalMin + LocalMax) / 2);
                chart1.Series[0].Points.AddXY(LocalCenter, yVal);
            }
            //////////
            MinLimit = Convert.ToDouble(Data[0]) - 0.001;
            MaxLimit = Convert.ToDouble(Data[Data.Count - 1]) + 0.001;
            Step = (MaxLimit - MinLimit) / NumbOfClasses;
            chart2.ChartAreas[0].AxisX.Interval = Step;
            chart2.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(MinLimit);
            chart2.ChartAreas[0].AxisX.LabelStyle.Format = "{0:0.0000}";
            chart2.Series[0].Points.Clear();
            chart2.Series[0].MarkerSize = ToolsForWork.ComputeSizeOfPoint(NumbOfClasses) + 1;
            double AlreadyCounted = 0;
            DataByClasses = new int[NumbOfClasses];
            for (int i = 0; i < DataByClasses.Length; i++)
            {
                DataByClasses[i] = 0;
            }
            IndOfRang = 0;
            for (int i = 0; i < Data.Count; i++)
            {
                while (Convert.ToDouble(Data[i]) > (MinLimit + (IndOfRang + 1) * ((MaxLimit - MinLimit) /NumbOfClasses)))
                {
                    IndOfRang++;
                }
                if (IndOfRang == NumbOfClasses)
                {
                    DataByClasses[IndOfRang - 1]++;
                }
                else
                {
                    DataByClasses[IndOfRang]++;
                }
            }
            for (int i = 0; i < NumbOfClasses; i++)
            {
                yVal = (double)DataByClasses[i] / (double)Data.Count;
                //LogOutputTextBox.Text += "loh " + yVal + Environment.NewLine;
                LocalMin = (MinLimit + Step * i);
                LocalMax = (MinLimit + Step * (i + 1));
                AlreadyCounted += yVal;
                for (LocalCenter = LocalMin; LocalCenter < LocalMax; LocalCenter += (LocalMax - LocalMin) / 100)
                {
                    chart2.Series[0].Points.AddXY(LocalCenter, AlreadyCounted);
                }
            }
            AlreadyCounted = 0;
            double[] DistrFunction = new double[Data.Count];
            int CountOFSame = 0;
            for (int i = 0; i < Data.Count; i += CountOFSame)
            {
                CountOFSame = 1;
                for (int j = i + 1; j < Data.Count; j++)
                {
                    if (Convert.ToDouble(Data[i]) == Convert.ToDouble(Data[j]))
                    {
                        CountOFSame++;
                    }
                    else
                    {
                        break;
                    }
                }
                yVal = ((double)CountOFSame) / Data.Count;
                AlreadyCounted += yVal;
                for (int j = i; j < i + CountOFSame; j++)
                {
                    DistrFunction[j] = AlreadyCounted;
                }
                chart2.Series[1].Points.AddXY(Convert.ToDouble(Data[i]), AlreadyCounted);
            }
            chart1.Invalidate();
            chart2.Invalidate();
        }
    }    
}
