
namespace Exec_Resolvido_2.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }


        // Sem o construtor vazio, ele obriga o usuário a entrar uma cor para cada formato
        // Sem ele tem de informar os argumentos necessários

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double area();
        // Essa definição tem de ser feita dentro das subclasses de shape, para isso a classe
        //Shapetbm tem de ser abstrata e não precisa deter a implementação da função.
        // Esta será feita dentro de cada subclasse
    }
}
