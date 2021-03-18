using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Versenyzok.FileKezeles;
using Versenyzok.Objektumok;

namespace Versenyzok
{
    class Program
    {
        static void Main(string[] args)
        {
            FileBeolvas beolvas = new FileBeolvas("pilotak.csv");
            Pilota.PilotaListaLetrehozas(beolvas.Feltolt(';'));
            
            Console.ReadKey(true);
        }
    }
}
