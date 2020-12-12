using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace EXEC_LISTA
{
    class Func
    {
        public int ID { get; private set; }
        public string Nome { get; private set; }
        public double Salario { get; private set; }

        public Func(int id, string nome, double salario)
        {
            ID = id;
            Nome = nome;
            Salario = salario;
        }

        public void AddSalary(double porcent)
        {
            Salario += Salario*(porcent / 100);
        }

        public override string ToString()
        {
            return ID + ", " + Nome + ", R$:" + Salario;
        }
    }
}
