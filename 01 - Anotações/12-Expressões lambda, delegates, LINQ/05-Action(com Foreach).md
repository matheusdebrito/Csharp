Representa um método void que recebe zero ou mais argumentos

Existem 16 sobrecargas do método action:

````c#
public delegate void Action();
public delegate void Action<in T>(T obj);
public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);
public delegate void Action<in T1, in T2, in T3>(T1 arg1, T2 arg2, T3 arg3);
...
````
Ex: fazer um programa que, a partir de uma lista de produtos, aumento o preço dos produtos em 10%

classe
````c#
namespace Action.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2");
        }
    }
}
````

código principal
````c#
using Action.Entities;
using System.Collections;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Product> list = new List<Product>();

        list.Add(new Product("Tv", 900.00));
        list.Add(new Product("Mouse", 50.00));
        list.Add(new Product("Table", 350.50));
        list.Add(new Product("HD Case", 80.90));

        Action<Product> act = p => { p.Price += p.Price * 0.1; };

        list.ForEach(act);
        foreach(Product p in list)
        {
            Console.WriteLine(p);
        }
    }
}
````