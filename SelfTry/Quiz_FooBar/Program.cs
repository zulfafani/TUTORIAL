using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FooBar
{
     class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Input your number: ");
            string inputUser = Console.ReadLine();
            int number = int.Parse(inputUser);

            for (int i = 1; i <= number; i++) 
            {
                if(i % 3 == 0 && i % 5 !=0)
                {
                    Console.WriteLine("Foo");
                }
                else if (i % 5 == 0 && i % 3 != 0)
                {
                    Console.WriteLine("Bar");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Foo Bar");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
