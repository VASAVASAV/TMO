using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class HillGen : IRandomGenerator
    {
        private uint key1;
        private uint key2;
        private uint key3;

        private uint m1;
        private uint d1;
        private uint m2;
        private uint d2;
        private uint m3;
        private uint d3;

        public HillGen()
        {
            m1 = 171;
            m2 = 172;
            m3 = 170;
            d1 = 30269;
            d2 = 30307;
            d3 = 30323;
            key1 = 1;
            key2 = 1;
            key3 = 1;
        }

        double IRandomGenerator.GetNext()
        {
            key1=  (key1 * m1) % d1;
            key2 = (key2 * m2) % d2;
            key3 = (key3 * m3) % d3;
            double temp = ((double)key1)/ d1 + ((double)key2) / d2 + ((double)key3) / d3;
            return (temp - Math.Floor(temp));
        }

        void IRandomGenerator.ChangeKey(uint NewKey)
        {
            if (NewKey != 0)
            {
                key1 = NewKey;
                key2 = NewKey;
                key3 = NewKey;
            }
        }
    }
}
