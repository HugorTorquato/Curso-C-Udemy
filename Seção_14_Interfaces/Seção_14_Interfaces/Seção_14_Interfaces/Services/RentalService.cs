using System;
using Seção_14_Interfaces.Entities;

namespace Seção_14_Interfaces.Services
{
    class RentalService
    {
        public double PricePerHour { get; set; }
        public double PricePerDay { get; set; }

        // Fica forte a dependência do serviço, pq funciona só para o serviço do brasil.
        // Se tiver de tricar, ten de abrir a classe e alterar, logo... alem de criar o serviço, tem de referenciar tbm
        // e alterar aqui
        // Ideal é ter uma classe fecahda par alteração, sem mudar nada nessa classe

        //private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        // O serviço tem uma dependencia a uma interface genéria, que tem uma operação que chama tax,
        // Contrato com a operação que deve cumprir
        // Com isso pode criar serviços exclusivos que criam a interface
        // Agora espera um serviço de imposto qualquer

        // Simplesmente declara e acrescenta no construtor
        private ITaxService _taxService;

        // Inverção de controle por meio de injeção de dependência, a classe não instancia a dependencia dela mais.
        // Não sabe a implemen~tação, só usa. Serviço desacoplado entre si
        // Recebe o objeto dependencia e atribui ( aprofundar ) - principios solid
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;

            if (duration.TotalHours <= 12)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours); 
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}
