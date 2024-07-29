#  Lista é uma estrutura de dados:

    - Homogênea (dados do mesmo tipo)
    - Ordenada (elementos acessados por meio de posições)
    - Inicia vazia, e seus elementos são alocados sob demanda
    - Cada elemento ocupa um "nó" (ou nodo) da lista

# Vantagens e Desvantagens
    Vantagens
    - Tamanho variável
    - Facilidade para realizar inserções e deleções

    Desvantagens
    - Acesso sequencial aos elementos ( Não é possível acessar um elemento no meio ou final da lista sem passar por todos os outros elementos que o antecedem.)


# Para declarar uma lista precisamos:

usar "using System.Collections.Generic;" no início do programa e usamos "List<string> list = new List<string>();"

````c#
using System;
using System.Collections.Generic;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
        }
    }
}
````

- List é o tipo lista
- Dentro de <> fica o tipo de dados da lista
- Após criar a lista é necessário instância-la

Támbém podemos criar a lista e já instância-la com elementos:

````c#
using System;
using System.Collections.Generic;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "Maria", "João", "Lucas" };
        }
    }
}
````

# Comandos

 - Add => Adiciona itens ao final da lista
 - Insert => Adiciona itens em uma determinada posição da lista e empurra o intem que estava na determinada posição para baixo
 - Count => Exibe o tamanho da lista
 - Find | FindLast => Encontrar o primeiro ou o último item da lista que satisfaça um predicado.
 - FindIndex | FindLastIndex => Encontrar a primeira ou última posição do elemento da lista que satisfaça um predicado
 - FindAdll => Filtra a lista com base em um predicado
 - Remove => Remove um item da lista
 - RemoveAll => Remove todos os itens que satisfaçam um predicado
 - RemoveAt => Remove um elemento pela sua posição
 - RemoveIndex => Remove os elementos de uma faixa

````c#
list.Add("Matheus");

list.Insert(2, "Marco"); // Adiciona "Marco" no índice 2 da lista

Console.WriteLine(list.Count);

string s1 = list.Find(x => x == "Alex");

int s2 = list.FindIndex(x => x[0] == 'A');

List<string> nomes = new List<string>();
nomes = list.FindAll(x => x[0] == 'M');

list.Remove("Alex");

list.RemoveAll(x => x[0] == 'J');

list.RemoveRange(0, 2); // Remove dois itens contando a partir da posição 0
````
