﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class MultiplicativeGen : IRandomGenerator
    {
        private double key;

        private readonly long m;
        private readonly long d;

        public MultiplicativeGen()
        {
            m = 630360016;
            d = 2147483647;
            key = 1;
        }

        double IRandomGenerator.GetNext()
        {
            key = ((key * m + 1) % d);
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
