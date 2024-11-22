using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Services
{
    internal class PixPayment : IPayment
    {
        public double Value { get; set; }

        public void ProcessarPagamento()
        {
            Console.WriteLine("Gerando código QR");
        }

        public string ObterDetalhesPagamento()
        {
            return $"Detalhes: valor R${Value.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public PixPayment(double value)
        {
            Value = value;
        }
    }
}
