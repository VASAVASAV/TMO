using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class SystemGen : IRandomGenerator
    {
        private uint key;

        private Random MyRand;

        public SystemGen()
        {
            MyRand = new Random(1);
        }

        double IRandomGenerator.GetNext()
        {
            return MyRand.NextDouble();
        }

        void IRandomGenerator.ChangeKey(uint NewKey)
        {
            if (NewKey != 0)
            {
                MyRand = new Random((int)NewKey);
            }
        }
    }
}
