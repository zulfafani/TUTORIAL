using System;
using System.Collections.Generic;

namespace FooBar
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<int, string> rules = new Dictionary<int, string>();
            rules.Add(3, "Foo");
            rules.Add(5, "Bar");
            rules.Add(7, "Fizz");
            rules.Add(9, "Buzz");

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

            for (int i = 1; i <= number; i++)
            {
                bool isRulesImplemented = false;
                string result = "";

                foreach (var member in rules)
                {
                    if (i % member.Key == 0)
                    {
                        result += member.Value;
                        isRulesImplemented = true;
                    }
                }

                if (!isRulesImplemented)
                    result = i.ToString();

                Console.WriteLine(result);
            }
        }
    }
}

