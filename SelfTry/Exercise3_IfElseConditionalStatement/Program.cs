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
            IfElse ifelse = new IfElse();
            Console.WriteLine(ifelse.IsElseConditionalStatement());
        }
    }
    public class IfElse
    {
        public string IsElseConditionalStatement()
        {
            int number = 0;
            string result;

            if (number >= 0)
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
            return result;
        }

    }
}
