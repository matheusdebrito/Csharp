using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            bool completo = false; // armazena um valor booleano
            char genero = 'F'; // armazena um caracter
            byte n1 = 126; // armazena números pequenos
            int n2 = 1000; // armazena números grandes
            int n3 = 2147483647; // armazena números grandes
            long n4 = 21474836478L; // armazena número muito grandes e é recomendado colocar o sufixo L no final do número
            float n5 = 4.5f; // precisa colocar a letra 'f' no final para especificar que é do tipo float e não do tipo double
            double n6 = 5.4;
            string nome = "Matheus"; //o tipo string é imutável
            object obj1 = 4.5f;


            Console.WriteLine(nome);
            Console.WriteLine(n6);
            Console.WriteLine(n5);
            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(obj1);

            Console.WriteLine("---------------------------------------------");

            // com as propriedades .MinValue e .MaxValue podemos verificar qual o valor mínimo e máximo aceito por um tipo
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(long.MaxValue);


        }
    }
}