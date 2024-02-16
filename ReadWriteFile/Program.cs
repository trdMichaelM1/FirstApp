using System;
using System.IO;

namespace ReadWriteFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = System.IO.Directory.GetCurrentDirectory();
            string text = "Hello, Michael M.";
            string path = $@"{currentDirectory}\note.txt";
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text);
                fs.Write(array, 0, array.Length);
            }
            Console.ReadKey();

            using (FileStream fs = File.OpenRead(path))
            {
                byte[] array = new byte[fs.Length];
                fs.Read(array, 0, array.Length);
                text = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine($"From file: {text}");
            }
        }
    }
}
