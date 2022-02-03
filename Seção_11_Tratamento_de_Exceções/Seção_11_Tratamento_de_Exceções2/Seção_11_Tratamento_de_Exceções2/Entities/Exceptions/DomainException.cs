using System;
using System.Collections.Generic;
using System.Text;

namespace Seção_11_Tratamento_de_Exceções2.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {
            // Passa a mensagem para o construtor da clase ApplicationException
        }
    }
}
