using System;

public class Program
{
	public static void Main(string[] args)
	{
		string[] days = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
		int[] numbers = {1,2,3,4,5};
		
		for(int i = 0; i < days.Length; i++)
		{
			Console.WriteLine(days[i]);
		}
		
		foreach(int j in numbers)
		{
			Console.WriteLine(j);
		}
		
		bool holidays = days.Contains("Sunday");
		if(holidays == true)
		{
			Console.WriteLine("Playing everyday");
		}
		else
		{
			Console.WriteLine("Not the days");
		}
	}
}
