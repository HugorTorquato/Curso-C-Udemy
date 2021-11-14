using System.Globalization;
using System;

namespace Exec_Proposto_1.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string priceTag()
        {
            return Name + "(used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " Manufactoring Date " + ManufactureDate;
        }


    }
}
