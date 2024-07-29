# DateTime
Serve para guardar uma data ou uma hora. É do tipo struct

Um objeto DateTime internamente armazena o número de "ticks" (100 nanosegundos) desde a meia noite do dia 1 de janeiro do ano 1 da era comum

````c#
using System;
using System.Collections.Generic;

namespace DateTime2
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d1 = new DateTime(2018, 11, 25);
            Console.WriteLine(d1);
            DateTime d2 = DateTime.Parse("2000-08-15"); // Converte uma string para DateTime
            DateTime d3 = DateTime.ParseExact("2000-05-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
        }
    }
}
````