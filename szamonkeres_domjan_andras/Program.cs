using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace szamonkeres_domjan_andras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string vezeteknev;

            while (true)
            {
                Console.Write("Kérem adja meg a vezetéknevét: ");
                vezeteknev = Console.ReadLine();
                if (char.IsUpper(vezeteknev.Trim()[0]))
                    break;
                else
                {
                    Console.WriteLine("Hibás név! A vezetéknévnek nagybetűvel kell kezdődnie.");
                }
            }

           
            string keresztnev;

            while (true)
            {
                Console.Write("Kérem adja meg a keresztnevét: ");
                keresztnev = Console.ReadLine();
                if (char.IsUpper(keresztnev.Trim()[0]))
                    break;
                else
                {
                    Console.WriteLine("Hibás név! A keresztnévnek nagybetűvel kell kezdődnie.");
                }
            }

            string nev = vezeteknev + " " + keresztnev;

            double testsuly;

            while (true)
            {
                Console.Write("Kérem adja meg a testsúlyát kilogrammban: ");
           
                if (double.TryParse(Console.ReadLine(), out testsuly) && testsuly >= 50 && testsuly <= 120)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hibás adat! A testsúly 50 és 120 között kell legyen.");
                }
            }

            int edzescel;
            while (true)
            {
                Console.Write("Kérem válassza ki az edzés célját (1 - Állóképesség, 2 - Izomtömeg növelése, 3 - Fogyás): ");
                if (int.TryParse(Console.ReadLine(), out edzescel) && edzescel >= 1 && edzescel <= 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hibás választás! Kérem adjon meg 1-et, 2-t vagy 3-at.");
                }
            }

            string edzestipus;
            int alaphossz = 0;

            switch (edzescel)
            {
                case 1:
                    edzestipus = "Futás/Kerékpározás";
                    alaphossz = 45;
                    break;
                case 2:
                    edzestipus = "Súlyzós edzés";
                    alaphossz = 60;
                    break;
                case 3:
                    edzestipus = "Intervall edzés";
                    alaphossz = 30;
                    break;
                default:
                    edzestipus = "Érvénytelen cél";
                    alaphossz = 0;
                    Console.WriteLine("Kérlek válassz ezek közül (1 - Állóképesség, 2 - Izomtömeg növelése, 3 - Fogyás):  ");
                    break;
            }


            int edzesnapok;
            while (true)
            {
                Console.Write("Hány napot szeretne edzeni a héten? (1-7): ");
                if (int.TryParse(Console.ReadLine(), out edzesnapok) && edzesnapok >= 1 && edzesnapok <= 7)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hibás adat! A napok száma 1 és 7 között kell legyen.");
                }
            }

            double heti_edzesido = 0;

            for (int i = 1; i <= edzesnapok; i++)
            {
                int erosseg;
                while (true)
                {
                    Console.Write($"Adja meg az {i}. napjára az erősségi szintet (1-től 5-ig): ");
                    if (int.TryParse(Console.ReadLine(), out erosseg) && erosseg >= 1 && erosseg <= 5)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Hibás erősségi szint! Kérjük, adjon meg egy számot 1 és 5 között.");
                    }
                }

                double napiEdzesIdo = alaphossz * (1 + 0.1 * erosseg);
                heti_edzesido += napiEdzesIdo;
            }

            double kaloria_szorzo = 0;
            switch (edzescel)
            {
                case 1:
                    kaloria_szorzo = 0.12;
                    break;
                case 2:
                    kaloria_szorzo = 0.10;
                    break;
                case 3:
                    kaloria_szorzo = 0.15;
                    break;
            }
            
            double heti_kaloria = testsuly * heti_edzesido * kaloria_szorzo;

            Console.WriteLine("\nEdzés összegzés");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Név: {nev}");
            Console.WriteLine($"Edzés célja: {edzestipus}");
            Console.WriteLine($"Heti edzésidő: {heti_edzesido} perc");
            Console.WriteLine($"Összes elégetett kalória: {heti_kaloria} kcal");
        }
    }
}