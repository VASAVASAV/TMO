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

        public static double ComputeDistrExp(double x, double parametrs)
        {
            if (x >= 0)
                return 1 - Math.Pow(Math.E, -1 * parametrs * x);
            else return 0;
        }

        private double CheckPirs(List<double> data)
        {
            List<double> Temp = new List<double>();
            Temp = data.Select(x => x).ToList();
            Temp.Sort();
            int Num = ToolsForWork.CompNumOfClasses(Temp.Count)/2;
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
            Lambda = (double)Temp.Count / (Lambda);
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
                theorz = Temp.Count * (ComputeDistrExp(LocalMax, Lambda) - ComputeDistrExp(LocalMin, Lambda));
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
                return CheckPirs(Data);
                //textBox3.Text += "Статистика критерію - " + Math.Round(answer, Data.NumberOfNum) + ", критичне значення критерію - " + Math.Round(quan, Data.NumberOfNum) + Environment.NewLine; //+ "--------------------------------------------------------------------------" + Environment.NewLine;
                //if (checkBox1.Checked)
                //{
                //    LogOutputTextBox.Text += "Статистика критерію - " + Math.Round(answer, Data.NumberOfNum) + ", критичне значення критерію - " + Math.Round(quan, Data.NumberOfNum) + Environment.NewLine; // + "--------------------------------------------------------------------------" + Environment.NewLine;
                //}
                //if (answer <= quan)
                //{
                //    textBox3.Text += "За критерієм згоди χ^2 Пірсона гіпотеза про збіг емпіричної функції розподілу з теоретичноую з критичним рівнем значущості " + Math.Round(Gamma, Data.NumberOfNum) + " є вірною " + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                //    if (checkBox1.Checked)
                //    {
                //        LogOutputTextBox.Text += "За критерієм згоди χ^2 Пірсона гіпотеза про збіг емпіричної функції розподілу з теоретичноую з критичним рівнем значущості " + Math.Round(Gamma, Data.NumberOfNum) + " є вірною " + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                //    }
                //}
                //else
                //{
                //    textBox3.Text += "За критерієм згоди χ^2 Пірсона гіпотеза про збіг емпіричної функції розподілу з теоретичноую з критичним рівнем значущості " + Math.Round(Gamma, Data.NumberOfNum) + " є невірною " + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                //    if (checkBox1.Checked)
                //    {
                //        LogOutputTextBox.Text += "За критерієм згоди χ^2 Пірсона гіпотеза про збіг емпіричної функції розподілу з теоретичноую з критичним рівнем значущості " + Math.Round(Gamma, Data.NumberOfNum) + " є невірною " + Environment.NewLine + "--------------------------------------------------------------------------" + Environment.NewLine;
                //    }
                //}
                //break;
            }
            else//Kolmogorov
            {
                double DNm = 0;
                double DNp = Math.Abs(stat.Seria3Y[0] - stat._FTeor[0]);

                for (int i = 1; i < stat.d.Length; i++)
                {
                    DNp = Math.Max(DNp, Math.Abs(stat.Seria3Y[i] - stat._FTeor[i]));
                    DNm = Math.Max(DNm, Math.Abs(stat.Seria3Y[i] - stat._FTeor[i - 1]));
                }

                double z = Math.Sqrt(stat.d.Length) * Math.Max(DNp, DNm);

                int k = 0;
                double sum = 0;
                double temp = 0;

                do
                {
                    k++;

                    double f1 = k * k - 0.5 * (1 - Math.Pow(-1, k));
                    double f2 = 5 * k * k + 22 - 7.5 * (1 - Math.Pow(-1, k));

                    #region temp-овые переменные, для упрощения большой суммы
                    double a = Math.Pow(-1, k) * Math.Exp(-2 * k * k * z * z);
                    double b = 1 - 2 * k * k * z / (3 * Math.Sqrt(stat.d.Length));
                    double c = 1d / (18 * stat.d.Length) * ((f1 - 4 * (f1 + 3)) * k * k * z * z + 8 * Math.Pow(k, 4) * Math.Pow(z, 4));

                    //d использовать нельзя
                    double e = k * k * z / (27 * Math.Pow(stat.d.Length, 3d / 2)) *
                               (f2 * f2 / 5d - 4 * (f2 + 45) * k * k * z * z / 15 + 8 * Math.Pow(k, 4) * Math.Pow(z, 4));

                    #endregion

                    temp = a * (b - c + e);
                    sum += temp;

                } while (temp >= 0.0001);

                double Kz = 1 + 2 * sum;
                double Pz = 1 - Kz;

                //Вывод решения решение
                string result = "";
                Action<string> add2log = v => result += v + Environment.NewLine;
                Func<double, double> r = v => Math.Round(v);

                add2log("");
                add2log("Критерій Колмогорова:");
                add2log("Pz = " + r(Pz));
                add2log("alpha = " + alpha);
                if (Pz >= alpha)
                {
                    add2log("Pz >= alpha");
                    add2log("Пройдено");
                }
                else
                {
                    add2log("Pz < alpha");
                    add2log("Не Пройдено");
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
