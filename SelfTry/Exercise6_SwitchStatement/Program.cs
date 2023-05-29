using System;

namespace Exercise
{
    public class Program
    {
        public static void Main()
        {
            SwitchStatement switchStatement = new SwitchStatement();
            Console.WriteLine(switchStatement.DescribeDay(5));
        }
    }
    public class SwitchStatement
    {
        public string DescribeDay(int dayNumber)
        {
            switch (dayNumber)
            {
                case 1: //untuk case yang sama bisa seperti ini
                case 2:
                case 3:
                case 4:
                case 5:
                    {
                        return "Working day";
                    }
                case 6:
                case 7:
                    {
                        return "Weekend";
                    }
                default:
                    {
                        return "Invalid day number";
                    }
            }
        }
    }
}
