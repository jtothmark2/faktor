//BigInteger osztály (struktúra) elérése:
//1. System.Numerics hozzáadása
//2. using System.Numerics
using System;
using System.Numerics;

namespace faktoriálisBigInteger
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Számok faktoriálisa 20 és 40 között");
            for (int szam = 20; szam <= 100000; szam++)
            {
                BigInteger faktor = 1;
                for (int i = 2; i <= szam; i++)
                {
                    faktor = faktor * i;
                }
                Console.WriteLine($"{szam}!={faktor}");
            }
            Console.ReadKey();
        }
    }
}
