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
        public double Preco { get; private set; }
        public int Quantidade { get; private set; } 

        // Construtor
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
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

        public double ValorTotalEmEstoque()
        {
            return(Preco * Quantidade);
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
            ValorTotalEmEstoque();
        }

        public void Removerprodutos(int quantidade) 
        {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return ($"Nome: {_nome}, Preço: $ {Preco}, Quantidade: {Quantidade}, Valor total: {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
