using ExcecaoPersonalizada.Entities;
using ExcecaoPersonalizada.Entities.Exceptions;
using System;

namespace ExcecaoPersonalizada
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            try
            {
                Eleitor eleitor = new Eleitor("Matheus", 10);
                eleitor.Votar();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (IdadeVotoException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e) { Console.WriteLine(e.Message); }
        }
    }
}