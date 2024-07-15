# Criando uma classe com 3 atributos para representar um triângulo
Clica com botão direito no projeto > adicionar > classe. O nome das classes deve começar com letra maiúscula.

# Código da classe.
````c#
namespace Aula
{
    internal class Triangulo
    {
        // Declaração dos atributos (ATRIBUTOS COMEÇAM COM LETRA MAIÚSCULA)
        public double A;
        public double B;
        public double C;

    }
}

```

# Usando a classe no código principal
````c#
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
            
            // Instância a classe.
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

            calculaAreaTriangulo(x.A, x.B, x.C);
            calculaAreaTriangulo(y.A, y.B, y.C);

        }

        static double calculaAreaTriangulo(double a, double b, double c) 
        {
            double perimetro = (a + b + c) / 2;
            double area = Math.Sqrt(perimetro * (perimetro - a) * (perimetro - b) * (perimetro - c));
            Console.WriteLine($"Area do triangulo é: {area}");
            return 0;
        }
               
    }
}


```
# Fim
