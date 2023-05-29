using System;

namespace Exercise
{
    public class Program
    {
        public static void Main()
        {
            StringInterpolation stringInterpolation = new StringInterpolation();
            Console.WriteLine(stringInterpolation.FormatDate(2023, 05, 26));
        }
    }
    public class StringInterpolation
    {
        public string FormatDate(int year, int month, int day)
        {
            //int x = year;
            //int y = month;
            //int z = day;
            //return ($"{x}/{y}/{z}");

            return ($"{year}/{month}/{day}"); //bisa langsung di return

        }
    }

}
