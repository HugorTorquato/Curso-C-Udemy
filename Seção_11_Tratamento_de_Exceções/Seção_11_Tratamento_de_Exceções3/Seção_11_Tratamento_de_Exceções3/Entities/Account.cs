using System;
using System.Collections.Generic;
using System.Text;
using Seção_11_Tratamento_de_Exceções3.Entities.Exceptions;

namespace Seção_11_Tratamento_de_Exceções3.Entities
{
    class Account
    {
        public int AccountNum { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }

        public Account(int accountNum, string holder, double balance, double withDrawLimit)
        {
            AccountNum = accountNum;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }



        public void TryWithDraw(double withdraw)
        {
            CheckWithDraw(withdraw);

            Balance -= withdraw;
        }

        public void CheckWithDraw(double withdraw)
        {
            if(withdraw <= 0)
            {
                throw new AccountExceptions("Withdraw needs to be grather than 0");
            }
            if(withdraw > Balance)
            {
                throw new AccountExceptions("WithDraw needs to be smaller than : " + Balance.ToString());
            }
            if(withdraw > WithDrawLimit)
            {
                throw new AccountExceptions("WithDraw needs to be smaller than : " + WithDrawLimit.ToString());
            }

        }

        public override string ToString()
        {
            return "New balance : "
                + Balance.ToString();
        }
    }
}
