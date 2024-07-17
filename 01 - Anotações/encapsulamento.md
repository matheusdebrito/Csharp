# Encapsulamento

É um princípio que consiste em esconder detalhes de um componente, expondo apenas operações seguras e que o mantenha em um estado consistente.

Regra de ouro: Um objeto deve estar sempre inconsistente, e a própria classe deve garantir isso.

Todo atributo é definido como private. Implementa-se métodos Get e Set para cada atributo, conforme regras de negócio.

Nota: não é usual na plataforma C#.

Ao definir um atributo como private ele não pode mais ser acessado por outra classe. Atributo privativos devem ser nomedos começando com _ e letra minúscula, Ex: _nome, _preco, _quantidade, etc...

Ao definiar os atributos como privados é necessário criar funções get para que os atributos sejam acessíveis. Para alterar é o atributo é necessário criar uma função set.

Com as funções set e get podemos definir condições, Ex: definir a condição que para alterar o nome é preciso ter mais de 1 caracter.

Para que os atributos sejam modificados apenas por métodos implementados na classe basta que não seja implementado o metodo Set.


# Classe
```c#
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    internal class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade; 

        // Construtor
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        } 

        // Construtor padrão
        public Produto() { }

        // Função Get
        public string GetNome() 
        { 
            return _nome; 
        }

        // Função Set

        public void SetNome(string nome) 
        {
            if (nome != null && nome.Length > 1) 
            {
            _nome = nome;
            } else 
            {
                Console.WriteLine("Erro! O nome digitado não atende aos padrões");
            }
        }

        public double ValorTotalEmEstoque()
        {
            return(_preco * _quantidade);
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
            ValorTotalEmEstoque();
        }

        public void Removerprodutos(int quantidade) 
        {
            _quantidade -= quantidade;
        }

        public override string ToString() {
            return ($"Nome: {_nome}, Preço: $ {_preco}, Quantidade: {_quantidade}, Valor total: {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}





```
# Fim classe


# Código principal
```c#
using System;
using System.Data;
using System.Globalization;

namespace Aula
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 500.00, 10);
            Console.WriteLine(p.GetNome());
            Console.Write("Novo nome: ");
            string novoNome = Console.ReadLine();
            p.SetNome(novoNome);
            Console.WriteLine(p.GetNome());

        }               
    }
}

```
# Fim código principal