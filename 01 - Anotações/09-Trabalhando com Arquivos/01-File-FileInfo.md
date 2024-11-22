Namespace System.IO
Realiza operações com arquivos (create, copy, delete, move, open, etc) e ajuda na criação de objetos FileStream.

File é mais simples, mas é mais lenta pois realiza uma verificação de segurança em cada operação.

FileInfo é preciso instanciar um objeto e chamar as operações a partir dele. Não realiza as verificações de segurança e por isso é um pouco mais rápido.

Quando usar cada um!

Se o programa for fazer poucas operações pode usar o File. Já em um programa em que serão realizadas muitas operações e que a performance seja importante é melhor usa o FileInfo.

Exceção -> IOException

````c#
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        string SourcePath = @"c:\windows\temp\file.txt";
        string TargetPath = @"c:\windows\temp\file2.txt";
        string[] lines = File.ReadAllLines(SourcePath);
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

        try
        {
            FileInfo fileInfo = new FileInfo(SourcePath);
            fileInfo.CopyTo(TargetPath);
        }
        catch (IOException e) { Console.WriteLine(e.Message); }
    }
}
````