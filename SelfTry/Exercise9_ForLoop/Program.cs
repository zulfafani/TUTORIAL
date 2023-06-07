using System;

namespace Exercise
{
    public class Program
    {
        public static void Main()
        {
            //input user
            Console.Write("Input your number: ");
            string inputUser = Console.ReadLine();
            bool isParsingSuccesfull = int.TryParse(inputUser, out int number);
            if (isParsingSuccesfull)
            {
                Console.WriteLine("Number is = " + number);
            }
            else
            {
                Console.WriteLine("Not the number");
            }

            ForLoop forLoop = new ForLoop();
            Console.WriteLine(forLoop.Factorial(number)); //input 5 = 120
        }
    }
    public class ForLoop
    {
        public int Factorial(int number)
        {
            int result = 1;
            for (int x = 1; x <= number; x++)
            {
                result *= x;
            }
            return result;
        }
    }
}
