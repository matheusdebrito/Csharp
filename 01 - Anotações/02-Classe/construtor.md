# Construtor

É uma operação especial da classe, que executa no momento da instância do objeto.

Usos comuns: Iniciar valores dos atributos, permitir ou obrigar que o objeto receba dados / depêndências no momento da sua instanciação.

É possível especificar mais de um construtor na mesma classe (Sobrecarga).

Para declarar o construtor usamos 

```c#

public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

```

Para instanciar a classe é necessário passar os valores dos atributos pedidos no construtor

```c#

Produto p = new Produto(nome, preco, quantidade);
//ou
Produto p = new Produto("TV", 500, 10);

```



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

        //Construtor
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

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

// Fim Classe

// Código Principal

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
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);
            
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
