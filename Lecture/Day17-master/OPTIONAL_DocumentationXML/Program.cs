﻿using DocumentationXML;
static class Program
{
	static void Main() 
	{
		double a = 4.5;
		double b = 2.5;
        double Add = MyLib.Add(a, b);
        double Mul = MyLib.Mul(a, b);
		double Div = MyLib.Div(a, b);
		double Sub = MyLib.Sub(a, b);
		string answer = $"{Add} {Mul} {Div} {Sub}";
		Console.WriteLine($"{a} + {b} = {answer}");
	}
}