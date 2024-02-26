namespace ReadAndWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "database.txt";
            string currentDirectgory = Environment.CurrentDirectory;
            string path = $@"{currentDirectgory}\{fileName}";

            Console.WriteLine(path);

            using (StreamWriter sw = new StreamWriter(path, false))
            {
                sw.WriteLine("Hello, Michael M.");
            }

            using (StreamReader sr = new StreamReader(path))
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}
