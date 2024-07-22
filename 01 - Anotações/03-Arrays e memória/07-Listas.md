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