using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_11_Tratamento_de_Exceções3.Entities.Exceptions
{
    class AccountExceptions : ApplicationException
    {
        public AccountExceptions(string message) : base(message) { }
    }
}
