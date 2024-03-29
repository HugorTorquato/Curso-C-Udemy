﻿using System.Globalization;

namespace Exec_Proposto_1.Entities
{
    class ImportedProduct :Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }

        public ImportedProduct(string name, double price, double customsFee)
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }

        public override string priceTag()
        {
            return Name + " $ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " Custom Fee : " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
