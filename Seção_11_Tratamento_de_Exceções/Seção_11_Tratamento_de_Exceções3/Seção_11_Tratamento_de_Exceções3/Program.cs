using System;
using Seção_11_Tratamento_de_Exceções3.Entities;
using Seção_11_Tratamento_de_Exceções3.Entities.Exceptions;

namespace Seção_11_Tratamento_de_Exceções3
{
    class Program
    {
        /*
         * Dados Conta bancária
         * 
         * Ler os dados da conta
            * Número da conta
            * Titular da conta
            * Balance ( creio que seja o total da conta)
            * witgdrawLimit ( creio que deve ser o limite de saque)
            * 
         * 
         * Funções
            * Deposito
            * Saque
         * 
         * Condições
            * Não pode acontecer se não houver saldo
            * Não pode ocorrer se o valor for maior que o saldo
         * 
         * 
         */

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.WriteLine("Number : ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Holder : ");
                string holder = Console.ReadLine();
                Console.WriteLine("Initial Balance : ");
                double balance = double.Parse(Console.ReadLine());
                Console.WriteLine("Withdraw Limit : ");
                double withdrawlimite = double.Parse(Console.ReadLine());

                Account acc = new Account(number, holder, balance, withdrawlimite);

                Console.WriteLine("Enter ammount for withdraw");
                double withdraw = double.Parse(Console.ReadLine());
                acc.TryWithDraw(withdraw);
                Console.WriteLine(acc);

            }
            catch (AccountExceptions e)
            {
                Console.WriteLine("Error : " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid Format : " + e.Message);
            }
        }
    }
}
