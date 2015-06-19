/*
 * Created by SharpDevelop.
 * User: kyzek
 * Date: 19.6.2015
 * Time: 12:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SecteniCisel
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Vítejte v programu pro sečtení prvních X čísel od 1 do 100!");
            Console.WriteLine();
			
			Pocty vypocet = new Pocty();
			
			int pocetCisel;
			bool opakovat = true;
			bool vybranaSpravnaVolba = false;
			
			while (opakovat)
			{
				opakovat = true;
				vybranaSpravnaVolba = false;
				
				Console.Write("Zadejte prosím počet čísel od 1 do 100, které chcete sečíst: ");
				
				try
				{
					pocetCisel = int.Parse(Console.ReadLine());
					
					if ((pocetCisel >= 1) && (pocetCisel <= 100))
					{
						Console.WriteLine("Soucet prvnich {0} cisel je: {1}", pocetCisel, vypocet.sectiCisla(pocetCisel));
						Console.ReadKey();
					}
					else
					{
						Console.WriteLine("Nezadali jste číslo v platném rozsahu od 1 do 100!");
						Console.ReadKey();
					}
				}
				
				catch (Exception ex)
				{
					Console.WriteLine("Nezadali jste číslo v platném rozsahu od 1 do 100!");
					Console.WriteLine();
					Console.WriteLine(ex.Message);
					Console.WriteLine();
					Console.WriteLine("Pokračujte libovolnou klávesou...");
					Console.ReadKey();
				}
				
				while (!vybranaSpravnaVolba)
				{
					Console.Clear();
					Console.WriteLine("Zvolte jednu z možností:");
					Console.WriteLine("1 - Opakovat zadání");
					Console.WriteLine("2 - Ukončit program");
					
					char volba = Console.ReadKey().KeyChar;
					
					switch (volba)
					{
						case '1':
							opakovat = true;
							vybranaSpravnaVolba = true;
                            Console.Clear();
							break;
						case '2':
							opakovat = false;
							vybranaSpravnaVolba = true;
                            Console.Clear();
							break;
						default:
							vybranaSpravnaVolba = false;
							break;
					}
				}
			}

		}
	}
}