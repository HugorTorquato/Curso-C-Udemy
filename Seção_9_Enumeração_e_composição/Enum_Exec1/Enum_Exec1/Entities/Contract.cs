using System;

namespace Enum_Exec1.Entities
{
    class Contract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public Contract () // PQ?
        {
        }

        public Contract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            return Date
                + ", "
                + ValuePerHour
                + ", "
                + Hours;
        }

    }
}
