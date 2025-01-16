Dictionary<TKey, TValue>

É uma coleção de pares chave / valor
 - Não admite repetições do objeto chave
 - Os elementos são indexados pelo objeto chave (não possuem posição)
 - Acesso, inserção e remoção de elementos são rápidos

Uso comum: cockies, local storage, qualquer modelo chave-valor

Dictionary
 - Armazenamento em tabela hash
 - Extremamente rápido: inserção, remoção e busca O(1)
 - A ordem dos elementos não é garantida

SortedDictionary
 - Armazenamento em árvore
 - Rápido: inserção, remoção e busca O(log(n))
 - Os elementos são armazenados ordenadamente conforme implementação IComparer<T>

 Alguns métodos importantes:
  - dictionary[key] - acessa o elemento pela chave informada
  - Add(key, value) - adiciona elemento (exceção em caso de repetição)
  - Clear() - esvazia a coleção
  - Count - quantidade de elementos
  - ContainsKey(key) - verifica se a dada chave existe
  - ContainsValue(value) - verifica se o dado valor existe 
  - Remove(key) - remove um elemento pela chave


````c#
using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string> coockies = new Dictionary<string, string>();

        coockies["user"] = "maria";
        coockies["email"] = "maria@gmail.com";
        coockies["phone"] = "99712234";
        coockies["phone"] = "83737388";

        Console.WriteLine(coockies["phone"]);
        Console.WriteLine(coockies["email"]);

        coockies.Remove("email");

        if (coockies.ContainsKey("email"))
        {
            Console.WriteLine(coockies["email"]);
        }
        else
        {
            Console.WriteLine("There is no 'email' key");
        }

        Console.WriteLine("Size: " + coockies.Count);

        Console.WriteLine("ALL COOCKIES:");

        // maneira de percorrer um dictionary
        foreach (KeyValuePair<string, string> item in coockies)
        {
            Console.WriteLine(item.Key + ":" + item.Value);
        }
        // ou
        foreach (var item in coockies)
        {
            Console.WriteLine(item.Key + ":" + item.Value);
        }
    }
}
````