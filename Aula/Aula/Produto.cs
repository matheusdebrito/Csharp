﻿using System;
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
        public string Nome;
        public double Preco;
        public int Quantidade;


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
            return ($"Nome: {Nome}, Preço: $ {Preco}, Quantidade: {Quantidade}, Valor total: {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
