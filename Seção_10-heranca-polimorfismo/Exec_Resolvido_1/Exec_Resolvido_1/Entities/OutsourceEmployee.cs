using System;
using System.Collections.Generic;
using System.Text;

namespace Exec_Resolvido_1.Entities
{
    class OutsourceEmployee :Employee
    {
        public double AdditionalCharges { get; set; }

        public OutsourceEmployee() { }

        public OutsourceEmployee(string name, int hours, double valePerHour, double additionalCharges)
            : base(name, hours, valePerHour)
        {
            AdditionalCharges = additionalCharges;
        }

        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharges;
        }
    }
}
