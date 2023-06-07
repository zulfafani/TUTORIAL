using System;
using System.Text;

namespace GarbageCollection
{
	public class Program
	{
		public static void Main(string[] args)
		{
			StringBuilder myStringBuilder = new StringBuilder();
			for (int i = 0; i < 10000000; i++)
			{
				Console.WriteLine("Hello, Welcome to String Builder");
				myStringBuilder.Append("abc");
				myStringBuilder.Clear();
				myStringBuilder.Append("def");
				myStringBuilder.Clear();
				myStringBuilder.Append("ghi");
			}
			Console.ReadLine();
		}
	}

	public class MyClass : IDisposable
	{
		private bool disposedValue = false;

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{

				}
				disposedValue = true;
			}

		}
		~MyClass()
		{
			Dispose(false);
		}
		
		public void Dispose()
		{
			Dispose(true);
			 GC.SuppressFinalize(this);
		}
	}
}
