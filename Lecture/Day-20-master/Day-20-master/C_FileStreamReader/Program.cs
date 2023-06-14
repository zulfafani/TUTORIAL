﻿using System.IO;

class Program {
    static void Main() {
        string path = "bootcamplargefile.txt";

        using (FileStream fs = new FileStream(path, FileMode.Open))
        using (StreamReader reader = new StreamReader(fs)) {
            string line;
            while ((line = reader.ReadLine()) != null) {
                Console.WriteLine(line);
            }
        }
    }
}
