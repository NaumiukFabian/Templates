using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06PrzykaldInterfejsyWlasne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kalkulator k = new Kalkulator();

            IUmiejacyWykonywacOperacje iwo = new MechanizmMnozenia();

            double wyinik = k.Policz(3, 5, iwo);
        }
    }
}
