using Demo1.Entities;
using System;
using System.Collections.Generic;

namespace Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "bob browm", 100.0, 500.0);

            Console.WriteLine(account.Balance);
            // account.Balance = 200;
            // Não é permitido por causa do protected - permite alterar somente em subclasses

            // Instanciar
            //Account acc = new Account(1001, "Alex", 0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0, 500);

            //Upcasting - conversão da subclasse para a superclasse

            // BusinesAccount para Account - O compilador aceita já que o BusinesAAcount É UM account, 
            // por isso podemos fazer a atribuição ( a atribuição da subclasse para a classe base é permitida )
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0, 200);
            Account acc3 = new SavingsAccount(1004, " Anna", 0, 0.01);

            // Downcasting - Conversão da superclasse para a subclasse

            // o Acc2 armazena na superclasse a instanciação de um BusinesAccount, mas a conversão não pode ser
            // implicita como o upcasting, temos de fazer o casting. Que é representado peo (CLASSE) antes do objeto

            // No caso não podemos fazer as operações do bisinesAccount com o ACC2, pq o compilador compreende ela como
            // Account, só é permitido depois do downcasting

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100);

            // No caso o acc3 foi instanciado com o savingsAccount ( que não é compativel com o BusinesAcount). Não
            // aparece erro no compilados, mas da um erro de converção quando compila ( não é possível converter)
            // Tem de seguir a instanciação correta das variáveis

            // OPERAÇÃO INSEGURA. Usar só quando necessário e tem de testar bem, muito bem!! Com o operador "IS"

            //BusinessAccount acc5 = (BusinessAccount)acc3;

            if (acc3 is BusinessAccount) // Faz o teste para depois fazer a conversão
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(200);
                Console.WriteLine("Loan!");
            }

            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("update!");
            }


            // Operador AS como forma alternativa de fazer o casting
            // 




            // ---------------------------------------------------------------------------------

            // No caso de ser uma classe abstrata... não pode ser instanciada
            //Account accc1 = new Account(1101, "Alex", 500);
            
            //Account accc1 = new Account(1101, "Alex", 500);
            Account accc2 = new SavingsAccount(1102, "Anna", 500, 0.01);

            //accc1.Withdraw(10);
            accc2.Withdraw(10);

            //Console.WriteLine(accc1.Balance); //485
            Console.WriteLine(accc2.Balance); //490

            // O saque para o accc2 já usa a regra na poupança, que não desconta os 5 reais

            // Exemplo de polimorfismo, em que variáveis de mesmo tipo possuem comportamentos diferentes ( objetos diferentes )
            // mas o tipo de variável é o mesmo

            // ---------------------------------------------------------------------------------

            List<Account> li = new List<Account>();

            li.Add(new SavingsAccount(1111, "Alex", 500, 0.01));
            li.Add(new SavingsAccount(1112, "Maria", 500, 0.01));
            li.Add(new BusinessAccount(1113, "Bod", 500, 400));
            li.Add(new BusinessAccount(1114, "Bod", 500, 400));

            // Como tem a superclasse genérica, podemos cliar vários elementos na lista de tipos diferentes
            // Sendo esses tipos subclasses da superclasse

            // Os métodos também serão execultados de forma polimorfica nesse caso.

            double sum = 0;
            foreach(Account a in li)
            {
                sum += a.Balance;
            }

            Console.WriteLine("TotalBalance : " + sum);
        
        
        }
    }
}
