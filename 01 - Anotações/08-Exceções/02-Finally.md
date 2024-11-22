Bloco finally é um bloco que contém código a ser executado independentemente de ter ocorrido ou não uma exceção.

Exemplo clássico: fechar um arquivo ou conexão com banco de dados ao final do processamento.

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
        catch (Exception e){
            Console.WriteLine("Error: " + e.Message);
        }
        finally{
            Console.WriteLine("Fim!");
        }
    }
}
````