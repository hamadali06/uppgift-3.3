using System;
namespace uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur många timmar vill du hyra en bil? ");
            int antalTimmar = Convert.ToInt32(Console.ReadLine());

            int maxKostnadPerDag = 950;
            int timpris = 80;

            int totalKostnad = antalTimmar <= 12 ? timpris * antalTimmar : maxKostnadPerDag;
            Console.WriteLine($"Kostnaden för {antalTimmar} timmars bilhyra är {totalKostnad} kr.");
        }
    }
}