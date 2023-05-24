class Program
{
	static void Main(string[] args)
	{
		int number1 = 10;
		int number2;
		// int number3;
		RefAsPointer(ref number1, out number2);
		//RefAsPointer(ref number1, out number2, in number3);
		Console.WriteLine(number1); //3
		Console.WriteLine(number2); //4
		//Console.WriteLine(number3); it is a readonly variable
		
	}
	
	static void RefAsPointer(ref int x, out int y)
	//static void RefAsPointer(ref int x, out int y, in int z)
	{
		x = 1 + 2;
		y = x + 1;
		//z = y + 1;
		
	}
}
