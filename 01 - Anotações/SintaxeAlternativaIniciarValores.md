# Sintaxe alternativa para iniciar valores

Os valores de um classe podem ser iniciados de uma maneira alternativa. Mesmo sem um construtor solicitando a inicialização dos valos podemos iniciar os mesmos.

É necessário incluir o construtor padrão na classe.

```c#
Produto p = new Produto() 
{
    Nome = "TV",
    Preco = 900.00,
    Quantidade = 0
};
```