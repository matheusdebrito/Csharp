using System;
using System.Globalization;

namespace ExercicioVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe quantas pessoas vão alugar quartos: ");
            int locatarios = int.Parse(Console.ReadLine());
            Quarto[] quartos = new Quarto[9];

            for (int i = 0; i < locatarios; i++)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();

                quartos[i] = new Quarto { Locatario = nome, Email = email };
            }

            for(int i = 0;i < quartos.Length; i++)
            {
                Console.WriteLine($"Quarto {i}");
                Console.WriteLine(quartos[i]);
            }
        }
    }
}