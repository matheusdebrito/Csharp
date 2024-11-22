FileStream é uma classe que disponibiliza um stream associado a um arquivo, permitindo operações de leitura e escrita. (stream binária)

StreamReader é uma stream (em informática "stream" significa uma sequência de dados) capaz de ler caracteres a partir de uma stream binária (stream de caracteres)

````c#
using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        string path = @"C:\Windows\Temp\file.txt";
        FileStream fs = null;
        StreamReader sr = null;
        try
        {
            fs = new FileStream(path, FileMode.Open);
            sr = new StreamReader(fs);
            while(!sr.EndOfStream){
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            

        }
        catch (IOException e) { Console.WriteLine(e.Message); }
        finally
        {
            if (sr != null) { sr.Close(); }
            if (fs != null) { fs.Close(); }
        }
    }
}
````