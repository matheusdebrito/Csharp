# Sobrecarga

É um recurso que uma classe possui de oferecer mais de uma operação com o mesmo nome, porém com diferentes listas de parâmetros.

Para fazer a sobrecarga declaramos mais de um construtor no programa usamos o que quisermos.


```c#
// Classe
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

        // Construtor
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // Segundo construtor

        public Produto(string nome, double preco) 
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
        }

        // Construtor padrão
        public Produto() { }

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

```

```c#
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
            
            
            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Quantidade: ");
            //int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco);
            
            Console.WriteLine(p);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int numero = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(numero);

            Console.WriteLine($"Dados Atualizados: {p}");

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            int numeroRemover = int.Parse(Console.ReadLine());
            p.Removerprodutos(numeroRemover);

            Console.WriteLine($"Dados Atualizados: {p}");
            
        }               
    }
}
```