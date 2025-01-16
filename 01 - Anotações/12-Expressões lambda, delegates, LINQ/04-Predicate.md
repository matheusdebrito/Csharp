Representa um método que recebe um objeto do tipo T e retorna um valor booleano

classe
````c#
namespace Course.Entities
{
    internal class Product
    {
        public string Name{ get; set; }
        public double Price{ get; set; }

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

programa principal
````c#
using Course.Entities;
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

        // remove da lista todos os produtos retornados pela função ProductTest
        list.RemoveAll(ProductTest);

        foreach( Product p in list)
        {
            Console.WriteLine(p);
        }
    }

    // função que verifica se o preço de um produto é maior ou igual a 100
    public static bool ProductTest(Product p)
    {
        return p.Price >= 100;
    }
}
````