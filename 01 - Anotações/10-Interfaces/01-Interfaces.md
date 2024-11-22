Interface é um tipo que define um conjunto de operações que uma classe (ou struct) deve implementar.
A interface que estabelece um contrato que a classe (ou struct) deve cumprir.

Pra quê interfaces ? Para criar sistemas com baixo acoplamento e flexívies.

No C# tem a convenção de nomear a interface com I na frente do nome Ex: IShape.

````c#
interface IShape {
    double Area();
    double Perimetro();
}
````