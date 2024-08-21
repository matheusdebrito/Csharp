# Variáveis tipo referência
Variáveis cujo tipo são classes não devem ser entendidas como caixas, mas sim "tentáculos" (ponteiros) para caixas.

Ao criar uma variável e não e instancia-la ela apenas ocupa um lugar na Stack. Ex:

```c#
Product p1;
```

Ao instancia-la ela aponta para um lugar na Heap.

Variáveis do tipo referência aceitam o valor null.

```c#
p1 = new Product();
```

# Variáveis do tipo valor
A linguagem C# possui também tipos valor, que são os "structs". Structs são CAIXAS e não ponteiros. Variáveis do tipo valor são os tipos básicos, Ex: double, int, string. As variáveis do tipo valor são caixas, ou seja, armazenam valor dentro delas ao invés de apontar para um lugar na Heap.

Podemos criar tipos básicos. Para isso usamos o struct. Criamos como se fosse uma classe mas ao invés de class usamos struct. Ao criar um tipo struct não é necessário instancia-lo com new. Mesmo não sendo necessário podemos instanciar o tipo básico feito com struct.

```c#
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoriaArraysListas
{
    struct Point
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return($"({X},{Y})");
        }
    }
}


```