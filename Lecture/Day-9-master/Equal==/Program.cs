using System;
namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello";
            string str2 = "hello";
            Console.WriteLine("Using Equality operator: {0}", str == str2);
            Console.WriteLine("Using equals() method: {0}", str.Equals(str2));

            object str3 = "hello";
            char[] values = { 'h', 'e', 'l', 'l', 'o' };
            object str4 = new string(values);
            Console.WriteLine("Using Equality operator: {0}", str3 == str4);
            Console.WriteLine("Using equals() method: {0}", str3.Equals(str4));

            var a = new MyClass(1);
            var b = new MyClass(1);
            var c = a;
            Console.WriteLine(a == b);
            Console.WriteLine(a == c);
        }
    }

    public class MyClass
    {
        private int id;

        public MyClass(int id) => this.id = id;
    }
}
