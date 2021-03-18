using System;
using System.Collections.Generic;

namespace Versenyzok.Objektumok
{
    class Pilota
    {
        public string PilotaNeve { get; set; }
        public DateTime SzuletesiIdo { get; set; }
        public string Nemzetiseg { get; set; }
        public string Rajtszam { get; set; }

        public Pilota(string pilotaNeve, string szuletesiIdo, string nemzetiseg, string rajtszam)
        {
            this.PilotaNeve = pilotaNeve;
            this.SzuletesiIdo = DateTime.Parse(szuletesiIdo);
            this.Nemzetiseg = nemzetiseg;
            this.Rajtszam = rajtszam;
        }

        static public List<Pilota> PilotaListaLetrehozas(List<string[]> lista)
        {
            List<Pilota> pilotaLista = new List<Pilota>();

            foreach (string[] tomb in lista)
            {
                Pilota pilota = new Pilota(tomb[0], tomb[1], tomb[2], tomb[3]);
                pilotaLista.Add(pilota);
            }

            return pilotaLista;
        }
    }
}
