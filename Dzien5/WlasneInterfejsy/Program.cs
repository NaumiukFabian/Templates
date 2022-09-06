using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WlasneInterfejsy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUmiejacyJezdzic[] obiektyUmiejaceJezdzic = new IUmiejacyJezdzic[2]
            {
                new Samochod(),
                new Amfibia()
            };

            foreach(var item in obiektyUmiejaceJezdzic)
            {
                item.Jedz();
            }




        }
    }
}
