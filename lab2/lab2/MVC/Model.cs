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
        List<double> Data = new List<double>();

        public void SetData(List<double> Input)
        {
            Data.Clear();
            for (int i = 0; i < Input.Count; i++)
            {
                Data.Add(Input[i]);
            }
            Data.Sort();
        }
    }
}
