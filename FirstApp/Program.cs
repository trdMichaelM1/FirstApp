using System;
using System.IO;

namespace CSharpEssentials
{
    class Program
    {
        static void Main()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                Console.WriteLine($"Название: {drive.Name}");
                if (drive.IsReady)
                {
                    Console.WriteLine($"Тип: {drive.DriveFormat}");
                    Console.WriteLine($"Объем диска: {drive.TotalSize / 1024 / 1024 / 1024}");
                    Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace / 1024 / 1024 / 1024}");
                }
                Console.WriteLine();
            }

            string dirName = @"C:\Users\Michael";

            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }

            // Чтобы поиск происходил в текущем каталоге (где находится файл exe), нужно в dirName указать точку:
            dirName = ".";

            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }
            }

            // Создание каталога
            string path = @"C:\Stream";
            string subpath = @"Michael\directories";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
            dirInfo.CreateSubdirectory(subpath);

            // Получение информации о каталоге
            dirName = @"C:\Program Files\Test";

            dirInfo = new DirectoryInfo(dirName);

            Console.WriteLine($"Название каталога: {dirInfo.Name}");
            Console.WriteLine($"Полное название каталога: {dirInfo.FullName}");
            Console.WriteLine($"Время создания каталога: {dirInfo.CreationTime}");
            Console.WriteLine($"Корневой каталог: {dirInfo.Root}");
            Console.WriteLine($"Родительский каталог: {dirInfo.Parent}");

            Console.ReadKey();
            // Удаление каталога
            dirName = @"C:\Stream";

            try
            {
                dirInfo = new DirectoryInfo(dirName);
                dirInfo.Delete(true); // папку надо удалять со всем содержимым
                Console.WriteLine("Каталог удален");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(Environment.MachineName);
            Console.WriteLine(Environment.UserName);
            Console.WriteLine(System.IO.Path.GetDirectoryName(typeof(Program).Assembly.Location));
            Console.WriteLine(System.AppDomain.CurrentDomain.BaseDirectory);
            Console.WriteLine(System.Environment.CurrentDirectory);
            Console.WriteLine(System.IO.Directory.GetCurrentDirectory());
        }
    }
}