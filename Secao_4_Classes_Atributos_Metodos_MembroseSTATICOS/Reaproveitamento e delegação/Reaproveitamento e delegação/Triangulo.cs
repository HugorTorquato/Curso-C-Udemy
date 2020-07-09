
using System; // iMPORTAÇÃO DE DEPENDÊNCIAS

namespace Reaproveitamento_e_delegação
{
    class Triangulo
    {
        // Atributos
        public double A;
        public double B;
        public double C;


        //Métodos
        public double Area() // Não tem nenhum parÂmetro de entrada por já estar dentro da classe Triangulo
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));            
        }

    }
}
