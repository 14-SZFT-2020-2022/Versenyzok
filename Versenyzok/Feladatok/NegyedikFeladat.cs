using System;
using System.Collections.Generic;
using Versenyzok.Objektumok;

namespace Versenyzok.Feladatok
{
    class NegyedikFeladat
    {
        static public void Megoldas(List<Pilota> lista)
        {
            Console.WriteLine($"4. Feladat: {lista[lista.Count - 1].PilotaNeve}");
        }
    }
}
