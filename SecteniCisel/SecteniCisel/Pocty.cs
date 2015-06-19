/*
 * Created by SharpDevelop.
 * User: kyzek
 * Date: 19.6.2015
 * Time: 13:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SecteniCisel
{
	/// <summary>
	/// Tato trida ma na starost veskere vypocty s cisly
	/// </summary>
	public class Pocty
	{
		public int sectiCisla(int pocetCisel)
		{
			int soucetCisel = 0;
			
			for (int i = 0; i < pocetCisel; i++)
			{
				soucetCisel += (i + 1);
			}
			
			return soucetCisel;
		}
	}
}
