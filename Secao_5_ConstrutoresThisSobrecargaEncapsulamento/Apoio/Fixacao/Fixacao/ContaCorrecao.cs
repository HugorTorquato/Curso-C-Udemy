using System.Globalization;

namespace Fixacao
{
    class ContaCorrecao
    {
        public int Numero  { get; private set; }

        public string Titular { get; set; }
        public double Saldo { get; private set; }

        // Construtores

        public ContaCorrecao(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaCorrecao(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
