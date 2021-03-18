using System;
using System.Collections.Generic;
using Versenyzok.Objektumok;

namespace Versenyzok.Feladatok
{
    class HatodikFeladat
    {
        static public void Megoldas(List<Pilota> lista)
        {
            string nemzetiseg = "";
            int legkisebb = Int32.MaxValue;

            foreach (Pilota elem in lista)
            {
                if (elem.Rajtszam != "")
                {
                    if (Int32.Parse(elem.Rajtszam) < legkisebb)
                    {
                        legkisebb = Int32.Parse(elem.Rajtszam);
                        nemzetiseg = elem.Nemzetiseg;
                    }
                }
            }

            Console.WriteLine($"6. Feladat: {nemzetiseg}");
        }
    }
}
