using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("What do you want to do");
            Console.WriteLine("[S]ee all TODOs");
            Console.WriteLine("[A]dd a TODO");
            Console.WriteLine("[R]emove a TODO");
            Console.WriteLine("[E]xit");
            Console.WriteLine();

            Console.WriteLine("Select [S][A][R][E] options");
            Console.Write("I want to: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("User input:" + userInput);
            

            Console.ReadLine();
        }
    }
}
