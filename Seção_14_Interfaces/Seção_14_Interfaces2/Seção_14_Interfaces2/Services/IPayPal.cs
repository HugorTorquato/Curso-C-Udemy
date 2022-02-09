using System;
using System.Collections.Generic;
using System.Text;
using Seção_14_Interfaces2.Entities;

namespace Seção_14_Interfaces2.Services
{
    interface IPayPal
    {
        List<Installments> Install(double ammount, DateTime date, int count);
    }
}
