using System;
using System.Xml;
class Program
{
	static void Main()
	{
		// Parsing hexadecimal string to integer
		int thirty = Convert.ToInt32("1E", 16); // Parse in hexadecimal (30)
		Console.WriteLine(thirty); // Output: 30

		// Parsing binary string to unsigned integer
		uint five = Convert.ToUInt32("101", 2); // Parse in binary (5)
		Console.WriteLine(five); // Output: 5

		// Using dynamic data type for implicit conversion
		dynamic x = 123;
		dynamic y = "456";

		// Convert x to a string
		string xStr = (string)x;
		Console.WriteLine(xStr); // Output: "123"

		// Convert y to an integer
		int yInt = (int)y;
		Console.WriteLine(yInt); // Output: 456

		// Convert yInt to a double
		double yDbl = (double)yInt;
		Console.WriteLine(yDbl); // Output: 456.0

		// Converting data types using Convert.ChangeType method
		Type targetType = typeof(int);
		object source = "42";
		object result = Convert.ChangeType(source, targetType);
		Console.WriteLine(result); // Output: 42
		Console.WriteLine(result.GetType()); // Output: System.Int32

		// Converting boolean to string and back using XmlConvert
		string s = XmlConvert.ToString(true); // s = "true"
		bool isTrue = XmlConvert.ToBoolean(s);
		Console.WriteLine(isTrue); // Output: True

		// Converting double to byte array using BitConverter
		byte[] bytes = BitConverter.GetBytes(123.456);
		foreach (byte b in bytes)
		{
			Console.Write(b + " "); // Output: 0 0 0 0 0 0 94 64
		}

		// Converting byte array back to double
		double dblValue = BitConverter.ToDouble(bytes, 0);
		Console.WriteLine(dblValue); // Output: 123.456
	}
}
