using System;

namespace HelloWorld
{
    public class Importer
    {
        public static String FileImport()
        {
            String filePath = @"C:";
            String text = System.IO.File.ReadAllText(filePath);
            return text;
        }

        public static void FileUpdate(String text)
        {
            String filePath = @"C:";
            System.IO.File.WriteAllText(filePath, text);
            Console.WriteLine("File updated");
        }
    }
}