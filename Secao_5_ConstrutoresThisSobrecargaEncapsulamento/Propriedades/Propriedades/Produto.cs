using System.Globalization;

namespace Propriedades
{
    class Produto
    {
        private string _nome; // -> Não tem como fazer autoproprety pq tem uma lógica particular
        //Autopropriedade
        public double Preco { get; private set; } // -> Autopropriedade
        //private int _quantidade;                // -> Propriedade normal
        public int Quantidade { get; private set; }
        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public string GetNome()
        {
            return _nome;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                //value -> Parametro que chegaria no método set ( nome )
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        /*
        public double Preco
        {
            get { return _preco;  }
        }

        //Autopropriedade


        public int Quantidade
        {
            get { return _quantidade; }
        }
        */
        /*
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }
        public double GetPreco()
        {
            return _preco;
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }
        */
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}