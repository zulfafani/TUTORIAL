using System;
using System.IO;

namespace StreamIO
{
	class Program
	{
		public static void Main()
		{
			string sourcePath = @"source.txt";
			string destinationPath = @"destination.txt";
			
			FileStream fileStream1 = new FileStream(sourcePath, FileMode.Create);
			FileStream fileStream2 = new FileStream(destinationPath, FileMode.Create);
			
			fileStream1.Close();  //dispose the FileStream
			File.Delete(sourcePath); //file sudah didelete jadi tidak menjalankan if statement
			if (File.Exists(sourcePath))
			{
				File.Delete(sourcePath);
				Console.WriteLine("File deleted.");
			}
			
			fileStream2.Close();  //dispose the FileStream
			if (File.Exists(destinationPath))
			{
				string content = File.ReadAllText(destinationPath);
				Console.WriteLine("Read text from a file" + content);
			}
		}
	}
}