Delegates

É uma referência (com type safety) para um ou mais métodos
 - É um tipo referência

Usos comuns:
 - Comunicação entre objetos de forma flexível e extensível (eventos/callbacks)
 - Parametrização de operações por métodos (programação funcional)

Delegates pré-definidos: Action, Func e Predicate

Classe
````c#
namespace Course.Entities
{
    internal class CalculationService
    {
        public static double Max(double x, double y)
        {
            return (x > y) ? x : y;
        }

        public static double Sum(double x, double y)
        {
            return x + y;
        }

        public static double Square(double x)
        {
            return x * x;
        }
    }
}
````
Programa principal
````c#
using Course.Entities;

internal class Program
{
    delegate double BinaryNumericOperation(double n1, double n2);

    private static void Main(string[] args)
    {
        double a = 10;
        double b = 12;

        BinaryNumericOperation op = CalculationService.Sum;

        double result = op(a, b);
        Console.WriteLine(result);
    }
}
````