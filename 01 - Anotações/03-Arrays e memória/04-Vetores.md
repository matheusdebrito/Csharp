# Criando vetores
Vetores em C# tem tamanho fixo e informado na criação do vetor.

````c#
// Cria o vetor e atribui ao vetor o tamanho n
int n = int.Parse(Console.ReadLine());
double[] vect = new double[n];

````

# Vetor do tipo classe
Ao criar um vetor do tipo classe é necessário instanciar, além do vetor, os itens do vetor. Não pode criar os construtores.

Exemplo de uso de vetores


# Código da classe
```c#
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Memoria
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public override string ToString()
        {
            return($"Nome: {Nome}, Preço: R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}


```

# Código principal 
````c# 
using Arrays_Memoria;
using System;
using System.Globalization;

namespace ArraysMemoria
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Quantidade de produtos a serem adicionados: ");
            int quantidadeProdutos = int.Parse(Console.ReadLine());
            Produto[] produtos = new Produto[quantidadeProdutos];

            for (int i = 0; i < quantidadeProdutos; i++)
            {
                Console.WriteLine($"{i + 1}° Produto : ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                // INSTANCIANDO O ELEMENTO DO VETOR
                produtos[i] = new Produto { Nome = nome, Preco = preco };
            }

            Console.WriteLine("Produtos");
            for (int i = 0;i < produtos.Length; i++)
            {
                Console.WriteLine($"Produto {i + 1}: {produtos[i]}");
            }
        }
    }
}
````