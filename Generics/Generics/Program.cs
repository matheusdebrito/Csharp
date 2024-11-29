using Generics.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        // instancia a classe passando o tipo string
        PrintService<string> printService = new PrintService<string>();

        Console.WriteLine("How many values?");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string x = Console.ReadLine();
            printService.AddValue(x);
        }

        string primeiroItem = printService.First();
        Console.WriteLine(primeiroItem);

        printService.Print();
    }
}