using System;
using System.Collections.Generic;
using System.Text;

namespace DeclararUmTipo
{
    struct Point // criando um tipo valor
    {
        public double x;
        public double y;

        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }



    }
}
