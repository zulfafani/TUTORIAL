using System;

namespace Override
{
class Animal
{
	public virtual void makeSound()
	{
		Console.WriteLine("Default");
	}
}
	class Cat : Animal
	{
		public override void makeSound()
		{
			Console.WriteLine("Miaw");
		}
	}
	class Dog : Animal
	{
		public override void makeSound()
		{
			Console.WriteLine("Bark");
		}
	}
	
	static class Program
	{
	static void Main()
	{
		Animal a = new Animal();
		Cat b = new Cat();
		Dog c = new Dog();

		a.makeSound();
		b.makeSound();
		c.makeSound();

		Animal aa = new Cat();

		aa.makeSound();

	}
	}
}

