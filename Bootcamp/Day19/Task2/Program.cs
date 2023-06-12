using System;
using System.Threading.Tasks;

class Program
{
	static async Task Main()
	{
		Task task = Task.Run(() => Console.WriteLine("Hello from Task 1!"));
		//task.Wait();
		await Task.Delay(2000);

		//Console.WriteLine($"IsCompleted: {task.IsCompleted}");
		//Console.WriteLine($"IsFaulted: {task.IsFaulted}");
		//Console.WriteLine($"IsCanceled: {task.IsCanceled}");

		Task continuation = task.ContinueWith(t => Console.WriteLine("Hello from Task 2!"));
		//continuation.Wait();
		await Task.Delay(2000);

		Task.Run(() => Console.WriteLine("Hello from Task 3!"));

		Task<int> task4 = Task.Run(() => Add(10));
		int result = task4.Result;
		Console.WriteLine($"Result: {result}");

		//TaskCancel
		CancellationTokenSource cts = new();
		CancellationToken token = cts.Token;

		Task task5 = DoWorkAsync(token);

		Console.WriteLine("Press 'c' to cancel the operation.");
		if (Console.ReadKey().KeyChar == 'c')
		{
			cts.Cancel();
		}

		try
		{
			await task5;
			Console.WriteLine("Operation completed.");
		}
		catch (OperationCanceledException)
		{
			Console.WriteLine("Operation canceled.");
		}

	}
	static async Task<int> Add(int a)
	{
		for (int j = 0; j < a; j++)
		{
			await Task.Delay(500);
			Console.WriteLine(j);
		}
		return a = a - 1;
	}
	static async Task DoWorkAsync(CancellationToken token)
	{
		for (int i = 0; i < 10; i++)
		{
			token.ThrowIfCancellationRequested();

			Console.WriteLine($"Work in progress: {i * 10}%");
			await Task.Delay(500, token);
		}
	}
}
