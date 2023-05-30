// See https://aka.ms/new-console-template for more information
using System;

namespace DataType
{
	class Cat
	{
		public Leg catLeg;
		
		public void SetLeg()
		{
			Console.WriteLine("setleg");
		}
	}
	
	class Leg
	{
		public int Leg;
		
		public Leg(int x)
		{
			catLeg = x;
		}
		
	}
	
	class Program
	{
		static void main()
		{
			Cat leg = new Cat();
			leg.SetLeg();
		}
		
	}

	
}
