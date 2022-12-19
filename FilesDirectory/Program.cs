using System.IO;
using System.Collections.Generic;


internal class Program
{
    private static void Main(string[] args)
    {
        IEnumerable<string> FindFiles(string folderName)
        {
            List<string> salesFiles = new List<string>();

            var founderFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);
            foreach (var file in founderFiles)
            {
                if (file.EndsWith("sales.json"))
                    salesFiles.Add(file);
            }

            return salesFiles;
        }

        var salesFiles = FindFiles("stores");
        foreach (var file in salesFiles)
        {
            Console.WriteLine(file);
        }
        Console.WriteLine("--------------------");
        // Search for special folder
        string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        Console.WriteLine(docPath);

        // Class Path é uma classe bem completa para trabalhar com caminhos relativos
        string fileName = $"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales{Path.DirectorySeparatorChar}sales.json";

        FileInfo info = new FileInfo(fileName);

        Console.WriteLine($"Full Name: {info.FullName}{Environment.NewLine}Directory: {info.Directory}{Environment.NewLine}Extension: {info.Extension}{Environment.NewLine}Create Date: {info.CreationTime}");
    }

}