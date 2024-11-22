using System;
using System.Globalization;
using Interfaces.Services;

namespace Interfaces.Services
{
    internal class BoletoPayment : IPayment
    {
        public int BoletoNumber{ get; set; }
        public double Value { get; set; }

        public void ProcessarPagamento()
        {
            Console.WriteLine("Processando pagamento por boleto...");
            Console.WriteLine("Boleto gerado com sucesso!");
        }

        public string ObterDetalhesPagamento()
        {
            return $"Detalhes: Boleto #{BoletoNumber}, valor R${Value.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        public BoletoPayment(double value)
        {
            Value = value;
        }

    }
}
