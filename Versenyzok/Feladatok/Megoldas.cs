using System;
using System.Collections.Generic;
using Versenyzok.FileKezeles;
using Versenyzok.Objektumok;

namespace Versenyzok.Feladatok
{
    class Megoldas
    {
        static public void Megoldasok()
        {
            FileBeolvas beolvas = new FileBeolvas("pilotak.csv");
            List<Pilota> lista = Pilota.PilotaListaLetrehozas(beolvas.Feltolt(';'));
            HarmadikFeladat.Megoldas(lista);
            NegyedikFeladat.Megoldas(lista);
            OtodikFeladat.Megoldas(lista);
            HatodikFeladat.Megoldas(lista);
            HetedikFeladat.Megoldas(lista);

            Console.ReadKey(true);
        }
    }
}
