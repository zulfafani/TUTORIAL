using System;

class Program
{
	enum Level
	{
		Low,
		Medium,
		High
	}
	public static void Main(string[] args)
	{
		Level status = Level.Low;

		switch(status) 
  		{
    		case Level.Low:
      		Console.WriteLine("Low level");
      		break;
    		case Level.Medium:
       		Console.WriteLine("Medium level");
      		break;
    		case Level.High:
      		Console.WriteLine("High level");
      		break;
  }
	}
}
