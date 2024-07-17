# Properties

São definições de métodos encapsulados, porém expondo uma sintaxe similar à de atributos e não métodos.



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

        // Properties
        public string Nome 
        {
            get { return _nome; }
            set 
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
                else
                {
                    Console.WriteLine("Erro! O nome digitado não atende aos padrões");
                }
            }
        }        

        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
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
            Console.WriteLine(p.Nome);
            Console.Write("Novo nome: ");
            string novoNome = Console.ReadLine();
            p.Nome = novoNome;
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
        }               
    }
}
```
# Fim Código principal