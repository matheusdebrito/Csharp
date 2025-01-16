Representa um método que recebe um ou mais argumentos e retorna um valor. A diferença entre o Func e o Action é que o Func retorna um valor.

````c#

using Func.Entities;
using System.Collections;
using System.Linq;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Product> list = new List<Product>();

        list.Add(new Product("Tv", 900.00));
        list.Add(new Product("Mouse", 50.00));
        list.Add(new Product("Table", 350.50));
        list.Add(new Product("HD Case", 80.90));

        Func<Product, string> func = p => p.Name.ToUpper(); 

        List<string> result = list.Select(func).ToList();
        foreach (string s in result)
        {
            Console.WriteLine(s);
        }
    }
}
````