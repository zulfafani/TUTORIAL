using System;
using System.IO;
using System.Text;

namespace FileHandlinDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Set the File Path where your File is Exist
            string FilePath = @"MyFile.txt";

            //Create an Instance of FileStream Class By specifying the File Path and File Mode
            //FileMode is going to be Append as we are going to append some text in the file
            FileStream fileStream = new FileStream(FilePath, FileMode.Append);

            //Create the byte array which contains the string data to be appended in the File
            byte[] bytedata = Encoding.Default.GetBytes("C# Is an Object Oriented Programming Language");

            //Write the Byte Array into the File Stream Object using the Write Method
            //array (bytedata): The buffer containing data to write to the stream.
            //offset (0): The zero-based byte offset in the array from which to begin copying bytes to the stream.
            //count (bytedata.Length): The maximum number of bytes to write.
            fileStream.Write(bytedata, 0, bytedata.Length);

            //Finally close the fileStream Object
            fileStream.Close();
            Console.WriteLine("Successfully saved file with data : C# Is an Object Oriented Programming Language");
            Console.ReadKey();
        }
    }
}