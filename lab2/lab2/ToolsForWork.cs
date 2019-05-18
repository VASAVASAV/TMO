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
    }
}
