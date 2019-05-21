using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Model
    {
        public static Controller MyCont;
        List<double> Data = new List<double>();//lets pretend they arent stored here

        public void SetData(List<double> Input)
        {
            Data.Clear();
            for (int i = 0; i < Input.Count; i++)
            {
                Data.Add(Input[i]);
            }
            Data.Sort();
        }

        public bool CheckData()
        {
            if (Data == null || Data.Count == 0)
                return false;
            return true; 
        }

        public static double ComputeDistrExp(double x, double[] parametrs)
        {
            if (x >= 0)
                return 1 - Math.Pow(Math.E, -1 * parametrs[0] * x);
            else return 0;
        }

        private double CheckPirs(List<double> data)
        {
            List<double> Temp = new List<double>();
            Temp = data.Select(x => x).ToList();
            Temp.Sort();
            int Num = ToolsForWork.CompNumOfClasses(Temp.Count);
            int[] DataByClasses = new int[Num];
            for (int i = 0; i < DataByClasses.Length; i++)
            {
                DataByClasses[i] = 0;
            }
            double Lambda = 0;
            for (int i = 0; i < Temp.Count; i++)
            {
                Lambda += Temp[i];
            }
            Lambda = (double)Temp.Count / ();
            int IndOfRang = 0;
            double MinLimit = Temp[0] - 0.00001;
            double MaxLimit = Temp[Temp.Count-1] + 0.00001;
            for (int i = 0; i < Temp.Count; i++)
            {
                while (Temp[i] > (MinLimit + (IndOfRang + 1) * ((MaxLimit - MinLimit) / Num)))
                {
                    IndOfRang++;
                }
                if (IndOfRang == (int)Num)
                {
                    DataByClasses[IndOfRang - 1]++;
                }
                else
                {
                    DataByClasses[IndOfRang]++;
                }
            }
            double yVal;
            double LocalMin = 0;
            double LocalMax = 0;    
            double sum = 0;
            double theorz = 0;
            double Step = (MaxLimit - MinLimit) / Num;
            for (int i = 0; i < (int)Num; i++)
            {
                yVal = (double)DataByClasses[i] / (double)Temp.Count;
                LocalMin = (MinLimit + Step * i);
                LocalMax = (MinLimit + Step * (i + 1));
                double lol = ComputeDistrExp(LocalMax, Lambda);
                double lil = ComputeDistrExp(LocalMin, Lambda);
                theorz = Temp.Count * (ToolsForWork.ComputeDistr(Data.TypeOfDistr, LocalMax, Data.Parameters) - ToolsForWork.ComputeDistr(Data.TypeOfDistr, LocalMin, Data.Parameters));
                if (theorz != 0)
                {
                    sum += Math.Pow(DataByClasses[i] - theorz, 2) / theorz;
                }
            }
            return sum;
        }

        public double CheckDataDist(bool TypeOfCheck, double alfa)
        {
            if (TypeOfCheck)//Pirson
            {

            }
            else//Kolmogorov
            {
                answer = CheckPirs();
                double quan = Quantile.HirsQuan(1 - Gamma, HistData.NumberOfClasses - 1);
                textBox3.Text += "Статистика критерію - " + Math.Round(answer, Data.NumberOfNum) + ", критичне значення критерію - " + Math.Round(quan, Data.NumberOfNum) + Environment.NewLine; //+ "--------------------------------------------------------------------------" + Environment.NewLine;
                if (checkBox1.Checked)
                {
                    LogOutputTextBox.Text += "Статистика критерію - " + Math.Round(answer, Data.NumberOfNum) + ", критичне значення критерію - " + Math.Round(quan, Data.NumberOfNum) + Environment.NewLine; // + "--------------------------------------------------------------------------" + Environment.NewLine;
                }
                if (answer <= quan)
                {
                    textBox3.Text += "За критерієм згоди χ^2 Пірсона гіпотеза про збіг емпіричної функції розподілу з теоретичноую з критичним рівнем значущості " + Math.Round(Gamma, Data.NumberOfNum) + " є вірною " + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                    if (checkBox1.Checked)
                    {
                        LogOutputTextBox.Text += "За критерієм згоди χ^2 Пірсона гіпотеза про збіг емпіричної функції розподілу з теоретичноую з критичним рівнем значущості " + Math.Round(Gamma, Data.NumberOfNum) + " є вірною " + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                    }
                }
                else
                {
                    textBox3.Text += "За критерієм згоди χ^2 Пірсона гіпотеза про збіг емпіричної функції розподілу з теоретичноую з критичним рівнем значущості " + Math.Round(Gamma, Data.NumberOfNum) + " є невірною " + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                    if (checkBox1.Checked)
                    {
                        LogOutputTextBox.Text += "За критерієм згоди χ^2 Пірсона гіпотеза про збіг емпіричної функції розподілу з теоретичноую з критичним рівнем значущості " + Math.Round(Gamma, Data.NumberOfNum) + " є невірною " + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                    }
                }
            }
            return 0;
        }

        public List<double> GetData()
        {
            List<double> result = new List<double>();
            for(int i=0; i < Data.Count;i++)
            {
                result.Add(Data[i]);
            }
            return result;
        }

        public bool CheckIntervals()
        {
            return true;
        }

        public void DeleteVal(double ValueToDelete)
        {
            Data.RemoveAll(x=> x==ValueToDelete);
        }
    }
}
