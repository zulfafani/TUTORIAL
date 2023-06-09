using System.Diagnostics.Contracts;

class Program
{
    static int Divide(int x, int y)
    {
        Contract.Requires(y != 0);
        Contract.Ensures(Contract.Result<int>() >= 0);
        
        
        Contract.Assume(x > 0);
        
        int result = x / y;
        
        Contract.Assert(result > 0);
        
        return result;
    }
    
    static void Main(string[] args)
    {
        Console.WriteLine(Divide(10, 5)); // should print 2
        Console.WriteLine(Divide(10, 0)); // should throw an exception due to Requires
        Console.WriteLine(Divide(-10, 5)); // should throw an exception due to Assume and Assert
    }
}
