# Matriz
Uma matriz é homogênea (possui os mesmos dados), Ordenada (elementos acessados por posições) e alocada de uma vez só, em um bloco contígui de memória.

# Vantagens e Desvantagens

Vantagem:
    - Acesso imediato aos elementos pela sua posição

Desvantagens: 
    - Tamanho fixo
    - Dificuldade para se realizar inserções e deleções

# Comandos
.Length retorna o tamanho da matriz
.Rank retorna a quantidade de linhas da matriz
.GetLength(0) retorna a quantidade de linhas
.GetLength(1) retorna a quantidade de colunas

# Declarando uma matriz

````c#
double[,] mat = new double[2, 3]; // 2 é o número de linhas e 3 o número de colunas
````

````c#
using System;
using System.Collections.Generic;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mat[i, i] + " ");
            }

            Console.WriteLine("");

            int count = 0;
            for ( int i = 0; i < n; i++)
            {
                for(int j = 0;j < n; j++)
                {
                    if (mat[i, j] < 0) { count++; }
                }
            }

            Console.WriteLine("Negative Numbers: " + count);
        }
    }
}
````