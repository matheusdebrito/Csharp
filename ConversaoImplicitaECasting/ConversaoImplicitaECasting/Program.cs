using System;
using System.Data;

namespace ConversaoImplicitaECasting
{
    class Program
    {
        static void Main(string[] args) 
        {

            // ao dividir dois inteiros que resulta em um número float é necessário fazer o casting para que o resultado seja double.
            // para fazer o casting basta escrever, entre parensetes, o tipo que será realizada a conversão.
            int a = 5;
            int b = 2;
            double resultado = (double) a / b;
            Console.WriteLine(resultado);
        }
    }
}