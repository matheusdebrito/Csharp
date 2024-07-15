using System;
using System.Globalization;

namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";


            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("f2")); // limite a exibição de casas decimais após a vírgula.
            Console.WriteLine(saldo.ToString("f2", CultureInfo.InvariantCulture)); //Exibe número float com . ao invés de ,
            Console.WriteLine("------------------------------");
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:f2} reais.", nome, idade, saldo); // Placeholder -> Método para juntar variáveis e texto

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:f2} reais.");

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("f2") + " reais.");
        }
    }
}
