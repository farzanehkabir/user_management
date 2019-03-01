using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class AllDate
	{
		public static Date ConvertMiladToShamsi(System.DateTime time)
		{
			
			System.Globalization.PersianCalendar persianCalender = new System.Globalization.PersianCalendar();
			int year = persianCalender.GetYear(time);
			int month = persianCalender.GetMonth(time);
			int day = persianCalender.GetDayOfMonth(time);
			Date persianDate = new Date(year: year, month: month, day: day);

			return persianDate;


		}
		public static DateTime ConverShamsiToMiladi(string time)
		{
			int year = Convert.ToInt32(time.Substring(0, 4));
			int month = Convert.ToInt32(time.Substring(5, 2));
			int day = Convert.ToInt32(time.Substring(8, 2));
			DateTime miladiDate = new DateTime(year, month, day);


			return miladiDate;

		}
		public static Date ConverMiladiToGhamari(System.DateTime time)
		{

			System.Globalization.HijriCalendar hijriCalendar = new System.Globalization.HijriCalendar();
			int year = hijriCalendar.GetYear(time);
			int month = hijriCalendar.GetMonth(time);
			int day = hijriCalendar.GetDayOfMonth(time);
			//string hijriDate = $"{date.Year}/{date.Month.ToString().PadLeft(2, '0')}/{date.Day.ToString().PadLeft(2, '0')}";
			Date hijriDate = new Date(year: year, month: month, day: day);
			return hijriDate;
		}

		public static DateTime ConverGhamariToMiladi(string time)
		{

			int year = Convert.ToInt32(time.Substring(0, 4));
			int month = Convert.ToInt32(time.Substring(5, 2));
			int day = Convert.ToInt32(time.Substring(8, 2));
			DateTime miladiDate = new DateTime(year, month, day);
			return miladiDate;

		}

		public static Date ConverMiladiToHebrew(System.DateTime time)
		{

			System.Globalization.HebrewCalendar hebrewCalendar = new System.Globalization.HebrewCalendar();
			int year = hebrewCalendar.GetYear(time);
			int month = hebrewCalendar.GetMonth(time);
			int day = hebrewCalendar.GetDayOfMonth(time);
			Date hebrewDate = new Date(year: year, month: month, day: day);
			return hebrewDate;
		}


	}
}
