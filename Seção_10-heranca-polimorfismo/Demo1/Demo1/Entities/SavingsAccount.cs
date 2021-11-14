using System;
using System.Collections.Generic;
using System.Text;

namespace Demo1.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) 
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount)
        {
            // sintaxe de override feita para sobreescrever uma função virtual da superclasse

            //Balance -= amount;

            // Reimplementa ( na subclasse ) uma função que já existe na super classe para mudar o comportamento dela
            // Nesse caso, usando o base, vai aproveitar os -5 reais da superclasse e vai adicionar um desconto de mais 2 reis
            // Aproveita a implementação da superclase e adiciona modificações

            base.Withdraw(amount);
            Balance -= 2;
        }
    }
}
