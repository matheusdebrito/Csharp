

# Classe Account
````c#
using System;

namespace Heranca.Entities
{
    internal class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdrawn(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount; 
        }


    }
}

```

# Classe que herda Account

```c#
namespace Heranca.Entities
{

    // : Account Indica que herda a classe Account
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount() { }
        // : base() Serve para usar um construtor da classe principal.
        public BusinessAccount(int number, string holder, double balance, double loanlimit) : base(number, holder, balance)
        {
            LoanLimit = loanlimit;

        }

        public void Loan (double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}

```