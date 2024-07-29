using System;
using System.Collections.Generic;
using System.Globalization;

namespace DateTime2
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime d1 = new DateTime(2018, 11, 25);
            DateTime d2 = DateTime.Parse("2000-08-15"); // Converte uma string para DateTime
            DateTime d3 = DateTime.ParseExact("2000-05-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(d1);
        }
    }
}