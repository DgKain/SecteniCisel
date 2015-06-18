//Tohle je aplikace urcena pro testovani mych myslenek a hypotez

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte počet čísel od 1 do 100, která chcete sečíst: ");
            int pocetCisel;
            int.TryParse(Console.ReadLine(), out pocetCisel);
            
            int vysledek = 0;

            if ((pocetCisel >= 1) && (pocetCisel <= 100))
            {
                for (int i = 0; i < pocetCisel; i++)
                {
                    vysledek += (i + 1);
                }
                Console.WriteLine(vysledek);
            }
            else
                Console.WriteLine("Nezadal jste hodnotu od 1 do 100");
        }
    }
}
