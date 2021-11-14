using System;
using System.Collections.Generic;
using System.Text;

namespace Demo1.Entities
{
    class BusinessAccount : Account
        // A classe BusinessAccount tem tudo que a classe Account tem
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) 
            : base(number, holder, balance) 
            // Aprveita o construtor que já está definido na classe base, já fazendo as atribuições implementadas lá
            // Construtor da subclasse
        {
            LoanLimit = LoanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }            
        }
    }
}
