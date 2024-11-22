Servem para fornecer operações com pastas (create, enumerate, get files, etc).

Directory tem operações estáticas.
DirectoryInfo tem operações de instância.

````c#
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        string path = @"C:\Windows\Temp\MyFolder";

        try
        {
            //Exibe todas as pastas a partir do caminho path
            IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("FOLDERS");
            foreach(string s in folders)
            {
                Console.WriteLine(s);
            }

            //Exibe todos os arquivos a partir do caminho path
            IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("FILES");
            foreach (string f in files)
            {
                Console.WriteLine(f);
            }

            //Cria uma pasta
            Directory.CreateDirectory(path + @"\nomeDaPasta");

        }
        catch (IOException e) 
        { 
            Console.WriteLine(e.Message); 
        }
    }
}
````