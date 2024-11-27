Para combinar uma interface com uma classe para que sejam herdadas as caracaterisitcas da classe e exigido que cumpam o contrato da interface criamos uma interface e depois criamos uma classe do tipo abstract que vai cumprir o contrato da interface. Como a classe vai ser do tipo abstract ela não vai precisar cumprir o contrato, somente as classes que herdarem ela.

````c#
// interface
interface Ishape{
    double Area();
}

// classe abstrata
abstract class Shape : Ishape {
    public string color { get; set; }

    public abstract double Area();
}

// classe que herda a classe Shape e cumpre o contrato de Ishape
public class Circle : Shape {

    public double Area(){

    }
}
````