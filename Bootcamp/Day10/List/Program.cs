using System;
using System.Collections.Generic;

namespace ListDays
{
	public class Program
	{
		public static void Main(string[] args)
		{
			List<string> days = new List<string>();
			days.Add("Sunday");
			days.Add("SUNDAY");
			days.Add("MONDAY");
			days.Add("Sund4y");
			days.Add("MONDAY");

			foreach (string i in days)
			{
				if (days.Contains(i))
				{
					continue; //not contain dupplicate maka next line dijalankan
				}

				bool isUpperCase = true; //value default dulu
				foreach (char character in i)
				{
					if (!char.IsUpper(character))
					{
						isUpperCase = false;
					}
				}
				if (isUpperCase)
				{
					days.Add(i);
				}
			}
			Console.WriteLine(string.Join(days));

		}
	}
}