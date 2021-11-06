using System;
using System.Collections.Generic;
using System.Text;

namespace FileExec.Entities
{
    class Product
    {
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }

        public Product(string productName, double productPrice, int productQuantity)
        {
            ProductName = productName;
            ProductPrice = productPrice;
            ProductQuantity = productQuantity;
        }

        public double ReturnTotal()
        {
            return ProductPrice * ProductQuantity;
        }
    }
}
