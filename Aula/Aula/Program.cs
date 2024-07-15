using System;
using System.Data;
using System.Globalization;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto x;
            x = new Produto();
            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            x.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            x.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            x.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine(x);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int numero = int.Parse(Console.ReadLine());
            x.AdicionarProdutos(numero);

            Console.WriteLine($"Dados Atualizados: {x}");

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int numeroRemover = int.Parse(Console.ReadLine());
            x.Removerprodutos(numeroRemover);

            Console.WriteLine($"Dados Atualizados: {x}");


        }               
    }
}