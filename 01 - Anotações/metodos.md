Os métodos devem ser criados dentro da classe e devem começar com letra maiúscula.
Caso os métodos forem usar apenas as variáveis da classe não é necessário declarar argumentos no método.
Para conseguirmos usar métodos das classes sem instanciar os objetos podemos adicionar um "static" depois do "public".


````c#

// Código da Classe
namespace Aula
{
    internal class Triangulo
    {
        // Declaração dos atributos (ATRIBUTOS COMEÇAM COM LETRA MAIÚSCULA)
        public double A;
        public double B;
        public double C;

        // Método
        public double CalcularArea()
        {
            double perimetro = (A + B + C) / 2;
            double area = Math.Sqrt(perimetro * (perimetro - A) * (perimetro - B) * (perimetro - C));
            Console.WriteLine($"Area do triangulo é: {area}");
            return area;
        }

    }
}

// --------------------------------------------------------------------------------------------------------------

// Código principal

using System;
using System.Data;
using System.Globalization;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria as variáveis x e y do tipo Triângulo.
            Triangulo x, y;
            
            // Instancia a classe.
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo x:");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo y:");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            // Para utilizar o método de uma classe é necessário abrir e fechar parênteses.
            double areaX = x.CalcularArea();
            double areaY = y.CalcularArea();

        }               
    }
}

// --------------------------------------------------------------------------------------------------------------

```

