﻿using System;
namespace DestructorExample
{
	class DestructorDemo
	{
		public DestructorDemo()
		{
			Console.WriteLine("Constructor Object Created");
		}
		~DestructorDemo()
		{
			string type = GetType().Name;
			Console.WriteLine($"Object {type} is Destroyed");
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			DestructorDemo obj1 = new DestructorDemo();
			DestructorDemo obj2 = new DestructorDemo();

			//Making obj1 for Garbage Collection
			obj1 = null;
			GC.Collect(0);
            Console.ReadKey();
        }
	}
}