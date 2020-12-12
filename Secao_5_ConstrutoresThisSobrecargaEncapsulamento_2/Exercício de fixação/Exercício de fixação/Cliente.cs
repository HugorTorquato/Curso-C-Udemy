using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercício_de_fixação
{
    class Cliente
    {
        // ---------------------------------------------------- Atributos privados
        private string _nomeTitular;
        //private double _saldo;
        //-------------------------------------------------  ---- Propriedades autoimplementadas
        public double Saldo { get; private set; }
        public int NumConta { get; private set; }
        public double DepoInit { get; set; }

        // -- --------------------------------------------------- Construtores
        public Cliente(string nome)
        {
            _nomeTitular = nome;
            NumConta = 123;
        }
        public Cliente(string nome, double deposito) : this(nome)
        {
            if(deposito >= 0)
            {
                DepoInit = deposito;
                Saldo = DepoInit;
            }
        }

        //---------------------------------------------------------- Propriedades Customizadas
        public string NomeTitular
        {
            get { return _nomeTitular; }
            set { if (value != null) _nomeTitular = value; }
        }
        //public double Saldo { 
        //    get { return _saldo; }
        //    set { if (value > 0) _saldo += value; }
        //}

        // --------------------------------------------------------------Métodos da classe

        public void Deposito(double valor)
        {
            Saldo += valor;
            Console.WriteLine(this);
        }
        public void Saque(double valor)
        {
            Saldo -= valor + 5;
            Console.WriteLine(this);
        }

        // ---------------------------------------------------------------- TO STRING
        public override string ToString()
        {
            return _nomeTitular
                + ", saldo em conta é  R$ " + Saldo.ToString("F2", CultureInfo.InvariantCulture)
                + "  , com número de conta : " + NumConta;
        }
    }
}
