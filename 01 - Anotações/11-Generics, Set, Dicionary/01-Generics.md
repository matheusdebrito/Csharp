Generics permitem que classes, interfaces e métodos possam ser parametrizados por tipo. Seus benefícios são:
- Reuso
- Type Safety
- Performance

Uso comum: coleções


Classe:
````c#

namespace Generics.Entities
{
    //<T> define que a classe tera o tipo especificado na instância.
    internal class PrintService<T>
    {
        // variável do tipo especificado
        private T[] _values = new T[10];
        private int _count = 0;

        public void AddValue(T value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[_count] = value;
            _count++;
        }

        // função que tem retorno do tipo especificado
        public T First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }
            Console.WriteLine("]");
        }
    }
}
````


Programa principal:
````c#
using Generics.Entities;

internal class Program
{
    private static void Main(string[] args)
    {
        // instancia a classe passando o tipo string
        PrintService<string> printService = new PrintService<string>();

        Console.WriteLine("How many values?");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string x = Console.ReadLine();
            printService.AddValue(x);
        }

        string primeiroItem = printService.First();
        Console.WriteLine(primeiroItem);

        printService.Print();
    }
}
````