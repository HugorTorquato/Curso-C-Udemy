using System;

namespace Exec_2
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;
        public double Aumento;

        public void Raise()
        {
            SalarioBruto += SalarioBruto * (Aumento / 100.00);
        }

        public double Salario()
        {
            return SalarioBruto - Imposto;
        }
    }
}
