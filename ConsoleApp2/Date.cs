using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	public class Date
	{
		public Date(int year,int month,int day)
		{
			Year = year;
			Month = month;
			Day = day;
				
		}

		public int Year { get; set; }

		public int Month { get; set; }

		public int Day { get; set; }

		public string GetString()
		{
			string result = $"{Year}/{Month.ToString().PadLeft(2, '0')}/{Day.ToString().PadLeft(2, '0')}";
			return result;
		}
	}
}
