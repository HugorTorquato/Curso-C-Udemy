using System;

namespace DeclararUmTipo
{
    class Program
    {
        static void Main(string[] args)
        {
            Point P; // Não precisa do new point, pq é um struct

            P.x = 10;
            P.y = 20;// sOMENTE DE POIS DE INICIALIZADA DA PARA IMPRIMIR NA TELA

            Console.WriteLine(P);

            P = new Point(); // Aceita e recria a caixinha sem atribuir nada para ela

            Console.WriteLine(P);
        }
    }
}
