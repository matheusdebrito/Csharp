using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {

            int m = 3;
            int n = 4;

            int[,] matriz = new int[m, n];

            string[] vetorNumeros = new string[m];
            vetorNumeros[0] = "10 8 15 12";
            vetorNumeros[1] = "21 11 23 8";
            vetorNumeros[2] = "14 5 13 19";

            for (int i = 0; i < m; i++)
            {
                string[] numeros = vetorNumeros[i].Split(' '); 
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(numeros[j]);
                }
            }


            Console.Write("Número: ");
            int x = int.Parse(Console.ReadLine());

            string position = "Não encontrado";

            for (int i = 0; i < m; ++i)
            {
                List<int> numeros = new List<int>();
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine("----------------------------------------");
                        position = $"Position: {i.ToString()}, {j.ToString()}";
                        Console.WriteLine(position);

                        if(j - 1 >= 0)
                        {
                            Console.WriteLine($"Left: {matriz[i, (j-1)]}");
                        }

                        if (j + 1 < matriz.GetLength(0))
                        {
                            Console.WriteLine($"Right: {matriz[i, (j + 1)]}");
                        }


                        if (i - 1 >= 0)
                        {
                            Console.WriteLine($"Up: {matriz[(i - 1), j]}");
                        }


                        if (i + 1 < matriz.GetLength(1))
                        {
                            Console.WriteLine($"Down: {matriz[(i + 1), j]}");
                        }

                    } 
                }
            }
            if(position == "Não encontrado")
            {
                Console.WriteLine(position);
            }

        }
    }
}