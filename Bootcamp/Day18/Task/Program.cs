using System;
using System.Threading.Tasks;

class Program
{
	static void Main()
	{
		Task.Run(() => Console.WriteLine("Hello, Task Run before new"));
		Task task = new Task(() => Console.WriteLine("Hello, Task!"));
		task.Start();
		Console.WriteLine("Task start"); //dicompile pertama kali
		Task.Run(() => Console.WriteLine("Hello, Task Run Immediately!"));//bisa dicompile setelah atau sebelum task wait
		task.Wait(); // Wait for the task to complete
		Console.WriteLine("Task wait");
		Task.Run(() => Console.WriteLine("Hello, Task Run after wait!"));
	}
}

