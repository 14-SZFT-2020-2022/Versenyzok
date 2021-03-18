using System;
using System.Collections.Generic;
using Versenyzok.Objektumok;

namespace Versenyzok.Feladatok
{
    class OtodikFeladat
    {
        static public void Megoldas(List<Pilota> lista)
        {
            Console.WriteLine($"5. Feladat: ");
            DateTime szazadFordulo = new DateTime(1901,01,01);
            
            foreach (Pilota elem in lista)
            {
                if (DateTime.Compare(elem.SzuletesiIdo, szazadFordulo) < 0)
                {
                    Console.WriteLine($"\t{elem.PilotaNeve} ({elem.SzuletesiIdo.ToShortDateString()})");
                }
            }
        }
    }
}
