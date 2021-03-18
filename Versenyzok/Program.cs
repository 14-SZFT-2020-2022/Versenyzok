using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Versenyzok.FileKezeles;
using Versenyzok.Objektumok;
using Versenyzok.Feladatok;

namespace Versenyzok
{
    class Program
    {
        static void Main(string[] args)
        {
            FileBeolvas beolvas = new FileBeolvas("pilotak.csv");
            List<Pilota> lista = Pilota.PilotaListaLetrehozas(beolvas.Feltolt(';'));
            HarmadikFeladat.Megoldas(lista);
            NegyedikFeladat.Megoldas(lista);
            OtodikFeladat.Megoldas(lista);
            
            Console.ReadKey(true);
        }
    }
}
