using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca.Entities
{
    // : Account Indica que herda a classe Account
    internal class SavingsAccount : Account
    {
        public double  InterestRate { get; set; }

        public SavingsAccount() { }

        // : base() Serve para usar um construtor da classe principal.
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdrawn(double amount)
        {
            Balance -= amount;
        }
    }
}
