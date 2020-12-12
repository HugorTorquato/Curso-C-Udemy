using System.Globalization;
namespace Course
{
    class Produto
    {

        private string _nome;
        //private double _preco;
        public double Preco { get; private set; } // Dessa forma dispensa a implementação da propetie caso não tenha uma condição especifica
        //private int _quantidade;
        public int Quantidade { get; private set; }

        //Construtor 3 argumentos
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome; //Nome do objeto recebe o nome do param
            Preco = preco;
            Quantidade = quantidade;
        }

        //Construtor 2 argumentos
        public Produto(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
            //Quantidade = 0; // Por default já começa com valor zero quando declara uma variável
        }

        //Cnstrutor Padrão
        public Produto() { }
        /*    ENCAPSULAMENTO MANUAL
        // Método Get para pegar o nome do produto
        public string GetNome()
        {
            return _nome;
        }

        public double GetPreco()
        {
            return _preco;
        }
        public double GetQuantidade()
        {
            return _preco;
        }

        public void SerNome(string nome)
        {
            // Pode adicionar alguma regra para setar o atributo
            if(nome != null && nome.Length > 1)
            {
                _nome = nome;
            }

        }
        */

        /* PROPIETES
         * 
         * 
         * 
         */
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }

            }
        }
        /* Manual Propeties, a autopropeties está declarada nos atributos
        public double Preco
        {
            get { return _preco; }
        }
        public int Quantidade
        {
            get { return _quantidade; }
        }
        */
        // FIM PROPETIES

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
