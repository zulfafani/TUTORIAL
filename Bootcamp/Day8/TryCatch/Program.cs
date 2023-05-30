using System;

class Program
{
	public static void Main(string[] args)
	{
		try
		{
			Console.WriteLine("User input: ");
			string userInput = Console.ReadLine();
			int number = int.Parse(userInput); //Unhandled exception if user input string
			Console.WriteLine(number);
			
			//if(int.TryParse(userInput))
		}
		catch (Exception e)
		{
				Console.WriteLine(e.Message); //"The input string was not in a correct format"
		}
	}
}