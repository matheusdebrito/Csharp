using System;
using System.Data;
using System.Globalization;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);
            Console.WriteLine(p.Nome);
            Console.Write("Novo nome: ");
            string novoNome = Console.ReadLine();
            p.Nome = novoNome;
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
        }               
    }
}