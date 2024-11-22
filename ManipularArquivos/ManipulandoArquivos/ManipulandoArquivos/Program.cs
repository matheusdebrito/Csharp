using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        string SourcePath = @"c:\windows\temp\file.txt";
        string TargetPath = @"c:\windows\temp\file2.txt";
        string[] lines = File.ReadAllLines(SourcePath);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        try
        {
            FileInfo fileInfo = new FileInfo(SourcePath);
            fileInfo.CopyTo(TargetPath);
        }
        catch (IOException e) { Console.WriteLine(e.Message); }
    }
}