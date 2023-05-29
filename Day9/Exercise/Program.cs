using System;
using System.Text;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello, Welcome to Stasiun ");
		StringBuilder myStringBuilder = new StringBuilder();
		//myStringBuilder.Capacity = 3;
		
		Console.WriteLine("Input Stasiun Code" );
		string inputUser = Console.ReadLine();
		int number = int.Parse(inputUser);
		
		switch (number)
		{
			case 1:
			myStringBuilder.Append("Semarang Poncol");
			break;
			case 2:
			myStringBuilder.Append("Gambir");
			break;
		}
		
		myStringBuilder.Append("Semarang Poncol");
		myStringBuilder.Clear();
		myStringBuilder.Append("Gambir");
		myStringBuilder.Clear();
		myStringBuilder.Append("Pasar Senen");
		
		string result = myStringBuilder.ToString();
		
		Console.WriteLine(result);
	}
}

class Stasiun
{
	
}
