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

        public double CheckDataDist(bool TypeOfCheck, double alfa)
        {
            if (TypeOfCheck)//Pirson
            {

            }
            else//Kolmogorov
            {

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
