using System;
using System.IO;

namespace CSharpEssentials
{
    class Program
    {
        static void Main()
        {
            // Получение информации о файле
            string path = @"C:\TestFiles\test1.txt";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                Console.WriteLine("Имя файла: {0}", fileInf.Name);
                Console.WriteLine("Время создания: {0}", fileInf.CreationTime);
                Console.WriteLine("Размер: {0}", fileInf.Length);
            }

            // Удаление файла
            path = @"C:\TestFiles\test1.txt";
            fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                fileInf.Delete();
                // альтернатива с помощью класса File
            }

            // Перемещение файла
            path = @"C:\TestFiles\test1.txt";
            string newPath = @"C:\TestFiles\test2\test1.txt";
            fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                fileInf.MoveTo(newPath);
                // альтернатива с помощью класса File
                // File.Move(path, newPath);
            }


            // Копирование файла
            path = @"";
            newPath = @"";
            fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                fileInf.CopyTo(newPath, true);
                // альтернатива с помощью класса File
                // File.Copy(path, newPath, true);
            }
        }
    }
}