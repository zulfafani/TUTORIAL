using System;

namespace Exercise
{
    public class Program
    {
        public static void Main()
        {
            //ForeachLoop foreachLoop = new ForeachLoop();
            //Console.WriteLine(foreachLoop.IsAnyWordLongerThan(5, "lima")); //belum bener
        }
    }
    public class ForeachLoop
    {
        public bool IsAnyWordLongerThan(int length, string[] words)
        {
            bool result = false;
            foreach (string word in words)
            {
                if (word.Length > length)
                {
                    return result = true; //boleh langsung return true/false tanpa declare var result
                }
            }
            return result;
        }
    }
}
