using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Fixacao
{
    class Conta
    {
        public int NumConta { get; private set; }
        private string _nome; // tem condição que não pode aceitar null
        public double Saldo { get; private set; }
        public double DepInicial { get; private set; }
        public double TaxaSaque { get; private set; }

        //Construtores

        // Construtor padrão
        public Conta()
        {
            TaxaSaque = 5.00;
        }

        //Construtor para nome e número da conta
        public Conta(string nome, int numconta) : this()
        {
            _nome = nome;
            NumConta = numconta;
            DepInicial = 0.00;
        }

        //Construtor com as 3 informações
        public Conta(string nome, int numconta, double depinicial) : this(nome, numconta)
        {
            DepInicial = depinicial;
            DepInic();
        }

        // Propriedades Customizadas
        // Para não permitir alterar nome com null

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)      // Esse value recebe os dados armazenados dentro de nome
                {
                    _nome = value;
                }
            }
        }


        // Saida de informações fixa
        public override string ToString()
        {
            return "Conta "
                + NumConta
                + ", Titular: "
                + Nome
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);

        }

        // Mpetodos e Classes

        public void DepInic()
        {
            Deposito(DepInicial);
        }

        public void Deposito(double dep)
        {
            Saldo += dep;
        }

        public void Saque(double saq)
        {
            Saldo -= (saq + TaxaSaque);
        }

    }
}
