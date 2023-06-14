using System.IO;

class Program {
    static void Main() {
        string sourcePath = @"..\00FileStream\bootcamp.txt";
        string destPath =@"..\00FileStream\bootcamp2.txt";

        // Copy a file
        if (File.Exists(sourcePath)) {
            File.Copy(sourcePath, destPath, true);
            Console.WriteLine("File copied.");
        }

        // Delete a file
        if (File.Exists(destPath)) {
            File.Delete(destPath);
            Console.WriteLine("File deleted.");
        }

        // Move a file
        if (File.Exists(sourcePath)) {
            string newPath = Path.Combine(Path.GetDirectoryName(sourcePath), "newfile.txt");
            File.Move(sourcePath, newPath);
            Console.WriteLine("File moved.");
        }

        // Read text from a file
        if (File.Exists(destPath)) {
            string content = File.ReadAllText(destPath);
            Console.WriteLine(content);
        }
    }
}
