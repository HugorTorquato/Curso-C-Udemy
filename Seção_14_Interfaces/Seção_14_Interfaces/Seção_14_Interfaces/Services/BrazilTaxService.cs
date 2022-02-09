using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_14_Interfaces.Services
{
    class BrazilTaxService : ITaxService 
        // Realização de interface, tem de ser compativel a imagem a a função a ser usada
    {
        public double Tax(double ammount)
        {
            if (ammount <= 100)
            {
                return ammount * 0.20;
            }
            else{
                return ammount * 0.15;
            }
        }
    }
}
