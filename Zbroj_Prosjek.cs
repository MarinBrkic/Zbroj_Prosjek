using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zbroj_i_Prosjek
{
    class KlasaC
    {
        public int Zbroj(int[] niz)
        {
            int zbroj = 0;
            foreach (int broj in niz)
            {
                zbroj += broj;
            }
            return zbroj;
        }

        public double Prosjek(int[] niz)
        {
            if (niz.Length == 0)
            {
                return 0; // Ako je niz prazan, vraćamo prosjek 0.
            }

            int zbroj = Zbroj(niz);
            return (double)zbroj / niz.Length;
        }
    }

    class Program
    {
        static void Main()
        {
            KlasaC objekt = new KlasaC();

            // Unos 5 cijelih brojeva od korisnika
            int[] unos = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Unesite {i + 1}. broj: ");
                if (int.TryParse(Console.ReadLine(), out int broj))
                {
                    unos[i] = broj;
                }
                else
                {
                    Console.WriteLine("Neispravan unos. Molimo unesite cijeli broj.");
                    i--; // Ponovni unos za isti indeks
                }
            }

            // Pozivanje metoda i spremanje rezultata
            int zbroj = objekt.Zbroj(unos);
            double prosjek = objekt.Prosjek(unos);

            // Ispis rezultata
            Console.WriteLine($"Zbroj unesenih brojeva: {zbroj}");
            Console.WriteLine($"Prosjek unesenih brojeva: {prosjek}");

            Console.ReadLine(); // Pauziranje konzole
        }
    }
}
