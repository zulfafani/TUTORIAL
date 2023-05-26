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
            int b = 10;
            int c = 3;
            int result = (a + b) / c ;

            Console.WriteLine(result); //langsung dari Main method

            Exercise exercise = new Exercise();
            Console.WriteLine(exercise.VariablesAndOperator2(7,8,9)); //mengambil dari method lain

            Console.ReadKey();
        }
    }
    public class Exercise
    {
        public int VariablesAndOperator2(int a, int b, int c) //pake static tidak bisa diakses di Main
        {
            int x = a;
            int y = b;
            int z = c;

            int result = (x + y) / z;
            return result;
        }
    }
}
