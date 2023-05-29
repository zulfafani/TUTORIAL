using System;

namespace Exercise
{
    public class Program
    {
        public static void Main()
        {
            WhileLoop whileLoop = new WhileLoop();
            Console.WriteLine(whileLoop.CalculateSumOfNumbersBetween(5, 10)); //45

            //return number; --> hasil 0,5,11,18,26,35,45
            /*number += firstNumber;
                0 = 0 + 5 = 5
                5 = 5 + 6 = 11
                11 = 11 + 7 = 18
                18 = 18 + 8 = 26
                26 = 26 + 9 = 35
                35 = 35 + 10 = 45 */
            //firstNumber++; --> 5,6,7,8,9,10 untuk looping while agar kondisi memenuhi sampai lastNumber
        }
        public class WhileLoop
        {
            public int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
            {
                int number = 0;
                while (firstNumber <= lastNumber) //memenuhi 5 <= 10, while loop dijalankan
                {                                //tidak memenuhi, while loop tidak dijalankan, number = 0
                    number += firstNumber;
                    firstNumber++;
                }
                return number;
            }
        }
    }
}