using System;
using System.Data;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Matheus");
            list.Add("Maria");
            list.Add("João");
            list.Add("Alex");

            list.Insert(2, "Marco");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine(list.Count);

            string s1 = list.Find(x => x == "Alex");
            int s2 = list.FindIndex(x => x[0] == 'A');
            List<string> nomes = new List<string>();
            nomes = list.FindAll(x => x[0] == 'M');
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            Console.WriteLine(nomes[0]);
            Console.WriteLine("__________________________");
            foreach (string obj in nomes)
            {
                Console.WriteLine(obj);
            }

            list.Remove("Alex");
            Console.WriteLine("__________________________");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            list.RemoveAll(x => x[0] == 'J');
            list.RemoveAt(1);
            Console.WriteLine("__________________________");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            list.RemoveRange(0, 2);
            Console.WriteLine("__________________________");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }

    }
}