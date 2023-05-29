using System;

namespace Exercise
{
    public class Program
    {
        public static void Main()
        {
            DoWhileLoop doWhileLoop = new DoWhileLoop();
            Console.WriteLine(doWhileLoop.RepeatCharacter('a', 4));
        }
    }
    public class DoWhileLoop
    {
        public string RepeatCharacter(char character, int targetLength)
        {
            string result = ""; // wajib pake ="" sama seperti int result = 0
            do
            {
                result += character; // result = character ditambah looping character
                // result += char.ToString(character); bisa juga
            }
            while (result.Length < targetLength); //kondisi yang harus dipenuhi
            return result;
        }
    }
}