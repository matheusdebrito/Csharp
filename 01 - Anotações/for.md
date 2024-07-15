# For

````c#
using System;
using System.Data;
using System.Globalization;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            int fatorial = numero;
            for (int i = 1; i < numero; i++) 
            {
                fatorial = fatorial * (numero - i);
            };
            Console.WriteLine($"Fatorial do número {numero} é {fatorial}");
        }
               
    }
}
```