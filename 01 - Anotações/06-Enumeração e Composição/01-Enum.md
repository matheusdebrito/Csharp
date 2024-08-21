É um tipo especial que serve para especificar de forma literal um conjunto de constantes relacionadas. É um tipo valor.

Vantagem: melhor semântica, código mais legível e auxiliado pelo compilador.

Para criar um enum devemos criar uma subpasta na pasta entities (pasta que ficam as classes) com o nome Enums e dentro dessa subpasta criamos uma classe com o nome do enum.

Para criar uma propriedade para uma classe usando o enum devemos importar os arquivos da pasta Enum.

Para instanciar a classe e usar o enum devemos importar o enum.

# Código do enum
```c#
namespace Enums.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3,
    }
}

```

# Código da classe
```c#
using System;
using Enums.Entities.Enums;
/*Enums é o nome do projeto
Entities é o nome da pasta que está a classe
Enums é o nome da pasta onde está o  */

namespace Enums.Entities
{
    internal class order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
    }

}

```


# Código do programa principal

```c#
using System;
using Enums.Entities; // Importa a classe
using Enums.Entities.Enums; //Importa o Enum

namespace Enums
{ 
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString(); //Converte do tipo OrderStatus para string
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); //Converte tipo string para tipo OrderStatus

            Console.WriteLine(os);
        }
    }
}
```


