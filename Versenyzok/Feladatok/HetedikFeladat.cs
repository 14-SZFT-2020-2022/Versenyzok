using System;
using System.Collections.Generic;
using Versenyzok.Objektumok;

namespace Versenyzok.Feladatok
{
    class HetedikFeladat
    {
        static public void Megoldas(List<Pilota> lista)
        {
            Dictionary<string, int> konytar = new Dictionary<string, int>();
            SortedSet<string> halmaz = new SortedSet<string>();

            foreach (Pilota elem in lista)
            {
                bool vanE = true;

                foreach (KeyValuePair<string, int> item in konytar)
                {
                    if (elem.Rajtszam == item.Key)
                    {
                        if (elem.Rajtszam != "")
                        {
                            halmaz.Add(elem.Rajtszam);
                        }
                        int adat = item.Value;
                        vanE = false;
                        konytar.Remove(item.Key);
                        konytar.Add(elem.Rajtszam, ++adat);
                        break;
                    }
                }

                if (vanE)
                {
                    konytar.Add(elem.Rajtszam, 1);
                }
            }

            string kiir = "7. Feladat: ";

            foreach (string elem in halmaz)
            {
                if (elem != halmaz.Max)
                {
                    kiir += $"{elem}, ";
                }
                else
                {
                    kiir += $"{elem}";
                }
            }

            Console.WriteLine(kiir);
        }
    }
}
