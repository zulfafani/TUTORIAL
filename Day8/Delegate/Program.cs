using System;

namespace Delegates
{
public delegate void MyDelegate();
class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello!");
		Console.WriteLine("What do you want to do?");
		Console.WriteLine("[S]ee all TODOs");
		Console.WriteLine("[A]dd a TODO");
		Console.WriteLine("[R]emove a TODO");
		Console.WriteLine("[E]xit\n");
		
		Console.Write("Select one of [S][A][R][E] option: ");
		char userInput = (Console.ReadKey()).ToChar;
		Console.WriteLine("Your choice is " + userInput);
		
		//switch (userInput)

		
		//create delegate instance
		MyDelegate myDelegateSeeAll = seeAll;
		myDelegateSeeAll();
		myDelegateSeeAll = addTodo;
		myDelegateSeeAll();
		myDelegateSeeAll = removeTodo;
		myDelegateSeeAll();
		myDelegateSeeAll = exit;
		myDelegateSeeAll();
		
		//user input
		

	}
	
	//method
	static void seeAll()
	
	{
		Console.WriteLine("All TODOs List");
	}
	static void addTodo()
	
	{
		Console.WriteLine("Add TODOs List");
	}
	static void removeTodo()
	
	{
		Console.WriteLine("Remove TODOs List");
	}
	static void exit()
	
	{
		Console.WriteLine("Exit");
	}
}
	
}

