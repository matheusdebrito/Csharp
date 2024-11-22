internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        string path = @"C:\Windows\Temp\file.txt";

        try
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}