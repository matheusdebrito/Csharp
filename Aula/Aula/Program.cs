using System;
using System.Data;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Produto p = new Produto("TV", 500.00, 10);
            Console.WriteLine(p.Nome);
            Console.Write("Novo nome: ");
            string novoNome = Console.ReadLine();
            p.Nome = novoNome;
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
            */

            Conta conta = new Conta();

            Console.Write("Númeo da conta: ");
            conta.NumeroConta = int.Parse(Console.ReadLine());
            Console.Write("Titular da Conta: ");
            conta.Titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial ? (s/n): ");
            string deposito = Console.ReadLine();
            if(deposito == "s") 
            {
                Deposito(conta);
                Console.WriteLine(conta);
            }

            Deposito(conta);
            



        }

        public static void Deposito(Conta conta) 
        {
    
            Console.Write("Valor do depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.AdicionaSaldo(valorDeposito);
            Console.WriteLine($"Dados atualizados: {conta}");
            
        }
    }
}