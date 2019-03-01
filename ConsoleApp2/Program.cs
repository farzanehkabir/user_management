using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			Date persianDate = AllDate.ConvertMiladToShamsi(System.DateTime.Now);
			Console.WriteLine(persianDate.GetString());
			System.Console.WriteLine(persianDate.Year);
			System.Console.WriteLine(persianDate.Month);
			System.Console.WriteLine(persianDate.Day);
			System.Console.WriteLine();

			Date hijriDate = AllDate.ConverMiladiToGhamari(System.DateTime.Now);
			Console.WriteLine(hijriDate.GetString());
			System.Console.WriteLine(hijriDate.Year);
			System.Console.WriteLine(hijriDate.Month);
			System.Console.WriteLine(hijriDate.Day);
			System.Console.WriteLine();

			Date hebrewDate = AllDate.ConverMiladiToHebrew(System.DateTime.Now);
			Console.WriteLine(hebrewDate.GetString());
			System.Console.WriteLine(hebrewDate.Year);
			System.Console.WriteLine(hebrewDate.Month);
			System.Console.WriteLine(hebrewDate.Day);
			System.Console.WriteLine();







			System.Console.Write("Press [Enter] to Exit....");
			System.Console.ReadLine();
		}
	}
}
