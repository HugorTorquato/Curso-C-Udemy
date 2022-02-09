using System;
using System.Globalization;
using Seção_14_Interfaces.Entities;
using Seção_14_Interfaces.Services;

namespace Seção_14_Interfaces
{
    class Program
    {
        /*
         * Regras
            * Valor por hora de até 12 horas
            * Se, > 12 horas... alocação vira valor diário
            * Imoposto
                * 20% até 100 reais
                * 15% > 100 reais
         * 
         * Programa
            * Dados de locação
                * Modelo do carro
                * instante inicial
                * instante final
                * valor por hora
                * valor diário de locação
         * 
         * Resultado
            * Notas de pagamentos
                * valor da locação
                * valor do imposto 
                * valor do pagamento total
         * 
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car Model : ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm) : ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm) : ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental carrental = new CarRental(start, finish, new Vehicle(model));

            Console.Write("Enter price per hour : ");
            double priceperhour = double.Parse(Console.ReadLine());
            Console.Write("Enter price per day : ");
            double priceperday = double.Parse(Console.ReadLine());

            // Informar a interface para o construtor
            // Instancia o serviço de aluguem com a dependência que quer, o objeto define qual função vai ser usada na
            // interface tac
            // Parte da injeção de cotrole e inverção de dependência. Passa a dependência como parâmetro,
            // logo é possível ter uma interface que aponta para várias dependências diferentes. No caso
            // Desse exemplo, as dependências são as taxas de cada país. Com isso da para apontar mais paises para a 
            // mesma interface mudando apenas a forma de passa a dependência desse construtor.
            RentalService rentalservice = new RentalService(priceperhour, priceperday, new BrazilTaxService());

            rentalservice.ProcessInvoice(carrental);

            Console.WriteLine();
            Console.WriteLine("INVOICE");
            Console.WriteLine(carrental.Invoice);
        }
    }
}
