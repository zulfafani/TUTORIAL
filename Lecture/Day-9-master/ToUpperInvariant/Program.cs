using System;
using System.Globalization;

class Program {
    static void Main() {
        string str = "i̇stanbul";

        // Use ToUpper() method to convert the string to uppercase
        string upper = str.ToUpper(new CultureInfo("tr-TR"));
        Console.WriteLine("ToUpper(): " + upper);

        // Use ToUpperInvariant() method to convert the string to uppercase
        string upperInvariant = str.ToUpperInvariant();
        Console.WriteLine("ToUpperInvariant(): " + upperInvariant);

        // Compare the two strings for equality
        bool isEqual = upper.Equals(upperInvariant, StringComparison.InvariantCulture);
        Console.WriteLine("Are they equal? " + isEqual);
    }
}
