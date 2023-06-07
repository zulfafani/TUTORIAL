using System;

namespace Exercise
{
    public class Program
    {
        public static void Main()
        {
            //ArrayBool arrayBool = new ArrayBool();
            //Console.WriteLine(arrayBool.IsWordPresentInCollection("four", "one")); //array belum bener
        }
    }
    public class ArrayBool
    {
        public bool IsWordPresentInCollection(string[] words, string wordToBeChecked)
        {
            string[] word = { "one", "two", "three" };
            bool result = false;

            for (int i = 0; i < word.Length; i++)
            {
                if (words[i] == wordToBeChecked)
                {
                    result = true;
                }
            }
            return result;
        }
    }
}
