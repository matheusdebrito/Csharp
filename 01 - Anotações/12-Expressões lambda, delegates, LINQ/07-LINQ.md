LINQ - Language Integrated Query
É um conjunto de tecnologias baseadas na integração de funcionalidades de consulta diretamente na linguagem C#.
 - Operações chamadas diretamente a partir das coleções
 - Consultas são objetos de primeira classe
 - Suporte ao compilador IntelliSense da IDE

Namespace: System.Linq

Possui diversas operações de consulta, cujos parâmetros tipicamente são expressões lambda ou expressões de sintaxesimilar à SQL

Três passos para trabalhar com Linq
 - Criar um data source (coleção, array, recurso de E/S, etc...)
 - Definir a query
 - Executar a query (foreach ou alguma operação terminal)

 Operações do LINQ:
  - Filtering: Where, OfType

  - Sorting: OrderBy, OrderByDescending, ThenBy, ThenByDescending, Reverse

  - Set: Distinct, Except, Intersect, Unior

  - Quantification: All, Any, Contains

  - Projection: Select, SelectMany

  - Partition: Skip, Take

  - Join: Join, GroupJoin

  - Grouping: GroupBy

  - Generational: Empty

  - Equality: SequenceEquals

  - Element: ElementAt, First, FirstOrDefault, Last, LastOrDefault, Single, SingleOrDefault

  - Conversions: AsEnumerable, AsQueryable

  - Concatenation: Concat

  - Aggregation: Aggregate, Average, Count, LongCount, Max, Min, Sum


 ````c#
 using System.Linq;
internal class Program
{
    private static void Main(string[] args)
    {

        // Specify Data Sourceint
        int[] numbers = { 2, 3, 4, 5 };

        // Define the query expression
        // atribui a varial result com o valor que obedece a condição de ser par e depois multiplica cada um deles por 10
        IEnumerable<int> result = numbers.Where(x  => x % 2 == 0).Select(x => x * 10);

        // Execute the query
        foreach (int x in result)
        {
            Console.WriteLine(x);
        }
    }
}
````