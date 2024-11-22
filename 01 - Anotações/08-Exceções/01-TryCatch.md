Bloco Try - Contém o código que representa a execução normal do trecho do código que pode acarretar em uma execução.

Bloco Catch - Contém o código a ser executado caso uma exceção ocorra. Deve ser especificado o tipo de exceção a ser tratada (upcasting é permitido).

````c#
internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            int result = n1 / n2;

            Console.WriteLine(result);
        }
        catch (Exception e){ // "e" é o apelido dado para a exceção.
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
````