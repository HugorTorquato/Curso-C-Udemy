using System;
using System.Globalization;
using Seção_14_Interfaces2.Entities;
using Seção_14_Interfaces2.Services;

namespace Seção_14_Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * Processamento de contratos
             * 
                * Gerar as parcelas a serem pagas com base no número de meses
             *
             * Serviço de pagamento onliine
                * Juros mensal
                    * 1% 
                * Taxa de pagamento
                    * 2%
             * 
             * Entradas
                * Número do contrato
                * data do contrato
                * valor total do contrato
                * Número de meses para parcelamento
             * 
             * Ação
                * registro d parcelas a serem pagas ( data e valor )
                * Primeira parcela 1 mes após a data do contrato 
             * 
             * 
             * 
             */

            Console.WriteLine("Enter Contract Data");
            Console.Write("Number : ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy) : ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract Value : ");
            double ammount = double.Parse(Console.ReadLine());

            Contract contract = new Contract(number, date, ammount);

            Console.WriteLine();
            Console.Write("Enter Number of installments : ");
            int count = int.Parse(Console.ReadLine());


            ContarctResume resume = new ContarctResume(count, new Paypal());

            resume.ProcessInstallments(contract);

            Console.WriteLine("INS");
            foreach (Installments instaa in resume.InstallmentsList)
            {
                Console.WriteLine(instaa);
            }

        }
    }
}
