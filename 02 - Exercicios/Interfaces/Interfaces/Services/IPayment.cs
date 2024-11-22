

namespace Interfaces.Services
{
    interface IPayment
    {
        void ProcessarPagamento();
        string ObterDetalhesPagamento();
    }
}
