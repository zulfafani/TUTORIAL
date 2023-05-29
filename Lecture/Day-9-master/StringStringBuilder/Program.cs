﻿using System;
using System.Diagnostics;
using System.Text;

class Program
{
	static void Main(string[] args)
	{
		// Concatenate a large number of strings using string
		Stopwatch stopwatch1 = Stopwatch.StartNew();

		string result1 = "";
		for (int i = 0; i < 100000; i++)
		{
			result1 += i.ToString();
		}

		stopwatch1.Stop();
		Console.WriteLine("Elapsed time (string): " + stopwatch1.ElapsedMilliseconds);

		// Concatenate a large number of strings using StringBuilder
		Stopwatch stopwatch2 = Stopwatch.StartNew();

		StringBuilder result2 = new StringBuilder();
		for (int i = 0; i < 100000; i++)
		{
			result2.Append(i.ToString());
		}
		stopwatch2.Stop();
		Console.WriteLine("Elapsed time (StringBuilder): " + stopwatch2.ElapsedMilliseconds);
	}
}
