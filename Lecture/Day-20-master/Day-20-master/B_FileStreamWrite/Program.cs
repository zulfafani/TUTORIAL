using System.IO;

class Program {
    static void Main() {
        string path = "bootcamp.txt";

        // Open the file for writing
        using (FileStream fs = new FileStream(path, FileMode.Create)) {
            // Write some data to the file
            byte[] data = System.Text.Encoding.UTF8.GetBytes("Hello, FileStream!"); //Convert string to byte array
            fs.Write(data, 0, data.Length); //data, offset, count
        }

        // Open the file for reading
        using (FileStream fs = new FileStream(path, FileMode.Open)) {
            // Read the data from the file
            byte[] buffer = new byte[fs.Length]; //fs.Length is the size of the file
            fs.Read(buffer, 0, buffer.Length); //buffer, offset, count
            string content = System.Text.Encoding.UTF8.GetString(buffer); //Convert byte array to string
            Console.WriteLine(content);
        }
    }
}
