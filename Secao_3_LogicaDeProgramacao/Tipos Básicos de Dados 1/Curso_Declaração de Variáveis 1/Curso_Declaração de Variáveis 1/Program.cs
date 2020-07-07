using System;

namespace Curso_Declaração_de_Variáveis_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SByte x = 100;

            //Console.WriteLine(x);

            byte n1 = 255;         // Não aceita números negativos e limitado até 256
            Console.WriteLine(n1);

            //overflow, quando um calculo extrapula o limite da variável. O valor da variável vai para o limite oposto

            int n2 = 1000;
            Console.WriteLine(n2);
            int n3 = 2147483647;
            Console.WriteLine(n3);
            long n4 = 2147483648L; // Colocar o sufixo no final para especificar que esta trabalhando com o numero long
            Console.WriteLine(n4);

            bool completo = false;
            char genero = 'f';    // Tem que colocar entre aspas simples 
            char letra = '\u0041';// Pode colocar o código unicode tbm

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);

            float n5 = 4.5f; // tem que indicar explicitamente que é um float com o f na frente, se não pensa que é double
            double n6 = 4.5;

            Console.WriteLine(n5);
            Console.WriteLine(n6);

            string nome = "Maria"; //Tem que usar apas duplas para cadeia de caracteres
            Console.WriteLine(nome);

            object obj1 = "Hugo"; // Tipo generico, aceita qualquer coisa
            object obj2 = 4.5f;

            Console.WriteLine(obj1);
            Console.WriteLine(obj2);


            // Tipos númericos tem limites e dentro do proprio tivo tem uma propriedade que fala essa valor
            /*int.MinValue
             * int.MaxValue.....
             */
            int n10 = int.MinValue;
            Console.WriteLine(n10);
            int n11 = int.MaxValue;
            Console.WriteLine(n11);
            decimal n12 = decimal.MaxValue;
            Console.WriteLine(n12);








        }
    }
}
