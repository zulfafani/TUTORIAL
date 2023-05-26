namespace TryandCatch;

class Program
{
	static void Main(string[] args)
	{
		try
		{
			int[] numbers = { 1, 2, 3 };
			Console.WriteLine(numbers[5]); // This will throw an IndexOutOfRangeException
		}
		catch (IndexOutOfRangeException e)
		{
			Console.WriteLine("Oops, you went out of bounds!");
		}
		catch (Exception e)
		{
			Console.WriteLine("An error occurred: " + e.Message);
		}
		finally
		{
			Console.WriteLine("The 'try catch' is finished.");
		}
	}
}
