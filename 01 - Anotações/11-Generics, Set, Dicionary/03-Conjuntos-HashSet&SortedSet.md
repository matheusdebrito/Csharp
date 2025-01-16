Representa um conjunto de elementos(similar ao da Álgebra) 
    - Não admimite repetições
    - Elementos não possuem posição
    - Acesso, inserção e remoção de elementos são rápidos
    - Oferece operações eficientes de conjunto: interseção, união, diferença.

HashSet
    - Armazena em tabela hash
    - Extremamente rápido: inserção, remoção e busca. O(1)
    - A ordem dos elementos não é garantida

SortedSet
    - Armazenamento em árvore
    - Rápido: inserção, remoção e busca. O(log(n))
    - Os elementos são armazenados e ordenados conforme implementação IComparer<T>


Principais métodos:
 - Add
 - Clear
 - Contains
 - UnionWith(other) - adiciona no conjunto os elementos do outro conjunto
 - IntersectWith(other) - Operação de interseção: remove do conjunto os elementos não contidos em other
 - ExceptWith(other) - Operação diferença: remove do conjunto os elementos contidos em other
 - Remove(T)
 - RemoveWhere(predicate)

Para utilizar é necessário importar com
````c# 
using System.Collections.Generic;
````

Como as coleções Hash testam igualdade? 

Em coleções Hash é precisa implementar as funções GetHashCode e Equals nas classes que criamos para que seja possível fazer uma comparação confiável. Nos tipos struct não é preciso.

Na classe criada implementar as funções
````c#

public override int GetHashCode(){
    // fazer para todas as variáveis, nesse caso seria para uma classe apenas com as variáveis Name e Price
    return Name.GetHashCode() + Price.GetHashCode()
}

public override bool Equals(object obj){
    if (!(obj is Product)){
        return false;
    }
    Product other = obj as Product
    // fazer para todas as variáveis, nesse caso seria para uma classe apenas com as variáveis Name e Price
    return Name.Equals(other.Name) && Price.Equals(other.Price)
}

````

HashSet
````c#
using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {

        HashSet<string> set = new HashSet<string>();
        set.Add("TV");
        set.Add("Notebook");
        set.Add("Tablet");

        Console.WriteLine(set.Contains("Notebook"));

        foreach (string s in set) 
        {
            Console.WriteLine(s);
        }

    }
}
````

SortedSet
````c#
using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {

        SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 6, 8, 10};
        SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

        // Union

        // Cria um conjunto "c" e ao passar "a" como parâmetro usa um construtor para adicionar ao conjunto "c" todos os elementos do cojunto "a"
        SortedSet<int> c = new SortedSet<int>(a);
        // Faz a união de "c" e "b". OBS: Conjuntos não aceitam repetição e adicionara apenas os números que não se repetem
        c.UnionWith(b);
        PrintColection(c);

        // Intersection
        SortedSet<int> d = new SortedSet<int>(a);
        d.IntersectWith(b);
        PrintColection(d);

        // Difference
        SortedSet<int> e = new SortedSet<int>(a);
        e.ExceptWith(b);
        PrintColection(e);
    }

    // Função para imprimir os itens de um conjunto
    static void PrintColection<T>(IEnumerable<T> collection)
    {
        foreach (T obj in collection)
        {
            Console.Write(obj + " ");
        }
        Console.WriteLine();
        Console.WriteLine("_______________");
    }
}
````