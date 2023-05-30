using System;

class Calculator
{
	public int number1, number2;
	
	public Calculator(int x, int y)
	{
		number1 = x;
		number2 = y;
	}
	public static Calculator operator -(Calculator c1)
	{
		c1.number1 = -c1.number1;
		c1.number2 = -c1.number2;
	return c1;
	}
	public void Print()
	{
		Console.WriteLine ("Number1 = " + number1);
		Console.WriteLine ("Number2 = " + number2);
	}
}

class Program
{
	static void Main(String []args)
	{
		Calculator calc = new Calculator(15, -25);
		calc = -calc;
	 
	}
}