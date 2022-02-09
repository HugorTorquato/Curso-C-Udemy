using System;
using System.Collections.Generic;
using System.Text;
using Seção_14_Interfaces2.Entities;
using Seção_14_Interfaces2.Services;

namespace Seção_14_Interfaces2.Services
{
    class Paypal : IPayPal
    {
        public List<Installments> Install(double ammount, DateTime date, int count)
        {

            double quota = ammount / count;

            List<Installments> inst = new List<Installments>();

            for (int n=1; n <= count; n++)
            {
                DateTime tempdate = date.AddMonths(n);
                double tempquota = (quota + quota * 0.01 * n) + (quota * 0.02);
                inst.Add(new Installments(tempdate, tempquota));

            }

            return inst;
        }
    }
}
