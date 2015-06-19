/*
 * Created by Ondrej Kyzek
 * User: kyzek
 * Date: 19.6.2015
 * Time: 12:59
 */
using System;

namespace SecteniCisel
{
	class Program
	{
		public static void Main(string[] args)
		{
            // Program vypise pozdrav na obrazovku a oddeli dalsi text prazdnym radkem
			Console.WriteLine("Vítejte v programu pro sečtení prvních X čísel od 1 do 100!");
            Console.WriteLine();

            Pocty vypocet = new Pocty(); // Vytvoreni instance tridy pro finalni vypocet
			
			int pocetCisel; // deklarace promenne pro uchovani vstupu od uzivatele
			bool opakovat = true; // promenna pro opakovani hlavni casti programu
			bool vybranaSpravnaVolba = false; // promenna pro opakovane zadani volby uzivatelem v pripade chybne volby
			
			while (opakovat) // dokud uzivatel bude chtit, pokracuj ve vykonavani programu
			{
                // nastaveni pocatecnich hodnot promennych, ktere ridi cykly
				opakovat = true;
				vybranaSpravnaVolba = false;
				
				Console.Write("Zadejte prosím počet čísel od 1 do 100, které chcete sečíst: ");
				
				try // osetruji, zda uzivatel zadava takove hodnoty, ktere pujde prevest na Integer
				{
					pocetCisel = int.Parse(Console.ReadLine()); // do hodnoty pocetCisel ukladam vstup od uzivatele prevedeny na datovy typ Integer
					
					if ((pocetCisel >= 1) && (pocetCisel <= 100)) // je vstup od uzivatele v rozmezi mezi 1 az 100?
					{
						Console.WriteLine("Soucet prvnich {0} cisel je: {1}", pocetCisel, vypocet.sectiCisla(pocetCisel)); // vypocteni hodnoty a vystup na obrazovku
						Console.ReadKey();
					}
					else
					{
						Console.WriteLine("Nezadali jste číslo v platném rozsahu od 1 do 100!");
						Console.ReadKey();
					}
				}
				
				catch (Exception ex) // osetreni jakekoliv vyjimky, ktera by v prubehu Parse mohla vzniknout
				{
					Console.WriteLine("Nezadali jste číslo v platném rozsahu od 1 do 100!");
					Console.WriteLine();
					Console.WriteLine(ex.Message);
					Console.WriteLine();
					Console.WriteLine("Pokračujte libovolnou klávesou...");
					Console.ReadKey();
				}
				
				while (!vybranaSpravnaVolba) // opakuj zadost o spravnou volbu uzivatele
				{
					Console.Clear();
					Console.WriteLine("Zvolte jednu z možností:");
					Console.WriteLine("1 - Opakovat zadání");
					Console.WriteLine("2 - Ukončit program");
					
					char volba = Console.ReadKey().KeyChar; // precti klavesu, kterou uzivatel stiskl, a uloz ji do promenne volba
					
					switch (volba) // zjistuji, kterou z moznosti uzivatel vybral
					{
						case '1': // v pripade, ze chce uzivatel pokracovat v behu programu, mazu obrazovku a vracim se zpet na "zacatek" programu
							opakovat = true;
							vybranaSpravnaVolba = true;
                            Console.Clear();
							break;
						case '2': // pokud se uzivatel rozhodl program ukoncit, mazu obrazovku a jiz nenecham program bezet znovu
							opakovat = false;
							vybranaSpravnaVolba = true;
                            Console.Clear();
							break;
						default:
							vybranaSpravnaVolba = false; // pokud uzivatel nevybral ani jednu z techto moznosti, pozadam o opetovne zadani volby 1 nebo 2
							break;
					}
				}
			}
		}
	}
}