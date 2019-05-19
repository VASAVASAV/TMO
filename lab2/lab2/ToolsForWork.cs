using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class ToolsForWork
    {
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
