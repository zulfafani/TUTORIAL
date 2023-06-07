using System;

namespace Exercise
{
    public class Program
    {
        public static void Main()
        {
            //belum tahu
        }
    }
    public class Exercise
    {
        public List<string> GetOnlyUpperCaseWords(List<string> words) //return type List<string> bukan string aja
        {
            var result = new List<string>(); //declare untuk input collection
            foreach (string word in words)
            {
                if (result.Contains(word))
                {
                    continue; //not contain dupplicate maka next line dijalankan
                }

                bool isUpperCase = true; //value default dulu
                foreach (char character in word)
                {
                    if (!char.IsUpper(character))
                    {
                        isUpperCase = false;
                    }
                }
                if (isUpperCase) //sudah boolean
                {
                    result.Add(word);
                }
            }
            return result;
        }
    }
}
