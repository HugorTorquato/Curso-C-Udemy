using System;
using System.Collections.Generic;
using System.Text;
using Seção_14_Interfaces.Entities;

namespace Seção_14_Interfaces.Entities
{
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            // O invoice vai ser gerado como nullo por default
        }
    }
}
