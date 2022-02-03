using System;
using System.Collections.Generic;
using System.Text;
using Seção_11_Tratamento_de_Exceções2.Entities.Exceptions;

namespace Seção_11_Tratamento_de_Exceções2.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
        {
            CheckDates(checkin, checkout);

            this.RoomNumber = roomNumber;
            this.Checkin = checkin;
            this.Checkout = checkout;
        }

        public int Duration()
        {
            TimeSpan duration = Checkout.Subtract(Checkin);
            // Retorna a diferênça em dias entre as reservas, com o cast no int
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            CheckDates(checkin, checkout);

            Checkin = checkin;
            Checkout = checkout;
        }

        // Quem tem de tratar as condições da reserva seria a classe da reserva
        public void CheckDates(DateTime checkin, DateTime checkout)
        {
            // Se der erro, corta a execulção e cai no catch, nada mais é compilado depois
            // que uma das condições seja triggada
            DateTime now = DateTime.Now;

            if (checkin < now || checkout < now)
            {
                throw new DomainException("Reservation dates must me grater than now");
            }
            if (checkout < checkin)
            {
                throw new DomainException("CheckOut mus be grater than CheckIn");
            }
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", CheckIn"
                + Checkin.ToString("dd/MM/yyyy") // Define a forma padrão para o output da data
                + ", Checkout"
                + Checkout.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}
