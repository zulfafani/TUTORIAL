using System;
using System.IO;

class Program {
    static void Main() {
        string path = @"bootcamp.bin";

        // Write some binary data to the file
        using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create))) {
            double[] myArray = { 1.1, 2.3, 3.4, 4.5, 5.6 };
            writer.Write(3); // write an int
            writer.Write(myArray.Length); // write the length of the array
            for (int i = 0; i < myArray.Length; i++) {
                writer.Write(myArray[i]); // write each double value in the array
            }
            writer.Write(true);
        }

        // Read the binary data from the file
        using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open))) {
            int x = reader.ReadInt32(); // read the first int value
            int length = reader.ReadInt32(); // read the length of the double array
            double[] myArray = new double[length];
            for (int i = 0; i < length; i++) {
                myArray[i] = reader.ReadDouble(); // read each double value in the array
            }
            bool boolData = reader.ReadBoolean(); // read the bool value
            
            Console.WriteLine("First int value: {0}", x);
            Console.WriteLine("Double array length: {0}", length);
            Console.WriteLine("Double array values: {0}", string.Join(", ", myArray));
            Console.WriteLine("Bool value: {0}", boolData);
        }
    }
}
