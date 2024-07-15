namespace Aula
{
    internal class Triangulo
    {
        // Declaração dos atributos (ATRIBUTOS COMEÇAM COM LETRA MAIÚSCULA)
        public double A;
        public double B;
        public double C;

        public double CalcularArea()
        {
            double perimetro = (A + B + C) / 2;
            double area = Math.Sqrt(perimetro * (perimetro - A) * (perimetro - B) * (perimetro - C));
            Console.WriteLine($"Area do triangulo é: {area}");
            return area;
        }

    }
}
