using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class MultiplicativeGen : IRandomGenerator
    {
        private uint key;

        private uint m;
        private uint d;

        public MultiplicativeGen()
        {
            m = 764261123;
            d = 2147483647;
            key = 1;
        }

        double IRandomGenerator.GetNext()
        {
            key = (key * m + 1) % d;
            return ((double)key)/d;
        }

        void IRandomGenerator.ChangeKey(uint NewKey)
        {
            if (NewKey != 0)
            {
                key = NewKey;
            }
        }
    }
}
