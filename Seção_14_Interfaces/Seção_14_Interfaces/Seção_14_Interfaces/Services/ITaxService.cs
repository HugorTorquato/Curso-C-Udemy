using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_14_Interfaces.Services
{
    interface ITaxService
    {   
        // Defini apenas o contrato, chamada para a função
        double Tax(double ammount);
    }
}
