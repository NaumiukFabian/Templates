using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03AplikacjaZawodnicy
{
    internal class TemperaturyRepository
    {
        public void DodajTemperature(Temperatura temp)
        {
            ModelBazyDanychDataContext db = new ModelBazyDanychDataContext();
            Temp nowaTemp = new Temp()
            {
                nazwaMiasta = temp.Miasto,
                dataSprawdzenia = temp.Data,
                temperatura = temp.Wartosc
            };
            db.Temp.InsertOnSubmit(nowaTemp);
            db.SubmitChanges();

        }
    }
}
