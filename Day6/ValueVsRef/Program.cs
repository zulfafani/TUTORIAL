using System;

namespace ValueReference
{
class Program
{
	static void Main()
	{
		int number1 = 10;
		int number2 = number1;
		string stringA = "First";
		string stringB = stringA;
		
		Console.WriteLine(number2); //10
		Console.WriteLine(stringB); //First
		
		MyClass myClassA = new MyClass(1,7);
		MyClass myClassB = myClassA;
		
		//Console.WriteLine(myClassA.number1); can't build because not contain in class MyClass
		//Console.WriteLine(myClassA.number2); can't build because not contain in class MyClass
		//Console.WriteLine(myClassB.number1); can't build because not contain in class MyClass
		//Console.WriteLine(myClassB.number2); can't build because not contain in class MyClass
		
		Console.WriteLine(myClassA.x);
		Console.WriteLine(myClassA.y);
		Console.WriteLine(myClassB.x);
		Console.WriteLine(myClassB.y);
		
	}
}

class MyClass
{
	public int x;
	public int y;
	
	public MyClass(int number1, int number2)
	{
		x = number1;
		y = number2;
	}
}
}
