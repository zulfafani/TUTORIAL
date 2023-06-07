using System;

namespace Exercise
{
    public class Program
    {
        public static void Main()
        {
            //MultiArray multiArray = new MultiArray();
            //Console.WriteLine(multiArray.FindMax(1)); belum bener
        }
    }
    public class MultiArray
    {
        public int FindMax(int[,] numbers)
        {
            int height = numbers.GetLength(0); //special to multidimentional array untuk tinggi
            if (height == 0)
            {
                return -1;
            }

            int width = numbers.GetLength(1); //special to multidimentional array untuk panjang/lebar
            if (width == 0)
            {
                return -1;
            }

            int result = numbers[0, 0];

            for (int i = 0; i < height; ++i)
            {
                for (int j = 0; j < width; ++j)
                {
                    int number = numbers[i, j];
                    if (number > result)
                    {
                        result = number;
                    }
                }
            }
            return result;
        }
    }
}