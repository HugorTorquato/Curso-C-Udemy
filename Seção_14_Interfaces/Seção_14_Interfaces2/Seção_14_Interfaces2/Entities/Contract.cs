using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_14_Interfaces2.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime InitialDate { get; set; }
        public double Ammount { get; set; }

        public Contract(int number, DateTime initialDate, double ammount)
        {
            Number = number;
            InitialDate = initialDate;
            Ammount = ammount;
        }
    }
}
