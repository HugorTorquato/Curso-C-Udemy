using System;
using System.Collections.Generic;
using System.Text;

namespace Demo1.Entities
{
    class SavinsAccountPluss : SavingsAccount
    {
        // O sealed impede que o Withdraw seja sobreescrito novamente em uma função base

        // convem selar pq sobreposições múltiplas pode gerar inconsistências e complicar as coisas
        // Perde o controle de qual implementação quer fazer.
    }
}
