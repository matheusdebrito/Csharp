using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        string path = @"C:\Windows\Temp\file.txt";
        FileStream fs = null;
        StreamReader sr = null;
        try
        {
            fs = new FileStream(path, FileMode.Open);
            sr = new StreamReader(fs);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }

        }
        catch (IOException e) { Console.WriteLine(e.Message); }
        finally
        {
            if (sr != null) { sr.Close(); }
            if (fs != null) { fs.Close(); }
        }
    }
}