Código principal
````c#
using Course.Entities;
using System.Collections.Generic;
using System.Linq;
internal class Program
{

    static void Print<T>(string message, IEnumerable<T> collection) 
    {
        Console.WriteLine(message);
        Console.WriteLine();
        foreach (T obj in collection)
        {
            Console.WriteLine(obj);
        }
        Console.WriteLine();
        Console.WriteLine("-----------------------------------");
    }

    private static void Main(string[] args)
    {
        Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2};
        Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1};
        Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1};

        List<Product> Products = new List<Product>() {

            new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2},
            new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1},
            new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3},
            new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2},
            new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1},
            new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2},
            new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3},
            new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3},
            new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2},
            new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3},
            new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1}
        };

        var r1 = Products.Where(p => p.Category.Tier == 1 && p.Price < 900);
        Print("TIER 1 AND PRICE < 900: ", r1);

        var r2 = Products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
        Print("NAMES OF PRODUCTS FROM TOOL", r2);

        // Cria um objeto anônimo. CategoryName é um alias(apelido) para p.Category.Name
        var r3 = Products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
        Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

        // .ThenBy serve para ordernar os itens que ficarem empatados por outra condição
        var r4 = Products.Where(p => p.Category.Tier == 1).OrderBy(p =>  p.Price).ThenBy(p => p.Name);
        Print("TIER 1 AND ODER BY PRICE THEN BY NAME", r4);

        var r5 = r4.Skip(2).Take(4);
        Print("TIER 1 AND ODER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

        // FirstOrDefault retorna nullo caso a celeção esteja vazia
        var r6 = Products.FirstOrDefault();
        Console.WriteLine("First or Default teste1: " + r6);

        var r7 = Products.Where(p => p.Price > 3000).FirstOrDefault();
        Console.WriteLine("Frist od Default teste2: " + r7);

        //Retorna um elemento ao invés de uma coleção. SingleOrDefault não funciona se retornar mais de um elemento
        var r8 = Products.Where(p => p.Id == 3).SingleOrDefault();
        Console.WriteLine("Single or Default teste1: " + r8);

        var r9 = Products.Where(p => p.Id == 30).SingleOrDefault();
        Console.WriteLine("Single or Default teste2: " + r9);




    }
}
````

Código da Classe Product
````c#
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return "ID: " + Id
                + ", "
                + "NAME: " + Name
                + ", "
                + "PRICE: " + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + "CATEGORY: " + Category.Name
                + ", "
                + "TIER: " + Category.Tier;
        }
    }

    
}
````

Código da classe Category
````c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Tier { get; set; }
    }
}
````