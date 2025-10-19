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
            Console.WriteLine("Kérem adja meg a vezetéknevét: ");
            string vezeteknev = Console.ReadLine();

            Console.WriteLine("Kérem adja meg a keresztnevét: ");
            string keresztnev = Console.ReadLine();

            string nev = vezeteknev + " " + keresztnev;

            double testsuly;

            while (true)
            {
                Console.WriteLine("Kérem adja meg a testsúlyát kilogrammban: ");
                if (double.TryParse(Console.ReadLine(), out testsuly) && testsuly >= 50 && testsuly <= 120)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hibás adat! A testsúly 50 és 120 között kell legyen.");
                }

            }
    }
}
}
