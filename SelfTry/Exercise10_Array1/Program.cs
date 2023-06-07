using System;

namespace Exercise
{
    public class Program
    {
        public static void Main()
        {
            ArrayChar arrayChar = new ArrayChar();
            Console.WriteLine(arrayChar.BuildHelloString());
        }
    }
    public class ArrayChar
    {
        public string BuildHelloString()
        {
            char[] letters = { 'h', 'e', 'l', 'l', 'o' };
            var result = "";
            for (int i = 0; i < letters.Length; ++i)
            {
                result += letters[i];
            }
            return result;
        }
    }
}