using System;

namespace Exec_3
{
    class Aluno
    {
        public string Nome;
        public double N1;
        public double N2;
        public double N3;

        public double NotaFinal()
        {
            return N1 + N2 + N3;
        }

        public double Restante()
        {
            return 60.00 - NotaFinal();
        }
            
    }
}
