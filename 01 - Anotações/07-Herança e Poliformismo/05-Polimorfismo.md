Polimorfismo é um dos pilares da programação orientada a objetos (POO) e refere-se à capacidade de objetos diferentes responderem de maneira específica a uma mesma mensagem ou método. Em outras palavras, é a habilidade de usar uma interface única para representar diferentes tipos de comportamento.

````c#
public class Animal
{
    public virtual void EmitirSom()
    {
        Console.WriteLine("O animal faz um som.");
    }
}

public class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("O cachorro late.");
    }
}

public class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("O gato mia.");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Animal meuAnimal = new Cachorro();
        meuAnimal.EmitirSom(); // Saída: O cachorro late.

        meuAnimal = new Gato();
        meuAnimal.EmitirSom(); // Saída: O gato mia.
    }
}
````