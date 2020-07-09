using System.Globalization;

namespace Segundo_Projeto_Exemplo
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        // Adicionar Produto
        public void AdicionarProdutos(int qte)
        {
            Quantidade += qte;
        }

        // Remover Produto
        public void RemoverProdutos(int qte)
        {
            Quantidade -= qte;
        }

        public override string ToString() // overrride -> Operação veio de outra classe 
            // Toda vez que colocar o objeto dentro de um WriteLine, chama esse metodo e faz a operação
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
