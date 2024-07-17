# This

A palavra this é uma referência para o própio objeto. Pode ser usada quando o parametro de um método ou construtor tem o mesmo nome de um atributo da classe.

Também pode ser usada para referenciar um construtor dentro de outro


```c#

class Produto
{

    public string Nome;
    public double Preco;
    public int Quantidade;

    public Produto()
    {
        Quantidade = 10;
    }

    // Reaproveita a variavel quantidade do construtor de cima
    public Produto(string nome, double preco) : this() {
        Nome = nome;
        Preco = preco;
    }

    public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
        Quantidade = quantidade
    }
}


```

```c#


```