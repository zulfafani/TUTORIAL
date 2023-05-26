using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 12;
            
            bool isSumLargerOrEqualTo17 = (a + b) >= 17;
            Console.WriteLine(isSumLargerOrEqualTo17);

            Boolean boolean = new Boolean();
            Console.WriteLine(boolean.BooleanTypesAndOperators());

            Console.ReadKey();
        }
    }

    public class Boolean
    {
        public bool BooleanTypesAndOperators()
        {
            int a = 1;
            int b = 7;

            bool isSumLargerOrEqualTo17 = (a + b) >= 17;

            return isSumLargerOrEqualTo17;
        }
    }
}
