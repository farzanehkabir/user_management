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

			System.DateTime dateNow = System.DateTime.Now;
			
			System.Console.WriteLine(dateNow.ToString("yyyy/MM/dd hh:mm:ss"));
			System.Console.WriteLine(dateNow);
			System.Console.WriteLine("--------------------------------------------");

			Date persianDate = AllDate.ConvertMiladToShamsi(dateNow);
			Console.WriteLine($"ConvertMiladToShamsi : \t\t {persianDate.GetString()}");
			//System.Console.WriteLine(persianDate.Year);
			//System.Console.WriteLine(persianDate.Month);
			//System.Console.WriteLine(persianDate.Day);
			System.Console.WriteLine();

			Date hijriDate = AllDate.ConverMiladiToGhamari(dateNow);
			Console.WriteLine($"ConverMiladiToGhamari : \t {hijriDate.GetString()}");
			//System.Console.WriteLine(hijriDate.Year);
			//System.Console.WriteLine(hijriDate.Month);
			//System.Console.WriteLine(hijriDate.Day);
			System.Console.WriteLine();

			Date hebrewDate = AllDate.ConverMiladiToHebrew(dateNow);
			Console.WriteLine($"ConverMiladiToHebrew : \t\t {hebrewDate.GetString()}");
			//System.Console.WriteLine(hebrewDate.Year);
			//System.Console.WriteLine(hebrewDate.Month);
			//System.Console.WriteLine(hebrewDate.Day);
			System.Console.WriteLine();

			string persianDate1 = persianDate.GetString();
			DateTime miladiDate = AllDate.ConverShamsiToMiladi(persianDate1);
			//System.Console.WriteLine(miladiDate.Year);
			//System.Console.WriteLine(miladiDate.Month);
			//System.Console.WriteLine(miladiDate.Day);

			Console.WriteLine($"ConverShamsiToMiladi : \t\t {miladiDate.Year}/{miladiDate.Month}/{miladiDate.Day}");
			Console.WriteLine();

			string hijriDate1 = hijriDate.GetString();
			DateTime miladiDate1 = AllDate.ConverGhamariToMiladi(hijriDate1);
			//Console.WriteLine(miladiDate1.Year);
			//Console.WriteLine(miladiDate1.Month);
			//Console.WriteLine(miladiDate1.Day);

			Console.WriteLine($"ConverGhamariToMiladi : \t {miladiDate1.Year}/{miladiDate1.Month}/{miladiDate1.Day}");
			System.Console.WriteLine();




			System.Console.Write("Press [Enter] to Exit....");
			System.Console.ReadLine();
		}
	}
}
