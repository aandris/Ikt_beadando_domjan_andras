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
            Console.Write("Kérem adja meg a vezetéknevét: ");
            string vezeteknev = Console.ReadLine();

            Console.Write("Kérem adja meg a keresztnevét: ");
            string keresztnev = Console.ReadLine();

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

            Console.Write("Kérem válassza ki az edzés célját (1 - Állóképesség, 2 - Izomtömeg növelése, 3 - Fogyás):");
            int edzescel=int.Parse(Console.ReadLine());


            string edzestipus="";
            int alaphossz=0;

            switch(edzescel)
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

            Console.WriteLine($"Edzés típusa: {edzestipus}");
            Console.WriteLine($"Alap edzésidő (perc): {alaphossz}");
        }
}
}
