﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06PrzykaldInterfejsyWlasne
{
    internal class MechanizmMnozenia : IUmiejacyWykonywacOperacje
    {
        public double WykonajOperacje(int a, int b)
        {
            return a * b;
        }
    }
}
