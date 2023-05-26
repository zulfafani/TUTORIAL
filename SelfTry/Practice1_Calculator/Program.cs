using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Program
    {
        public static void Main()
            //kalo pake static tidak bisa passing value parameter dari method lain
            //harus instance of class methodnya
        {
            UserAction finalEquation = new UserAction(); // Class instanceMethod = new Class

            Console.WriteLine("Hello!");
            Console.WriteLine("Input the first number: ");
            string inputUser = Console.ReadLine();
            int number1 = int.Parse(inputUser);
            //Console.WriteLine(number1); tidak perlu

            Console.Write("Input the second number: ");
            string inputUser2 = Console.ReadLine();
            int number2 = int.Parse(inputUser2);
            //Console.WriteLine(number2); tidak perlu

            Console.WriteLine("What do you want to do with those numbers?");
            Console.WriteLine("[A]dd");
            Console.WriteLine("[S]ubtract");
            Console.WriteLine("[M]ultiply");
            string inputUserAction = Console.ReadLine();

            //if (inputUserAction == "A" || inputUserAction == "a") ndak efektif
            if (finalEquation.PrintOption(inputUserAction, "A")) // aku coba ("A","A") bisa
            {
                int result = number1 + number2;
                //Console.WriteLine(number1 + " + " + number2 + " = " + result); ndak efektif
                finalEquation.PrintFinalEquation(number1, number2, result, "+"); //instanceMethod.method()
            }
            //else if (inputUserAction == "S" || inputUserAction == "s") ndak efektif
            else if (finalEquation.PrintOption(inputUserAction, "S")) // aku coba ("inputUserAction","inputUserAction") bisa
            {
                int result = number1 - number2;
                //Console.WriteLine(number1 + " - " + number2 + " = " + result); ndak efektif
                finalEquation.PrintFinalEquation(number1, number2, result, "-");  //instanceMethod.method()
            }
            //else if (inputUserAction == "M" || inputUserAction == "m") ndak efektif
            else if (finalEquation.PrintOption("inputUserAction", "M")) // aku coba ("m","m") bisa
            {
                int result = number1 * number2;
                //Console.WriteLine(number1 + " * " + number2 + " = " + result); ndak efektif
                finalEquation.PrintFinalEquation(number1, number2, result, "*");  //instanceMethod.method()
            }
            else
            {
                Console.WriteLine("Invalid Option");
            }

            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }

    }

    public class UserAction
    {
        public void PrintFinalEquation(int number1, int number2, int result, string @operator)
        {
            Console.WriteLine(number1 + " " + @operator + " " + number2 + " = " + result);
            //Console.WriteLine($"{number1} {@operator} {number2} = {result}"); using string interpolation
        }

        public bool PrintOption(string left, string right)
        {
            return left.ToUpper() == right.ToUpper();

        }

    }
}
