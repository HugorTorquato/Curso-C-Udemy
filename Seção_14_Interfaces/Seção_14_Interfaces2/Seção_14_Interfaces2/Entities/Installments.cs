using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Seção_14_Interfaces2.Entities
{
    class Installments
    {
        public DateTime PaymentDate { get; set; }
        public double InstallmentValue { get; set; }

        public Installments(DateTime paymentDate, double installmentValue)
        {
            PaymentDate = paymentDate;
            InstallmentValue = installmentValue;
        }

        public override string ToString()
        {
            return PaymentDate.ToString("dd/MM/yyyy") +
                "-" +
                InstallmentValue.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
