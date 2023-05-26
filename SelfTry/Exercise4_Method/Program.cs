using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Exercise exercise = new Exercise();
            Console.WriteLine(exercise.AbsoluteOfSum(-2, -8)); //10
        }
    }
    public class Exercise
    {
        public int AbsoluteOfSum(int x, int y)
        {
            return Math.Abs(x + y);
        }
    }
}
