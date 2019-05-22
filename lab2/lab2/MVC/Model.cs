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

        private double CheckKolm(List<double> data)
        {
            List<double> Temp = data.Select(x => x).ToList();
            Temp.Sort();
            //////////
            double Lambda = 0;
            for (int i = 0; i < Temp.Count; i++)
            {
                Lambda += Temp[i];
            }
            Lambda = (double)Temp.Count / (Lambda);
            ///////////
            double yVal;
            double AlreadyCounted = 0;
            double[] DistrFunction = new double[Temp.Count];
            int CountOFSame = 0;
            for (int i = 0; i < Temp.Count; i += CountOFSame)
            {
                CountOFSame = 1;
                for (int j = i + 1; j < Temp.Count; j++)
                {
                    if (Convert.ToDouble(Temp[i]) == Convert.ToDouble(Temp[j]))
                    {
                        CountOFSame++;
                    }
                    else
                    {
                        break;
                    }
                }
                yVal = ((double)CountOFSame) / Temp.Count;
                AlreadyCounted += yVal;
                for (int j = i; j < i + CountOFSame; j++)
                {
                    DistrFunction[j] = AlreadyCounted;
                }
            }
            //////////
            double DNp = Math.Abs(DistrFunction[0] - ComputeDistrExp( Temp[0], Lambda));
            double DNm = 0;

            for (int i = 1; i < Temp.Count; i++)
            {
                DNp = Math.Max(DNp, Math.Abs(DistrFunction[i] - ComputeDistrExp( Temp[i], Lambda)));
                DNm = Math.Max(DNm, Math.Abs(DistrFunction[i] - ComputeDistrExp( Temp[i - 1], Lambda)));
            }
            double z = Math.Sqrt(Temp.Count) * Math.Max(DNp, DNm);
            return 1 - ToolsForWork.ComputeKol(z, Temp.Count);
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
                
            }
            else//Kolmogorov
            {
                return CheckKolm(Data);
            }
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
