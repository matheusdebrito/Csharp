using Interfaces.Services;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Digite o valor do pagamento: ");
        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        PixPayment pix = new PixPayment(valor);
        pix.ProcessarPagamento();
        Console.WriteLine(pix.ObterDetalhesPagamento());

        Console.WriteLine("Fim");


    }
}