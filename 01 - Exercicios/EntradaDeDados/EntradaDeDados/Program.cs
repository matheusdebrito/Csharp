using System;
using System.Globalization;

namespace EntradaDeDados
{
    class Program
    {
        public static void Main(string[] args) 
        {
            Console.Write("Seu Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Quantos quartos tem a sua casa: ");
            int quartos = int.Parse(Console.ReadLine());

            Console.Write("O preço de um produto: ");
            int precoProduto = int.Parse(Console.ReadLine());

            Console.Write("Seu último nome, idade e altura (todos na mesma linha): ");
            string[] vetor = Console.ReadLine().Split(' ');

            string ultimoNome = vetor[0];
            int idade = int.Parse(vetor[1]);
            double altura = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(precoProduto);
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);


        }
    }
}