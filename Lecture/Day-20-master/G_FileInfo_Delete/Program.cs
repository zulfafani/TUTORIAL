﻿using System;
using System.IO;

namespace FileInfoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"MyTestFile2.txt";
            FileInfo fileInfo = new FileInfo(path);
            fileInfo.Delete();
            Console.WriteLine("File has been deleted");
            Console.ReadKey();
        }
    }
}