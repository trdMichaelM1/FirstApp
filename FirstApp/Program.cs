using System;

namespace CSharpEssentials
{
    public enum FileFormat
    {
        PlainText,
        OfficeWord,
        Markdown,
        Json,
        XML
    }

    public static class Helper
    {
        public static string GetFileExtension(this FileFormat fileFormat)
        {
            string extension = string.Empty;
            switch (fileFormat)
            {
                case FileFormat.PlainText: extension = "txt"; break;
                case FileFormat.OfficeWord: extension = "docx"; break;
                case FileFormat.Markdown: extension = "md"; break;
                case FileFormat.Json: extension = "json"; break;
                case FileFormat.XML: extension = "xml"; break;
            }
            return extension;
        }
    }
    class Program
    {
        static void Main()
        {
            var format = FileFormat.Markdown;
            var fileExt = format.GetFileExtension(); // "md"
            var fileName = $"output.{fileExt}"; // "output.md"
            Console.WriteLine(fileName);
        }
    }
}