using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula
{
    public class Conta
    {
        public int NumeroConta { get; set; }
        public string Titular { get; set; }
        public double SaldoConta { get; private set; }

        public void AdicionaSaldo(double valor) 
        {
            SaldoConta += valor;
        }

        public override string ToString()
        {
            return ($"Conta: {NumeroConta} | Titular: {Titular} | Saldo: ${SaldoConta.ToString("F2", CultureInfo.InvariantCulture)}.");
        }
    }
}
