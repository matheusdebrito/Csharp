Com override string ToString() podemos definir a exibição de uma classe para facilitar a impressão da classe.

```c#
// Código da classe
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public double ValorTotalEmEstoque()
        {
            return(Preco * Quantidade);
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
            ValorTotalEmEstoque();
        }

        public void Removerprodutos(int quantidade) 
        {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return ($"Nome: {Nome}, Preço: $ {Preco}, Quantidade: {Quantidade}, Valor total: {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}



// Código principal

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

```