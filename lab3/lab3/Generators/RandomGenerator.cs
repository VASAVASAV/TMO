﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    interface IRandomGenerator
    {
        double GetNext();

        void ChangeKey(uint Key);
    }
}
