using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class ToolsForWork
    {
        public static double fu1(double k)
        {
            return k * k - 0.5 * (1 - Math.Pow(-1, k));
        }
        public static double fu2(double k)
        {
            return 5 * k * k + 22 - 7.5 * (1 - Math.Pow(-1, k));
        }

        public static double ComputeKol(double zet, int Number)
        {
            double sum = 0;
            double tempsum = 0;
            double k = 1;
            do
            {
                double f1 = fu1(k);
                double f2 = fu2(k);
                double MainPart = Math.Pow(-1, k) * Math.Exp(-2 * k * k * zet * zet);
                double a = 1 - (2 * k * k * zet) / (3 * Math.Sqrt(Number));
                double b = (1.0 / (18 * Number)) * ((f1 - 4 * (f1 + 3)) * k * k * zet * zet + 8 * Math.Pow(k, 4) * Math.Pow(zet, 4));
                double c = ((k * k * zet) / (27 * Math.Pow(Number, 3.0 / 2))) *
                           ((f2 * f2) / 5 - ((4 * (f2 + 45) * k * k * zet * zet) / 15) + 8 * Math.Pow(k, 4) * Math.Pow(zet, 4));
                tempsum = MainPart * (a - b + c);
                sum += tempsum;
                k++;

            }
            while (Math.Abs(tempsum) >= 0.000001);
            /*double sum1 = 0; ;
            k = 0;
            do
            {
                k++;
                double MainPart = Math.Pow(-1, k) * Math.Exp(-2 * k * k * zet * zet);
                tempsum = MainPart;
                sum1 += tempsum;

            }
            while (tempsum >= 0.0000001);
            sum1 = 1 + 2 * sum1;*/
            sum = 1 + 2 * sum;
            return sum;
        }

        public static void RemoveComments(ref string s)
        {
            char[] b = new char[s.Length];
            char[] z = s.ToCharArray();
            int Len = 0;
            for (int i = 0; i < z.Length; i++)
            {
                if (z[i] != '#')
                {
                    Len++;
                    b[i] = z[i];
                }
                else break;
            }

            if (b.Length == 0)
                s = null;
            s = "";
            for (int i = 0; i < Len; i++)
            {
                s += b[i];
            }
        }

        public static int CompNumOfClasses(int Number)
        {
            int FinalNumber = 0;
            if (Number > 100)
            {
                FinalNumber = (int)Math.Ceiling(Math.Pow(Number, 1.0 / 3));
            }
            else
            {
                FinalNumber = (int)Math.Pow(Number, 1.0 / 2);
            }
            if ((FinalNumber % 2) == 0)
            {
                return FinalNumber + 1;
            }
            else
            {
                return FinalNumber;
            }
        }

        public static int ComputeSizeOfPoint(int Number)
        {
            if (Number < 13)
            {
                if (Number < 4)
                    return 5;
                if (Number > 8)
                    return 3;
                return 4;
            }
            else
            {
                if (Number > 25)
                    return 1;
                return 2;
            }
        }
    }
}
