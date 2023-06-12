using System;
using System.Threading;

class Program
{
	static void Main()
	{
		// Create a new thread using the ThreadStart delegate
		Thread t1 = new Thread(new ThreadStart(DoWorkSimple));
		t1.Start();
		t1.Priority = ThreadPriority.Highest;
		// Create a new thread using the ParameterizedThreadStart delegate
		Thread t2 = new Thread(new ParameterizedThreadStart(DoWorkWithParameter));
		t2.Start(2);
		t2.IsBackground = true;
		// Create a new thread using the ThreadStart delegate
		Thread t3 = new Thread(new ThreadStart(IsElseConditionalStatement));
		t3.Start();
		t3.Join(); //nungguin selesai
	}

	static void DoWorkSimple()
	{
		Console.WriteLine("Simple work: Thread ID={0}", Thread.CurrentThread.ManagedThreadId);
	}

	static void DoWorkWithParameter(object param)
	{
			Console.WriteLine("Parameterized work: Thread ID={0}, Parameter='{1}'", Thread.CurrentThread.ManagedThreadId, param);
	}
	static void IsElseConditionalStatement()
	{
		int number = 0;
		string result;

		if (number < 0)
		{
			result = "negative";
		}
		else if (number == 0)
		{
			result = "zero";
		}
		else
		{
			result = "positive";
		}
		Console.WriteLine(result + " Thread ID={0}", Thread.CurrentThread.ManagedThreadId);
		Thread.Sleep(2000);
		Console.WriteLine(result + " Thread ID={0}", Thread.CurrentThread.ManagedThreadId);
		
	}

}

