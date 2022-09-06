using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06PrzykaldInterfejsyWlasne
{
    internal class Kalkulator
    {
        public double Policz(int a, int b, IUmiejacyWykonywacOperacje iwo)
        {
            return iwo.WykonajOperacje(a, b);
        }




    }
}
