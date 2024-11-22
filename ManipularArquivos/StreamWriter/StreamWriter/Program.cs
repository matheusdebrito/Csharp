internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        string sourcePath = @"C:\Windows\Temp\file.txt";
        string targetPath = @"C:\Windows\Temp\file2.txt";

        try
        {
            string[] lines = File.ReadAllLines(sourcePath);

            using (StreamWriter sw = File.AppendText(targetPath))
            {
                foreach (string line in lines)
                {
                    sw.WriteLine(line.ToUpper());
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}